Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace ReviewsJuegos
    <CompilerServices.DesignerGenerated()>

    ' Form reemplaza a Dispose para limpiar la lista de componentes.
    Public Partial Class FormularioActualizar
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
            Label3 = New Label()
            Label4 = New Label()
            Label5 = New Label()
            Label6 = New Label()
            Label7 = New Label()
            Label8 = New Label()
            Label9 = New Label()
            BtnActualizar = New Button()
            AddHandler BtnActualizar.Click, New EventHandler(AddressOf btnActualizarJuego_Click)
            TxtIdJuego = New TextBox()
            TxtNombreJuego = New TextBox()
            TxtNumJugadores = New TextBox()
            TxtMetascore = New TextBox()
            TxtPuntajeUsuario = New TextBox()
            ComboBoxGenero = New ComboBox()
            ComboBoxDesarrolladora = New ComboBox()
            ComboBoxPlataforma = New ComboBox()
            DTTFechaLanzamiento = New DateTimePicker()
            SuspendLayout()
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Location = New Point(78, 59)
            Label1.Name = "Label1"
            Label1.Size = New Size(17, 15)
            Label1.TabIndex = 0
            Label1.Text = "Id"
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Location = New Point(77, 116)
            Label2.Name = "Label2"
            Label2.Size = New Size(104, 15)
            Label2.TabIndex = 1
            Label2.Text = "Nombre del Juego"
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Location = New Point(77, 184)
            Label3.Name = "Label3"
            Label3.Size = New Size(45, 15)
            Label3.TabIndex = 2
            Label3.Text = "Genero"
            ' 
            ' Label4
            ' 
            Label4.AutoSize = True
            Label4.Location = New Point(78, 242)
            Label4.Name = "Label4"
            Label4.Size = New Size(83, 15)
            Label4.TabIndex = 3
            Label4.Text = "Desarrolladora"
            ' 
            ' Label5
            ' 
            Label5.AutoSize = True
            Label5.Location = New Point(78, 302)
            Label5.Name = "Label5"
            Label5.Size = New Size(65, 15)
            Label5.TabIndex = 4
            Label5.Text = "Plataforma"
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Location = New Point(342, 60)
            Label6.Name = "Label6"
            Label6.Size = New Size(122, 15)
            Label6.TabIndex = 5
            Label6.Text = "Fecha de lanzamiento"
            ' 
            ' Label7
            ' 
            Label7.AutoSize = True
            Label7.Location = New Point(342, 107)
            Label7.Name = "Label7"
            Label7.Size = New Size(122, 15)
            Label7.TabIndex = 6
            Label7.Text = "Numero de jugadores"
            ' 
            ' Label8
            ' 
            Label8.AutoSize = True
            Label8.Location = New Point(342, 185)
            Label8.Name = "Label8"
            Label8.Size = New Size(121, 15)
            Label8.TabIndex = 7
            Label8.Text = "Puntaje de metascore"
            ' 
            ' Label9
            ' 
            Label9.AutoSize = True
            Label9.Location = New Point(342, 243)
            Label9.Name = "Label9"
            Label9.Size = New Size(90, 15)
            Label9.TabIndex = 8
            Label9.Text = "Puntaje Usuario"
            ' 
            ' BtnActualizar
            ' 
            BtnActualizar.Location = New Point(529, 201)
            BtnActualizar.Name = "BtnActualizar"
            BtnActualizar.Size = New Size(75, 23)
            BtnActualizar.TabIndex = 10
            BtnActualizar.Text = "Actualizar"
            BtnActualizar.UseVisualStyleBackColor = True
            ' 
            ' TxtIdJuego
            ' 
            TxtIdJuego.Location = New Point(77, 78)
            TxtIdJuego.Name = "TxtIdJuego"
            TxtIdJuego.Size = New Size(100, 23)
            TxtIdJuego.TabIndex = 11
            ' 
            ' TxtNombreJuego
            ' 
            TxtNombreJuego.Location = New Point(77, 134)
            TxtNombreJuego.Name = "TxtNombreJuego"
            TxtNombreJuego.Size = New Size(100, 23)
            TxtNombreJuego.TabIndex = 12
            ' 
            ' TxtNumJugadores
            ' 
            TxtNumJugadores.Location = New Point(342, 135)
            TxtNumJugadores.Name = "TxtNumJugadores"
            TxtNumJugadores.Size = New Size(100, 23)
            TxtNumJugadores.TabIndex = 17
            ' 
            ' TxtMetascore
            ' 
            TxtMetascore.Location = New Point(342, 203)
            TxtMetascore.Name = "TxtMetascore"
            TxtMetascore.Size = New Size(100, 23)
            TxtMetascore.TabIndex = 18
            ' 
            ' TxtPuntajeUsuario
            ' 
            TxtPuntajeUsuario.Location = New Point(342, 261)
            TxtPuntajeUsuario.Name = "TxtPuntajeUsuario"
            TxtPuntajeUsuario.Size = New Size(100, 23)
            TxtPuntajeUsuario.TabIndex = 19
            ' 
            ' ComboBoxGenero
            ' 
            ComboBoxGenero.FormattingEnabled = True
            ComboBoxGenero.Location = New Point(76, 210)
            ComboBoxGenero.Name = "ComboBoxGenero"
            ComboBoxGenero.Size = New Size(121, 23)
            ComboBoxGenero.TabIndex = 21
            ' 
            ' ComboBoxDesarrolladora
            ' 
            ComboBoxDesarrolladora.FormattingEnabled = True
            ComboBoxDesarrolladora.Location = New Point(77, 271)
            ComboBoxDesarrolladora.Name = "ComboBoxDesarrolladora"
            ComboBoxDesarrolladora.Size = New Size(121, 23)
            ComboBoxDesarrolladora.TabIndex = 22
            ' 
            ' ComboBoxPlataforma
            ' 
            ComboBoxPlataforma.FormattingEnabled = True
            ComboBoxPlataforma.Location = New Point(77, 342)
            ComboBoxPlataforma.Name = "ComboBoxPlataforma"
            ComboBoxPlataforma.Size = New Size(121, 23)
            ComboBoxPlataforma.TabIndex = 23
            ' 
            ' DTTFechaLanzamiento
            ' 
            DTTFechaLanzamiento.Location = New Point(342, 81)
            DTTFechaLanzamiento.Name = "DTTFechaLanzamiento"
            DTTFechaLanzamiento.Size = New Size(200, 23)
            DTTFechaLanzamiento.TabIndex = 24
            ' 
            ' FormularioActualizar
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(643, 450)
            Controls.Add(DTTFechaLanzamiento)
            Controls.Add(ComboBoxPlataforma)
            Controls.Add(ComboBoxDesarrolladora)
            Controls.Add(ComboBoxGenero)
            Controls.Add(TxtPuntajeUsuario)
            Controls.Add(TxtMetascore)
            Controls.Add(TxtNumJugadores)
            Controls.Add(TxtNombreJuego)
            Controls.Add(TxtIdJuego)
            Controls.Add(BtnActualizar)
            Controls.Add(Label9)
            Controls.Add(Label8)
            Controls.Add(Label7)
            Controls.Add(Label6)
            Controls.Add(Label5)
            Controls.Add(Label4)
            Controls.Add(Label3)
            Controls.Add(Label2)
            Controls.Add(Label1)
            Name = "FormularioActualizar"
            Text = "FormularioActualizar"
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend Label1 As Label
        Friend Label2 As Label
        Friend Label3 As Label
        Friend Label4 As Label
        Friend Label5 As Label
        Friend Label6 As Label
        Friend Label7 As Label
        Friend Label8 As Label
        Friend Label9 As Label
        Friend BtnActualizar As Button
        Friend TxtIdJuego As TextBox
        Friend TxtNombreJuego As TextBox
        Friend TxtNumJugadores As TextBox
        Friend TxtMetascore As TextBox
        Friend TxtPuntajeUsuario As TextBox
        Friend ComboBoxGenero As ComboBox
        Friend ComboBoxDesarrolladora As ComboBox
        Friend ComboBoxPlataforma As ComboBox
        Friend DTTFechaLanzamiento As DateTimePicker
    End Class
End Namespace
