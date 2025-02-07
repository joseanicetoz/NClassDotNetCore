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

using NClass.Core;
using System;
using System.Collections.Generic;
using System.IO;
using NClass.Core.Entities;

namespace NClass.CodeGenerator;

public abstract class ProjectGenerator
{
    private Model model;
    private List<string> fileNames = new List<string>();

    /// <exception cref="ArgumentNullException">
    /// <paramref name="model"/> is null.
    /// </exception>
    protected ProjectGenerator(Model model)
    {
        this.model = model ?? throw new ArgumentNullException(nameof(model));
    }

    public string ProjectName
    {
        get { return model.Name; }
        set { model.Name = value; }
    }

    public abstract string RelativeProjectFileName { get; }

    public Language ProjectLanguage
    {
        get { return model.Language; }
        set { model.Language = value; }
    }

    protected Model Model
    {
        get { return model; }
        set { model = value; }
    }

    protected string RootNamespace
    {
        get
        {
            string projectName = Model.Project.Name;
            string modelName = Model.Name;

            if (string.Equals(projectName, modelName, StringComparison.OrdinalIgnoreCase))
                return modelName;
            else
                return projectName + "." + modelName;
        }
    }

    protected List<string> FileNames
    {
        get { return fileNames; }
        set { fileNames = value; }
    }

    internal bool Generate(string location)
    {
        bool success = true;

        success &= GenerateSourceFiles(location);
        success &= GenerateProjectFiles(location);

        return success;
    }

    private bool GenerateSourceFiles(string location)
    {
        bool success = true;
        location = Path.Combine(location, ProjectName);

        fileNames.Clear();
        foreach (IEntity entity in model.Entities)
        {
            if (entity is TypeBase type && !type.IsNested)
            {
                SourceFileGenerator sourceFile = CreateSourceFileGenerator(type);

                try
                {
                    string fileName = sourceFile.Generate(location);
                    fileNames.Add(fileName);
                }
                catch (FileGenerationException)
                {
                    success = false;
                }
            }
        }

        return success;
    }

    protected abstract SourceFileGenerator CreateSourceFileGenerator(TypeBase type);

    protected abstract bool GenerateProjectFiles(string location);
}