Public Class Empresa
    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 48) ' Establecer la nueva ubicación de Form6 en relación con Form1

    End Sub
End Class