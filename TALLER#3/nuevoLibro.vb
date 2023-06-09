Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class nuevoLibro
    'HOLA jeisoon conectate CERDO AGREGE Q
    Dim conexion As New SqlConnection("Data source =YERCKEN\SQLEXPRESS; Initial Catalog=taller3; integrated security = true ")

    Dim connectionString As String = "Data source =YERCKEN\SQLEXPRESS; Initial Catalog=taller3; integrated security = true "

    Private Sub nuevoLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form2 en relación con Form1

        PanelAutorExistente.Visible = False
        PanelNuevoAutor.Visible = False


        Try

            conexion.Open()

            DataGridView1.DataSource = ObtenerLibrosAutores()
            'PROPIEDADES GRIDVIEW-----------------------------------------------------------------
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AutoSize = False
            DataGridView1.MaximumSize = New Size(1192, 570)
            DataGridView1.AutoResizeColumns()
            DataGridView1.ReadOnly = True
            CargarDatosEnDropList()


            conexion.Close()


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

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        PanelAutorExistente.Visible = False
        PanelNuevoAutor.Visible = True
    End Sub


    'FUNCIÓN PARA CARGAR LA DROPLIST---------------------------------------
    Private Sub CargarDatosEnDropList()


        Dim query As String = "SELECT Name FROM Authors"
        Dim command As New SqlCommand(query, conexion)

        Dim reader As SqlDataReader = command.ExecuteReader()

        While reader.Read()
            Dim name As String = reader.GetString(0)
            ListaAutorExistente.Items.Add(name)
        End While


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

    Private Sub AgregarLibroAAutorExistente(ByVal nombreAutor As String, ByVal tituloLibro As String)
        ' Verificar si el libro ya existe

        If ExisteLibro(tituloLibro) Then
            MessageBox.Show("El libro ya existe en la base de datos.")
            Return
        End If

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
            Dim insertBookQuery As String = "INSERT INTO Books (Title) VALUES (@TituloLibro); SELECT SCOPE_IDENTITY();"

            Using command As New SqlCommand(insertBookQuery, connection)
                command.Parameters.AddWithValue("@TituloLibro", tituloLibro)
                bookId = Convert.ToInt32(command.ExecuteScalar())
            End Using

            ' Relacionar el libro con el autor existente
            Dim insertBooksAuthorsQuery As String = "INSERT INTO BooksAuthors (BookId, AuthorId) VALUES (@BookId, @AuthorId)"

            Using command As New SqlCommand(insertBooksAuthorsQuery, connection)
                command.Parameters.AddWithValue("@BookId", bookId)
                command.Parameters.AddWithValue("@AuthorId", authorId)
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Libro agregado al autor existente con éxito.")

    End Sub


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        AgregarLibroAAutorExistente(ListaAutorExistente.Text, TextBoxTítulo.Text)
        DataGridView1.DataSource = ObtenerLibrosAutores()
    End Sub
End Class