// NClass - Free class diagram editor
// Copyright (C) 2006-2009 Balazs Tihanyi
// 
// NClass.Ruby
// Copyright (C) 2021 Jose Aniceto
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

namespace Ruby
{
    internal sealed class RubyClass : ClassType
    {
        internal RubyClass() : this("NewClass")
        {
        }

        /// <exception cref="BadSyntaxException">
        /// The <paramref name="name"/> does not fit to the syntax.
        /// </exception>
        internal RubyClass(string name) : base(name)
        {
        }

        public override bool SupportsDestructors => throw new NotImplementedException();

        public override bool SupportsProperties => throw new NotImplementedException();

        public override bool SupportsEvents => throw new NotImplementedException();

        public override AccessModifier DefaultMemberAccess => throw new NotImplementedException();

        public override AccessModifier DefaultAccess => throw new NotImplementedException();

        public override Language Language => throw new NotImplementedException();

        public override Constructor AddConstructor()
        {
            throw new NotImplementedException();
        }

        public override Destructor AddDestructor()
        {
            throw new NotImplementedException();
        }

        public override Event AddEvent()
        {
            throw new NotImplementedException();
        }

        public override Field AddField()
        {
            throw new NotImplementedException();
        }

        public override Method AddMethod()
        {
            throw new NotImplementedException();
        }

        public override Property AddProperty()
        {
            throw new NotImplementedException();
        }

        public override ClassType Clone()
        {
            throw new NotImplementedException();
        }

        public override string GetDeclaration()
        {
            throw new NotImplementedException();
        }
    }
}
