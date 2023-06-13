Public Class eliminacion
    Private Sub eliminacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class