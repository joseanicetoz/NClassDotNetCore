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
using NClass.Core.Entities;
using NClass.Core.Members;

namespace NClass.CSharp;

internal sealed class CSharpDestructor : Destructor
{
    public override string Name
    {
        get { return "~" + GetNameWithoutGeneric(Parent.Name); }
        set
        {
            if (value != null && value != "~" + GetNameWithoutGeneric(Parent.Name))
                throw new BadSyntaxException(Strings.ErrorDestructorName);
        }
    }

    public override AccessModifier AccessModifier
    {
        get { return base.AccessModifier; }
        set
        {
            if (value != AccessModifier.Default)
                throw new BadSyntaxException(Strings.ErrorCannotSetAccess);
        }
    }

    public override AccessModifier DefaultAccess
    {
        get { return AccessModifier.Private; }
    }

    public override bool IsAccessModifiable
    {
        get { return false; }
    }

    public override bool IsVirtual
    {
        get { return base.IsVirtual; }
        set
        {
            if (value)
                throw new BadSyntaxException(Strings.ErrorCannotSetModifier);
        }
    }

    public override bool IsOverride
    {
        get { return base.IsOverride; }
        set
        {
            if (value)
                throw new BadSyntaxException(Strings.ErrorCannotSetModifier);
        }
    }

    public override bool IsSealed
    {
        get { return base.IsSealed; }
        set
        {
            if (value)
                throw new BadSyntaxException(Strings.ErrorCannotSetModifier);
        }
    }

    public override Language Language
    {
        get { return CSharpLanguage.Instance; }
    }

    internal CSharpDestructor(CompositeType parent) : base(parent)
    {
        AccessModifier = AccessModifier.Default;
    }

    public override void InitFromString(string declaration)
    {
        ValidName = "~" + Parent.Name;
    }

    public override string GetDeclaration()
    {
        return Name + "()";
    }

    public override Operation Clone(CompositeType newParent)
    {
        return new CSharpDestructor(newParent);
    }
}