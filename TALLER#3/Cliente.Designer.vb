<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        ActualizarBtn = New Button()
        BtnIngresar = New Button()
        ModificarClientesPanel = New Panel()
        libroLb = New Label()
        EstadoCb = New ComboBox()
        ObservacionTb = New TextBox()
        Label4 = New Label()
        LabelTítulo = New Label()
        CostoTb = New TextBox()
        Label3 = New Label()
        IdClienteTb = New TextBox()
        PanelAutorExistente = New Panel()
        ListaAutorExistente = New ComboBox()
        LabelVe = New Label()
        Label2 = New Label()
        FechaDevLb = New Label()
        continuarBtn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ModificarClientesPanel.SuspendLayout()
        PanelAutorExistente.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(1156, 41)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 29)
        Label1.TabIndex = 12
        Label1.Text = "CLIENTE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle4.Padding = New Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.White
        DataGridView1.Location = New Point(40, 558)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1238, 262)
        DataGridView1.TabIndex = 53
        ' 
        ' ActualizarBtn
        ' 
        ActualizarBtn.BackColor = Color.FromArgb(CByte(82), CByte(235), CByte(163))
        ActualizarBtn.Cursor = Cursors.Hand
        ActualizarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ActualizarBtn.FlatAppearance.BorderSize = 0
        ActualizarBtn.FlatStyle = FlatStyle.Flat
        ActualizarBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ActualizarBtn.ForeColor = Color.White
        ActualizarBtn.Location = New Point(299, 371)
        ActualizarBtn.Name = "ActualizarBtn"
        ActualizarBtn.Size = New Size(162, 51)
        ActualizarBtn.TabIndex = 52
        ActualizarBtn.Text = "Actualizar"
        ActualizarBtn.UseVisualStyleBackColor = False
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnIngresar.Cursor = Cursors.Hand
        BtnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnIngresar.FlatAppearance.BorderSize = 0
        BtnIngresar.FlatStyle = FlatStyle.Flat
        BtnIngresar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnIngresar.Location = New Point(104, 371)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(162, 51)
        BtnIngresar.TabIndex = 49
        BtnIngresar.Text = "Seleccionar"
        BtnIngresar.UseVisualStyleBackColor = False
        ' 
        ' ModificarClientesPanel
        ' 
        ModificarClientesPanel.Controls.Add(libroLb)
        ModificarClientesPanel.Controls.Add(EstadoCb)
        ModificarClientesPanel.Controls.Add(ObservacionTb)
        ModificarClientesPanel.Controls.Add(Label4)
        ModificarClientesPanel.Controls.Add(LabelTítulo)
        ModificarClientesPanel.Controls.Add(CostoTb)
        ModificarClientesPanel.Controls.Add(Label3)
        ModificarClientesPanel.Enabled = False
        ModificarClientesPanel.Location = New Point(518, 212)
        ModificarClientesPanel.Name = "ModificarClientesPanel"
        ModificarClientesPanel.Size = New Size(754, 254)
        ModificarClientesPanel.TabIndex = 50
        ' 
        ' libroLb
        ' 
        libroLb.AutoSize = True
        libroLb.Enabled = False
        libroLb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        libroLb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        libroLb.Location = New Point(16, 26)
        libroLb.Name = "libroLb"
        libroLb.Size = New Size(60, 25)
        libroLb.TabIndex = 49
        libroLb.Text = "Libro"
        ' 
        ' EstadoCb
        ' 
        EstadoCb.DropDownStyle = ComboBoxStyle.DropDownList
        EstadoCb.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        EstadoCb.FormattingEnabled = True
        EstadoCb.Location = New Point(561, 86)
        EstadoCb.Name = "EstadoCb"
        EstadoCb.Size = New Size(169, 39)
        EstadoCb.TabIndex = 21
        ' 
        ' ObservacionTb
        ' 
        ObservacionTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        ObservacionTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ObservacionTb.Location = New Point(181, 165)
        ObservacionTb.Multiline = True
        ObservacionTb.Name = "ObservacionTb"
        ObservacionTb.Size = New Size(552, 68)
        ObservacionTb.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label4.Location = New Point(16, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 25)
        Label4.TabIndex = 20
        Label4.Text = "Observación"
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTítulo.Location = New Point(469, 91)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(79, 25)
        LabelTítulo.TabIndex = 16
        LabelTítulo.Text = "Estado"
        ' 
        ' CostoTb
        ' 
        CostoTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        CostoTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        CostoTb.Location = New Point(182, 89)
        CostoTb.Name = "CostoTb"
        CostoTb.Size = New Size(214, 36)
        CostoTb.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(81, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 18
        Label3.Text = "Costo"
        ' 
        ' IdClienteTb
        ' 
        IdClienteTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        IdClienteTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        IdClienteTb.Location = New Point(299, 253)
        IdClienteTb.Name = "IdClienteTb"
        IdClienteTb.Size = New Size(162, 36)
        IdClienteTb.TabIndex = 47
        ' 
        ' PanelAutorExistente
        ' 
        PanelAutorExistente.Controls.Add(ListaAutorExistente)
        PanelAutorExistente.Controls.Add(LabelVe)
        PanelAutorExistente.Location = New Point(639, 211)
        PanelAutorExistente.Name = "PanelAutorExistente"
        PanelAutorExistente.Size = New Size(439, 87)
        PanelAutorExistente.TabIndex = 51
        ' 
        ' ListaAutorExistente
        ' 
        ListaAutorExistente.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ListaAutorExistente.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaAutorExistente.FormattingEnabled = True
        ListaAutorExistente.Location = New Point(0, 42)
        ListaAutorExistente.Name = "ListaAutorExistente"
        ListaAutorExistente.Size = New Size(439, 33)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(104, 260)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 25)
        Label2.TabIndex = 48
        Label2.Text = "ID Préstamo"
        ' 
        ' FechaDevLb
        ' 
        FechaDevLb.AutoSize = True
        FechaDevLb.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FechaDevLb.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        FechaDevLb.Location = New Point(397, 117)
        FechaDevLb.Name = "FechaDevLb"
        FechaDevLb.Padding = New Padding(5)
        FechaDevLb.Size = New Size(199, 35)
        FechaDevLb.TabIndex = 54
        FechaDevLb.Text = "Fecha devolucion:"
        FechaDevLb.Visible = False
        ' 
        ' continuarBtn
        ' 
        continuarBtn.BackColor = Color.FromArgb(CByte(255), CByte(115), CByte(115))
        continuarBtn.Cursor = Cursors.Hand
        continuarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        continuarBtn.FlatAppearance.BorderSize = 0
        continuarBtn.FlatStyle = FlatStyle.Flat
        continuarBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        continuarBtn.ForeColor = Color.White
        continuarBtn.Location = New Point(1142, 114)
        continuarBtn.Name = "continuarBtn"
        continuarBtn.Size = New Size(129, 36)
        continuarBtn.TabIndex = 57
        continuarBtn.Text = "Continuar"
        continuarBtn.UseVisualStyleBackColor = False
        continuarBtn.Visible = False
        ' 
        ' Cliente
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1306, 843)
        Controls.Add(continuarBtn)
        Controls.Add(FechaDevLb)
        Controls.Add(DataGridView1)
        Controls.Add(ActualizarBtn)
        Controls.Add(BtnIngresar)
        Controls.Add(ModificarClientesPanel)
        Controls.Add(IdClienteTb)
        Controls.Add(PanelAutorExistente)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Cliente"
        Text = "CLIENTE"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ModificarClientesPanel.ResumeLayout(False)
        ModificarClientesPanel.PerformLayout()
        PanelAutorExistente.ResumeLayout(False)
        PanelAutorExistente.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ActualizarBtn As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents ModificarClientesPanel As Panel
    Friend WithEvents EstadoCb As ComboBox
    Friend WithEvents ObservacionTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTítulo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IdClienteTb As TextBox
    Friend WithEvents PanelAutorExistente As Panel
    Friend WithEvents ListaAutorExistente As ComboBox
    Friend WithEvents LabelVe As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FechaDevLb As Label
    Friend WithEvents libroLb As Label
    Friend WithEvents continuarBtn As Button
    Friend WithEvents CostoTb As TextBox
End Class
