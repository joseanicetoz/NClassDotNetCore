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

using NClass.Core.Entities;
using NClass.Translations;

namespace NClass.Core.Members;

public abstract class Destructor : Method
{
    public sealed override MemberType MemberType
    {
        get { return MemberType.Destructor; }
    }

    public abstract override string Name { get; set; }

    public sealed override bool IsNameReadonly
    {
        get { return true; }
    }

    public sealed override bool Overridable
    {
        get { return false; }
    }

    public sealed override bool IsOperator
    {
        get { return false; }
    }

    public sealed override string Type
    {
        get { return null; }
        set
        {
            if (value != null)
                throw new BadSyntaxException(Strings.ErrorCannotSetType);
        }
    }

    public sealed override bool IsTypeReadonly
    {
        get { return true; }
    }

    protected sealed override string DefaultType
    {
        get { return null; }
    }
    public sealed override bool IsStatic
    {
        get { return false; }
        set
        {
            if (value)
                throw new BadSyntaxException(Strings.ErrorCannotSetStatic);
        }
    }

    public override bool IsHider
    {
        get { return base.IsHider; }
        set
        {
            if (value)
                throw new BadSyntaxException(Strings.ErrorCannotSetModifier);
        }
    }

    public override bool IsAbstract
    {
        get { return base.IsAbstract; }
        set
        {
            if (value)
                throw new BadSyntaxException(Strings.ErrorCannotSetModifier);
        }
    }

    protected Destructor(CompositeType parent) : base(null, parent)
    {
    }

}