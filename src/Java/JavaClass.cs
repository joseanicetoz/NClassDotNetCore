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

namespace NClass.Java;

internal sealed class JavaClass : ClassType
{
    public override AccessModifier AccessModifier
    {
        get { return base.AccessModifier; }
        set
        {
            if (IsNested ||
                value == AccessModifier.Default ||
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
            if (base.BaseClass == null && this != JavaLanguage.ObjectClass)
                return JavaLanguage.ObjectClass;
            else
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
        get { return AccessModifier.Internal; }
    }

    public override bool SupportsProperties
    {
        get { return false; }
    }

    public override bool SupportsConstuctors
    {
        get { return (base.SupportsConstuctors && Modifier != ClassModifier.Static); }
    }

    public override bool SupportsDestructors
    {
        get { return false; }
    }

    public override bool SupportsEvents
    {
        get { return false; }
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
        get { return JavaLanguage.Instance; }
    }

    internal JavaClass() : this("NewClass")
    {
    }
    internal JavaClass(string name) : base(name)
    {
    }
    public override void AddInterface(InterfaceType interfaceType)
    {
        if (!(interfaceType is JavaInterface))
        {
            throw new RelationshipException(
                string.Format(Strings.ErrorInterfaceLanguage, "Java"));
        }

        base.AddInterface(interfaceType);
    }

    public override Field AddField()
    {
        Field field = new JavaField(this)
        {
            AccessModifier = AccessModifier.Private
        };
        AddField(field);

        return field;
    }

    public override Constructor AddConstructor()
    {
        Constructor constructor = new JavaConstructor(this);

        if (Modifier == ClassModifier.Abstract)
            constructor.AccessModifier = AccessModifier.Protected;
        else
            constructor.AccessModifier = AccessModifier.Public;
        AddOperation(constructor);

        return constructor;
    }

    public override Destructor AddDestructor()
    {
        throw new InvalidOperationException("Java class does not support destructors.");
    }

    public override Method AddMethod()
    {
        Method method = new JavaMethod(this)
        {
            AccessModifier = AccessModifier.Public
        };
        AddOperation(method);

        return method;
    }

    public override Property AddProperty()
    {
        throw new InvalidOperationException("Java language does not support properties.");
    }

    public override Event AddEvent()
    {
        throw new InvalidOperationException("Java language does not support events.");
    }

    public override string GetDeclaration()
    {
        StringBuilder builder = new StringBuilder();

        if (AccessModifier != AccessModifier.Default)
        {
            builder.Append(Language.GetAccessString(AccessModifier, true));
            builder.Append(" ");
        }
        if (IsNested || Modifier == ClassModifier.Static)
        {
            builder.Append("static ");
        }
        if (Modifier != ClassModifier.None && Modifier != ClassModifier.Static)
        {
            builder.Append(Language.GetClassModifierString(Modifier, true));
            builder.Append(" ");
        }

        builder.AppendFormat("class {0}", Name);

        if (HasExplicitBase)
        {
            builder.Append(" extends ");
            builder.Append(BaseClass.Name);
        }
        if (InterfaceList.Count > 0)
        {
            builder.Append(" implements ");
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
        JavaClass newClass = new JavaClass();
        newClass.CopyFrom(this);
        return newClass;
    }
}
