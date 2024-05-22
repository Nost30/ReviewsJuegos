Imports System.ComponentModel

Namespace ReviewsJuegos.My
    Friend Partial Module MyProject
        Friend Partial Class MyForms

            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_AgregarDesarrolladora As AgregarDesarrolladora
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.AgregarDesarrolladora AgregarDesarrolladora
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_AgregarDesarrolladora = Create__Instance__(this.m_AgregarDesarrolladora);
'''                     return this.m_AgregarDesarrolladora;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_AgregarDesarrolladora))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_AgregarDesarrolladora);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_AgregarGenero As AgregarGenero
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.AgregarGenero AgregarGenero
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_AgregarGenero = Create__Instance__(this.m_AgregarGenero);
'''                     return this.m_AgregarGenero;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_AgregarGenero))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_AgregarGenero);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_AgregarPlataforma As AgregarPlataforma
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.AgregarPlataforma AgregarPlataforma
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_AgregarPlataforma = Create__Instance__(this.m_AgregarPlataforma);
'''                     return this.m_AgregarPlataforma;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_AgregarPlataforma))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_AgregarPlataforma);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_EditarDesarrolladora As EditarDesarrolladora
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.EditarDesarrolladora EditarDesarrolladora
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_EditarDesarrolladora = Create__Instance__(this.m_EditarDesarrolladora);
'''                     return this.m_EditarDesarrolladora;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_EditarDesarrolladora))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_EditarDesarrolladora);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_EditarGenero As EditarGenero
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.EditarGenero EditarGenero
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_EditarGenero = Create__Instance__(this.m_EditarGenero);
'''                     return this.m_EditarGenero;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_EditarGenero))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_EditarGenero);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_EditarPlataforma As EditarPlataforma
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.EditarPlataforma EditarPlataforma
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_EditarPlataforma = Create__Instance__(this.m_EditarPlataforma);
'''                     return this.m_EditarPlataforma;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_EditarPlataforma))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_EditarPlataforma);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_EliminarDesarrolladora As EliminarDesarrolladora
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.EliminarDesarrolladora EliminarDesarrolladora
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_EliminarDesarrolladora = Create__Instance__(this.m_EliminarDesarrolladora);
'''                     return this.m_EliminarDesarrolladora;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_EliminarDesarrolladora))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_EliminarDesarrolladora);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_EliminarGenero As EliminarGenero
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.EliminarGenero EliminarGenero
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_EliminarGenero = Create__Instance__(this.m_EliminarGenero);
'''                     return this.m_EliminarGenero;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_EliminarGenero))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_EliminarGenero);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_EliminarPlataforma As EliminarPlataforma
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.EliminarPlataforma EliminarPlataforma
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_EliminarPlataforma = Create__Instance__(this.m_EliminarPlataforma);
'''                     return this.m_EliminarPlataforma;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_EliminarPlataforma))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_EliminarPlataforma);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_Form1 As Form1
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.Form1 Form1
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_Form1 = Create__Instance__(this.m_Form1);
'''                     return this.m_Form1;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_Form1))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_Form1);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_FormularioActualizar As FormularioActualizar
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.FormularioActualizar FormularioActualizar
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_FormularioActualizar = Create__Instance__(this.m_FormularioActualizar);
'''                     return this.m_FormularioActualizar;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_FormularioActualizar))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_FormularioActualizar);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_FormularioAgregar As FormularioAgregar
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.FormularioAgregar FormularioAgregar
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_FormularioAgregar = Create__Instance__(this.m_FormularioAgregar);
'''                     return this.m_FormularioAgregar;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_FormularioAgregar))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_FormularioAgregar);
'''                 }
'''             }
''' 
''' 


            <EditorBrowsable(EditorBrowsableState.Never)>
            Public m_Login As Login
                        ''' Cannot convert PropertyDeclarationSyntax, System.ArgumentOutOfRangeException: Se produjo una excepción de tipo 'System.ArgumentOutOfRangeException'.
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
'''    en ICSharpCode.CodeConverter.VB.CommonConversions.ConvertAccessor(AccessorDeclarationSyntax node, Boolean& isIterator, Boolean isAutoImplementedProperty)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull)
'''    en ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    en Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    en ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''             public ReviewsJuegos.Login Login
'''             {
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 get
'''                 {
'''                     this.m_Login = Create__Instance__(this.m_Login);
'''                     return this.m_Login;
'''                 }
'''                 [System.Diagnostics.@DebuggerHiddenAttribute]
'''                 set
'''                 {
'''                     if (System.Object.ReferenceEquals(value, this.m_Login))
'''                         return;
'''                     if (value is not null)
'''                         throw new System.ArgumentException("Property can only be set to Nothing");
'''                     Dispose__Instance__(ref this.m_Login);
'''                 }
'''             }
''' 
''' 

        End Class


    End Module
End Namespace
