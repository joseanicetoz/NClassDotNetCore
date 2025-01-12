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
using System.Xml;
using NClass.Core.EventArgs;
using NClass.Translations;

namespace NClass.Core.Entities;

public sealed class Comment : Element, IEntity
{
    private string text = string.Empty;

    public event SerializeEventHandler Serializing;
    public event SerializeEventHandler Deserializing;

    public EntityType EntityType { get; set; } = EntityType.Comment;

    public string Name  { get; set; } = Strings.Comment;

    public string Text
    {
        get { return text; }
        set
        {
            if (value == null)
                value = string.Empty;

            if (text != value)
            {
                text = value;
                Changed();
            }
        }
    }

    internal Comment()
    {
    }

    internal Comment(string text)
    {
        this.text = text;
    }

    public Comment Clone()
    {
        return new Comment(this.text);
    }

    [Obsolete]
    void ISerializableElement.Serialize(XmlElement node)
    {
        Serialize(node);
    }

    [Obsolete]
    void ISerializableElement.Deserialize(XmlElement node)
    {
        Deserialize(node);
    }

    [Obsolete]
    internal void Serialize(XmlElement node)
    {
        if (node == null)
            throw new ArgumentNullException(nameof(node));

        XmlElement child = node.OwnerDocument.CreateElement("Text");
        child.InnerText = Text;
        node.AppendChild(child);

        OnSerializing(new SerializeEventArgs(node));
    }

    [Obsolete]
    internal void Deserialize(XmlElement node)
    {
        if (node == null)
            throw new ArgumentNullException(nameof(node));

        XmlElement textNode = node["Text"];

        Text = null;

        if (textNode != null)
            Text = textNode.InnerText;

        OnDeserializing(new SerializeEventArgs(node));
    }

    private void OnSerializing(SerializeEventArgs e)
    {
        Serializing?.Invoke(this, e);
    }

    private void OnDeserializing(SerializeEventArgs e)
    {
        Deserializing?.Invoke(this, e);
    }

    public override string ToString()
    {
        const int maxLength = 50;

        if (Text == null)
        {
            return Strings.Comment;
        }
        else if (Text.Length > maxLength)
        {
            return '"' + Text.Substring(0, maxLength) + "...\"";
        }

        return $"\"{Text}\"";
    }
}