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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        textBoxAutor = New TextBox()
        TextBoxPais = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PanelNuevoAutor = New Panel()
        PanelAutorExistente = New Panel()
        ListaAutorExistente = New ComboBox()
        LabelVe = New Label()
        Label3 = New Label()
        TextBoxTítulo = New TextBox()
        BtnIngresar = New Button()
        PanelPanelIngresar = New Panel()
        LabelTítulo = New Label()
        BtnExistente = New Button()
        BtnNuevo = New Button()
        PanelBtnTipoAutor = New Panel()
        btnMostrarPanelAutores = New Button()
        PanelIngresoDeAutores = New Panel()
        Panel1 = New Panel()
        listaLibros = New ComboBox()
        Label4 = New Label()
        btnIngresarAutor = New Button()
        DataGridView2 = New DataGridView()
        btnMostrarPanelNuevoLibro = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelNuevoAutor.SuspendLayout()
        PanelAutorExistente.SuspendLayout()
        PanelPanelIngresar.SuspendLayout()
        PanelBtnTipoAutor.SuspendLayout()
        PanelIngresoDeAutores.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.Red
        DataGridViewCellStyle5.Padding = New Padding(5)
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        DataGridView1.Location = New Point(104, 78)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(554, 336)
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
        PanelNuevoAutor.Location = New Point(12, 240)
        PanelNuevoAutor.Name = "PanelNuevoAutor"
        PanelNuevoAutor.Size = New Size(439, 177)
        PanelNuevoAutor.TabIndex = 39
        ' 
        ' PanelAutorExistente
        ' 
        PanelAutorExistente.Controls.Add(ListaAutorExistente)
        PanelAutorExistente.Controls.Add(LabelVe)
        PanelAutorExistente.Location = New Point(13, 291)
        PanelAutorExistente.Name = "PanelAutorExistente"
        PanelAutorExistente.Size = New Size(439, 87)
        PanelAutorExistente.TabIndex = 40
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 27)
        Label3.TabIndex = 42
        Label3.Text = "Ingresar Autores"
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
        BtnIngresar.Location = New Point(1, 117)
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
        PanelPanelIngresar.Location = New Point(743, 59)
        PanelPanelIngresar.Name = "PanelPanelIngresar"
        PanelPanelIngresar.Size = New Size(440, 190)
        PanelPanelIngresar.TabIndex = 41
        ' 
        ' LabelTítulo
        ' 
        LabelTítulo.AutoSize = True
        LabelTítulo.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelTítulo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        LabelTítulo.Location = New Point(0, 0)
        LabelTítulo.Name = "LabelTítulo"
        LabelTítulo.Size = New Size(245, 27)
        LabelTítulo.TabIndex = 16
        LabelTítulo.Text = "Título del Nuevo Libro"
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
        BtnExistente.Location = New Point(2, 49)
        BtnExistente.Name = "BtnExistente"
        BtnExistente.Size = New Size(215, 51)
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
        BtnNuevo.Location = New Point(223, 49)
        BtnNuevo.Name = "BtnNuevo"
        BtnNuevo.Size = New Size(216, 51)
        BtnNuevo.TabIndex = 38
        BtnNuevo.Text = "Nuevo"
        BtnNuevo.UseVisualStyleBackColor = False
        ' 
        ' PanelBtnTipoAutor
        ' 
        PanelBtnTipoAutor.Controls.Add(BtnNuevo)
        PanelBtnTipoAutor.Controls.Add(Label3)
        PanelBtnTipoAutor.Controls.Add(BtnExistente)
        PanelBtnTipoAutor.Location = New Point(14, 9)
        PanelBtnTipoAutor.Name = "PanelBtnTipoAutor"
        PanelBtnTipoAutor.Size = New Size(439, 106)
        PanelBtnTipoAutor.TabIndex = 40
        ' 
        ' btnMostrarPanelAutores
        ' 
        btnMostrarPanelAutores.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        btnMostrarPanelAutores.Cursor = Cursors.Hand
        btnMostrarPanelAutores.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        btnMostrarPanelAutores.FlatAppearance.BorderSize = 0
        btnMostrarPanelAutores.FlatStyle = FlatStyle.Flat
        btnMostrarPanelAutores.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnMostrarPanelAutores.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnMostrarPanelAutores.Location = New Point(744, 269)
        btnMostrarPanelAutores.Name = "btnMostrarPanelAutores"
        btnMostrarPanelAutores.Size = New Size(439, 51)
        btnMostrarPanelAutores.TabIndex = 43
        btnMostrarPanelAutores.Text = "Ingresar Autores"
        btnMostrarPanelAutores.UseVisualStyleBackColor = False
        ' 
        ' PanelIngresoDeAutores
        ' 
        PanelIngresoDeAutores.Controls.Add(PanelNuevoAutor)
        PanelIngresoDeAutores.Controls.Add(Panel1)
        PanelIngresoDeAutores.Controls.Add(btnIngresarAutor)
        PanelIngresoDeAutores.Controls.Add(PanelBtnTipoAutor)
        PanelIngresoDeAutores.Controls.Add(PanelAutorExistente)
        PanelIngresoDeAutores.Location = New Point(730, 314)
        PanelIngresoDeAutores.Name = "PanelIngresoDeAutores"
        PanelIngresoDeAutores.Size = New Size(471, 501)
        PanelIngresoDeAutores.TabIndex = 44
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(listaLibros)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(12, 135)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(439, 87)
        Panel1.TabIndex = 45
        ' 
        ' listaLibros
        ' 
        listaLibros.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        listaLibros.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        listaLibros.FormattingEnabled = True
        listaLibros.Location = New Point(0, 42)
        listaLibros.Name = "listaLibros"
        listaLibros.Size = New Size(439, 33)
        listaLibros.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label4.Location = New Point(-1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 42
        Label4.Text = "Libro"
        ' 
        ' btnIngresarAutor
        ' 
        btnIngresarAutor.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        btnIngresarAutor.Cursor = Cursors.Hand
        btnIngresarAutor.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        btnIngresarAutor.FlatAppearance.BorderSize = 0
        btnIngresarAutor.FlatStyle = FlatStyle.Flat
        btnIngresarAutor.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnIngresarAutor.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnIngresarAutor.Location = New Point(14, 431)
        btnIngresarAutor.Name = "btnIngresarAutor"
        btnIngresarAutor.Size = New Size(439, 51)
        btnIngresarAutor.TabIndex = 44
        btnIngresarAutor.Text = "Ingresar"
        btnIngresarAutor.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = Color.Red
        DataGridViewCellStyle7.Padding = New Padding(5)
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridView2.ColumnHeadersHeight = 50
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Window
        DataGridViewCellStyle8.Font = New Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle8
        DataGridView2.Location = New Point(104, 442)
        DataGridView2.Margin = New Padding(4, 3, 4, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 31
        DataGridView2.Size = New Size(554, 199)
        DataGridView2.TabIndex = 45
        ' 
        ' btnMostrarPanelNuevoLibro
        ' 
        btnMostrarPanelNuevoLibro.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        btnMostrarPanelNuevoLibro.Cursor = Cursors.Hand
        btnMostrarPanelNuevoLibro.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        btnMostrarPanelNuevoLibro.FlatAppearance.BorderSize = 0
        btnMostrarPanelNuevoLibro.FlatStyle = FlatStyle.Flat
        btnMostrarPanelNuevoLibro.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnMostrarPanelNuevoLibro.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnMostrarPanelNuevoLibro.Location = New Point(744, 128)
        btnMostrarPanelNuevoLibro.Name = "btnMostrarPanelNuevoLibro"
        btnMostrarPanelNuevoLibro.Size = New Size(439, 51)
        btnMostrarPanelNuevoLibro.TabIndex = 46
        btnMostrarPanelNuevoLibro.Text = "Ingresar Nuevo Libro"
        btnMostrarPanelNuevoLibro.UseVisualStyleBackColor = False
        ' 
        ' nuevoLibro
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1306, 874)
        Controls.Add(btnMostrarPanelNuevoLibro)
        Controls.Add(PanelIngresoDeAutores)
        Controls.Add(DataGridView2)
        Controls.Add(btnMostrarPanelAutores)
        Controls.Add(DataGridView1)
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
        PanelBtnTipoAutor.PerformLayout()
        PanelIngresoDeAutores.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
    Friend WithEvents btnMostrarPanelAutores As Button
    Friend WithEvents PanelIngresoDeAutores As Panel
    Friend WithEvents btnIngresarAutor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents listaLibros As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnMostrarPanelNuevoLibro As Button
End Class
