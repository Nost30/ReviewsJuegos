Imports System
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Namespace ReviewsJuegos

    Public Partial Class AgregarDesarrolladora
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs)
            ' Crear parámetros para el procedimiento almacenado
            Dim IdUsuario = 1
            Dim parametros = New SqlParameter(1) {}
            parametros(0) = New SqlParameter("@Desarrolladora", TxtAgDesarrolladora.Text)
            parametros(1) = New SqlParameter("@IdUsuarioCrea ", IdUsuario)




            ' Ejecutar el procedimiento almacenado
            ConexionSQL.ExecuteStoredProcedure("SP_AgregarDesarrolladora", parametros)
            MsgBox("Registro exitoso")
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub TxtAgDesarrolladora_TextChanged(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
