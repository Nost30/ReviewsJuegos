Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace ReviewsJuegos
    <CompilerServices.DesignerGenerated()>

    ' Form reemplaza a Dispose para limpiar la lista de componentes.
    Public Partial Class EditarPlataforma
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
            Label1 = New Label()
            Label2 = New Label()
            Cbxplataf = New ComboBox()
            TxtPlatafEdit = New TextBox()
            Button1 = New Button()
            AddHandler Button1.Click, New EventHandler(AddressOf Button1_Click)
            Button2 = New Button()
            AddHandler Button2.Click, New EventHandler(AddressOf Button2_Click)
            SuspendLayout()
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Location = New Point(72, 34)
            Label1.Name = "Label1"
            Label1.Size = New Size(147, 15)
            Label1.TabIndex = 0
            Label1.Text = "Selecciona una paltaforma"
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Location = New Point(57, 137)
            Label2.Name = "Label2"
            Label2.Size = New Size(136, 15)
            Label2.TabIndex = 1
            Label2.Text = "¿Como quieres llamarla?"
            ' 
            ' Cbxplataf
            ' 
            Cbxplataf.FormattingEnabled = True
            Cbxplataf.Location = New Point(72, 70)
            Cbxplataf.Name = "Cbxplataf"
            Cbxplataf.Size = New Size(121, 23)
            Cbxplataf.TabIndex = 2
            ' 
            ' TxtPlatafEdit
            ' 
            TxtPlatafEdit.Location = New Point(80, 175)
            TxtPlatafEdit.Name = "TxtPlatafEdit"
            TxtPlatafEdit.Size = New Size(100, 23)
            TxtPlatafEdit.TabIndex = 3
            ' 
            ' Button1
            ' 
            Button1.Location = New Point(37, 218)
            Button1.Name = "Button1"
            Button1.Size = New Size(75, 23)
            Button1.TabIndex = 4
            Button1.Text = "Editar"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' Button2
            ' 
            Button2.Location = New Point(155, 218)
            Button2.Name = "Button2"
            Button2.Size = New Size(75, 23)
            Button2.TabIndex = 5
            Button2.Text = "Salir"
            Button2.UseVisualStyleBackColor = True
            ' 
            ' EditarPlataforma
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(276, 290)
            Controls.Add(Button2)
            Controls.Add(Button1)
            Controls.Add(TxtPlatafEdit)
            Controls.Add(Cbxplataf)
            Controls.Add(Label2)
            Controls.Add(Label1)
            Name = "EditarPlataforma"
            Text = "EditarPlataforma"
            AddHandler Load, New EventHandler(AddressOf EditarPlataforma_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend Label1 As Label
        Friend Label2 As Label
        Friend Cbxplataf As ComboBox
        Friend TxtPlatafEdit As TextBox
        Friend Button1 As Button
        Friend Button2 As Button
    End Class
End Namespace
