Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace ReviewsJuegos

    Public Partial Class EliminarPlataforma
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub EliminarPlataforma_Load(sender As Object, e As EventArgs)
            CargarPlataformas()

        End Sub

        Private Sub CargarPlataformas()
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "EXEC SP_ObtenerPlataformas"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                Dim adapter = New SqlDataAdapter(command)
                Dim table = New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(table)
                    CbxPlataf.DisplayMember = "NombrePlataforma"
                    CbxPlataf.ValueMember = "Id"
                    CbxPlataf.DataSource = table
                Catch ex As Exception
                    MessageBox.Show("Error al cargar las desarrolladoras: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            ' Asegurarse de que se haya seleccionado una desarrolladora
            If CbxPlataf.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, selecciona una Plataforma.")
                Return
            End If

            ' Obtener el ID de la desarrolladora seleccionada
            Dim idPlataforma As Integer
            If Integer.TryParse(CbxPlataf.SelectedValue.ToString(), idPlataforma) Then
                Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
                Dim query = "SP_EliminarPlataforma"


                Using connection = New SqlConnection(connectionString)
                    Dim command = New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@IdPlataforma", idPlataforma))

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Plataforma eliminada correctamente.")
                        CargarPlataformas() ' Recargar la lista después de eliminar
                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar la Plataforma: " & ex.Message)
                    Finally
                        connection.Close()
                    End Try
                End Using
            Else
                MessageBox.Show("El ID de la Plataforma seleccionada no es válido.")
            End If
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Close()
        End Sub
    End Class
End Namespace
