Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace ReviewsJuegos

    Public Partial Class EditarPlataforma
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub EditarPlataforma_Load(sender As Object, e As EventArgs)
            CargarPlataformas()

        End Sub

        Private Sub CargarPlataformas()
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "SELECT Id, NombrePlataforma FROM Plataforma"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                Dim adapter = New SqlDataAdapter(command)
                Dim table = New DataTable()

                adapter.Fill(table)

                Cbxplataf.DisplayMember = "NombrePlataforma"
                Cbxplataf.ValueMember = "Id"
                Cbxplataf.DataSource = table
            End Using
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            If Cbxplataf.SelectedIndex <> -1 And Not String.IsNullOrEmpty(TxtPlatafEdit.Text) Then
                Dim idPlataforma = Conversions.ToInteger(Cbxplataf.SelectedValue)
                Dim nuevoNombre = TxtPlatafEdit.Text

                ActualizarNombrePlataforma(idPlataforma, nuevoNombre)
            Else
                MessageBox.Show("Seleccione una plataforma y escriba el nuevo nombre.")
            End If
        End Sub

        Private Sub ActualizarNombrePlataforma(idPlataforma As Integer, nuevoNombre As String)
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "SP_ActualizarPlataforma"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@IdPlataforma", idPlataforma)
                command.Parameters.AddWithValue("@NombrePlataforma", nuevoNombre)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Nombre de la Plataforma actualizado correctamente.")
                CargarPlataformas() ' Recargar la lista de desarrolladoras
            End Using
        End Sub
    End Class
End Namespace
