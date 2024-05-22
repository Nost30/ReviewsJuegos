Imports System
Imports System.Windows.Forms

Namespace ReviewsJuegos
    Public Partial Class Login
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ButtonLogin_Click(sender As Object, e As EventArgs)
            Dim username = TxtUsuario.Text
            Dim password = TxtContra.Text

            ' Aquí deberías tener código para verificar las credenciales.
            ' Esto podría involucrar la comparación con una base de datos, un archivo de texto, etc.
            ' Aquí tienes un ejemplo muy básico:

            If Equals(username, "admin") AndAlso Equals(password, "12345") Then
                MessageBox.Show("Inicio de sesión exitoso")

                Dim ReviewsJuegos = New Form1()
                ReviewsJuegos.Show()

                Hide() ' Cierra el formulario de inicio de sesión
            Else

                MessageBox.Show("Nombre de usuario o contraseña incorrectos")
            End If
        End Sub
    End Class
End Namespace
