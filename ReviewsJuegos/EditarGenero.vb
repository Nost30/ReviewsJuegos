Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace ReviewsJuegos

    Public Partial Class EditarGenero
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub EditarGenero_Load(sender As Object, e As EventArgs)
            CargarGeneros()
        End Sub

        Private Sub CargarGeneros()
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "SELECT Id, Genero FROM Genero"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                Dim adapter = New SqlDataAdapter(command)
                Dim table = New DataTable()

                adapter.Fill(table)

                CbxGene.DisplayMember = "Genero"
                CbxGene.ValueMember = "Id"
                CbxGene.DataSource = table
            End Using
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            If CbxGene.SelectedIndex <> -1 And Not String.IsNullOrEmpty(TxtGenEdit.Text) Then
                Dim idGenero = Conversions.ToInteger(CbxGene.SelectedValue)
                Dim nuevoNombre = TxtGenEdit.Text

                ActualizarNombreGenero(idGenero, nuevoNombre)
            Else
                MessageBox.Show("Seleccione un género y escriba el nuevo nombre.")
            End If
        End Sub

        Private Sub ActualizarNombreGenero(idGenero As Integer, nuevoNombre As String)
            Dim connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
            Dim query = "SP_ActualizarGenero"

            Using connection = New SqlConnection(connectionString)
                Dim command = New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@IdGenero", idGenero)
                command.Parameters.AddWithValue("@NombreGenero", nuevoNombre)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Nombre del género actualizado correctamente.")
                CargarGeneros() ' Recargar la lista de géneros
            End Using
        End Sub
    End Class
End Namespace
