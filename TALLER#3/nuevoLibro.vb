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

        PanelPanelIngresar.Visible = False

        Try

            conexion.Open()

            DataGridView1.DataSource = ObtenerLibrosAutores()
            'PROPIEDADES GRIDVIEW-----------------------------------------------------------------
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSize = False
            DataGridView1.MaximumSize = New Size(1192, 570)
            DataGridView1.AutoResizeColumns()
            DataGridView1.ReadOnly = True



            conexion.Close()

            CargarDatosEnDropList()

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

        PanelPanelIngresar.Visible = True
        PanelAutorExistente.Visible = True
        PanelNuevoAutor.Visible = False

        BtnExistente.Visible = False
        BtnNuevo.Visible = True
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        PanelAutorExistente.Visible = False
        PanelNuevoAutor.Visible = True
        PanelPanelIngresar.Visible = True

        BtnNuevo.Visible = False
        BtnExistente.Visible = True

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
            bookId = InsertBook(tituloLibro)

            ' Relacionar el libro con el autor existente
            AssociateAuthorWithBook(authorId, bookId)

        End Using


    End Sub


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        'NUEVO------------------------------------------------------------------

        If BtnExistente.Visible Then

            'ESTAN LLENAS LOS DATOS

            If textBoxAutor.Text = "" Then
                textBoxAutor.BackColor = Color.FromArgb(255, 222, 222)

            ElseIf TextBoxPais.Text = "" Then

                textBoxAutor.BackColor = Color.White
                TextBoxPais.BackColor = Color.FromArgb(255, 222, 222)

            ElseIf TextBoxTítulo.Text = "" Then
                textBoxAutor.BackColor = Color.White
                TextBoxTítulo.BackColor = Color.FromArgb(255, 222, 222)
                TextBoxPais.BackColor = Color.White

            Else
                textBoxAutor.BackColor = Color.White
                TextBoxTítulo.BackColor = Color.White
                TextBoxPais.BackColor = Color.White

                'CODIGO

                ' El botón es visible
                If ExisteAutor(textBoxAutor.Text) Then

                    textBoxAutor.BackColor = Color.FromArgb(255, 222, 222)

                    MessageBox.Show("ERROR: EL AUTOR YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                ElseIf ExisteLibro(TextBoxTítulo.Text) Then

                    textBoxAutor.BackColor = Color.White
                    TextBoxTítulo.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("ERROR: EL LIBRO YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    textBoxAutor.BackColor = Color.White
                    TextBoxTítulo.BackColor = Color.White

                    ' Insertar el autor
                    Dim authorId As Integer = InsertAuthor(textBoxAutor.Text, TextBoxPais.Text)
                    ' Insertar el libro
                    Dim bookId As Integer = InsertBook(TextBoxTítulo.Text)
                    ' Asociar el autor con el libro

                    AssociateAuthorWithBook(authorId, bookId)
                    MessageBox.Show("LIBRO Y AUTOR INSERTADOS CORRECTAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    textBoxAutor.Text = ""
                    TextBoxTítulo.Text = ""
                    TextBoxPais.Text = ""

                End If

            End If



            'EXISTENTE-------------------------------------------------------------------
        ElseIf BtnNuevo.Visible Then

            If ListaAutorExistente.Text = "" Then

                ListaAutorExistente.BackColor = Color.FromArgb(255, 222, 222)

            ElseIf TextBoxTítulo.Text = "" Then

                ListaAutorExistente.BackColor = Color.White
                TextBoxTítulo.BackColor = Color.FromArgb(255, 222, 222)

            Else

                ListaAutorExistente.BackColor = Color.White

                If ExisteLibro(TextBoxTítulo.Text) Then

                    TextBoxTítulo.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("ERROR: EL LIBRO YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                Else

                    TextBoxTítulo.BackColor = Color.White
                    AgregarLibroAAutorExistente(ListaAutorExistente.Text, TextBoxTítulo.Text)
                    MessageBox.Show("LIBRO AGREGADO AL AUTOR EXISTENTE CON EXITO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListaAutorExistente.Text = ""
                    TextBoxTítulo.Text = ""
                    TextBoxTítulo.BackColor = Color.White

                End If

            End If

        End If

        'ACTUALIZACIÓN
        DataGridView1.DataSource = ObtenerLibrosAutores()

        CargarDatosEnDropList()

    End Sub


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

    Private Function InsertBook(title As String) As Integer
        Dim bookId As Integer = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO Books (Title) VALUES (@Title); SELECT SCOPE_IDENTITY();"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Title", title)

                bookId = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return bookId
    End Function

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



End Class