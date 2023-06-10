<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        NewClienteBtn = New Button()
        IngresarCliente = New Panel()
        CorreoTb = New TextBox()
        NombreTb = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        PanelAutorExistente = New Panel()
        ListaAutorExistente = New ComboBox()
        LabelVe = New Label()
        IngresarCliente.SuspendLayout()
        PanelAutorExistente.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(13, 21)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 29)
        Label1.TabIndex = 13
        Label1.Text = "Nuevo Cliente"
        ' 
        ' NewClienteBtn
        ' 
        NewClienteBtn.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        NewClienteBtn.Cursor = Cursors.Hand
        NewClienteBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        NewClienteBtn.FlatAppearance.BorderSize = 0
        NewClienteBtn.FlatStyle = FlatStyle.Flat
        NewClienteBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NewClienteBtn.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        NewClienteBtn.Location = New Point(335, 353)
        NewClienteBtn.Name = "NewClienteBtn"
        NewClienteBtn.Size = New Size(390, 49)
        NewClienteBtn.TabIndex = 46
        NewClienteBtn.Text = "Ingresar"
        NewClienteBtn.UseVisualStyleBackColor = False
        ' 
        ' IngresarCliente
        ' 
        IngresarCliente.Controls.Add(CorreoTb)
        IngresarCliente.Controls.Add(NombreTb)
        IngresarCliente.Controls.Add(Label2)
        IngresarCliente.Controls.Add(Label3)
        IngresarCliente.Location = New Point(336, 141)
        IngresarCliente.Name = "IngresarCliente"
        IngresarCliente.Size = New Size(390, 169)
        IngresarCliente.TabIndex = 47
        ' 
        ' CorreoTb
        ' 
        CorreoTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        CorreoTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        CorreoTb.Location = New Point(0, 117)
        CorreoTb.Name = "CorreoTb"
        CorreoTb.Size = New Size(391, 36)
        CorreoTb.TabIndex = 14
        ' 
        ' NombreTb
        ' 
        NombreTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        NombreTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        NombreTb.Location = New Point(0, 42)
        NombreTb.Name = "NombreTb"
        NombreTb.Size = New Size(391, 36)
        NombreTb.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(-1, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 25)
        Label2.TabIndex = 17
        Label2.Text = "Nombre "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(-1, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 18
        Label3.Text = "Correo"
        ' 
        ' PanelAutorExistente
        ' 
        PanelAutorExistente.Controls.Add(ListaAutorExistente)
        PanelAutorExistente.Controls.Add(LabelVe)
        PanelAutorExistente.Location = New Point(336, 179)
        PanelAutorExistente.Name = "PanelAutorExistente"
        PanelAutorExistente.Size = New Size(390, 83)
        PanelAutorExistente.TabIndex = 48
        ' 
        ' ListaAutorExistente
        ' 
        ListaAutorExistente.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ListaAutorExistente.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaAutorExistente.FormattingEnabled = True
        ListaAutorExistente.Location = New Point(0, 40)
        ListaAutorExistente.Name = "ListaAutorExistente"
        ListaAutorExistente.Size = New Size(391, 33)
        ListaAutorExistente.TabIndex = 41
        ' 
        ' LabelVe
        ' 
        LabelVe.AutoSize = True
        LabelVe.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelVe.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelVe.Location = New Point(-1, 0)
        LabelVe.Name = "LabelVe"
        LabelVe.Size = New Size(64, 25)
        LabelVe.TabIndex = 42
        LabelVe.Text = "Autor"
        ' 
        ' NuevoCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1060, 543)
        Controls.Add(NewClienteBtn)
        Controls.Add(IngresarCliente)
        Controls.Add(PanelAutorExistente)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "NuevoCliente"
        Text = "NuevoCliente"
        IngresarCliente.ResumeLayout(False)
        IngresarCliente.PerformLayout()
        PanelAutorExistente.ResumeLayout(False)
        PanelAutorExistente.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NewClienteBtn As Button
    Friend WithEvents IngresarCliente As Panel
    Friend WithEvents CorreoTb As TextBox
    Friend WithEvents NombreTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelAutorExistente As Panel
    Friend WithEvents ListaAutorExistente As ComboBox
    Friend WithEvents LabelVe As Label
End Class
