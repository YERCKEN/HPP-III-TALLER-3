Imports System.Data.SqlClient

Public Class Cliente
    Dim conexion As New SqlConnection(varGlobales.cadenaConexion)

    Dim connectionString As String = varGlobales.cadenaConexion
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form4 en relación con Form1
    End Sub
End Class