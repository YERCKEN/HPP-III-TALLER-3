Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class nuevoPrestamo

    Dim connectionString As String = varGlobales.cadenaConexion
    Dim id As Integer
    Dim queryBusquedad As String
    Dim contadorDot As Integer = 0

    'LOAD------------------------------------------------------------------------------------------------------
    Private Sub nuevoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form3 en relación con Form1

        'INCIO
        panelIngresoDatos2.Visible = False
        ListaMostrarLibros.DropDownStyle = ComboBoxStyle.DropDownList

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Font = New Font("Montserrat", 14, FontStyle.Bold) ' Cambiar la fuente a Arial, tamaño 12 y estilo negrita
        DateTimePicker1.ForeColor = Color.FromArgb(83, 97, 98)
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
        DataGridView1.MaximumSize = New Size(1257, 250)
        DataGridView1.AutoResizeColumns()
        DataGridView1.ReadOnly = True

        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSize = False
        DataGridView2.MaximumSize = New Size(432, 103)
        DataGridView2.AutoResizeColumns()
        DataGridView2.ReadOnly = True
        'DataGridView2.Columns.Remove(DataGridView2.Columns("DataGridViewCheckBoxColumn"))

        DataGridView2.Columns("Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


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



    'FUNCION COMPROBACION SI EXISTE EL ID
    Public Function ComprobacionId(idUsuario As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Cliente WHERE Id = @IdUsuario"
        Dim existeId As Boolean = False

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdUsuario", idUsuario)
                connection.Open()
                Dim count As Integer = CInt(command.ExecuteScalar())
                If count > 0 Then
                    existeId = True
                End If
            End Using
        End Using

        Return existeId
    End Function



    'BOTON DE SELECCIONAR ID ------------------------------------------------------------------------------------------
    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        If TextBoxId.Text <> "" Then

            If ComprobacionId(TextBoxId.Text) Then

                panelIngresoDatos2.Visible = True
                PanelSeleccionId.Visible = False

                TextBoxObservacion.Text = "Entregado el: " & DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                id = TextBoxId.Text
            Else

                MsgBox("ERROR: EL ID SELECCIONADO NO EXISTE", MsgBoxStyle.Critical, "Error")
            End If

        Else

            MessageBox.Show("ERROR: Es necesario Ingresar un ID", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If




    End Sub



    'VOLVER -----------------------------------------------------------------------------------------------------
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        panelIngresoDatos2.Visible = False
        PanelSeleccionId.Visible = True

        'MsgBox("fecha: " & DateTimePicker1.Text)

        'Dim fechaActual As String = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
        'MsgBox("DE GOY: " & fechaActual)



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

    'funcion par abuscar ID DEL LIBRO

    Private Function EncontrarIdLibroPorNombre(nombreLibro As String) As Integer
        Dim libroId As Integer = 0

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT Id FROM Books WHERE Title = @Nombre"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Nombre", nombreLibro)

            connection.Open()
            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                libroId = Convert.ToInt32(result)
            End If
        End Using

        Return libroId
    End Function



    'BTN HACER EL INSERT
    Private Sub NewClienteBtn_Click(sender As Object, e As EventArgs) Handles NewClienteBtn.Click

        Dim libroId As Integer = EncontrarIdLibroPorNombre(ListaMostrarLibros.Text)

        'SI SE RESCATA ID 
        If libroId > 0 Then

            If TextBoxCosto.Text <> "" Then


                MsgBox("FECHA ACTUAL: " & DateTime.Now.ToString("yyyy-MM-dd"))
                MsgBox("FECHA entrega: " & DateTimePicker1.Text)


                InsertarPrestamo(id, libroId, TextBoxCosto.Text, "Prestado", TextBoxObservacion.Text, DateTime.Now.ToString("yyyy-MM-dd"), DateTimePicker1.Text)

                MessageBox.Show("Prestamo insertado correctamente.", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DataGridView1.DataSource = MostrarPrestamos()
                panelIngresoDatos2.Visible = False
                PanelSeleccionId.Visible = True
            Else
                MessageBox.Show("ERROR: El monto no puede ser un valor NULO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else
            MsgBox("EL LIBRO SELECCIONADOR NO EXISTE", MsgBoxStyle.Critical, "Error")

        End If

    End Sub

    'CONTORL DE ENTRADA---------------------------------------------------------------------------------------------------------------------
    Private Sub TextBoxId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxId.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            TextBoxId.BackColor = Color.White

        End If
    End Sub

    Private Sub TextBoxCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCosto.KeyPress
        'CANCELACIÓN
        If contadorDot = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxCosto.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot += 1
                End If

                TextBoxCosto.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxCosto.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxCosto.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub TextBoxCosto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCosto.TextChanged

        If TextBoxCosto.Text > 100 Then

            TextBoxCosto.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: DESBORDAMIENTO, MAX = " & "100 $", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxCosto.Text = TextBoxCosto.Text.Substring(0, TextBoxCosto.Text.Length - 1)
            TextBoxCosto.BackColor = Color.White
        Else

            If TextBoxCosto.Text.Count(Function(c) c = ".") = 0 And contadorDot = 1 Then
                contadorDot = 0

            End If

        End If

    End Sub



    'FUNCION INSERTAR DATOS-------------------------------------------------------------------------------------------------------

    Private Sub InsertarPrestamo(clienteId As Integer, libroId As Integer, costo As Decimal, estado As String, observacion As String, fechaPrestamo As date, fechaDevolucion As Date)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Prestamos (ClienteId, LibroId, Costo, Estado, Observacion, FechaPrestamo, FechaDevolucion) VALUES (@ClienteId, @LibroId, @Costo, @Estado, @Observacion, @FechaPrestamo, @FechaDevolucion)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ClienteId", clienteId)
            command.Parameters.AddWithValue("@LibroId", libroId)
            command.Parameters.AddWithValue("@Costo", costo)
            command.Parameters.AddWithValue("@Estado", estado)
            command.Parameters.AddWithValue("@Observacion", observacion)
            command.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)
            command.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion)

            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class