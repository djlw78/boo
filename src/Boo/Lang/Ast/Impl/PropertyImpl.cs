﻿#region license
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
// This file was generated automatically by
// astgenerator.boo on 3/30/2004 11:25:04 PM
//

namespace Boo.Lang.Ast.Impl
{	
	using Boo.Lang.Ast;
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public abstract class PropertyImpl : TypeMember
	{

		protected ParameterDeclarationCollection _parameters;
		protected Method _getter;
		protected Method _setter;
		protected TypeReference _type;

		protected PropertyImpl()
		{
			InitializeFields();
		}
		
		protected PropertyImpl(LexicalInfo info) : base(info)
		{
			InitializeFields();
		}
		

		protected PropertyImpl(Method getter, Method setter, TypeReference type)
		{
			InitializeFields();
			Getter = getter;
			Setter = setter;
			Type = type;
		}
			
		protected PropertyImpl(LexicalInfo lexicalInfo, Method getter, Method setter, TypeReference type) : base(lexicalInfo)
		{
			InitializeFields();
			Getter = getter;
			Setter = setter;
			Type = type;
		}
			
		new public Property CloneNode()
		{
			return Clone() as Property;
		}

		override public NodeType NodeType
		{
			get
			{
				return NodeType.Property;
			}
		}
		
		override public void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Property thisNode = (Property)this;
			Property resultingTypedNode = thisNode;
			transformer.OnProperty(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}

		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}

			if (_attributes != null)
			{
				Attribute item = existing as Attribute;
				if (null != item)
				{
					Attribute newItem = (Attribute)newNode;
					if (_attributes.Replace(item, newItem))
					{
						return true;
					}
				}
			}

			if (_parameters != null)
			{
				ParameterDeclaration item = existing as ParameterDeclaration;
				if (null != item)
				{
					ParameterDeclaration newItem = (ParameterDeclaration)newNode;
					if (_parameters.Replace(item, newItem))
					{
						return true;
					}
				}
			}

			if (_getter == existing)
			{
				this.Getter = (Method)newNode;
				return true;
			}

			if (_setter == existing)
			{
				this.Setter = (Method)newNode;
				return true;
			}

			if (_type == existing)
			{
				this.Type = (TypeReference)newNode;
				return true;
			}

			return false;
		}

		override public object Clone()
		{
			Property clone = FormatterServices.GetUninitializedObject(typeof(Property)) as Property;
			clone._lexicalInfo = _lexicalInfo;
			clone._documentation = _documentation;
			clone._properties = _properties.Clone() as Hashtable;
			

			clone._modifiers = _modifiers;

			clone._name = _name;

			if (null != _attributes)
			{
				clone._attributes = _attributes.Clone() as AttributeCollection;
				clone._attributes.InitializeParent(clone);
			}

			if (null != _parameters)
			{
				clone._parameters = _parameters.Clone() as ParameterDeclarationCollection;
				clone._parameters.InitializeParent(clone);
			}

			if (null != _getter)
			{
				clone._getter = _getter.Clone() as Method;
				clone._getter.InitializeParent(clone);
			}

			if (null != _setter)
			{
				clone._setter = _setter.Clone() as Method;
				clone._setter.InitializeParent(clone);
			}

			if (null != _type)
			{
				clone._type = _type.Clone() as TypeReference;
				clone._type.InitializeParent(clone);
			}
			
			return clone;
		}
			
		public ParameterDeclarationCollection Parameters
		{
			get
			{
				return _parameters;
			}
			

			set
			{
				if (_parameters != value)
				{
					_parameters = value;
					if (null != _parameters)
					{
						_parameters.InitializeParent(this);

					}
				}
			}
			

		}
		

		public Method Getter
		{
			get
			{
				return _getter;
			}
			

			set
			{
				if (_getter != value)
				{
					_getter = value;
					if (null != _getter)
					{
						_getter.InitializeParent(this);

					}
				}
			}
			

		}
		

		public Method Setter
		{
			get
			{
				return _setter;
			}
			

			set
			{
				if (_setter != value)
				{
					_setter = value;
					if (null != _setter)
					{
						_setter.InitializeParent(this);

					}
				}
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
		

		private void InitializeFields()
		{
			_parameters = new ParameterDeclarationCollection(this);

		}
	}
}
