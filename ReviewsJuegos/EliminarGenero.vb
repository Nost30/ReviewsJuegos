Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace ReviewsJuegos

    Public Partial Class EliminarGenero
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub EliminarPlataforma_Load(sender As Object, e As EventArgs)
            CargarGeneros()

        End Sub

        Private Sub CargarGeneros()
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "EXEC SP_ObtenerGeneros"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                Dim adapter = New SqlDataAdapter(command)
                Dim table = New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(table)
                    CbxGen.DisplayMember = "Genero"
                    CbxGen.ValueMember = "Id"
                    CbxGen.DataSource = table
                Catch ex As Exception
                    MessageBox.Show("Error al cargar las generos: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Sub
        Private Sub EliminarGenero_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            ' Asegurarse de que se haya seleccionado una desarrolladora
            If CbxGen.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, selecciona un genero.")
                Return
            End If

            ' Obtener el ID de la desarrolladora seleccionada
            Dim idDesarrolladora As Integer
            If Integer.TryParse(CbxGen.SelectedValue.ToString(), idDesarrolladora) Then
                Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
                Dim query = "SP_EliminarGenero"

                Using connection = New SqlConnection(connectionString)
                    Dim command = New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@IdGenero", idDesarrolladora))

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Genero eliminada correctamente.")
                        CargarGeneros() ' Recargar la lista después de eliminar
                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar el genero: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                End Using
            Else
                MessageBox.Show("El ID del genero seleccionado no es válido.")
            End If
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace
