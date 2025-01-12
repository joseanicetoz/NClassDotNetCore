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

public sealed class GeneralizationRelationship : TypeRelationship
{

    public override RelationshipType RelationshipType { get; set; } = RelationshipType.Generalization;
    private CompositeType DerivedType
    {
        get { return (CompositeType)First; }
    }

    private CompositeType BaseType
    {
        get { return (CompositeType)Second; }
    }

    internal GeneralizationRelationship(CompositeType derivedType, CompositeType baseType) : base(derivedType, baseType)
    {
        Attach();
    }

    public GeneralizationRelationship Clone(CompositeType derivedType, CompositeType baseType)
    {
        GeneralizationRelationship generalization =
            new GeneralizationRelationship(derivedType, baseType);
        generalization.CopyFrom(this);
        return generalization;
    }

    protected override void OnAttaching(System.EventArgs e)
    {
        base.OnAttaching(e);

        if (!DerivedType.IsAllowedChild)
            throw new RelationshipException(Strings.ErrorNotAllowedChild);
        if (!BaseType.IsAllowedParent)
            throw new RelationshipException(Strings.ErrorNotAllowedParent);
        if (First is SingleInheritanceType type && type.HasExplicitBase)
            throw new RelationshipException(Strings.ErrorMultipleBases);
        if (First is SingleInheritanceType ^ Second is SingleInheritanceType ||
            First is InterfaceType ^ Second is InterfaceType)
            throw new RelationshipException(Strings.ErrorInvalidBaseType);

        if (First is SingleInheritanceType first && Second is SingleInheritanceType second)
        {
            first.Base = second;
        }
        else if (First is InterfaceType first1 && Second is InterfaceType second1)
        {
            first1.AddBase(second1);
        }
    }

    protected override void OnDetaching(System.EventArgs e)
    {
        base.OnDetaching(e);

        if (First is SingleInheritanceType singletype)
            singletype.Base = null;
        else if (First is InterfaceType interfacetype)
            interfacetype.RemoveBase(Second as InterfaceType);
    }

    public override string ToString()
    {
        return $@"{Strings.Generalization}: {First.Name} --> {Second.Name}";
    }
}