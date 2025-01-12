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
using System.Text.Json.Serialization;
using System.Xml;
using NClass.Core.Entities;
using NClass.Core.EventArgs;

namespace NClass.Core.Relationships;

public abstract class Relationship : Element, ISerializableElement
{
    private string label = string.Empty;
    private bool attached = false;

    public event EventHandler Attaching;
    public event EventHandler Detaching;
    public event SerializeEventHandler Serializing;
    public event SerializeEventHandler Deserializing;

    public abstract IEntity First { get; set; }
    public abstract IEntity Second { get; set; }

    public abstract RelationshipType RelationshipType { get; set; }

    public virtual string Label
    {
        get { return label; }
        set
        {
            if (value == "")
                value = null;

            if (label != value && SupportsLabel)
            {
                label = value;
                Changed();
            }
        }
    }

    [JsonIgnore] 
    public virtual bool SupportsLabel { get; set; } = false;

    internal void Attach()
    {
        if (!attached)
            OnAttaching(System.EventArgs.Empty);
        attached = true;
    }

    internal void Detach()
    {
        if (attached)
            OnDetaching(System.EventArgs.Empty);
        attached = false;
    }

    protected virtual void CopyFrom(Relationship relationship)
    {
        label = relationship.label;
    }

    void ISerializableElement.Serialize(XmlElement node)
    {
        Serialize(node);
    }

    void ISerializableElement.Deserialize(XmlElement node)
    {
        Deserialize(node);
    }

    protected internal virtual void Serialize(XmlElement node)
    {
        if (node == null)
            throw new ArgumentNullException(nameof(node));

        if (SupportsLabel && Label != null)
        {
            XmlElement labelNode = node.OwnerDocument.CreateElement("Label");
            labelNode.InnerText = Label.ToString();
            node.AppendChild(labelNode);
        }
        OnSerializing(new SerializeEventArgs(node));
    }

    protected internal virtual void Deserialize(XmlElement node)
    {
        if (node == null)
            throw new ArgumentNullException(nameof(node));

        if (SupportsLabel)
        {
            XmlElement labelNode = node["Label"];
            if (labelNode != null)
                Label = labelNode.InnerText;
        }
        OnDeserializing(new SerializeEventArgs(node));
    }

    protected virtual void OnAttaching(System.EventArgs e)
    {
        Attaching?.Invoke(this, e);
    }

    protected virtual void OnDetaching(System.EventArgs e)
    {
        Detaching?.Invoke(this, e);
    }

    private void OnSerializing(SerializeEventArgs e)
    {
        Serializing?.Invoke(this, e);
    }

    private void OnDeserializing(SerializeEventArgs e)
    {
        Deserializing?.Invoke(this, e);
    }

    public abstract override string ToString();
}