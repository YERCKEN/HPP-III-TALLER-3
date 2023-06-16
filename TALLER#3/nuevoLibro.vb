Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class nuevoLibro
    'HOLA jeisoon conectate CERDO AGREGE Q
    Dim conexion As New SqlConnection(varGlobales.cadenaConexion)

    Dim connectionString As String = varGlobales.cadenaConexion

    Private Sub nuevoLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form2 en relación con Form1

        PanelAutorExistente.Visible = False
        PanelNuevoAutor.Visible = False
        PanelIngresoDeAutores.Visible = False
        btnIngresarAutor.Visible = False
        ListaAutorExistente.DropDownStyle = ComboBoxStyle.DropDownList
        listaLibros.DropDownStyle = ComboBoxStyle.DropDownList
        btnMostrarPanelNuevoLibro.Visible = False
        Try

            conexion.Open()

            DataGridView1.DataSource = ObtenerLibrosAutores()
            'PROPIEDADES GRIDVIEW-----------------------------------------------------------------
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSize = False
            DataGridView1.MaximumSize = New Size(1192, 336)
            DataGridView1.AutoResizeColumns()
            DataGridView1.ReadOnly = True


            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView2.AutoSize = False
            DataGridView2.MaximumSize = New Size(1192, 199)
            DataGridView2.AutoResizeColumns()
            DataGridView2.ReadOnly = True
            ' Cambiar el encabezado de la columna "Title"

            conexion.Close()

            CargarDatosEnDropList()
            LoadBookNamesToDropDown()
            cargarBook()
            DataGridView2.Columns("Title").HeaderText = "Libros Sin Autores Definidos"

        Catch ex As Exception

            MsgBox("ERRROR CONECTAR CON BASE")
            conexion.Close()

        End Try
    End Sub

    Public Function ObtenerLibrosAutores() As DataTable

        Dim query As String = "SELECT Books.Title AS Book, Authors.Name AS Author
                                FROM Books
                                JOIN BooksAuthors ON Books.Id = BooksAuthors.BookId
                                JOIN Authors ON Authors.Id = BooksAuthors.AuthorId;"

        Dim dataTable As New DataTable()
        ' Crear el adaptador y ejecutar la consulta
        Dim adapter As New SqlDataAdapter(query, conexion)
        adapter.Fill(dataTable)

        Return dataTable

    End Function

    Private Sub BtnExistente_Click(sender As Object, e As EventArgs) Handles BtnExistente.Click

        PanelAutorExistente.Visible = True
        PanelNuevoAutor.Visible = False

        BtnExistente.Visible = False
        BtnNuevo.Visible = True
        btnIngresarAutor.Visible = True
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        PanelAutorExistente.Visible = False
        PanelNuevoAutor.Visible = True

        BtnNuevo.Visible = False
        BtnExistente.Visible = True
        btnIngresarAutor.Visible = True
    End Sub


    'FUNCIÓN PARA CARGAR LA DROPLIST---------------------------------------
    Private Sub CargarDatosEnDropList()


        Using conexion As New SqlConnection(connectionString)

            ListaAutorExistente.Items.Clear()

            conexion.Open()

            Dim query As String = "SELECT Name FROM Authors"
            Dim command As New SqlCommand(query, conexion)

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim name As String = reader.GetString(0)
                ListaAutorExistente.Items.Add(name)
            End While

        End Using


    End Sub

    'si el libro existe
    Private Function ExisteLibro(ByVal tituloLibro As String) As Boolean

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM Books WHERE Title = @TituloLibro"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@TituloLibro", tituloLibro)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                connection.Close()
                Return count > 0

            End Using
        End Using

    End Function


    'si el autor existe
    Private Function ExisteAutor(ByVal autor As String) As Boolean

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM Authors WHERE name = @autor"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@autor", autor)
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                connection.Close()
                Return count > 0

            End Using
        End Using

    End Function



    Private Sub AgregarLibroAAutorExistente(ByVal nombreAutor As String, ByVal tituloLibro As String)

        ' Resto del código para agregar el libro al autor existente
        Dim authorId As Integer
        Dim bookId As Integer

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Obtener el ID del autor existente
            Dim authorIdQuery As String = "SELECT Id FROM Authors WHERE Name = @NombreAutor"

            Using command As New SqlCommand(authorIdQuery, connection)
                command.Parameters.AddWithValue("@NombreAutor", nombreAutor)
                authorId = Convert.ToInt32(command.ExecuteScalar())
            End Using

            ' Insertar un nuevo libro
            bookId = EncontrarIdLibroPorNombre(listaLibros.Text)

            ' Relacionar el libro con el autor existente
            AssociateAuthorWithBook(authorId, bookId)

        End Using


    End Sub


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TextBoxTítulo.Text <> "" Then

            'INGRESAR LIBRO------------------------------------------------------------------
            InsertBook(TextBoxTítulo.Text)

        Else

            TextBoxTítulo.BackColor = Color.FromArgb(255, 222, 222)

        End If


    End Sub




    'SELECT PARA LISTA DE LIBROS EXISTENTE---------------------------------------
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
                    listaLibros.Items.Clear()

                    ' Agregar los nombres de los libros al control de DropDown (ComboBox)
                    While reader.Read()
                        Dim bookName As String = reader.GetString(0)
                        listaLibros.Items.Add(bookName)
                    End While
                End Using
            End Using
        End Using
    End Sub


    'ENCONTRAR ID DEL LIBRO POR NOMBRE DE LA LISTA NOMBRE-      ---------------------------------------------------------------------------
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



    'NUEVO AUTOR Y NUEVO LIBRO--------------------------------------------------------------------------------------------------------

    'FUNCIÓN PARA INSERTAR AUTOR
    Private Function InsertAuthor(name As String, country As String) As Integer
        Dim authorId As Integer = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Authors (Name, Country) VALUES (@Name, @Country); SELECT SCOPE_IDENTITY();"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@Country", country)

                authorId = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return authorId
    End Function


    'FUNCION INSERTAR LIBRO

    Private Sub InsertBook(title As String)

        If ExisteLibro(TextBoxTítulo.Text) Then

            TextBoxTítulo.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: EL LIBRO YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Books (Title) VALUES (@Title);"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Title", title)
                    command.ExecuteNonQuery()

                    TextBoxTítulo.BackColor = Color.FromArgb(207, 255, 235)

                    MessageBox.Show("LIBRO INSERTADO CORRECTAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBoxTítulo.BackColor = Color.White
                    TextBoxTítulo.Text = ""
                    cargarBook()
                End Using
            End Using
        End If
    End Sub

    'INSERTAR ID PARA RELACIÓN ENTRE LIBROS Y AUTORES
    Private Sub AssociateAuthorWithBook(authorId As Integer, bookId As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO BooksAuthors (AuthorId, BookId) VALUES (@AuthorId, @BookId);"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AuthorId", authorId)
                command.Parameters.AddWithValue("@BookId", bookId)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnMostrarPanelAutores_Click(sender As Object, e As EventArgs) Handles btnMostrarPanelAutores.Click
        PanelIngresoDeAutores.Visible = True
        btnMostrarPanelAutores.Visible = False

        btnMostrarPanelNuevoLibro.Visible = True


        PanelPanelIngresar.Visible = False
    End Sub

    Private Sub btnIngresarAutor_Click(sender As Object, e As EventArgs) Handles btnIngresarAutor.Click


        'NUEVO------------------------------------------------------------------

        If BtnExistente.Visible Then

            'ESTAN LLENAS LOS DATOS

            If textBoxAutor.Text = "" Then
                textBoxAutor.BackColor = Color.FromArgb(255, 222, 222)

            ElseIf TextBoxPais.Text = "" Then

                textBoxAutor.BackColor = Color.White
                TextBoxPais.BackColor = Color.FromArgb(255, 222, 222)

            Else
                textBoxAutor.BackColor = Color.White
                TextBoxTítulo.BackColor = Color.White
                TextBoxPais.BackColor = Color.White

                'CODIGO

                ' El botón es visible
                If ExisteAutor(textBoxAutor.Text) Then

                    textBoxAutor.BackColor = Color.FromArgb(255, 222, 222)

                    MessageBox.Show("ERROR: EL AUTOR YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    textBoxAutor.BackColor = Color.White

                Else
                    textBoxAutor.BackColor = Color.White

                    ' Insertar el autor
                    Dim authorId As Integer = InsertAuthor(textBoxAutor.Text, TextBoxPais.Text)
                    ' Insertar el libro
                    Dim bookId As Integer = EncontrarIdLibroPorNombre(listaLibros.Text)
                    ' Asociar el autor con el libro

                    AssociateAuthorWithBook(authorId, bookId)
                    MessageBox.Show("AUTOR RELACIONADO CORRECTAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    textBoxAutor.Text = ""
                    TextBoxTítulo.Text = ""
                    TextBoxPais.Text = ""
                    listaLibros.Text = ""



                End If

            End If



            'EXISTENTE-------------------------------------------------------------------
        ElseIf BtnNuevo.Visible Then

            If ListaAutorExistente.Text = "" Then

                ListaAutorExistente.BackColor = Color.FromArgb(255, 222, 222)

            ElseIf listaLibros.Text = "" Then

                ListaAutorExistente.BackColor = Color.White
                TextBoxTítulo.BackColor = Color.FromArgb(255, 222, 222)

            Else

                ListaAutorExistente.BackColor = Color.White


                TextBoxTítulo.BackColor = Color.White
                AgregarLibroAAutorExistente(ListaAutorExistente.Text, listaLibros.Text)
                MessageBox.Show("LIBRO AGREGADO AL AUTOR EXISTENTE CON EXITO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListaAutorExistente.Text = ""
                TextBoxTítulo.Text = ""
                listaLibros.Text = ""
                TextBoxTítulo.BackColor = Color.White



            End If

        End If

        'ACTUALIZACIÓN
        DataGridView1.DataSource = ObtenerLibrosAutores()

        CargarDatosEnDropList()
        cargarBook()
    End Sub





    Private Sub cargarBook()

        ' Consulta SQL para seleccionar los libros sin autores
        Dim query As String = "SELECT B.Title FROM Books B LEFT JOIN BooksAuthors BA ON B.Id = BA.BookId WHERE BA.BookId IS NULL"

        ' Crear una nueva conexión a la base de datos
        Using connection As New SqlConnection(connectionString)
            ' Crear un nuevo comando SQL
            Using command As New SqlCommand(query, connection)
                ' Abrir la conexión
                connection.Open()

                ' Crear un adaptador de datos
                Using adapter As New SqlDataAdapter(command)
                    ' Crear un nuevo DataTable para almacenar los resultados de la consulta
                    Dim dataTable As New DataTable()

                    ' Llenar el DataTable con los datos del adaptador
                    adapter.Fill(dataTable)

                    ' Asignar el DataTable al control DataGridView
                    DataGridView2.DataSource = dataTable
                End Using
            End Using
        End Using
    End Sub



    Private Sub btnMostrarPanelNuevoLibro_Click(sender As Object, e As EventArgs) Handles btnMostrarPanelNuevoLibro.Click
        btnMostrarPanelNuevoLibro.Visible = False
        PanelIngresoDeAutores.Visible = False
        PanelPanelIngresar.Visible = True
        btnMostrarPanelAutores.Visible = True
    End Sub
End Class