// NClass - Free class diagram editor
// Copyright (C) 2006-2009 Balazs Tihanyi
// 
// This program is free software; you can redistribute it and/or modify it under 
// the terms of the GNU General Public License as published by the Free Software 
// Foundation; either version 3 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT 
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with 
// this program; if not, write to the Free Software Foundation, Inc., 
// 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using NClass.Translations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using NClass.Core.EventArgs;
using System.Diagnostics;

namespace NClass.Core;

public sealed class Project : IModifiable
{
    private string name;
    private FileInfo projectFile = null;
    private List<IProjectItem> items = new List<IProjectItem>();
    private bool loading = false;

    public event EventHandler Modified;
    public event EventHandler Renamed;
    public event EventHandler FileStateChanged;
    public event ProjectItemEventHandler ItemAdded;
    public event ProjectItemEventHandler ItemRemoved;

    public string Name
    {
        get { return name; }
        set
        {
            if (name == value || value == null || value.Length <= 0) return;
            name = value;
            IsUntitled = false;
            OnRenamed(System.EventArgs.Empty);
            OnModified(System.EventArgs.Empty);
        }
    }

    [JsonIgnore]
    public bool IsUntitled { get; private set; } = true;

    [JsonIgnore]
    public bool IsReadOnly { get; private set; } = false;

    [JsonIgnore]
    public string FilePath
    {
        get { return projectFile != null ? projectFile.FullName : null; }
        private set
        {
            if (value != null)
            {
                try
                {
                    FileInfo file = new FileInfo(value);

                    if (projectFile != null && projectFile.FullName == file.FullName) return;
                    projectFile = file;
                    OnFileStateChanged(System.EventArgs.Empty);
                }
                catch
                {
                    if (projectFile != null)
                    {
                        projectFile = null;
                        OnFileStateChanged(System.EventArgs.Empty);
                    }
                }
            }
            else if (projectFile != null) // value == null
            {
                projectFile = null;
                OnFileStateChanged(System.EventArgs.Empty);
            }
        }
    }

    [JsonIgnore]
    public string FileName
    {
        get
        {
            if (projectFile != null) return projectFile.Name;

            return Name + ".ncp";
        }
    }

    [JsonIgnore]
    public bool IsDirty { get; set; } = false;

    public IList<IProjectItem> Items
    {
        get { return items; }
        set { items = (List<IProjectItem>)value; }
    }

    [JsonIgnore]
    [Obsolete("Use Items.Count() instead.")]
    public int ItemCount
    {
        get { return items.Count; }
    }

    [JsonIgnore]
    public bool IsEmpty
    {
        get { return items.Count == 0; }
    }

    public Project()
    {
        name = Strings.Untitled;
    }

    public Project(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException(nameof(name));
        
        this.name = name;
    }

    public void Clean()
    {
        foreach (IProjectItem item in Items)
        {
            item.Clean();
        }

        if (!IsDirty) return;
        IsDirty = false;
        OnFileStateChanged(System.EventArgs.Empty);
    }

    public void CloseItems()
    {
        foreach (IProjectItem item in Items)
        {
            item.Close();
        }
    }

    public void Add(IProjectItem item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));
        
        if (items.Contains(item))
            throw new ArgumentException("The project already contains this item.");

        item.Project = this;
        item.Modified += new EventHandler(item_Modified);
        items.Add(item);

        OnItemAdded(new ProjectItemEventArgs(item));
        OnModified(System.EventArgs.Empty);
    }

    public void Remove(IProjectItem item)
    {
        if (!items.Remove(item)) return;
        item.Close();
        item.Modified -= new EventHandler(item_Modified);
        OnItemRemoved(new ProjectItemEventArgs(item));
        OnModified(System.EventArgs.Empty);
    }

    private void item_Modified(object sender, System.EventArgs e)
    {
        IsDirty = true;
        OnModified(System.EventArgs.Empty);
    }

    public string GetProjectDirectory()
    {
        if (projectFile != null)
            return projectFile.DirectoryName;
        return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }

    public static Project Load(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            throw new ArgumentException(Strings.ErrorBlankFilename, nameof(fileName));

        if (!File.Exists(fileName))
            throw new FileNotFoundException(Strings.ErrorFileNotFound);

        XmlDocument document = new XmlDocument();
        
        try
        {
            document.Load(fileName);
        }
        catch (Exception ex)
        {
            throw new IOException(Strings.ErrorCouldNotLoadFile, ex);
        }

        XmlElement root = document["Project"];
        
        if (root == null)
        {
            root = document["ClassProject"]; // Old file format
            
            if (root == null)
            {
                throw new InvalidDataException(Strings.ErrorCorruptSaveFile);
            }
            
            Project oldProject = LoadWithPreviousFormat(root);
            oldProject.FilePath = fileName;
            oldProject.name = Path.GetFileNameWithoutExtension(fileName);
            oldProject.IsUntitled = false;
            
            return oldProject;
        }

        Project project = new Project
        {
            loading = true
        };
        try
        {
            project.Deserialize(root);
        }
        catch (Exception ex)
        {
            throw new InvalidDataException(Strings.ErrorCorruptSaveFile, ex);
        }
        project.loading = false;
        project.FilePath = fileName;
        project.IsReadOnly = project.projectFile.IsReadOnly;

        return project;
    }

    private static Project LoadWithPreviousFormat(XmlElement root)
    {
        Project project = new Project
        {
            loading = true
        };

        Assembly assembly = Assembly.Load("NClass.DiagramEditor");
        IProjectItem projectItem = (IProjectItem)assembly.CreateInstance(
            "NClass.DiagramEditor.ClassDiagram.Diagram", false,
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
            null, null, null, null);

        try
        {
            projectItem.Deserialize(root);

            project.Add(projectItem);
            project.loading = false;
            project.IsReadOnly = true;

            return project;
        }
        catch (Exception ex)
        {
            throw new InvalidDataException(Strings.ErrorCorruptSaveFile, ex);
        }
    }

    public void Save()
    {
        if (projectFile == null)
            throw new InvalidOperationException(Strings.ErrorCannotSaveFile);

        Save(FilePath);
    }

    public void Save(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            throw new ArgumentException(Strings.ErrorBlankFilename, nameof(fileName));

        //var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });

        XmlDocument document = new XmlDocument();
        XmlElement root = document.CreateElement("Project");
        document.AppendChild(root);

        Serialize(root);
        
        try
        {
            document.Save(fileName);
        }
        catch (Exception ex)
        {
            throw new IOException(Strings.ErrorCouldNotSaveFile, ex);
        }

        IsReadOnly = false;
        FilePath = fileName;
        Clean();
    }

    private void Serialize(XmlElement node)
    {
        XmlElement nameElement = node.OwnerDocument.CreateElement("Name");
        nameElement.InnerText = this.Name;
        node.AppendChild(nameElement);

        foreach (IProjectItem item in Items)
        {
            XmlElement itemElement = node.OwnerDocument.CreateElement("ProjectItem");
            item.Serialize(itemElement);

            Type type = item.GetType();
            XmlAttribute typeAttribute = node.OwnerDocument.CreateAttribute("type");
            typeAttribute.InnerText = type.FullName;
            itemElement.Attributes.Append(typeAttribute);

            XmlAttribute assemblyAttribute = node.OwnerDocument.CreateAttribute("assembly");
            assemblyAttribute.InnerText = type.Assembly.FullName;
            itemElement.Attributes.Append(assemblyAttribute);

            node.AppendChild(itemElement);
        }
    }

    private void Deserialize(XmlElement node)
    {
        IsUntitled = false;

        XmlElement nameElement = node["Name"];
        if (nameElement == null || nameElement.InnerText == "")
            throw new InvalidDataException("Project's name cannot be empty.");
        
        name = nameElement.InnerText;

        foreach (XmlElement itemElement in node.GetElementsByTagName("ProjectItem"))
        {
            XmlAttribute typeAttribute = itemElement.Attributes["type"];
            XmlAttribute assemblyAttribute = itemElement.Attributes["assembly"];

            if (typeAttribute == null || assemblyAttribute == null)
                throw new InvalidDataException("ProjectItem's type or assembly name is missing.");

            string typeName = typeAttribute.InnerText;
            string assemblyName = assemblyAttribute.InnerText;

            Debug.WriteLine($"typeName={typeName}, assemblyName={assemblyName}");

            try
            {
                Assembly assembly = Assembly.Load(assemblyName);
                IProjectItem projectItem = (IProjectItem)assembly.CreateInstance(
                    typeName, false,
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                    null, null, null, null);

                if (projectItem != null)
                {
                    projectItem.Deserialize(itemElement);
                    projectItem.Clean();
                    Add(projectItem);
                }
            }
            catch (InvalidDataException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidDataException("Invalid type or assembly of ProjectItem.", ex);
            }
        }
    }

    private void OnModified(System.EventArgs e)
    {
        if (loading) return;
        IsDirty = true;
        Modified?.Invoke(this, e);
    }

    private void OnRenamed(System.EventArgs e)
    {
        Renamed?.Invoke(this, e);
    }

    private void OnItemAdded(ProjectItemEventArgs e)
    {
        ItemAdded?.Invoke(this, e);
    }

    private void OnItemRemoved(ProjectItemEventArgs e)
    {
        ItemRemoved?.Invoke(this, e);
    }

    private void OnFileStateChanged(System.EventArgs e)
    {
        FileStateChanged?.Invoke(this, e);
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;

        if (this.GetType() != obj.GetType())
            return false;

        Project project = (Project)obj;

        if (projectFile == null && project.projectFile == null)
            return object.ReferenceEquals(this, obj);

        return (
            projectFile != null && project.projectFile != null &&
            projectFile.FullName == project.projectFile.FullName
        );
    }

    public override int GetHashCode()
    {
        if (projectFile != null)
            return projectFile.GetHashCode();
        return Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Name} [{FilePath}]";
    }
}
