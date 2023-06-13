﻿Imports System.Data.SqlClient

Public Class Cliente
    Dim conexion As New SqlConnection(varGlobales.cadenaConexion)

    Dim connectionString As String = varGlobales.cadenaConexion
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form4 en relación con Form1
        Try

            conexion.Open()

            DataGridView1.DataSource = MostrarClientes()
            'PROPIEDADES GRIDVIEW-----------------------------------------------------------------
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSize = False
            DataGridView1.MaximumSize = New Size(1192, 570)
            DataGridView1.AutoResizeColumns()
            DataGridView1.ReadOnly = True

            conexion.Close()
            EstadoCb.Items.Add("Prestado")
            EstadoCb.Items.Add("Devuelto")
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

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            Dim IdCliente As Integer = Integer.Parse(IdClienteTb.Text)
            If ComprobacionId(IdCliente) = True Then
                ActualizarBtn.Enabled = True
                ModificarClientesPanel.Enabled = True
                Using con As New SqlConnection(connectionString)
                    ' Abrir la conexión
                    con.Open()

                    ' Consulta SQL para obtener los datos
                    Dim query As String = "SELECT Cliente.Id, Cliente.Nombre AS Cliente, Books.Title AS Libro, Prestamos.Costo, Prestamos.Estado, Prestamos.Observacion, Prestamos.FechaPrestamo, Prestamos.FechaDevolucion
            FROM Cliente
            JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId
            JOIN Books ON Prestamos.LibroId = Books.Id
            WHERE Cliente.Id = " & IdCliente

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
                    MostrarCosto(IdCliente)
                    MostrarEstado(IdCliente)
                    MostrarObservacion(IdCliente)
                    IdClienteTb.Enabled = False
                    BtnIngresar.Enabled = False
                End Using
            Else
                IdClienteTb.Text = ""
            End If
        Catch ex As Exception
            IdClienteTb.Text = ""
        End Try

    End Sub
    Private Sub MostrarCosto(ByVal IdCliente As Integer)

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT Costo FROM Prestamos WHERE ClienteId = " & IdCliente
            Dim command As New SqlCommand(query, con)
            Dim dato As Object = command.ExecuteScalar()

            If dato IsNot Nothing Then
                CostoTb.Text = dato.ToString()
            Else
                CostoTb.Text = "No se encontró el dato."
            End If
        End Using
    End Sub
    Private Sub MostrarEstado(ByVal IdCliente As Integer)

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT Estado FROM Prestamos WHERE ClienteId = " & IdCliente
            Dim command As New SqlCommand(query, con)
            Dim dato As Object = command.ExecuteScalar()

            If dato IsNot Nothing Then
                EstadoCb.SelectedItem = dato.ToString()
            Else
                EstadoCb.SelectedIndex = -1
            End If
        End Using
    End Sub
    Private Sub MostrarObservacion(ByVal IdCliente As Integer)

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "SELECT Observacion FROM Prestamos WHERE ClienteId = " & IdCliente
            Dim command As New SqlCommand(query, con)
            Dim dato As Object = command.ExecuteScalar()

            If dato IsNot Nothing Then
                ObservacionTb.Text = dato.ToString()
            Else
                ObservacionTb.Text = "No se encontró el dato."
            End If
        End Using
    End Sub

    Private Sub ActualizarBtn_Click(sender As Object, e As EventArgs) Handles ActualizarBtn.Click
        Try
            Dim IdCliente As Integer = Integer.Parse(IdClienteTb.Text)
            If ActualizarCosto(IdCliente) = True And ActualizarEstado(IdCliente) = True And ActualizarObservacion(IdCliente) = True Then
                conexion.Open()
                DataGridView1.DataSource = MostrarClientes()
                IdClienteTb.Enabled = True
                BtnIngresar.Enabled = True
                ActualizarBtn.Enabled = False
                ModificarClientesPanel.Enabled = False
                conexion.Close()
                ' Opcional: Mostrar un cuadro de mensaje para indicar que la actualización fue exitosa
                MessageBox.Show("Datos actualizado.")
            End If
        Catch ex As Exception
            IdClienteTb.Text = ""
        End Try

    End Sub


    'ACTUALIZAR COSTO---------------------------------------------------------------------------------------------------

    Public Function ActualizarCosto(ByVal IdCliente As Integer) As Boolean
        Dim success As Boolean = False
        Try
            ' Obtener el valor del cuadro de texto para el nuevo Costo
            Dim Costo As Decimal = Decimal.Parse(CostoTb.Text)

            ' Consulta SQL para actualizar la columna Costo
            Dim sqlQuery As String = "UPDATE Prestamos SET Costo = @Costo WHERE ClienteId = " & IdCliente

            ' Crear una SqlConnection y SqlCommand
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(sqlQuery, connection)
                    ' Agregar parámetros para Costo y ClienteId
                    command.Parameters.AddWithValue("@Costo", Costo)
                    command.Parameters.AddWithValue("@ClienteId", IdCliente)

                    ' Abrir la conexión
                    connection.Open()

                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                End Using
            End Using
            success = True
        Catch ex As Exception
            CostoTb.Text = ""
        End Try
        Return success
    End Function

    'ACTUALIZAR ESTADO---------------------------------------------------------------------------------------------------
    Public Function ActualizarEstado(ByVal IdCliente As Integer) As Boolean
        Dim success As Boolean = False
        ' Obtener el valor del cuadro de texto para el nuevo Costo
        Dim Estado As String = EstadoCb.SelectedItem

        ' Consulta SQL para actualizar la columna Costo
        Dim sqlQuery As String = "UPDATE Prestamos SET Estado = @Estado WHERE ClienteId = " & IdCliente

        ' Crear una SqlConnection y SqlCommand
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sqlQuery, connection)
                ' Agregar parámetros para Costo y ClienteId
                command.Parameters.AddWithValue("@Estado", Estado)
                command.Parameters.AddWithValue("@ClienteId", IdCliente)

                ' Abrir la conexión
                connection.Open()

                ' Ejecutar la consulta
                command.ExecuteNonQuery()
                success = True
            End Using
        End Using
        Return success
    End Function

    'ACTUALIZAR OBSERVACION---------------------------------------------------------------------------------------------------

    Public Function ActualizarObservacion(ByVal IdCliente As Integer) As Boolean
        Dim success As Boolean = False
        ' Obtener el valor del cuadro de texto para el nuevo Costo
        Dim Observacion As String = ObservacionTb.Text

        ' Consulta SQL para actualizar la columna Costo
        Dim sqlQuery As String = "UPDATE Prestamos SET Observacion = @Observacion WHERE ClienteId = " & IdCliente

        ' Crear una SqlConnection y SqlCommand
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(sqlQuery, connection)
                ' Agregar parámetros para Costo y ClienteId
                command.Parameters.AddWithValue("@Observacion", Observacion)
                command.Parameters.AddWithValue("@ClienteId", IdCliente)

                ' Abrir la conexión
                connection.Open()

                ' Ejecutar la consulta
                command.ExecuteNonQuery()
                success = True
            End Using
        End Using
        Return success
    End Function
    'FUNCION COMPROBACION SI EXISTE EL ID
    Public Function ComprobacionId(IdCliente As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Cliente WHERE Id = " & IdCliente
        Dim existeId As Boolean = False

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdUsuario", IdCliente)
                connection.Open()
                Dim count As Integer = CInt(command.ExecuteScalar())
                If count > 0 Then
                    existeId = True
                End If
            End Using
        End Using

        Return existeId
    End Function
End Class