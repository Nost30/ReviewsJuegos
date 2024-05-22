Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace ReviewsJuegos
    <CompilerServices.DesignerGenerated()>

    ' Form reemplaza a Dispose para limpiar la lista de componentes.
    Public Partial Class Login
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
            TxtUsuario = New TextBox()
            TxtContra = New TextBox()
            Label2 = New Label()
            Label3 = New Label()
            BtnLogin = New Button()
            AddHandler BtnLogin.Click, New EventHandler(AddressOf ButtonLogin_Click)
            SuspendLayout()
            ' 
            ' TxtUsuario
            ' 
            TxtUsuario.Location = New Point(121, 74)
            TxtUsuario.Name = "TxtUsuario"
            TxtUsuario.Size = New Size(100, 23)
            TxtUsuario.TabIndex = 1
            ' 
            ' TxtContra
            ' 
            TxtContra.Location = New Point(121, 143)
            TxtContra.Name = "TxtContra"
            TxtContra.Size = New Size(100, 23)
            TxtContra.TabIndex = 2
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Location = New Point(124, 56)
            Label2.Name = "Label2"
            Label2.Size = New Size(47, 15)
            Label2.TabIndex = 4
            Label2.Text = "Usuario"
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Location = New Point(123, 116)
            Label3.Name = "Label3"
            Label3.Size = New Size(67, 15)
            Label3.TabIndex = 5
            Label3.Text = "Contraseña"
            ' 
            ' BtnLogin
            ' 
            BtnLogin.Location = New Point(124, 206)
            BtnLogin.Name = "BtnLogin"
            BtnLogin.Size = New Size(75, 23)
            BtnLogin.TabIndex = 6
            BtnLogin.Text = "Login"
            BtnLogin.UseVisualStyleBackColor = True
            ' 
            ' Login
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(317, 306)
            Controls.Add(BtnLogin)
            Controls.Add(Label3)
            Controls.Add(Label2)
            Controls.Add(TxtContra)
            Controls.Add(TxtUsuario)
            Name = "Login"
            Text = "Login"
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend TxtUsuario As TextBox
        Friend TxtContra As TextBox
        Friend Label2 As Label
        Friend Label3 As Label
        Friend BtnLogin As Button
    End Class
End Namespace
