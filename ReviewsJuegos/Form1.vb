Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace ReviewsJuegos

    Public Partial Class Form1
        Private query As String
        Private auto As Boolean
        ' Create a constructor
        Public Sub New()
            auto = True
            InitializeComponent()
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


            query = "SELECT id,Genero FROM Genero"
            ComboBoxJuego.DataSource = ConexionSQL.SelectQuery(query)
            ComboBoxJuego.DisplayMember = "Genero"
            ComboBoxJuego.ValueMember = "id"
            auto = False
            DataGridView1.ReadOnly = True

            query = "SELECT * FROM VW_JuegoReview"
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query)



        End Sub





        Private Sub ComboBoxJuego_SelectedIndexChanged(sender As Object, e As EventArgs)
            If ComboBoxJuego.Text Is Nothing Then
                Return
            End If
            query = "SELECT * FROM VW_JuegoReview
where Genero='" & ComboBoxJuego.Text & "'"
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query)
        End Sub

        Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
            Dim buscarTexto As String = TxtJuego.Text.Trim()
            Dim query = ""
            query = "SELECT * FROM VW_JuegoReview
WHERE nombrejuego LIKE '%" & buscarTexto & "%'"
            ' Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
            Dim dt = ConexionSQL.SelectQuery(query)

            DataGridView1.DataSource = dt



        End Sub

        Private Sub TxtId_TextChanged(sender As Object, e As EventArgs)
            Dim buscarId As Integer

            ' Verificar si el texto en el TxtId es un número válido
            If Integer.TryParse(TxtId.Text.Trim(), buscarId) Then
                ' Iterar sobre las filas del DataGridView para encontrar la que corresponde al ID buscado
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Convert.ToInt32(row.Cells("IdJuego").Value) = buscarId Then
                        ' Seleccionar la fila encontrada y salir del bucle
                        DataGridView1.CurrentCell = row.Cells(0)
                        Exit For
                    End If
                Next
            Else
                ' Si el texto no es un número válido, limpiar la selección del DataGridView
                DataGridView1.ClearSelection()
            End If
        End Sub


        Private Sub btnEliminarJuego_Click(sender As Object, e As EventArgs)
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim connection = New SqlConnection(connectionString)

            Try
                connection.Open()
                Dim command = New SqlCommand("SP_EliminarJuego", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Suponiendo que el procedimiento almacenado toma el ID del juego como parámetro
                command.Parameters.AddWithValue("@IdJuego", TxtId.Text)

                command.ExecuteNonQuery()
                MessageBox.Show("Juego eliminado correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el juego: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Sub


        Private Sub ActualizarDataGridView()
            ' Actualizar el DataGridView con la lista actualizada de juegos
            query = "SELECT * FROM VW_JuegoReview"
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query)
        End Sub


        Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
            My.Forms.FormularioAgregar.Show()
        End Sub

        Private Sub BtnActualizar_Click(sender As Object, e As EventArgs)
            My.Forms.FormularioActualizar.Show()
        End Sub

        Private Sub BtnRefrescar_Click(sender As Object, e As EventArgs)
            query = "SELECT id,Genero FROM Genero"
            ComboBoxJuego.DataSource = ConexionSQL.SelectQuery(query)
            ComboBoxJuego.DisplayMember = "Genero"
            ComboBoxJuego.ValueMember = "id"
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            My.Forms.AgregarGenero.Show()
        End Sub

        Private Sub BtnAgregarPlata_Click(sender As Object, e As EventArgs)
            My.Forms.AgregarPlataforma.Show()
        End Sub

        Private Sub BtnAgDesarrolladora_Click(sender As Object, e As EventArgs)
            My.Forms.AgregarDesarrolladora.Show()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            My.Forms.EliminarDesarrolladora.Show()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs)
            My.Forms.EliminarPlataforma.Show()
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs)
            My.Forms.EliminarGenero.Show()
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs)
            My.Forms.EditarDesarrolladora.Show()
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs)
            My.Forms.EditarPlataforma.Show()
        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs)
            My.Forms.EditarGenero.Show()
        End Sub
    End Class
End Namespace
