Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class nuevoPrestamo

    Dim connectionString As String = varGlobales.cadenaConexion
    Dim id As Integer
    Dim queryBusquedad As String

    'LOAD------------------------------------------------------------------------------------------------------
    Private Sub nuevoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form3 en relación con Form1

        'INCIO
        panelIngresoDatos2.Visible = False


        Try

            Using connection As New SqlConnection(connectionString)
                connection.Open()

            End Using

        Catch ex As Exception

            MsgBox("ERRROR CONECTAR CON BASE")

        End Try


        DataGridView1.DataSource = MostrarPrestamos()
        MostrarClientes()
        'PROPIEDADES GRIDVIEW-----------------------------------------------------------------
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSize = False
        DataGridView1.MaximumSize = New Size(1192, 250)
        DataGridView1.AutoResizeColumns()
        DataGridView1.ReadOnly = True

        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSize = False
        DataGridView2.MaximumSize = New Size(432, 103)
        DataGridView2.AutoResizeColumns()
        DataGridView2.ReadOnly = True
        'DataGridView2.Columns.Remove(DataGridView2.Columns("DataGridViewCheckBoxColumn"))

        DataGridView2.Columns("Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView2.ReadOnly = True


        LoadBookNamesToDropDown()
    End Sub



    Public Function MostrarPrestamos() As DataTable

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Dim query As String = "SELECT Cliente.Id, Cliente.Nombre AS Cliente, Books.Title AS Libro, Prestamos.Costo, Prestamos.Estado, Prestamos.Observacion, Prestamos.FechaPrestamo, Prestamos.FechaDevolucion
            FROM Cliente
            JOIN Prestamos ON Cliente.Id = Prestamos.ClienteId
            JOIN Books ON Prestamos.LibroId = Books.Id"

            Dim dataTable As New DataTable()
            ' Crear el adaptador y ejecutar la consulta
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(dataTable)

            Return dataTable

        End Using
    End Function



    Public Sub MostrarClientes()

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Dim query As String = "SELECT  Id, Nombre FROM Cliente"

            Dim dataTable As New DataTable()
            ' Crear el adaptador y ejecutar la consulta
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(dataTable)

            DataGridView2.DataSource = dataTable


        End Using

    End Sub



    Private Sub TextBoxBusquedad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusquedad.TextChanged

        If TextBoxBusquedad.Text = "" Then

            MostrarClientes()

        Else

            queryBusquedad = "SELECT Id, Nombre FROM Cliente WHERE Nombre LIKE '%' + @nombre + '%'"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(queryBusquedad, connection)
                    command.Parameters.AddWithValue("@nombre", TextBoxBusquedad.Text)

                    Try
                        connection.Open()
                        Dim adapter As New SqlDataAdapter(command)
                        Dim dataSet As New DataSet()
                        adapter.Fill(dataSet, "Cliente")

                        DataGridView2.DataSource = dataSet.Tables("Cliente")
                    Catch ex As Exception
                        MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
                    End Try
                End Using
            End Using

        End If

    End Sub

    'BOTON DE SELECCIONAR ID ------------------------------------------------------------------------------------------
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        panelIngresoDatos2.Visible = True
        PanelSeleccionId.Visible = False

        id = TextBoxId.Text
    End Sub



    'VOLVER -----------------------------------------------------------------------------------------------------
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        panelIngresoDatos2.Visible = False
        PanelSeleccionId.Visible = True
    End Sub


    Private Sub LoadBookNamesToDropDown()

        ' Consulta SQL para obtener los nombres de los libros
        Dim query As String = "SELECT Title FROM Books"

        ' Usar el bloque Using para asegurar la liberación de los recursos
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Abrir la conexión
                connection.Open()

                ' Crear un lector de datos para obtener los resultados
                Using reader As SqlDataReader = command.ExecuteReader()
                    ' Limpiar los elementos existentes en el control de DropDown
                    ListaMostrarLibros.Items.Clear()

                    ' Agregar los nombres de los libros al control de DropDown (ComboBox)
                    While reader.Read()
                        Dim bookName As String = reader.GetString(0)
                        ListaMostrarLibros.Items.Add(bookName)
                    End While
                End Using
            End Using
        End Using
    End Sub


End Class