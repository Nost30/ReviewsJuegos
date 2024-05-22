Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Xml.Linq
Imports Microsoft.VisualBasic
' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

' See Compiler::LoadXmlSolutionExtension
Namespace ReviewsJuegos.My
    <Embedded()>
    <DebuggerNonUserCode()>
    <CompilerGenerated()>
    <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
    Friend NotInheritable Class InternalXmlHelper
        <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
        Private Sub New()
        End Sub
        Public Shared Function get_Value(source As IEnumerable(Of XElement)) As String
            For Each item In source
                Return item.Value
            Next
            Return Nothing
        End Function

        Public Shared Sub set_Value(source As IEnumerable(Of XElement), value As String)
            For Each item In source
                item.Value = value
                Exit For
            Next
        End Sub
        Public Shared Function get_AttributeValue(source As IEnumerable(Of XElement), name As XName) As String
            For Each item In source
                Return CStr(item.Attribute(name))
            Next
            Return Nothing
        End Function

        Public Shared Sub set_AttributeValue(source As IEnumerable(Of XElement), name As XName, value As String)
            For Each item In source
                item.SetAttributeValue(name, value)
                Exit For
            Next
        End Sub
        Public Shared Function get_AttributeValue(source As XElement, name As XName) As String
            Return CStr(source.Attribute(name))
        End Function

        Public Shared Sub set_AttributeValue(source As XElement, name As XName, value As String)
            source.SetAttributeValue(name, value)
        End Sub
        <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
        Public Shared Function CreateAttribute(name As XName, value As Object) As XAttribute
            If value Is Nothing Then
                Return Nothing
            End If
            Return New XAttribute(name, value)
        End Function
        <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
        Public Shared Function CreateNamespaceAttribute(name As XName, ns As XNamespace) As XAttribute
            Dim a = New XAttribute(name, ns.NamespaceName)
            a.AddAnnotation(ns)
            Return a
        End Function

                ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
''' Nombre del parámetro: node
''' Valor actual not null.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToVariableDeclaratorOrNull(IsPatternExpressionSyntax node)
'''    en System.Linq.Enumerable.WhereSelectListIterator`2.MoveNext()
'''    en System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
'''    en System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
'''    en System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    en System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToDeclarationStatement(List`1 des, List`1 isPatternExpressions)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.InsertRequiredDeclarations(SyntaxList`1 convertedStatements, CSharpSyntaxNode originaNode)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatement(StatementSyntax statement, CSharpSyntaxVisitor`1 methodBodyVisitor)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass10_0.<ConvertStatements>b__0(StatementSyntax s)
'''    en System.Linq.Enumerable.<SelectManyIterator>d__17`2.MoveNext()
'''    en Microsoft.CodeAnalysis.SyntaxList`1.CreateNode(IEnumerable`1 nodes)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatements(SyntaxList`1 statements, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertBody(BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, Boolean hasReturnType, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         [System.ComponentModel.@EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
'''         public static object RemoveNamespaceAttributes(string[] inScopePrefixes, System.Xml.Linq.XNamespace[] inScopeNs, System.Collections.Generic.List<System.Xml.Linq.XAttribute> attributes, object obj)
'''         {
'''             if (obj is not null)
'''             {
'''                 System.Xml.Linq.XElement elem = obj as System.Xml.Linq.XElement;
'''                 if (elem is not null)
'''                 {
'''                     return ReviewsJuegos.My.InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, elem);
'''                 }
'''                 else
'''                 {
'''                     System.Collections.IEnumerable elems = obj as System.Collections.IEnumerable;
'''                     if (elems is not null)
'''                     {
'''                         return ReviewsJuegos.My.InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, elems);
'''                     }
'''                 }
'''             }
'''             return obj;
'''         }
''' 
''' 
                ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
''' Nombre del parámetro: node
''' Valor actual not null.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToVariableDeclaratorOrNull(IsPatternExpressionSyntax node)
'''    en System.Linq.Enumerable.WhereSelectListIterator`2.MoveNext()
'''    en System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
'''    en System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
'''    en System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    en System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToDeclarationStatement(List`1 des, List`1 isPatternExpressions)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.InsertRequiredDeclarations(SyntaxList`1 convertedStatements, CSharpSyntaxNode originaNode)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatement(StatementSyntax statement, CSharpSyntaxVisitor`1 methodBodyVisitor)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass10_0.<ConvertStatements>b__0(StatementSyntax s)
'''    en System.Linq.Enumerable.<SelectManyIterator>d__17`2.MoveNext()
'''    en Microsoft.CodeAnalysis.SyntaxList`1.CreateNode(IEnumerable`1 nodes)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatements(SyntaxList`1 statements, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertBody(BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, Boolean hasReturnType, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         [System.ComponentModel.@EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
'''         public static System.Collections.IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, System.Xml.Linq.XNamespace[] inScopeNs, System.Collections.Generic.List<System.Xml.Linq.XAttribute> attributes, System.Collections.IEnumerable obj)
'''         {
'''             if (obj is not null)
'''             {
'''                 System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> elems = obj as System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>;
'''                 if (elems is not null)
'''                 {
'''                     return elems.Select(new ReviewsJuegos.My.InternalXmlHelper.RemoveNamespaceAttributesClosure((System.String[])(inScopePrefixes), (System.Xml.Linq.XNamespace[])(inScopeNs), (System.Collections.Generic.List<System.Xml.Linq.XAttribute>)(attributes)).ProcessXElement);
'''                 }
'''                 else
'''                 {
'''                     return obj.Cast<object>().Select(new ReviewsJuegos.My.InternalXmlHelper.RemoveNamespaceAttributesClosure((System.String[])(inScopePrefixes), (System.Xml.Linq.XNamespace[])(inScopeNs), (System.Collections.Generic.List<System.Xml.Linq.XAttribute>)(attributes)).ProcessObject);
'''                 }
'''             }
'''             return obj;
'''         }
''' 
''' 
        <DebuggerNonUserCode()>
        <CompilerGenerated()>
        <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
        Private NotInheritable Class RemoveNamespaceAttributesClosure
            Private ReadOnly m_inScopePrefixes As String()
            Private ReadOnly m_inScopeNs As XNamespace()
            Private ReadOnly m_attributes As List(Of XAttribute)
            <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
            Friend Sub New(inScopePrefixes As String(), inScopeNs As XNamespace(), attributes As List(Of XAttribute))
                m_inScopePrefixes = inScopePrefixes
                m_inScopeNs = inScopeNs
                m_attributes = attributes
            End Sub
            <ComponentModel.EditorBrowsable(ComponentModel.EditorBrowsableState.Never)>
            Friend Function ProcessXElement(elem As XElement) As XElement
                Return InternalXmlHelper.RemoveNamespaceAttributes(m_inScopePrefixes, m_inScopeNs, m_attributes, elem)
            End Function

                        ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
''' Nombre del parámetro: node
''' Valor actual not null.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToVariableDeclaratorOrNull(IsPatternExpressionSyntax node)
'''    en System.Linq.Enumerable.WhereSelectListIterator`2.MoveNext()
'''    en System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
'''    en System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
'''    en System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    en System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToDeclarationStatement(List`1 des, List`1 isPatternExpressions)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.InsertRequiredDeclarations(SyntaxList`1 convertedStatements, CSharpSyntaxNode originaNode)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatement(StatementSyntax statement, CSharpSyntaxVisitor`1 methodBodyVisitor)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass10_0.<ConvertStatements>b__0(StatementSyntax s)
'''    en System.Linq.Enumerable.<SelectManyIterator>d__17`2.MoveNext()
'''    en Microsoft.CodeAnalysis.SyntaxList`1.CreateNode(IEnumerable`1 nodes)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatements(SyntaxList`1 statements, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertBody(BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, Boolean hasReturnType, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             [System.ComponentModel.@EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
'''             internal object ProcessObject(object obj)
'''             {
'''                 System.Xml.Linq.XElement elem = obj as System.Xml.Linq.XElement;
'''                 if (elem is not null)
'''                 {
'''                     return ReviewsJuegos.My.InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, elem);
'''                 }
'''                 else
'''                 {
'''                     return obj;
'''                 }
'''             }
''' 
''' 
            ' prefix and namespace match.  Remove the unneeded ns attribute 

            ' prefix is in scope but refers to something else.  Leave the ns attribute. 
            ' Prefix is not in scope 
            ' Now check whether it's going to be in scope because it is in the attributes list 

            ' prefix and namespace match.  Remove the unneeded ns attribute 

            ' prefix is in scope but refers to something else.  Leave the ns attribute. 
            ' Prefix is definitely not in scope  
            ' namespace is not defined either.  Add this attributes list 
        End Class

                ''' Cannot convert MethodDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
''' Nombre del parámetro: node
''' Valor actual not null.
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToVariableDeclaratorOrNull(IsPatternExpressionSyntax node)
'''    en System.Linq.Enumerable.WhereSelectListIterator`2.MoveNext()
'''    en System.Linq.Enumerable.WhereEnumerableIterator`1.MoveNext()
'''    en System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
'''    en System.Linq.Buffer`1..ctor(IEnumerable`1 source)
'''    en System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertToDeclarationStatement(List`1 des, List`1 isPatternExpressions)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.InsertRequiredDeclarations(SyntaxList`1 convertedStatements, CSharpSyntaxNode originaNode)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatement(StatementSyntax statement, CSharpSyntaxVisitor`1 methodBodyVisitor)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.<>c__DisplayClass10_0.<ConvertStatements>b__0(StatementSyntax s)
'''    en System.Linq.Enumerable.<SelectManyIterator>d__17`2.MoveNext()
'''    en Microsoft.CodeAnalysis.SyntaxList`1.CreateNode(IEnumerable`1 nodes)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertStatements(SyntaxList`1 statements, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertBody(BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, Boolean hasReturnType, MethodBodyExecutableStatementVisitor iteratorState)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         [System.ComponentModel.@EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
'''         public static System.Xml.Linq.XElement RemoveNamespaceAttributes(string[] inScopePrefixes, System.Xml.Linq.XNamespace[] inScopeNs, System.Collections.Generic.List<System.Xml.Linq.XAttribute> attributes, System.Xml.Linq.XElement e)
'''         {
'''             if (e is not null)
'''             {
'''                 var a = e.FirstAttribute;
''' 
'''                 while (a is not null)
'''                 {
'''                     var nextA = a.NextAttribute;
''' 
'''                     if (a.IsNamespaceDeclaration)
'''                     {
'''                         var ns = a.Annotation<System.Xml.Linq.XNamespace>();
'''                         string prefix = a.Name.LocalName;
''' 
'''                         if (ns is not null)
'''                         {
'''                             if (inScopePrefixes is not null && inScopeNs is not null)
'''                             {
'''                                 int lastIndex = inScopePrefixes.Length - 1;
''' 
'''                                 for (int i = 0, loopTo = lastIndex; i <= loopTo; i++)
'''                                 {
'''                                     string currentInScopePrefix = inScopePrefixes[i];
'''                                     var currentInScopeNs = inScopeNs[i];
'''                                     if (prefix.Equals(currentInScopePrefix))
'''                                     {
'''                                         if (ns == currentInScopeNs)
'''                                         {
'''                                             // prefix and namespace match.  Remove the unneeded ns attribute 
'''                                             a.Remove();
'''                                         }
''' 
'''                                         // prefix is in scope but refers to something else.  Leave the ns attribute. 
'''                                         a = null;
'''                                         break;
'''                                     }
'''                                 }
'''                             }
''' 
'''                             if (a is not null)
'''                             {
'''                                 // Prefix is not in scope 
'''                                 // Now check whether it's going to be in scope because it is in the attributes list 
''' 
'''                                 if (attributes is not null)
'''                                 {
'''                                     int lastIndex = attributes.Count - 1;
'''                                     for (int i = 0, loopTo1 = lastIndex; i <= loopTo1; i++)
'''                                     {
'''                                         var currentA = attributes[i];
'''                                         string currentInScopePrefix = currentA.Name.LocalName;
'''                                         var currentInScopeNs = currentA.Annotation<System.Xml.Linq.XNamespace>();
'''                                         if (currentInScopeNs is not null)
'''                                         {
'''                                             if (prefix.Equals(currentInScopePrefix))
'''                                             {
'''                                                 if (ns == currentInScopeNs)
'''                                                 {
'''                                                     // prefix and namespace match.  Remove the unneeded ns attribute 
'''                                                     a.Remove();
'''                                                 }
''' 
'''                                                 // prefix is in scope but refers to something else.  Leave the ns attribute. 
'''                                                 a = null;
'''                                                 break;
'''                                             }
'''                                         }
'''                                     }
'''                                 }
''' 
'''                                 if (a is not null)
'''                                 {
'''                                     // Prefix is definitely not in scope  
'''                                     a.Remove();
'''                                     // namespace is not defined either.  Add this attributes list 
'''                                     attributes.Add(a);
'''                                 }
'''                             }
'''                         }
'''                     }
''' 
'''                     a = nextA;
'''                 }
'''             }
'''             return e;
'''         }
''' 
''' 

    End Class
End Namespace
