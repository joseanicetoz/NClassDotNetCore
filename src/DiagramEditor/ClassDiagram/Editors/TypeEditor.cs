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

using NClass.DiagramEditor.ClassDiagram.Shapes;
using System.Drawing;

namespace NClass.DiagramEditor.ClassDiagram.Editors;

public abstract class TypeEditor : FloatingEditor
{
    internal sealed override void Relocate(DiagramElement element)
    {
        Relocate((TypeShape)element);
    }

    internal void Relocate(TypeShape shape)
    {
        Diagram diagram = shape.Diagram;
        if (diagram != null)
        {
            Point absolute = new Point(shape.Right, shape.Top);
            Size relative = new Size(
                (int)(absolute.X * diagram.Zoom) - diagram.Offset.X + MarginSize,
                (int)(absolute.Y * diagram.Zoom) - diagram.Offset.Y);

            this.Location = ParentLocation + relative;
        }
    }
}