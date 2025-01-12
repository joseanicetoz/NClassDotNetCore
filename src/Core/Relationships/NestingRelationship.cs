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

using System;
using NClass.Core.Entities;
using NClass.Translations;

namespace NClass.Core.Relationships;

public sealed class NestingRelationship : TypeRelationship
{
    public override RelationshipType RelationshipType { get;  set; } = RelationshipType.Nesting;
    private CompositeType ParentType
    {
        get { return (CompositeType)First; }
    }

    private TypeBase InnerType
    {
        get { return (TypeBase)Second; }
    }

    internal NestingRelationship(CompositeType parentType, TypeBase innerType) : base(parentType, innerType)
    {
        Attach();
    }

    public NestingRelationship Clone(CompositeType parentType, TypeBase innerType)
    {
        NestingRelationship nesting = new NestingRelationship(parentType, innerType);
        nesting.CopyFrom(this);
        return nesting;
    }

    protected override void OnAttaching(System.EventArgs e)
    {
        if (InnerType.IsNested)
            throw new RelationshipException(Strings.ErrorInnerTypeAlreadyNested);

        InnerType.NestingParent = ParentType;
    }

    protected override void OnDetaching(System.EventArgs e)
    {
        InnerType.NestingParent = null;
    }

    public override string ToString()
    {
        return $@"{Strings.Nesting}: {First.Name} (+)--> {Second.Name}";
    }
}