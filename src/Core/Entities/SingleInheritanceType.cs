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
using System.Collections.Generic;
using NClass.Core.Members;
using NClass.Core.Relationships;
using NClass.Translations;

namespace NClass.Core.Entities;

public abstract class SingleInheritanceType : CompositeType, IInterfaceImplementer
{
    private readonly List<InterfaceType> interfaceList = new List<InterfaceType>();

    protected SingleInheritanceType(string name) : base(name)
    {
    }

    public abstract SingleInheritanceType Base
    {
        get;
        set;
    }

    public abstract IEnumerable<Operation> OverridableOperations { get; }

    protected List<InterfaceType> InterfaceList
    {
        get { return interfaceList; }
    }

    public IEnumerable<InterfaceType> Interfaces
    {
        get { return interfaceList; }
    }

    public bool ImplementsInterface
    {
        get { return (interfaceList.Count > 0); }
    }

    public virtual void AddInterface(InterfaceType interfaceType)
    {
        if (interfaceType == null)
            throw new ArgumentNullException(nameof(interfaceType));

        foreach (InterfaceType implementedInterface in InterfaceList)
        {
            if (interfaceType == implementedInterface)
                throw new RelationshipException(Strings.ErrorCannotAddSameInterface);
        }

        InterfaceList.Add(interfaceType);
        Changed();
    }

    public void RemoveInterface(InterfaceType interfaceType)
    {
        if (InterfaceList.Remove(interfaceType))
            Changed();
    }

    public Operation Implement(Operation operation, bool explicitly)
    {
        if (operation == null)
            throw new ArgumentNullException(nameof(operation));

        if (operation.Language != this.Language)
            throw new ArgumentException(Strings.ErrorLanguagesDoNotEqual);

        if (!(operation.Parent is InterfaceType))
        {
            throw new ArgumentException("The operation is not a member of an interface.");
        }

        if (explicitly && !operation.Language.SupportsExplicitImplementation)
        {
            throw new ArgumentException(
                Strings.ErrorExplicitImplementation, nameof(explicitly));
        }

        Operation newOperation = Language.Implement(operation, this, explicitly);
        newOperation.Parent = this;

        AddOperation(newOperation);
        return newOperation;
    }

    public Operation Override(Operation operation)
    {
        if (operation == null)
            throw new ArgumentNullException(nameof(operation));

        if (operation.Language != this.Language)
            throw new ArgumentException(Strings.ErrorLanguagesDoNotEqual);

        Operation newOperation = Language.Override(operation, this);

        AddOperation(newOperation);
        return newOperation;
    }
}