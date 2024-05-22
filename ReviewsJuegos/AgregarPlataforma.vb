Imports System
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Namespace ReviewsJuegos

    Public Partial Class AgregarPlataforma
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
            ' Crear parámetros para el procedimiento almacenado
            Dim IdUsuario = 1
            Dim parametros = New SqlParameter(1) {}
            parametros(0) = New SqlParameter("@NombrePlataforma", TxtAgPlata.Text)
            parametros(1) = New SqlParameter("@IdUsuarioCrea ", IdUsuario)




            ' Ejecutar el procedimiento almacenado
            ConexionSQL.ExecuteStoredProcedure("SP_AgregarPlataforma", parametros)
            MsgBox("Registro exitoso")
        End Sub

        Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
            Close()

        End Sub
    End Class
End Namespace
