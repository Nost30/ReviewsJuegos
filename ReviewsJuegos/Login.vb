﻿Public Class Login

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUsuario.Text
        Dim password As String = TxtContra.Text

        ' Aquí deberías tener código para verificar las credenciales.
        ' Esto podría involucrar la comparación con una base de datos, un archivo de texto, etc.
        ' Aquí tienes un ejemplo muy básico:

        If username = "admin" AndAlso password = "4E7AFEBCFBAE000B22C7C85E5560F89A2A0280B4" Then
            MessageBox.Show("Inicio de sesión exitoso")

            Dim ReviewsJuegos As New Form1()
            ReviewsJuegos.Show()
            Me.Close() ' Cierra el formulario de inicio de sesión

        Else

            MessageBox.Show("Nombre de usuario o contraseña incorrectos")
        End If
    End Sub
End Class