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
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Ruby
{
    public sealed class RubyLanguage : Language
    {
        static readonly RubyLanguage instance = new RubyLanguage();

        static readonly string[] reservedNames = {
            "begin", "end", "alias", "and", "break", "case", "class", "def", "module",
            "next", "nil", "not", "or", "redo", "rescue", "retry", "return", "elsif",
            "false", "ensure", "for", "if", "true", "undef", "unless", "do", "else",
            "super", "then", "until", "when", "while", "defined?", "self"
        };

        static readonly RubyClass objectClass;

        static RubyLanguage()
        {
        }

        public RubyLanguage()
        {
        }

        public static RubyLanguage Instance
        {
            get { return instance; }
        }
        public override string Name { get { return "Ruby"; } }

        public override string AssemblyName
        {
            get { return Assembly.GetExecutingAssembly().GetName().Name; }
        }

        public override Dictionary<AccessModifier, string> ValidAccessModifiers => throw new NotImplementedException();

        public override Dictionary<ClassModifier, string> ValidClassModifiers => throw new NotImplementedException();

        public override Dictionary<FieldModifier, string> ValidFieldModifiers => throw new NotImplementedException();

        public override Dictionary<OperationModifier, string> ValidOperationModifiers => throw new NotImplementedException();

        public override bool SupportsAssemblyImport => throw new NotImplementedException();

        public override bool SupportsInterfaces => throw new NotImplementedException();

        public override bool SupportsStructures => throw new NotImplementedException();

        public override bool SupportsEnums => throw new NotImplementedException();

        public override bool SupportsDelegates => throw new NotImplementedException();

        public override bool SupportsExplicitImplementation => throw new NotImplementedException();

        public override bool ExplicitVirtualMethods => throw new NotImplementedException();

        public override string DefaultFileExtension => throw new NotImplementedException();

        protected override string[] ReservedNames => throw new NotImplementedException();

        protected override string[] TypeKeywords => throw new NotImplementedException();

        public override string GetAccessString(AccessModifier access, bool forCode)
        {
            throw new NotImplementedException();
        }

        public override string GetClassModifierString(ClassModifier modifier, bool forCode)
        {
            throw new NotImplementedException();
        }

        public override string GetFieldModifierString(FieldModifier modifier, bool forCode)
        {
            throw new NotImplementedException();
        }

        public override string GetOperationModifierString(OperationModifier modifier, bool forCode)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidModifier(FieldModifier modifier)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidModifier(OperationModifier modifier)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidModifier(AccessModifier modifier)
        {
            throw new NotImplementedException();
        }

        protected override ClassType CreateClass()
        {
            throw new NotImplementedException();
        }

        protected override DelegateType CreateDelegate()
        {
            throw new NotImplementedException();
        }

        protected override EnumType CreateEnum()
        {
            throw new NotImplementedException();
        }

        protected override InterfaceType CreateInterface()
        {
            throw new NotImplementedException();
        }

        protected override ArgumentList CreateParameterCollection()
        {
            throw new NotImplementedException();
        }

        protected override StructureType CreateStructure()
        {
            throw new NotImplementedException();
        }

        protected override Operation Implement(Operation operation, CompositeType newParent, bool explicitly)
        {
            throw new NotImplementedException();
        }

        protected override Operation Override(Operation operation, CompositeType newParent)
        {
            throw new NotImplementedException();
        }

        protected override void ValidateField(Field field)
        {
            throw new NotImplementedException();
        }

        protected override void ValidateOperation(Operation operation)
        {
            throw new NotImplementedException();
        }
    }
}
