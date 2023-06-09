﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Collections.ObjectModel
Imports System.Runtime.InteropServices

'otro comentario estoy cerda
Public Class Form1

    ' Consulta SQL
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = 2
    Dim query As String
    Dim queryT As String = "SELECT Cliente.Nombre AS Cliente, Books.Title AS Libro, Prestamos.Costo, Prestamos.Estado, Prestamos.Observacion, Prestamos.FechaPrestamo, Prestamos.FechaDevolucion
                            FROM Cliente
                            JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId
                            JOIN Books ON Prestamos.LibroId = Books.Id;"

    ' Cadena de conexión a la base de datos
    Dim conexion As New SqlConnection(varGlobales.cadenaConexion)



    'Declaración de la función SendMessage
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    'Declaración de la función ReleaseCapture
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            conexion.Open()
            query = queryT
            DataGridView1.DataSource = ObtenerLibrosPrestados()
            ListaMostrar.Text = "Todos"
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

    'boton cerrar BARRA 
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    'boton cerrar MINIMIZAR

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    'DROP BOX-------------------------------------------------------------------------------------------------------------------------


    Private Sub ListaMostrar_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListaMostrar.SelectedValueChanged



        If ListaMostrar.Text = "" Or ListaMostrar.Text = "Libros Prestados" Then

            query = "SELECT Cliente.Nombre AS Cliente, Books.Title AS Libro, Prestamos.Costo, Prestamos.Estado, Prestamos.Observacion, Prestamos.FechaPrestamo, Prestamos.FechaDevolucion " &
                              "FROM Cliente " &
                              "JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId " &
                              "JOIN Books ON Prestamos.LibroId = Books.Id " &
                              "WHERE Prestamos.Estado = 'Prestado'"


        ElseIf ListaMostrar.Text = "Libros Devueltos" Then

            query = "SELECT Cliente.Nombre AS Cliente, Books.Title AS Libro, Prestamos.Costo, Prestamos.Estado, Prestamos.Observacion, Prestamos.FechaPrestamo, Prestamos.FechaDevolucion
                        FROM Cliente
                        JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId
                        JOIN Books ON Prestamos.LibroId = Books.Id
                        WHERE Prestamos.Estado = 'Devuelto';"

        ElseIf ListaMostrar.Text = "Todos" Then

            query = queryT

        End If


        DataGridView1.DataSource = ObtenerLibrosPrestados()

    End Sub


    Public Function ObtenerLibrosPrestados() As DataTable
        Dim dataTable As New DataTable()
        ' Crear el adaptador y ejecutar la consulta
        Dim adapter As New SqlDataAdapter(query, conexion)
        adapter.Fill(dataTable)

        Return dataTable

    End Function

    'REDIRECCIONAR---------------------------------------------
    Private Sub archivoP1_Click(sender As Object, e As EventArgs) Handles archivoP1.Click
        nuevoLibro.Visible = False

    End Sub
    Private Sub archivoP2_Click(sender As Object, e As EventArgs) Handles archivoP2.Click
        nuevoLibro.Visible = True
        nuevoLibro.Owner = Me
    End Sub


    'locacion
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged

        If nuevoLibro IsNot Nothing Then ' Verificar si el Formulario 2 está abierto
            nuevoLibro.Location = New Point(Me.Location.X, Me.Location.Y + 48) ' Establecer la nueva ubicación de Form2 en relación con Form1
        End If

    End Sub

    Private Sub Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles Menu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If


    End Sub


End Class
