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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        ActualizarBtn = New Button()
        BtnIngresar = New Button()
        ModificarClientesPanel = New Panel()
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
        Label1.Location = New Point(1050, 43)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 29)
        Label1.TabIndex = 12
        Label1.Text = "CLIENTE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.WhiteSmoke
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Red
        DataGridViewCellStyle3.Padding = New Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.Location = New Point(12, 296)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1163, 262)
        DataGridView1.TabIndex = 53
        ' 
        ' ActualizarBtn
        ' 
        ActualizarBtn.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        ActualizarBtn.Cursor = Cursors.Hand
        ActualizarBtn.Enabled = False
        ActualizarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ActualizarBtn.FlatAppearance.BorderSize = 0
        ActualizarBtn.FlatStyle = FlatStyle.Flat
        ActualizarBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ActualizarBtn.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ActualizarBtn.Location = New Point(229, 220)
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
        BtnIngresar.Location = New Point(15, 220)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(162, 51)
        BtnIngresar.TabIndex = 49
        BtnIngresar.Text = "Ingresar"
        BtnIngresar.UseVisualStyleBackColor = False
        ' 
        ' ModificarClientesPanel
        ' 
        ModificarClientesPanel.Controls.Add(EstadoCb)
        ModificarClientesPanel.Controls.Add(ObservacionTb)
        ModificarClientesPanel.Controls.Add(Label4)
        ModificarClientesPanel.Controls.Add(LabelTítulo)
        ModificarClientesPanel.Controls.Add(CostoTb)
        ModificarClientesPanel.Controls.Add(Label3)
        ModificarClientesPanel.Enabled = False
        ModificarClientesPanel.Location = New Point(418, 92)
        ModificarClientesPanel.Name = "ModificarClientesPanel"
        ModificarClientesPanel.Size = New Size(754, 191)
        ModificarClientesPanel.TabIndex = 50
        ' 
        ' EstadoCb
        ' 
        EstadoCb.DropDownStyle = ComboBoxStyle.DropDownList
        EstadoCb.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        EstadoCb.FormattingEnabled = True
        EstadoCb.Location = New Point(561, 49)
        EstadoCb.Name = "EstadoCb"
        EstadoCb.Size = New Size(169, 39)
        EstadoCb.TabIndex = 21
        ' 
        ' ObservacionTb
        ' 
        ObservacionTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        ObservacionTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ObservacionTb.Location = New Point(181, 105)
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
        Label4.Location = New Point(16, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 25)
        Label4.TabIndex = 20
        Label4.Text = "Observación:"
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTítulo.Location = New Point(469, 54)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(86, 25)
        LabelTítulo.TabIndex = 16
        LabelTítulo.Text = "Estado:"
        ' 
        ' CostoTb
        ' 
        CostoTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        CostoTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        CostoTb.Location = New Point(182, 52)
        CostoTb.Name = "CostoTb"
        CostoTb.Size = New Size(214, 36)
        CostoTb.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(90, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 25)
        Label3.TabIndex = 18
        Label3.Text = "Costo:"
        ' 
        ' IdClienteTb
        ' 
        IdClienteTb.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        IdClienteTb.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        IdClienteTb.Location = New Point(229, 102)
        IdClienteTb.Name = "IdClienteTb"
        IdClienteTb.Size = New Size(162, 36)
        IdClienteTb.TabIndex = 47
        ' 
        ' PanelAutorExistente
        ' 
        PanelAutorExistente.Controls.Add(ListaAutorExistente)
        PanelAutorExistente.Controls.Add(LabelVe)
        PanelAutorExistente.Location = New Point(640, 102)
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
        Label2.Location = New Point(33, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 48
        Label2.Text = "ID del cliente:"
        ' 
        ' Cliente
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1192, 570)
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
    Friend WithEvents CostoTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IdClienteTb As TextBox
    Friend WithEvents PanelAutorExistente As Panel
    Friend WithEvents ListaAutorExistente As ComboBox
    Friend WithEvents LabelVe As Label
    Friend WithEvents Label2 As Label
End Class
