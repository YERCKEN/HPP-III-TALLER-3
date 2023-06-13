Imports System.Data.SqlClient

Public Class eliminacion
    Dim conexion As New SqlConnection(varGlobales.cadenaConexion)

    Dim connectionString As String = varGlobales.cadenaConexion
    Private Sub eliminacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form6 en relación con Form1
        Try
            conexion.Open()
            DataGridView1.DataSource = MostrarClientes()
            'PROPIEDADES GRIDVIEW-----------------------------------------------------------------
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSize = False
            DataGridView1.MaximumSize = New Size(1192, 250)
            DataGridView1.AutoResizeColumns()
            DataGridView1.ReadOnly = True


            conexion.Close()

        Catch ex As Exception

            MsgBox("ERRROR CONECTAR CON BASE")
            conexion.Close()

        End Try
    End Sub
    Public Function MostrarClientes() As DataTable
        Dim query As String = "SELECT Cliente.Id, Cliente.Nombre AS Cliente, Books.Title AS Libro, Prestamos.Costo, Prestamos.Estado, Prestamos.Observacion, Prestamos.FechaPrestamo, Prestamos.FechaDevolucion
            FROM Cliente
            JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId
            JOIN Books ON Prestamos.LibroId = Books.Id"

        Dim dataTable As New DataTable()
        ' Crear el adaptador y ejecutar la consulta
        Dim adapter As New SqlDataAdapter(query, conexion)
        adapter.Fill(dataTable)

        Return dataTable

    End Function
End Class