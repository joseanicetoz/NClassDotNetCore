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

namespace NClass.Core
{
    public abstract class TypeRelationship : Relationship
    {
        TypeBase first;
        TypeBase second;

        /// <exception cref="ArgumentNullException">
        /// <paramref name="first"/> is null.-or-
        /// <paramref name="second"/> is null.
        /// </exception>
        protected TypeRelationship(TypeBase first, TypeBase second)
        {
            this.first = first ?? throw new ArgumentNullException("first");
            this.second = second ?? throw new ArgumentNullException("second");
        }

        //TODO: ink�bb abstract property-kre hivatkozzon
        public sealed override IEntity First
        {
            get { return first; }
            protected set { first = (TypeBase)value; }
        }

        public sealed override IEntity Second
        {
            get { return second; }
            protected set { second = (TypeBase)value; }
        }
    }
}
