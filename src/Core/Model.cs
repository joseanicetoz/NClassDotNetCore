﻿using NClass.Translations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml;
using NClass.Core.Entities;
using NClass.Core.EventArgs;
using NClass.Core.Relationships;

namespace NClass.Core;

public class Model : IProjectItem, IDisposable
{
    private string name;
    private Language language;
    private readonly List<IEntity> entities = new List<IEntity>();
    private readonly List<Relationship> relationships = new List<Relationship>();
    private Project project;

    public event EventHandler Modified;
    public event EventHandler Renamed;
    public event EventHandler Closing;
    public event EntityEventHandler EntityAdded;
    public event EntityEventHandler EntityRemoved;
    public event RelationshipEventHandler RelationAdded;
    public event RelationshipEventHandler RelationRemoved;
    public event SerializeEventHandler Serializing;
    public event SerializeEventHandler Deserializing;

    protected Model()
    {
        name = Strings.Untitled;
        language = null;
    }

    public Model(Language language) : this(null, language)
    {
    }

    public Model(string name, Language language)
    {
        if (name != null && name.Length == 0)
            throw new ArgumentException("Name cannot empty string.");

        this.name = name;
        this.language = language ?? throw new ArgumentNullException(nameof(language));
    }

    public string Name
    {
        get
        {
            if (name == null)
                return Strings.Untitled;
            return name;
        }
        set
        {
            if (name != value && value != null)
            {
                name = value;
                OnRenamed(System.EventArgs.Empty);
                OnModified(System.EventArgs.Empty);
            }
        }
    }

    public Language Language
    {
        get { return language; }
        set {  language = value; }
    }

    [JsonIgnore]
    public Project Project
    {
        get { return project; }
        set { project = value; }
    }

    [JsonIgnore]
    public bool IsUntitled
    {
        get { return (name == null); }
    }

    [JsonIgnore]
    public bool IsDirty { get; set; }

    [JsonIgnore]
    protected bool Loading { get; set; }

    [JsonIgnore]
    public bool IsEmpty
    {
        get { return (entities.Count == 0 && relationships.Count == 0); }
    }

    void IModifiable.Clean()
    {
        IsDirty = false;
    }

    void IProjectItem.Close()
    {
        OnClosing(System.EventArgs.Empty);
    }

    public IEnumerable<IEntity> Entities
    {
        get { return entities; }
    }

    public IEnumerable<Relationship> Relationships
    {
        get { return relationships; }
    }

    private void ElementChanged(object sender, System.EventArgs e)
    {
        OnModified(e);
    }

    private void AddEntity(IEntity entity)
    {
        entities.Add(entity);
        entity.Modified += ElementChanged;
        OnEntityAdded(new EntityEventArgs(entity));
    }

    public ClassType AddClass()
    {
        ClassType newClass = Language.CreateClass();
        AddClass(newClass);
        return newClass;
    }

    protected virtual void AddClass(ClassType newClass)
    {
        AddEntity(newClass);
    }

    public bool InsertClass(ClassType newClass)
    {
        if (newClass != null && !entities.Contains(newClass) && newClass.Language.Name == language.Name)
        {
            AddClass(newClass);
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <exception cref="InvalidOperationException">
    /// The language does not support structures.
    /// </exception>
    public StructureType AddStructure()
    {
        StructureType structure = Language.CreateStructure();
        AddStructure(structure);
        return structure;
    }

    protected virtual void AddStructure(StructureType structure)
    {
        AddEntity(structure);
    }

    public bool InsertStructure(StructureType structure)
    {
        if (structure != null && !entities.Contains(structure) &&
            structure.Language.Name == language.Name)
        {
            AddStructure(structure);
            return true;
        }
        else
        {
            return false;
        }
    }

    public InterfaceType AddInterface()
    {
        InterfaceType newInterface = Language.CreateInterface();
        AddInterface(newInterface);
        return newInterface;
    }

    protected virtual void AddInterface(InterfaceType newInterface)
    {
        AddEntity(newInterface);
    }

    public bool InsertInterface(InterfaceType newInterface)
    {
        if (newInterface == null || entities.Contains(newInterface) ||
            newInterface.Language.Name != language.Name) return false;
        AddInterface(newInterface);
        return true;
    }

    public EnumType AddEnum()
    {
        EnumType newEnum = Language.CreateEnum();
        AddEnum(newEnum);
        return newEnum;
    }

    protected virtual void AddEnum(EnumType newEnum)
    {
        AddEntity(newEnum);
    }

    public bool InsertEnum(EnumType newEnum)
    {
        if (newEnum != null && !entities.Contains(newEnum) &&
            newEnum.Language.Name == language.Name)
        {
            AddEnum(newEnum);
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <exception cref="InvalidOperationException">
    /// The language does not support delegates.
    /// </exception>
    public DelegateType AddDelegate()
    {
        DelegateType newDelegate = Language.CreateDelegate();
        AddDelegate(newDelegate);
        return newDelegate;
    }

    protected virtual void AddDelegate(DelegateType newDelegate)
    {
        AddEntity(newDelegate);
    }

    public bool InsertDelegate(DelegateType newDelegate)
    {
        if (newDelegate != null && !entities.Contains(newDelegate) &&
            newDelegate.Language.Name == language.Name)
        {
            AddDelegate(newDelegate);
            return true;
        }
        else
        {
            return false;
        }
    }

    public Comment AddComment()
    {
        Comment comment = new Comment();
        AddComment(comment);
        return comment;
    }

    protected virtual void AddComment(Comment comment)
    {
        AddEntity(comment);
    }

    public bool InsertComment(Comment comment)
    {
        if (comment != null && !entities.Contains(comment))
        {
            AddComment(comment);
            return true;
        }
        else
        {
            return false;
        }
    }

    private void AddRelationship(Relationship relationship)
    {
        relationships.Add(relationship);
        relationship.Modified += ElementChanged;
        OnRelationAdded(new RelationshipEventArgs(relationship));
    }

    /// <exception cref="ArgumentNullException">
    /// <paramref name="first"/> or <paramref name="second"/> is null.
    /// </exception>
    public AssociationRelationship AddAssociation(TypeBase first, TypeBase second)
    {
        AssociationRelationship association = new AssociationRelationship(first, second);
        AddAssociation(association);
        return association;
    }

    protected virtual void AddAssociation(AssociationRelationship association)
    {
        AddRelationship(association);
    }

    public bool InsertAssociation(AssociationRelationship associaton)
    {
        if (associaton == null || relationships.Contains(associaton) ||
            !entities.Contains(associaton.First) || !entities.Contains(associaton.Second)) return false;
        AddAssociation(associaton);
        return true;
    }

    /// <exception cref="ArgumentNullException">
    /// <paramref name="first"/> or <paramref name="second"/> is null.
    /// </exception>
    public AssociationRelationship AddComposition(TypeBase first, TypeBase second)
    {
        AssociationRelationship composition = new AssociationRelationship(
            first, second, AssociationType.Composition);
        AddAssociation(composition);
        return composition;
    }

    /// <exception cref="ArgumentNullException">
    /// <paramref name="first"/> or <paramref name="second"/> is null.
    /// </exception>
    public AssociationRelationship AddAggregation(TypeBase first, TypeBase second)
    {
        AssociationRelationship aggregation = new AssociationRelationship(
            first, second, AssociationType.Aggregation);
        AddAssociation(aggregation);
        return aggregation;
    }

    /// <exception cref="RelationshipException">
    /// Cannot create relationship between the two types.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="derivedType"/> or <paramref name="baseType"/> is null.
    /// </exception>
    public GeneralizationRelationship AddGeneralization(CompositeType derivedType,
        CompositeType baseType)
    {
        GeneralizationRelationship generalization =
            new GeneralizationRelationship(derivedType, baseType);

        AddGeneralization(generalization);
        return generalization;
    }

    protected virtual void AddGeneralization(GeneralizationRelationship generalization)
    {
        AddRelationship(generalization);
    }

    public bool InsertGeneralization(GeneralizationRelationship generalization)
    {
        if (generalization == null || relationships.Contains(generalization) ||
            !entities.Contains(generalization.First) || !entities.Contains(generalization.Second)) return false;
        AddGeneralization(generalization);
        return true;
    }

    /// <exception cref="RelationshipException">
    /// Cannot create relationship between the two types.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="implementer"/> or <paramref name="baseType"/> is null.
    /// </exception>
    public RealizationRelationship AddRealization(TypeBase implementer,
        InterfaceType baseType)
    {
        RealizationRelationship realization = new RealizationRelationship(
            implementer, baseType);

        AddRealization(realization);
        return realization;
    }

    protected virtual void AddRealization(RealizationRelationship realization)
    {
        AddRelationship(realization);
    }

    public bool InsertRealization(RealizationRelationship realization)
    {
        if (realization == null || relationships.Contains(realization) ||
            !entities.Contains(realization.First) || !entities.Contains(realization.Second)) return false;
        AddRealization(realization);
        return true;
    }

    /// <exception cref="ArgumentNullException">
    /// <paramref name="first"/> or <paramref name="second"/> is null.
    /// </exception>
    public DependencyRelationship AddDependency(TypeBase first, TypeBase second)
    {
        DependencyRelationship dependency = new DependencyRelationship(first, second);

        AddDependency(dependency);
        return dependency;
    }

    protected virtual void AddDependency(DependencyRelationship dependency)
    {
        AddRelationship(dependency);
    }

    public bool InsertDependency(DependencyRelationship dependency)
    {
        if (dependency == null || relationships.Contains(dependency) ||
            !entities.Contains(dependency.First) || !entities.Contains(dependency.Second)) return false;
        AddDependency(dependency);
        return true;
    }

    public NestingRelationship AddNesting(CompositeType parentType, TypeBase innerType)
    {
        NestingRelationship nesting = new NestingRelationship(parentType, innerType);

        AddNesting(nesting);
        return nesting;
    }

    protected virtual void AddNesting(NestingRelationship nesting)
    {
        AddRelationship(nesting);
    }

    public bool InsertNesting(NestingRelationship nesting)
    {
        if (nesting != null && !relationships.Contains(nesting) &&
            entities.Contains(nesting.First) && entities.Contains(nesting.Second))
        {
            AddNesting(nesting);
            return true;
        }
        else
        {
            return false;
        }
    }

    public virtual CommentRelationship AddCommentRelationship(Comment comment, IEntity entity)
    {
        CommentRelationship commentRelationship = new CommentRelationship(comment, entity);

        AddCommentRelationship(commentRelationship);
        return commentRelationship;
    }

    protected virtual void AddCommentRelationship(CommentRelationship commentRelationship)
    {
        AddRelationship(commentRelationship);
    }

    public bool InsertCommentRelationship(CommentRelationship commentRelationship)
    {
        if (commentRelationship != null && !relationships.Contains(commentRelationship) &&
            entities.Contains(commentRelationship.First) && entities.Contains(commentRelationship.Second))
        {
            AddCommentRelationship(commentRelationship);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void RemoveEntity(IEntity entity)
    {
        if (!entities.Remove(entity)) return;
        entity.Modified -= ElementChanged;
        RemoveRelationships(entity);
        OnEntityRemoved(new EntityEventArgs(entity));
    }

    private void RemoveRelationships(IEntity entity)
    {
        for (int i = 0; i < relationships.Count; i++)
        {
            Relationship relationship = relationships[i];
            if (relationship.First == entity || relationship.Second == entity)
            {
                relationship.Detach();
                relationship.Modified -= ElementChanged;
                relationships.RemoveAt(i--);
                OnRelationRemoved(new RelationshipEventArgs(relationship));
            }
        }
    }

    public void RemoveRelationship(Relationship relationship)
    {
        if (relationships.Contains(relationship))
        {
            relationship.Detach();
            relationship.Modified -= ElementChanged;
            relationships.Remove(relationship);
            OnRelationRemoved(new RelationshipEventArgs(relationship));
        }
    }
    
    void IProjectItem.Serialize(XmlElement node)
    {
        if (node == null)
            throw new ArgumentNullException("root");

        if (node.OwnerDocument != null)
        {
            XmlElement nameElement = node.OwnerDocument.CreateElement("Name");
            nameElement.InnerText = Name;
            node.AppendChild(nameElement);
        }

        if (node.OwnerDocument != null)
        {
            XmlElement languageElement = node.OwnerDocument.CreateElement("Language");
            languageElement.InnerText = Language.Name;
            node.AppendChild(languageElement);
        }

        SaveEntitites(node);
        SaveRelationships(node);

        OnSerializing(new SerializeEventArgs(node));
    }

    void IProjectItem.Deserialize(XmlElement node)
    {
        if (node == null)
            throw new ArgumentNullException("root");
        Loading = true;

        XmlElement nameElement = node["Name"];
        if (nameElement == null || nameElement.InnerText == "")
            name = null;
        else
            name = nameElement.InnerText;

        XmlElement languageElement = node["Language"];
        
        try
        {
            Language lang = LanguageManager.Instance.GetLanguage(languageElement.InnerText);
            this.language = lang ?? throw new InvalidDataException("Invalid project language.");
        }
        catch (Exception ex)
        {
            throw new InvalidDataException("Invalid project language.", ex);
        }

        LoadEntitites(node);
        LoadRelationships(node);

        OnDeserializing(new SerializeEventArgs(node));
        Loading = false;
    }

    private void LoadEntitites(XmlNode root)
    {
        if (root == null)
            throw new ArgumentNullException(nameof(root));

        XmlNodeList nodeList = root.SelectNodes("Entities/Entity");

        foreach (XmlElement node in nodeList)
        {
            try
            {
                string type = node.GetAttribute("type");

                IEntity entity = GetEntity(type);
                entity.Deserialize(node);
            }
            catch (BadSyntaxException ex)
            {
                throw new InvalidDataException("Invalid entity.", ex);
            }
        }
    }

    private IEntity GetEntity(string type)
    {
        switch (type)
        {
            case "Class":
            case "CSharpClass":     // Old file format
            case "JavaClass":       // Old file format
                return AddClass();

            case "Structure":
            case "StructType":      // Old file format
                return AddStructure();

            case "Interface":
            case "CSharpInterface": // Old file format
            case "JavaInterface":   // Old file format
                return AddInterface();

            case "Enum":
            case "CSharpEnum":      // Old file format
            case "JavaEnum":        // Old file format
                return AddEnum();

            case "Delegate":
            case "DelegateType":    // Old file format
                return AddDelegate();

            case "Comment":
                return AddComment();

            default:
                throw new InvalidDataException("Invalid entity type: " + type);
        }
    }

    private void LoadRelationships(XmlNode root)
    {
        if (root == null)
            throw new ArgumentNullException(nameof(root));

        XmlNodeList nodeList = root.SelectNodes(
            "Relationships/Relationship|Relations/Relation"); // old file format

        foreach (XmlElement node in nodeList)
        {
            string type = node.GetAttribute("type");
            string firstString = node.GetAttribute("first");
            string secondString = node.GetAttribute("second");

            if (!int.TryParse(firstString, out int firstIndex) ||
                !int.TryParse(secondString, out int secondIndex))
            {
                throw new InvalidDataException(Strings.ErrorCorruptSaveFormat);
            }
            if (firstIndex < 0 || firstIndex >= entities.Count ||
                secondIndex < 0 || secondIndex >= entities.Count)
            {
                throw new InvalidDataException(Strings.ErrorCorruptSaveFormat);
            }

            try
            {
                IEntity first = entities[firstIndex];
                IEntity second = entities[secondIndex];
                Relationship relationship;

                switch (type)
                {
                    case "Association":
                        relationship = AddAssociation(first as TypeBase, second as TypeBase);
                        break;

                    case "Generalization":
                        relationship = AddGeneralization(
                            first as CompositeType, second as CompositeType);
                        break;

                    case "Realization":
                        relationship = AddRealization(first as TypeBase, second as InterfaceType);
                        break;

                    case "Dependency":
                        relationship = AddDependency(first as TypeBase, second as TypeBase);
                        break;

                    case "Nesting":
                        relationship = AddNesting(first as CompositeType, second as TypeBase);
                        break;

                    case "Comment":
                    case "CommentRelationship": // Old file format
                        if (first is Comment)
                            relationship = AddCommentRelationship(first as Comment, second);
                        else
                            relationship = AddCommentRelationship(second as Comment, first);
                        break;

                    default:
                        throw new InvalidDataException(
                            Strings.ErrorCorruptSaveFormat);
                }
                relationship.Deserialize(node);
            }
            catch (ArgumentNullException ex)
            {
                throw new InvalidDataException("Invalid relationship.", ex);
            }
            catch (RelationshipException ex)
            {
                throw new InvalidDataException("Invalid relationship.", ex);
            }
        }
    }

    private void SaveEntitites(XmlElement node)
    {
        if (node == null)
            throw new ArgumentNullException("root");

        XmlElement entitiesChild = node.OwnerDocument.CreateElement("Entities");

        foreach (IEntity entity in entities)
        {
            XmlElement child = node.OwnerDocument.CreateElement("Entity");

            entity.Serialize(child);
            child.SetAttribute("type", entity.EntityType.ToString());
            entitiesChild.AppendChild(child);
        }
        node.AppendChild(entitiesChild);
    }

    private void SaveRelationships(XmlNode root)
    {
        if (root == null)
            throw new ArgumentNullException(nameof(root));

        if (root.OwnerDocument != null)
        {
            XmlElement relationsChild = root.OwnerDocument.CreateElement("Relationships");

            foreach (Relationship relationship in relationships)
            {
                XmlElement child = root.OwnerDocument.CreateElement("Relationship");

                int firstIndex = entities.IndexOf(relationship.First);
                int secondIndex = entities.IndexOf(relationship.Second);

                relationship.Serialize(child);
                child.SetAttribute("type", relationship.RelationshipType.ToString());
                child.SetAttribute("first", firstIndex.ToString());
                child.SetAttribute("second", secondIndex.ToString());
                relationsChild.AppendChild(child);
            }
            
            root.AppendChild(relationsChild);
        }
    }

    protected virtual void OnEntityAdded(EntityEventArgs e)
    {
        EntityAdded?.Invoke(this, e);
        OnModified(System.EventArgs.Empty);
    }

    protected virtual void OnEntityRemoved(EntityEventArgs e)
    {
        EntityRemoved?.Invoke(this, e);
        OnModified(System.EventArgs.Empty);
    }

    protected virtual void OnRelationAdded(RelationshipEventArgs e)
    {
        RelationAdded?.Invoke(this, e);
        OnModified(System.EventArgs.Empty);
    }

    protected virtual void OnRelationRemoved(RelationshipEventArgs e)
    {
        RelationRemoved?.Invoke(this, e);
        OnModified(System.EventArgs.Empty);
    }

    protected virtual void OnSerializing(SerializeEventArgs e)
    {
        Serializing?.Invoke(this, e);
    }

    protected virtual void OnDeserializing(SerializeEventArgs e)
    {
        Deserializing?.Invoke(this, e);
        OnModified(System.EventArgs.Empty);
    }

    protected virtual void OnModified(System.EventArgs e)
    {
        IsDirty = true;
        Modified?.Invoke(this, e);
    }

    protected virtual void OnRenamed(System.EventArgs e)
    {
        Renamed?.Invoke(this, e);
    }

    protected virtual void OnClosing(System.EventArgs e)
    {
        Closing?.Invoke(this, e);
    }

    public override string ToString()
    {
        if (IsDirty)
            return Name + "*";
        else
            return Name;
    }

    public void Dispose()
    {
    }
}
