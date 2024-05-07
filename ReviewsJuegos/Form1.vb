﻿Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Form1
    Private query As String
    Private auto As Boolean
    ' Create a constructor
    Public Sub New()
        auto = True
        InitializeComponent()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        query = "SELECT Id,NombreJuego FROM Juego"
        ComboBoxJuego.DataSource = ConexionSQL.SelectQuery(query)
        ComboBoxJuego.DisplayMember = "NombreJuego"
        ComboBoxJuego.ValueMember = "id"
        auto = False
        DataGridView1.ReadOnly = True

        query = "SELECT * FROM VW_JuegoReview"
        DataGridView1.DataSource = ConexionSQL.SelectQuery(query)



    End Sub





    Private Sub ComboBoxJuego_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJuego.SelectedIndexChanged
        If ComboBoxJuego.Text Is Nothing Then
            Return
        End If
        query = "SELECT * FROM VW_JuegoReview
where nombrejuego='" & ComboBoxJuego.Text & "'"
        DataGridView1.DataSource = ConexionSQL.SelectQuery(query)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim buscarTexto As String = TxtJuego.Text.Trim()
        Dim query = ""
        query = "SELECT * FROM VW_JuegoReview
WHERE nombrejuego LIKE '%" & buscarTexto & "%'"
        ' Ejecutar la consulta SQL y mostrar los resultados en el DataGridView
        Dim dt = ConexionSQL.SelectQuery(query)

        DataGridView1.DataSource = dt



    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged
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


    Private Sub btnEliminarJuego_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim connectionString As String = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()
            Dim command As New SqlCommand("SP_EliminarJuego", connection)
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


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        FormularioAgregar.Show()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        FormularioActualizar.Show()
    End Sub

    Private Sub BtnRefrescar_Click(sender As Object, e As EventArgs) Handles BtnRefrescar.Click
        Me.Refresh()
    End Sub
End Class