Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace ReviewsJuegos
    <CompilerServices.DesignerGenerated()>

    ' Form overrides dispose to clean up the component list.
    Public Partial Class Form1
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
'''         // Form overrides dispose to clean up the component list.
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

        ' Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        ' NOTE: The following procedure is required by the Windows Form Designer
        ' It can be modified using the Windows Form Designer.  
        ' Do not modify it using the code editor.
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources = New ComponentModel.ComponentResourceManager(GetType(Form1))
            DataGridView1 = New DataGridView()
            BtnAgregar = New Button()
            AddHandler BtnAgregar.Click, New EventHandler(AddressOf BtnAgregar_Click)
            BtnBuscar = New Button()
            AddHandler BtnBuscar.Click, New EventHandler(AddressOf BtnBuscar_Click)
            ComboBoxJuego = New ComboBox()
            AddHandler ComboBoxJuego.SelectedIndexChanged, New EventHandler(AddressOf ComboBoxJuego_SelectedIndexChanged)
            TxtJuego = New TextBox()
            Label1 = New Label()
            PictureBox1 = New PictureBox()
            Label2 = New Label()
            BtnEliminar = New Button()
            AddHandler BtnEliminar.Click, New EventHandler(AddressOf btnEliminarJuego_Click)
            TxtId = New TextBox()
            AddHandler TxtId.TextChanged, New EventHandler(AddressOf TxtId_TextChanged)
            Label3 = New Label()
            BtnActualizar = New Button()
            AddHandler BtnActualizar.Click, New EventHandler(AddressOf BtnActualizar_Click)
            BtnRefrescar = New Button()
            AddHandler BtnRefrescar.Click, New EventHandler(AddressOf BtnRefrescar_Click)
            Button1 = New Button()
            AddHandler Button1.Click, New EventHandler(AddressOf Button1_Click)
            BtnAgregarPlata = New Button()
            AddHandler BtnAgregarPlata.Click, New EventHandler(AddressOf BtnAgregarPlata_Click)
            BtnAgDesarrolladora = New Button()
            AddHandler BtnAgDesarrolladora.Click, New EventHandler(AddressOf BtnAgDesarrolladora_Click)
            Button2 = New Button()
            AddHandler Button2.Click, New EventHandler(AddressOf Button2_Click)
            Button3 = New Button()
            AddHandler Button3.Click, New EventHandler(AddressOf Button3_Click)
            Button4 = New Button()
            AddHandler Button4.Click, New EventHandler(AddressOf Button4_Click)
            Button7 = New Button()
            AddHandler Button7.Click, New EventHandler(AddressOf Button7_Click)
            Button5 = New Button()
            AddHandler Button5.Click, New EventHandler(AddressOf Button5_Click)
            Button6 = New Button()
            AddHandler Button6.Click, New EventHandler(AddressOf Button6_Click)
            CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
            CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' DataGridView1
            ' 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridView1.Location = New Point(48, 165)
            DataGridView1.Name = "DataGridView1"
            DataGridView1.RowTemplate.Height = 25
            DataGridView1.Size = New Size(467, 184)
            DataGridView1.TabIndex = 0
            ' 
            ' BtnAgregar
            ' 
            BtnAgregar.Location = New Point(48, 395)
            BtnAgregar.Name = "BtnAgregar"
            BtnAgregar.Size = New Size(75, 23)
            BtnAgregar.TabIndex = 1
            BtnAgregar.Text = "Agregar"
            BtnAgregar.UseVisualStyleBackColor = True
            ' 
            ' BtnBuscar
            ' 
            BtnBuscar.Location = New Point(440, 122)
            BtnBuscar.Name = "BtnBuscar"
            BtnBuscar.Size = New Size(75, 23)
            BtnBuscar.TabIndex = 2
            BtnBuscar.Text = "Buscar"
            BtnBuscar.UseVisualStyleBackColor = True
            ' 
            ' ComboBoxJuego
            ' 
            ComboBoxJuego.FormattingEnabled = True
            ComboBoxJuego.Location = New Point(238, 122)
            ComboBoxJuego.Name = "ComboBoxJuego"
            ComboBoxJuego.Size = New Size(187, 23)
            ComboBoxJuego.TabIndex = 5
            ' 
            ' TxtJuego
            ' 
            TxtJuego.Location = New Point(112, 122)
            TxtJuego.Name = "TxtJuego"
            TxtJuego.Size = New Size(110, 23)
            TxtJuego.TabIndex = 6
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Location = New Point(48, 367)
            Label1.Name = "Label1"
            Label1.Size = New Size(154, 15)
            Label1.TabIndex = 7
            Label1.Text = "¿Deseas agregar otro juego?"
            ' 
            ' PictureBox1
            ' 
            PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
            PictureBox1.Location = New Point(48, 27)
            PictureBox1.Name = "PictureBox1"
            PictureBox1.Size = New Size(187, 67)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.TabIndex = 8
            PictureBox1.TabStop = False
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Location = New Point(432, 367)
            Label2.Name = "Label2"
            Label2.Size = New Size(83, 15)
            Label2.TabIndex = 9
            Label2.Text = "Eliminar juego"
            ' 
            ' BtnEliminar
            ' 
            BtnEliminar.Location = New Point(440, 395)
            BtnEliminar.Name = "BtnEliminar"
            BtnEliminar.Size = New Size(75, 23)
            BtnEliminar.TabIndex = 10
            BtnEliminar.Text = "Eliminar"
            BtnEliminar.UseVisualStyleBackColor = True
            ' 
            ' TxtId
            ' 
            TxtId.Location = New Point(48, 122)
            TxtId.Name = "TxtId"
            TxtId.Size = New Size(41, 23)
            TxtId.TabIndex = 11
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Location = New Point(48, 439)
            Label3.Name = "Label3"
            Label3.Size = New Size(151, 15)
            Label3.TabIndex = 12
            Label3.Text = "¿Desea actualizar los datos?"
            ' 
            ' BtnActualizar
            ' 
            BtnActualizar.Location = New Point(48, 457)
            BtnActualizar.Name = "BtnActualizar"
            BtnActualizar.Size = New Size(75, 23)
            BtnActualizar.TabIndex = 13
            BtnActualizar.Text = "Actualizar"
            BtnActualizar.UseVisualStyleBackColor = True
            ' 
            ' BtnRefrescar
            ' 
            BtnRefrescar.Location = New Point(440, 45)
            BtnRefrescar.Name = "BtnRefrescar"
            BtnRefrescar.Size = New Size(75, 23)
            BtnRefrescar.TabIndex = 14
            BtnRefrescar.Text = "Refrescar"
            BtnRefrescar.UseVisualStyleBackColor = True
            ' 
            ' Button1
            ' 
            Button1.Location = New Point(579, 167)
            Button1.Name = "Button1"
            Button1.Size = New Size(75, 44)
            Button1.TabIndex = 15
            Button1.Text = "Agregar genero"
            Button1.UseVisualStyleBackColor = True
            ' 
            ' BtnAgregarPlata
            ' 
            BtnAgregarPlata.Location = New Point(579, 215)
            BtnAgregarPlata.Name = "BtnAgregarPlata"
            BtnAgregarPlata.Size = New Size(75, 40)
            BtnAgregarPlata.TabIndex = 16
            BtnAgregarPlata.Text = "Agregar plataforma"
            BtnAgregarPlata.UseVisualStyleBackColor = True
            ' 
            ' BtnAgDesarrolladora
            ' 
            BtnAgDesarrolladora.Location = New Point(565, 266)
            BtnAgDesarrolladora.Name = "BtnAgDesarrolladora"
            BtnAgDesarrolladora.Size = New Size(105, 60)
            BtnAgDesarrolladora.TabIndex = 17
            BtnAgDesarrolladora.Text = "Agregar Desarrolladora"
            BtnAgDesarrolladora.UseVisualStyleBackColor = True
            ' 
            ' Button2
            ' 
            Button2.Location = New Point(694, 266)
            Button2.Name = "Button2"
            Button2.Size = New Size(91, 60)
            Button2.TabIndex = 18
            Button2.Text = "Eliminar desarrolladora"
            Button2.UseVisualStyleBackColor = True
            ' 
            ' Button3
            ' 
            Button3.Location = New Point(694, 215)
            Button3.Name = "Button3"
            Button3.Size = New Size(91, 38)
            Button3.TabIndex = 19
            Button3.Text = "Eliminar plataforma"
            Button3.UseVisualStyleBackColor = True
            ' 
            ' Button4
            ' 
            Button4.Location = New Point(696, 170)
            Button4.Name = "Button4"
            Button4.Size = New Size(89, 39)
            Button4.TabIndex = 20
            Button4.Text = "Eliminar genero"
            Button4.UseVisualStyleBackColor = True
            ' 
            ' Button7
            ' 
            Button7.Location = New Point(814, 271)
            Button7.Name = "Button7"
            Button7.Size = New Size(97, 50)
            Button7.TabIndex = 23
            Button7.Text = "Editar Desarrolladora"
            Button7.UseVisualStyleBackColor = True
            ' 
            ' Button5
            ' 
            Button5.Location = New Point(822, 215)
            Button5.Name = "Button5"
            Button5.Size = New Size(89, 38)
            Button5.TabIndex = 24
            Button5.Text = "Editar plataforma"
            Button5.UseVisualStyleBackColor = True
            ' 
            ' Button6
            ' 
            Button6.Location = New Point(815, 170)
            Button6.Name = "Button6"
            Button6.Size = New Size(89, 39)
            Button6.TabIndex = 25
            Button6.Text = "Editar genero"
            Button6.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            AcceptButton = BtnBuscar
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = SystemColors.Menu
            ClientSize = New Size(943, 516)
            Controls.Add(Button6)
            Controls.Add(Button5)
            Controls.Add(Button7)
            Controls.Add(Button4)
            Controls.Add(Button3)
            Controls.Add(Button2)
            Controls.Add(BtnAgDesarrolladora)
            Controls.Add(BtnAgregarPlata)
            Controls.Add(Button1)
            Controls.Add(BtnRefrescar)
            Controls.Add(BtnActualizar)
            Controls.Add(Label3)
            Controls.Add(TxtId)
            Controls.Add(BtnEliminar)
            Controls.Add(Label2)
            Controls.Add(PictureBox1)
            Controls.Add(Label1)
            Controls.Add(TxtJuego)
            Controls.Add(ComboBoxJuego)
            Controls.Add(BtnBuscar)
            Controls.Add(BtnAgregar)
            Controls.Add(DataGridView1)
            Name = "Form1"
            Text = "Form1"
            CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
            CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend DataGridView1 As DataGridView
        Friend BtnAgregar As Button
        Friend BtnBuscar As Button
        Friend ComboBoxJuego As ComboBox
        Friend TxtJuego As TextBox
        Friend Label1 As Label
        Friend PictureBox1 As PictureBox
        Friend Label2 As Label
        Friend BtnEliminar As Button
        Friend TxtId As TextBox
        Friend Label3 As Label
        Friend BtnActualizar As Button
        Friend BtnRefrescar As Button
        Friend Button1 As Button
        Friend BtnAgregarPlata As Button
        Friend BtnAgDesarrolladora As Button
        Friend Button2 As Button
        Friend Button3 As Button
        Friend Button4 As Button
        Friend Button7 As Button
        Friend Button5 As Button
        Friend Button6 As Button
    End Class
End Namespace
