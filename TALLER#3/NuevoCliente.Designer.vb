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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        NewClienteBtn = New Button()
        IngresarCliente = New Panel()
        CorreoTb = New TextBox()
        NombreTb = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        IngresarCliente.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(843, 82)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 32)
        Label1.TabIndex = 13
        Label1.Text = "NUEVO CLIENTE"
        ' 
        ' NewClienteBtn
        ' 
        NewClienteBtn.BackColor = Color.FromArgb(CByte(82), CByte(235), CByte(163))
        NewClienteBtn.Cursor = Cursors.Hand
        NewClienteBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        NewClienteBtn.FlatAppearance.BorderSize = 0
        NewClienteBtn.FlatStyle = FlatStyle.Flat
        NewClienteBtn.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NewClienteBtn.ForeColor = Color.White
        NewClienteBtn.Location = New Point(737, 401)
        NewClienteBtn.Name = "NewClienteBtn"
        NewClienteBtn.Size = New Size(439, 51)
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
        IngresarCliente.Location = New Point(737, 179)
        IngresarCliente.Name = "IngresarCliente"
        IngresarCliente.Size = New Size(439, 177)
        IngresarCliente.TabIndex = 47
        ' 
        ' CorreoTb
        ' 
        CorreoTb.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CorreoTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        CorreoTb.Location = New Point(0, 123)
        CorreoTb.Name = "CorreoTb"
        CorreoTb.Size = New Size(439, 32)
        CorreoTb.TabIndex = 14
        ' 
        ' NombreTb
        ' 
        NombreTb.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NombreTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        NombreTb.Location = New Point(0, 33)
        NombreTb.Name = "NombreTb"
        NombreTb.Size = New Size(439, 32)
        NombreTb.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(-1, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 27)
        Label2.TabIndex = 17
        Label2.Text = "Nombre "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(-1, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 27)
        Label3.TabIndex = 18
        Label3.Text = "Correo"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(82, 53)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(554, 482)
        DataGridView1.TabIndex = 49
        ' 
        ' NuevoCliente
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1306, 667)
        Controls.Add(DataGridView1)
        Controls.Add(NewClienteBtn)
        Controls.Add(IngresarCliente)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "NuevoCliente"
        Text = "NuevoCliente"
        IngresarCliente.ResumeLayout(False)
        IngresarCliente.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
End Class
