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
        Dim query As String = "SELECT * FROM Cliente"

        Dim dataTable As New DataTable()
        ' Crear el adaptador y ejecutar la consulta
        Dim adapter As New SqlDataAdapter(query, conexion)
        adapter.Fill(dataTable)

        Return dataTable

    End Function
    Public Function MostrarAutores() As DataTable
        Dim query As String = "SELECT * FROM Authors"

        Dim dataTable As New DataTable()
        ' Crear el adaptador y ejecutar la consulta
        Dim adapter As New SqlDataAdapter(query, conexion)
        adapter.Fill(dataTable)

        Return dataTable

    End Function
    Public Function eliminarLibroAutor(ByVal IdCliente As Integer)
        Dim query As String = "DELETE FROM BooksAuthors WHERE AuthorId =" & IdCliente
        Dim rowCount As Integer = 0
        ' Crear una SqlConnection y SqlCommand
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AuthorId", IdCliente)
                connection.Open()
                rowCount = command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Private Sub clienteBtn_Click(sender As Object, e As EventArgs) Handles clienteBtn.Click
        IdLb.Text = "Id de cliente:"
        clienteBtn.Enabled = False
        autorBtn.Enabled = True
        conexion.Open()
        DataGridView1.DataSource = MostrarClientes()
        conexion.Close()
    End Sub

    Private Sub autorBtn_Click(sender As Object, e As EventArgs) Handles autorBtn.Click
        IdLb.Text = "Id de autor:"
        autorBtn.Enabled = False
        clienteBtn.Enabled = True
        conexion.Open()
        DataGridView1.DataSource = MostrarAutores()
        conexion.Close()
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        Dim IdCliente As Integer = Integer.Parse(IdClienteTb.Text)
        IdClienteTb.Clear()
        If clienteBtn.Enabled = False Then
            Using con As New SqlConnection(connectionString)
                ' Abrir la conexión
                con.Open()

                ' Consulta SQL para obtener los datos
                Dim query As String = "DELETE FROM Cliente WHERE Id = " & IdCliente

                ' Crear un adaptador de datos
                Dim adapter As New SqlDataAdapter(query, con)
                ' Crear un DataSet para almacenar los datos
                Dim dataSet As New DataSet()

                ' Llenar el DataSet con los datos del adaptador
                adapter.Fill(dataSet, "Cliente")

                ' Asignar el DataTable al control DataGridView
                DataGridView1.DataSource = dataSet.Tables("Cliente")

                ' Cerrar la conexión
                con.Close()
                IdClienteTb.Clear()
                DataGridView1.DataSource = MostrarClientes()
            End Using
        Else
            eliminarLibroAutor(IdCliente)
            Using con As New SqlConnection(connectionString)
                ' Abrir la conexión
                con.Open()

                ' Consulta SQL para obtener los datos
                Dim query As String = "DELETE FROM Authors WHERE Id = " & IdCliente

                ' Crear un adaptador de datos
                Dim adapter As New SqlDataAdapter(query, con)
                ' Crear un DataSet para almacenar los datos
                Dim dataSet As New DataSet()

                ' Llenar el DataSet con los datos del adaptador
                adapter.Fill(dataSet, "Cliente")

                ' Asignar el DataTable al control DataGridView
                DataGridView1.DataSource = dataSet.Tables("Cliente")

                ' Cerrar la conexión
                con.Close()
                IdClienteTb.Clear()
                DataGridView1.DataSource = MostrarAutores()
            End Using
        End If
    End Sub
End Class