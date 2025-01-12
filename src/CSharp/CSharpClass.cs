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
using NClass.Translations;
using System;
using System.Text;
using NClass.Core.Entities;
using NClass.Core.Members;
using NClass.Core.Relationships;

namespace NClass.CSharp;

internal sealed class CSharpClass : ClassType
{

    public override AccessModifier AccessModifier
    {
        get { return base.AccessModifier; }
        set
        {
            if (IsNested ||
                value == AccessModifier.Default ||
                value == AccessModifier.Internal ||
                value == AccessModifier.Public)
            {
                base.AccessModifier = value;
            }
        }
    }

    public override ClassType BaseClass
    {
        get
        {
            if (base.BaseClass == null && this != CSharpLanguage.ObjectClass)
                return CSharpLanguage.ObjectClass;
            return base.BaseClass;
        }
        set { base.BaseClass = value; }
    }

    public override AccessModifier DefaultAccess
    {
        get { return AccessModifier.Internal; }
    }

    public override AccessModifier DefaultMemberAccess
    {
        get { return AccessModifier.Private; }
    }

    public override bool SupportsProperties
    {
        get { return true; }
    }

    public override bool SupportsEvents
    {
        get { return true; }
    }

    public override bool SupportsDestructors
    {
        get { return true; }
    }

    public override CompositeType NestingParent
    {
        get { return base.NestingParent; }
        protected set
        {
            try
            {
                RaiseChangedEvent = false;

                base.NestingParent = value;
                if (NestingParent == null && Access != AccessModifier.Public)
                    AccessModifier = AccessModifier.Internal;
            }
            finally
            {
                RaiseChangedEvent = true;
            }
        }
    }

    public override Language Language
    {
        get { return CSharpLanguage.Instance; }
    }

    internal CSharpClass() : this("NewClass")
    {
    }
    internal CSharpClass(string name) : base(name)
    {
    }

    public override void AddInterface(InterfaceType interfaceType)
    {
        if (!(interfaceType is CSharpInterface))
            throw new RelationshipException(string.Format(Strings.ErrorInterfaceLanguage, "C#"));

        base.AddInterface(interfaceType);
    }

    /// <exception cref="BadSyntaxException">
    /// The <paramref name="name"/> does not fit to the syntax.
    /// </exception>
    public override Field AddField()
    {
        Field field = new CSharpField(this);

        AddField(field);
        return field;
    }

    public override Constructor AddConstructor()
    {
        Constructor constructor = new CSharpConstructor(this);

        if (Modifier == ClassModifier.Abstract)
            constructor.AccessModifier = AccessModifier.Protected;
        else if (Modifier != ClassModifier.Static)
            constructor.AccessModifier = AccessModifier.Public;

        AddOperation(constructor);
        return constructor;
    }

    public override Destructor AddDestructor()
    {
        Destructor destructor = new CSharpDestructor(this);

        AddOperation(destructor);
        return destructor;
    }

    /// <exception cref="BadSyntaxException">
    /// The <paramref name="name"/> does not fit to the syntax.
    /// </exception>
    public override Method AddMethod()
    {
        Method method = new CSharpMethod(this)
        {
            AccessModifier = AccessModifier.Public,
            IsStatic = (Modifier == ClassModifier.Static)
        };

        AddOperation(method);
        return method;
    }

    /// <exception cref="BadSyntaxException">
    /// The <paramref name="name"/> does not fit to the syntax.
    /// </exception>
    public override Property AddProperty()
    {
        Property property = new CSharpProperty(this)
        {
            AccessModifier = AccessModifier.Public,
            IsStatic = (Modifier == ClassModifier.Static)
        };

        AddOperation(property);
        return property;
    }

    /// <exception cref="BadSyntaxException">
    /// The <paramref name="name"/> does not fit to the syntax.
    /// </exception>
    public override Event AddEvent()
    {
        Event newEvent = new CSharpEvent(this)
        {
            AccessModifier = AccessModifier.Public,
            IsStatic = (Modifier == ClassModifier.Static)
        };

        AddOperation(newEvent);
        return newEvent;
    }

    public override string GetDeclaration()
    {
        StringBuilder builder = new StringBuilder();

        if (AccessModifier != AccessModifier.Default)
        {
            builder.Append(Language.GetAccessString(AccessModifier, true));
            builder.Append(" ");
        }
        if (Modifier != ClassModifier.None)
        {
            builder.Append(Language.GetClassModifierString(Modifier, true));
            builder.Append(" ");
        }
        builder.AppendFormat("class {0}", Name);

        if (HasExplicitBase || InterfaceList.Count > 0)
        {
            builder.Append(" : ");
            if (HasExplicitBase)
            {
                builder.Append(BaseClass.Name);
                if (InterfaceList.Count > 0)
                    builder.Append(", ");
            }
            for (int i = 0; i < InterfaceList.Count; i++)
            {
                builder.Append(InterfaceList[i].Name);
                if (i < InterfaceList.Count - 1)
                    builder.Append(", ");
            }
        }

        return builder.ToString();
    }

    public override ClassType Clone()
    {
        CSharpClass newClass = new CSharpClass();
        newClass.CopyFrom(this);
        return newClass;
    }
}