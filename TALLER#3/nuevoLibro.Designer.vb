<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoLibro
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
        DataGridView1 = New DataGridView()
        textBoxAutor = New TextBox()
        TextBoxPais = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PanelNuevoAutor = New Panel()
        LabelVe = New Label()
        ListaAutorExistente = New ComboBox()
        PanelAutorExistente = New Panel()
        Label3 = New Label()
        TextBoxTítulo = New TextBox()
        BtnIngresar = New Button()
        PanelPanelIngresar = New Panel()
        LabelTítulo = New Label()
        BtnExistente = New Button()
        BtnNuevo = New Button()
        PanelBtnTipoAutor = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelNuevoAutor.SuspendLayout()
        PanelAutorExistente.SuspendLayout()
        PanelPanelIngresar.SuspendLayout()
        PanelBtnTipoAutor.SuspendLayout()
        SuspendLayout()
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
        DataGridView1.Location = New Point(103, 50)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(554, 486)
        DataGridView1.TabIndex = 2
        ' 
        ' textBoxAutor
        ' 
        textBoxAutor.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        textBoxAutor.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        textBoxAutor.Location = New Point(0, 44)
        textBoxAutor.Name = "textBoxAutor"
        textBoxAutor.Size = New Size(439, 36)
        textBoxAutor.TabIndex = 13
        ' 
        ' TextBoxPais
        ' 
        TextBoxPais.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxPais.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxPais.Location = New Point(0, 123)
        TextBoxPais.Name = "TextBoxPais"
        TextBoxPais.Size = New Size(439, 36)
        TextBoxPais.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(-1, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 27)
        Label1.TabIndex = 17
        Label1.Text = "Nombre "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(-1, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 27)
        Label2.TabIndex = 18
        Label2.Text = "País"
        ' 
        ' PanelNuevoAutor
        ' 
        PanelNuevoAutor.Controls.Add(TextBoxPais)
        PanelNuevoAutor.Controls.Add(textBoxAutor)
        PanelNuevoAutor.Controls.Add(Label1)
        PanelNuevoAutor.Controls.Add(Label2)
        PanelNuevoAutor.Location = New Point(739, 170)
        PanelNuevoAutor.Name = "PanelNuevoAutor"
        PanelNuevoAutor.Size = New Size(439, 177)
        PanelNuevoAutor.TabIndex = 39
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
        ' PanelAutorExistente
        ' 
        PanelAutorExistente.Controls.Add(ListaAutorExistente)
        PanelAutorExistente.Controls.Add(LabelVe)
        PanelAutorExistente.Location = New Point(739, 189)
        PanelAutorExistente.Name = "PanelAutorExistente"
        PanelAutorExistente.Size = New Size(439, 87)
        PanelAutorExistente.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(925, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 27)
        Label3.TabIndex = 42
        Label3.Text = "AUTOR"
        ' 
        ' TextBoxTítulo
        ' 
        TextBoxTítulo.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxTítulo.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxTítulo.Location = New Point(1, 38)
        TextBoxTítulo.Name = "TextBoxTítulo"
        TextBoxTítulo.Size = New Size(439, 36)
        TextBoxTítulo.TabIndex = 15
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnIngresar.Cursor = Cursors.Hand
        BtnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnIngresar.FlatAppearance.BorderSize = 0
        BtnIngresar.FlatStyle = FlatStyle.Flat
        BtnIngresar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnIngresar.Location = New Point(1, 101)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(439, 51)
        BtnIngresar.TabIndex = 36
        BtnIngresar.Text = "Ingresar"
        BtnIngresar.UseVisualStyleBackColor = False
        ' 
        ' PanelPanelIngresar
        ' 
        PanelPanelIngresar.Controls.Add(BtnIngresar)
        PanelPanelIngresar.Controls.Add(LabelTítulo)
        PanelPanelIngresar.Controls.Add(TextBoxTítulo)
        PanelPanelIngresar.Location = New Point(738, 356)
        PanelPanelIngresar.Name = "PanelPanelIngresar"
        PanelPanelIngresar.Size = New Size(440, 155)
        PanelPanelIngresar.TabIndex = 41
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTítulo.Location = New Point(0, 0)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(72, 27)
        LabelTítulo.TabIndex = 16
        LabelTítulo.Text = "Título"
        ' 
        ' BtnExistente
        ' 
        BtnExistente.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnExistente.Cursor = Cursors.Hand
        BtnExistente.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnExistente.FlatAppearance.BorderSize = 0
        BtnExistente.FlatStyle = FlatStyle.Flat
        BtnExistente.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnExistente.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnExistente.Location = New Point(15, 5)
        BtnExistente.Name = "BtnExistente"
        BtnExistente.Size = New Size(194, 51)
        BtnExistente.TabIndex = 37
        BtnExistente.Text = "Existente"
        BtnExistente.UseVisualStyleBackColor = False
        ' 
        ' BtnNuevo
        ' 
        BtnNuevo.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnNuevo.Cursor = Cursors.Hand
        BtnNuevo.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnNuevo.FlatAppearance.BorderSize = 0
        BtnNuevo.FlatStyle = FlatStyle.Flat
        BtnNuevo.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNuevo.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnNuevo.Location = New Point(234, 5)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(194, 51)
        BtnNuevo.TabIndex = 38
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = False
        ' 
        ' PanelBtnTipoAutor
        ' 
        PanelBtnTipoAutor.Controls.Add(BtnNuevo)
        PanelBtnTipoAutor.Controls.Add(BtnExistente)
        PanelBtnTipoAutor.Location = New Point(739, 77)
        PanelBtnTipoAutor.Name = "PanelBtnTipoAutor"
        PanelBtnTipoAutor.Size = New Size(439, 62)
        PanelBtnTipoAutor.TabIndex = 40
        ' 
        ' nuevoLibro
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1306, 570)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(PanelNuevoAutor)
        Controls.Add(PanelBtnTipoAutor)
        Controls.Add(PanelAutorExistente)
        Controls.Add(PanelPanelIngresar)
        FormBorderStyle = FormBorderStyle.None
        Name = "nuevoLibro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "nuevoLibro"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelNuevoAutor.ResumeLayout(False)
        PanelNuevoAutor.PerformLayout()
        PanelAutorExistente.ResumeLayout(False)
        PanelAutorExistente.PerformLayout()
        PanelPanelIngresar.ResumeLayout(False)
        PanelPanelIngresar.PerformLayout()
        PanelBtnTipoAutor.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents textBoxAutor As TextBox
    Friend WithEvents TextBoxPais As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelNuevoAutor As Panel
    Friend WithEvents LabelVe As Label
    Friend WithEvents ListaAutorExistente As ComboBox
    Friend WithEvents PanelAutorExistente As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxTítulo As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents PanelPanelIngresar As Panel
    Friend WithEvents LabelTítulo As Label
    Friend WithEvents BtnExistente As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PanelBtnTipoAutor As Panel
End Class
