#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Mon Feb 09 16:31:52 2004
//
using System;

namespace Boo.Lang.Ast.Impl
{
	[Serializable]
	public abstract class FieldImpl : TypeMember
	{
		protected TypeReference _type;
		protected Expression _initializer;
		
		protected FieldImpl()
		{
 		}
		
		protected FieldImpl(TypeReference type, Expression initializer)
		{
 			Type = type;
			Initializer = initializer;
		}
		
		protected FieldImpl(LexicalInfo lexicalInfo, TypeReference type, Expression initializer) : base(lexicalInfo)
		{
 			Type = type;				
			Initializer = initializer;				
		}
		
		protected FieldImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.Field;
			}
		}
		public TypeReference Type
		{
			get
			{
				return _type;
			}
			
			set
			{
				
				if (_type != value)
				{
					_type = value;
					if (null != _type)
					{
						_type.InitializeParent(this);
					}
				}
			}
		}
		public Expression Initializer
		{
			get
			{
				return _initializer;
			}
			
			set
			{
				
				if (_initializer != value)
				{
					_initializer = value;
					if (null != _initializer)
					{
						_initializer.InitializeParent(this);
					}
				}
			}
		}
		new public Field CloneNode()
		{
			return (Field)Clone();
		}
		
		override public object Clone()
		{
			Field clone = (Field)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(GetType());
			clone._lexicalInfo = _lexicalInfo;
			clone._documentation = _documentation;
			clone._properties = (System.Collections.Hashtable)_properties.Clone();
			
			if (null != _type)
			{
				clone._type = (TypeReference)_type.Clone();
			}
			if (null != _initializer)
			{
				clone._initializer = (Expression)_initializer.Clone();
			}
			clone._modifiers = _modifiers;
			clone._name = _name;
			if (null != _attributes)
			{
				clone._attributes = (AttributeCollection)_attributes.Clone();
			}
			
			return clone;
		}
		
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			
			if (_type == existing)
			{
				this.Type = (TypeReference)newNode;
				return true;
			}
			if (_initializer == existing)
			{
				this.Initializer = (Expression)newNode;
				return true;
			}
			if (_attributes != null)
			{
				Attribute item = existing as Attribute;
				if (null != item)
				{
					if (_attributes.Replace(item, (Attribute)newNode))
					{
						return true;
					}
				}
			}
			return false;
		}
		
		override public void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Field thisNode = (Field)this;
			Field resultingTypedNode = thisNode;
			transformer.OnField(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}
