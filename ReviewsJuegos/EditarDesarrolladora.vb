Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace ReviewsJuegos
    Public Partial Class EditarDesarrolladora
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ActualizarDesarrolladora_Load(sender As Object, e As EventArgs)
            CargarDesarrolladoras()
        End Sub

        Private Sub CargarDesarrolladoras()
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "SELECT Id, Desarrolladora FROM Desarrolladora"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                Dim adapter = New SqlDataAdapter(command)
                Dim table = New DataTable()

                adapter.Fill(table)

                CbxDesa.DisplayMember = "Desarrolladora"
                CbxDesa.ValueMember = "Id"
                CbxDesa.DataSource = table
            End Using
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            If CbxDesa.SelectedIndex <> -1 And Not String.IsNullOrEmpty(TxtDesaEdit.Text) Then
                Dim idDesarrolladora = Conversions.ToInteger(CbxDesa.SelectedValue)
                Dim nuevoNombre = TxtDesaEdit.Text

                ActualizarNombreDesarrolladora(idDesarrolladora, nuevoNombre)
            Else
                MessageBox.Show("Seleccione una desarrolladora y escriba el nuevo nombre.")
            End If
        End Sub

        Private Sub ActualizarNombreDesarrolladora(idDesarrolladora As Integer, nuevoNombre As String)
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "SP_ActualizarDesarrolladora"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@IdDesarrolladora", idDesarrolladora)
                command.Parameters.AddWithValue("@NombreDesarrolladora", nuevoNombre)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Nombre de la desarrolladora actualizado correctamente.")
                CargarDesarrolladoras() ' Recargar la lista de desarrolladoras
            End Using
        End Sub
    End Class
End Namespace
