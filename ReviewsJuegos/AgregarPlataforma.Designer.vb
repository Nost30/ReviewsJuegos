Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace ReviewsJuegos
    <CompilerServices.DesignerGenerated()>

    ' Form reemplaza a Dispose para limpiar la lista de componentes.
    Public Partial Class AgregarPlataforma
        Inherits Form

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
''' 
'''         // Form reemplaza a Dispose para limpiar la lista de componentes.
'''         [System.Diagnostics.@DebuggerNonUserCodeAttribute()]
'''         protected override void Dispose(bool disposing)
'''         {
'''             try
'''             {
'''                 if (disposing && this.components is not null)
'''                 {
'''                     this.components.Dispose();
'''                 }
'''             }
'''             finally
'''             {
'''                 base.Dispose(disposing);
'''             }
'''         }
''' 
''' 

        ' Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        ' NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        ' Se puede modificar usando el Diseñador de Windows Forms.  
        ' No lo modifique con el editor de código.
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            TxtAgPlata = New TextBox()
            BtnAgregar = New Button()
            AddHandler BtnAgregar.Click, New EventHandler(AddressOf BtnAgregar_Click)
            BtnCerrar = New Button()
            AddHandler BtnCerrar.Click, New EventHandler(AddressOf BtnCerrar_Click)
            Label1 = New Label()
            SuspendLayout()
            ' 
            ' TxtAgPlata
            ' 
            TxtAgPlata.Location = New Point(132, 133)
            TxtAgPlata.Name = "TxtAgPlata"
            TxtAgPlata.Size = New Size(100, 23)
            TxtAgPlata.TabIndex = 0
            ' 
            ' BtnAgregar
            ' 
            BtnAgregar.Location = New Point(50, 197)
            BtnAgregar.Name = "BtnAgregar"
            BtnAgregar.Size = New Size(75, 23)
            BtnAgregar.TabIndex = 1
            BtnAgregar.Text = "Agregar"
            BtnAgregar.UseVisualStyleBackColor = True
            ' 
            ' BtnCerrar
            ' 
            BtnCerrar.Location = New Point(226, 197)
            BtnCerrar.Name = "BtnCerrar"
            BtnCerrar.Size = New Size(75, 23)
            BtnCerrar.TabIndex = 2
            BtnCerrar.Text = "Cerrar"
            BtnCerrar.UseVisualStyleBackColor = True
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Location = New Point(90, 80)
            Label1.Name = "Label1"
            Label1.Size = New Size(177, 15)
            Label1.TabIndex = 3
            Label1.Text = "Escribe una plataforma de juego"
            ' 
            ' AgregarPlataforma
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(360, 305)
            Controls.Add(Label1)
            Controls.Add(BtnCerrar)
            Controls.Add(BtnAgregar)
            Controls.Add(TxtAgPlata)
            Name = "AgregarPlataforma"
            Text = "AgregarPlataforma"
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend TxtAgPlata As TextBox
        Friend BtnAgregar As Button
        Friend BtnCerrar As Button
        Friend Label1 As Label
    End Class
End Namespace
