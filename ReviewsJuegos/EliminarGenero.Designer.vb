Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace ReviewsJuegos
    <CompilerServices.DesignerGenerated()>

    ' Form reemplaza a Dispose para limpiar la lista de componentes.
    Public Partial Class EliminarGenero
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
            Button1 = New Button()
            AddHandler Button1.Click, New EventHandler(AddressOf Button1_Click)
            Button2 = New Button()
            AddHandler Button2.Click, New EventHandler(AddressOf Button2_Click)
            CbxGen = New ComboBox()
            SuspendLayout()
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Location = New Point(114, 56)
            Label1.Name = "Label1"
            Label1.Size = New Size(115, 15)
            Label1.TabIndex = 0
            Label1.Text = "Selecciona el genero"
            ' 
            ' Button1
            ' 
            Button1.Location = New Point(65, 166)
            Button1.Name = "Button1"
            Button1.Size = New Size(75, 23)
            Button1.TabIndex = 1
            Button1.Text = "Eliminar"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' Button2
            ' 
            Button2.Location = New Point(208, 166)
            Button2.Name = "Button2"
            Button2.Size = New Size(75, 23)
            Button2.TabIndex = 2
            Button2.Text = "Salir"
            Button2.UseVisualStyleBackColor = True
            ' 
            ' CbxGen
            ' 
            CbxGen.FormattingEnabled = True
            CbxGen.Location = New Point(108, 101)
            CbxGen.Name = "CbxGen"
            CbxGen.Size = New Size(121, 23)
            CbxGen.TabIndex = 3
            ' 
            ' EliminarGenero
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(365, 252)
            Controls.Add(CbxGen)
            Controls.Add(Button2)
            Controls.Add(Button1)
            Controls.Add(Label1)
            Name = "EliminarGenero"
            Text = "EliminarGenero"
            AddHandler Load, New EventHandler(AddressOf EliminarPlataforma_Load)
            AddHandler Load, New EventHandler(AddressOf EliminarGenero_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend Label1 As Label
        Friend Button1 As Button
        Friend Button2 As Button
        Friend CbxGen As ComboBox
    End Class
End Namespace
