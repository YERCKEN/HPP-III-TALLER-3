Imports System.Data.SqlClient

Public Class NuevoCliente
    Dim conexion As New SqlConnection(varGlobales.cadenaConexion)

    Dim connectionString As String = varGlobales.cadenaConexion

    Private Sub NuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form3 en relación con Form1
    End Sub

    Private Sub NewClienteBtn_Click(sender As Object, e As EventArgs) Handles NewClienteBtn.Click
        Dim nombre As String = NombreTb.Text
        Dim correo As String = CorreoTb.Text
        ' Validar si los campos están llenos
        ' Validar si los campos están llenos
        If nombre <> "" AndAlso correo <> "" Then
            ' Verificar si el correo electrónico ya existe en la base de datos
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "SELECT COUNT(*) FROM Cliente WHERE correo = @Correo"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Correo", correo)
                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                        If count > 0 Then
                            MessageBox.Show("El correo electrónico ya está registrado.")
                            Return
                        End If
                    End Using
                End Using

                ' Insertar el nuevo cliente en la base de datos
                Try
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()
                        Dim insertQuery As String = "INSERT INTO Cliente (Nombre, correo) VALUES (@Nombre, @Correo)"
                        Using command As New SqlCommand(insertQuery, connection)
                            command.Parameters.AddWithValue("@Nombre", nombre)
                            command.Parameters.AddWithValue("@Correo", correo)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Cliente guardado exitosamente.")

                    ' Limpiar los campos después de guardar
                    NombreTb.Text = ""
                    CorreoTb.Text = ""
                Catch ex As Exception
                    MessageBox.Show("Error al guardar el cliente: " & ex.Message)
                End Try
            Catch ex As Exception
                MessageBox.Show("Error al verificar el correo electrónico: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Por favor, complete todos los campos.")
        End If
    End Sub
End Class