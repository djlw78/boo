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
// astgenerator.boo on 3/14/2004 7:20:48 PM
//

namespace Boo.Lang.Ast
{
	public interface IAstTransformer
	{			
		void OnCompileUnit(Boo.Lang.Ast.CompileUnit node, ref Boo.Lang.Ast.CompileUnit newNode);
			
		void OnSimpleTypeReference(Boo.Lang.Ast.SimpleTypeReference node, ref Boo.Lang.Ast.TypeReference newNode);
			
		void OnTupleTypeReference(Boo.Lang.Ast.TupleTypeReference node, ref Boo.Lang.Ast.TypeReference newNode);
			
		void OnNamespaceDeclaration(Boo.Lang.Ast.NamespaceDeclaration node, ref Boo.Lang.Ast.NamespaceDeclaration newNode);
			
		void OnImport(Boo.Lang.Ast.Import node, ref Boo.Lang.Ast.Import newNode);
			
		void OnModule(Boo.Lang.Ast.Module node, ref Boo.Lang.Ast.Module newNode);
			
		void OnClassDefinition(Boo.Lang.Ast.ClassDefinition node, ref Boo.Lang.Ast.ClassDefinition newNode);
			
		void OnInterfaceDefinition(Boo.Lang.Ast.InterfaceDefinition node, ref Boo.Lang.Ast.InterfaceDefinition newNode);
			
		void OnEnumDefinition(Boo.Lang.Ast.EnumDefinition node, ref Boo.Lang.Ast.EnumDefinition newNode);
			
		void OnEnumMember(Boo.Lang.Ast.EnumMember node, ref Boo.Lang.Ast.EnumMember newNode);
			
		void OnField(Boo.Lang.Ast.Field node, ref Boo.Lang.Ast.Field newNode);
			
		void OnProperty(Boo.Lang.Ast.Property node, ref Boo.Lang.Ast.Property newNode);
			
		void OnLocal(Boo.Lang.Ast.Local node, ref Boo.Lang.Ast.Local newNode);
			
		void OnMethod(Boo.Lang.Ast.Method node, ref Boo.Lang.Ast.Method newNode);
			
		void OnConstructor(Boo.Lang.Ast.Constructor node, ref Boo.Lang.Ast.Constructor newNode);
			
		void OnParameterDeclaration(Boo.Lang.Ast.ParameterDeclaration node, ref Boo.Lang.Ast.ParameterDeclaration newNode);
			
		void OnDeclaration(Boo.Lang.Ast.Declaration node, ref Boo.Lang.Ast.Declaration newNode);
			
		void OnAttribute(Boo.Lang.Ast.Attribute node, ref Boo.Lang.Ast.Attribute newNode);
			
		void OnStatementModifier(Boo.Lang.Ast.StatementModifier node, ref Boo.Lang.Ast.StatementModifier newNode);
			
		void OnBlock(Boo.Lang.Ast.Block node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnDeclarationStatement(Boo.Lang.Ast.DeclarationStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnAssertStatement(Boo.Lang.Ast.AssertStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnMacroStatement(Boo.Lang.Ast.MacroStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnTryStatement(Boo.Lang.Ast.TryStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnExceptionHandler(Boo.Lang.Ast.ExceptionHandler node, ref Boo.Lang.Ast.ExceptionHandler newNode);
			
		void OnIfStatement(Boo.Lang.Ast.IfStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnUnlessStatement(Boo.Lang.Ast.UnlessStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnForStatement(Boo.Lang.Ast.ForStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnWhileStatement(Boo.Lang.Ast.WhileStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnGivenStatement(Boo.Lang.Ast.GivenStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnWhenClause(Boo.Lang.Ast.WhenClause node, ref Boo.Lang.Ast.WhenClause newNode);
			
		void OnBreakStatement(Boo.Lang.Ast.BreakStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnContinueStatement(Boo.Lang.Ast.ContinueStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnRetryStatement(Boo.Lang.Ast.RetryStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnReturnStatement(Boo.Lang.Ast.ReturnStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnYieldStatement(Boo.Lang.Ast.YieldStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnRaiseStatement(Boo.Lang.Ast.RaiseStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnUnpackStatement(Boo.Lang.Ast.UnpackStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnExpressionStatement(Boo.Lang.Ast.ExpressionStatement node, ref Boo.Lang.Ast.Statement newNode);
			
		void OnOmittedExpression(Boo.Lang.Ast.OmittedExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnExpressionPair(Boo.Lang.Ast.ExpressionPair node, ref Boo.Lang.Ast.ExpressionPair newNode);
			
		void OnMethodInvocationExpression(Boo.Lang.Ast.MethodInvocationExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnUnaryExpression(Boo.Lang.Ast.UnaryExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnBinaryExpression(Boo.Lang.Ast.BinaryExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnTernaryExpression(Boo.Lang.Ast.TernaryExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnReferenceExpression(Boo.Lang.Ast.ReferenceExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnMemberReferenceExpression(Boo.Lang.Ast.MemberReferenceExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnStringLiteralExpression(Boo.Lang.Ast.StringLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnTimeSpanLiteralExpression(Boo.Lang.Ast.TimeSpanLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnIntegerLiteralExpression(Boo.Lang.Ast.IntegerLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnDoubleLiteralExpression(Boo.Lang.Ast.DoubleLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnNullLiteralExpression(Boo.Lang.Ast.NullLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnSelfLiteralExpression(Boo.Lang.Ast.SelfLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnSuperLiteralExpression(Boo.Lang.Ast.SuperLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnBoolLiteralExpression(Boo.Lang.Ast.BoolLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnRELiteralExpression(Boo.Lang.Ast.RELiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnStringFormattingExpression(Boo.Lang.Ast.StringFormattingExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnHashLiteralExpression(Boo.Lang.Ast.HashLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnListLiteralExpression(Boo.Lang.Ast.ListLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnTupleLiteralExpression(Boo.Lang.Ast.TupleLiteralExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnIteratorExpression(Boo.Lang.Ast.IteratorExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnSlicingExpression(Boo.Lang.Ast.SlicingExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnAsExpression(Boo.Lang.Ast.AsExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnCastExpression(Boo.Lang.Ast.CastExpression node, ref Boo.Lang.Ast.Expression newNode);
			
		void OnTypeofExpression(Boo.Lang.Ast.TypeofExpression node, ref Boo.Lang.Ast.Expression newNode);

	}
}