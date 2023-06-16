<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminacion
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
        autorBtn = New Button()
        clienteBtn = New Button()
        DataGridView1 = New DataGridView()
        IdClienteTb = New TextBox()
        IdLb = New Label()
        eliminarBtn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' autorBtn
        ' 
        autorBtn.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        autorBtn.Cursor = Cursors.Hand
        autorBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        autorBtn.FlatAppearance.BorderSize = 0
        autorBtn.FlatStyle = FlatStyle.Flat
        autorBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        autorBtn.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        autorBtn.Location = New Point(948, 182)
        autorBtn.Name = "autorBtn"
        autorBtn.Size = New Size(251, 51)
        autorBtn.TabIndex = 54
        autorBtn.Text = "Autor"
        autorBtn.UseVisualStyleBackColor = False
        ' 
        ' clienteBtn
        ' 
        clienteBtn.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        clienteBtn.Cursor = Cursors.Hand
        clienteBtn.Enabled = False
        clienteBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        clienteBtn.FlatAppearance.BorderSize = 0
        clienteBtn.FlatStyle = FlatStyle.Flat
        clienteBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        clienteBtn.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        clienteBtn.Location = New Point(667, 182)
        clienteBtn.Name = "clienteBtn"
        clienteBtn.Size = New Size(251, 51)
        clienteBtn.TabIndex = 53
        clienteBtn.Text = "Cliente"
        clienteBtn.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.ForeColor = Color.Red
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.GridColor = SystemColors.Control
        DataGridView1.Location = New Point(73, 57)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(534, 454)
        DataGridView1.TabIndex = 55
        ' 
        ' IdClienteTb
        ' 
        IdClienteTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        IdClienteTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        IdClienteTb.Location = New Point(667, 338)
        IdClienteTb.Name = "IdClienteTb"
        IdClienteTb.Size = New Size(251, 36)
        IdClienteTb.TabIndex = 56
        ' 
        ' IdLb
        ' 
        IdLb.AutoSize = True
        IdLb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        IdLb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        IdLb.Location = New Point(667, 295)
        IdLb.Name = "IdLb"
        IdLb.Size = New Size(137, 25)
        IdLb.TabIndex = 57
        IdLb.Text = "ID del cliente"
        ' 
        ' eliminarBtn
        ' 
        eliminarBtn.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        eliminarBtn.Cursor = Cursors.Hand
        eliminarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        eliminarBtn.FlatAppearance.BorderSize = 0
        eliminarBtn.FlatStyle = FlatStyle.Flat
        eliminarBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        eliminarBtn.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        eliminarBtn.Location = New Point(948, 326)
        eliminarBtn.Name = "eliminarBtn"
        eliminarBtn.Size = New Size(251, 51)
        eliminarBtn.TabIndex = 58
        eliminarBtn.Text = "Eliminar"
        eliminarBtn.UseVisualStyleBackColor = False
        ' 
        ' eliminacion
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1306, 549)
        Controls.Add(eliminarBtn)
        Controls.Add(IdClienteTb)
        Controls.Add(IdLb)
        Controls.Add(DataGridView1)
        Controls.Add(autorBtn)
        Controls.Add(clienteBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "eliminacion"
        Text = "eliminacion"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents autorBtn As Button
    Friend WithEvents clienteBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdClienteTb As TextBox
    Friend WithEvents IdLb As Label
    Friend WithEvents eliminarBtn As Button
End Class
