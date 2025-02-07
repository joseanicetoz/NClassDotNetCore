// NClass - Free class diagram editor
// Copyright (C) 2006-2007 Balazs Tihanyi
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

namespace NClass.DiagramEditor.ClassDiagram.ContextMenus;

public abstract class DiagramContextMenu : ContextMenu
{
    private Diagram diagram = null;

    protected sealed override IDocument Document
    {
        get { return diagram; }
        set => diagram = (Diagram)value;
    }

    protected Diagram Diagram
    {
        get { return diagram; }
        set => diagram = value;
    }

    public sealed override void ValidateMenuItems(IDocument document)
    {
        ValidateMenuItems(document as Diagram);
    }

    public virtual void ValidateMenuItems(Diagram diagram)
    {
        this.diagram = diagram;
    }
}