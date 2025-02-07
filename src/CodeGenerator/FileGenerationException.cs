﻿// NClass - Free class diagram editor
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
using System.Runtime.Serialization;

namespace NClass.CodeGenerator;

[Serializable]
public class FileGenerationException : Exception
{
    public FileGenerationException(string filePath) : base(@"Could not generate the file\n" + filePath)
    {
        this.FilePath = filePath;
    }

    public FileGenerationException(string filePath, string message) : base(message)
    {
        this.FilePath = filePath;
    }

    public FileGenerationException(string filePath, Exception innerException) : base(@"Could not generate the file\n" + filePath, innerException)
    {
        this.FilePath = filePath;
    }

    public FileGenerationException(string filePath, string message, Exception innerException) : base(message, innerException)
    {
        this.FilePath = filePath;
    }

    /*
    protected FileGenerationException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
    */

    public string FilePath { get; set; }
}
