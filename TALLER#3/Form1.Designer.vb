<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        Menu = New MenuStrip()
        Archivo = New ToolStripMenuItem()
        archivoP1 = New ToolStripMenuItem()
        archivoP2 = New ToolStripMenuItem()
        ArchivoP4 = New ToolStripMenuItem()
        P3 = New ToolStripMenuItem()
        ArchivoPrestamo = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        ayuda = New ToolStripMenuItem()
        btnEmpresa = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        version = New ToolStripMenuItem()
        BuscarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        BtnCerrar = New PictureBox()
        BtnMin = New PictureBox()
        ListaMostrar = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Menu.SuspendLayout()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnMin, ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
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
        DataGridView1.Location = New Point(31, 316)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1242, 250)
        DataGridView1.TabIndex = 1
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.Transparent
        Menu.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Menu.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Menu.GripMargin = New Padding(2, 60, 60, 2)
        Menu.ImageScalingSize = New Size(20, 20)
        Menu.Items.AddRange(New ToolStripItem() {Archivo, toolStripSeparator5, ayuda, toolStripSeparator2, version})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Padding = New Padding(0)
        Menu.RenderMode = ToolStripRenderMode.Professional
        Menu.Size = New Size(1306, 49)
        Menu.TabIndex = 10
        Menu.Text = "MenuStrip1"
        ' 
        ' Archivo
        ' 
        Archivo.DropDownItems.AddRange(New ToolStripItem() {archivoP1, archivoP2, ArchivoP4, P3, ArchivoPrestamo, EliminarToolStripMenuItem, ToolStripSeparator1, SalirToolStripMenuItem})
        Archivo.Margin = New Padding(20, 0, 0, 0)
        Archivo.Name = "Archivo"
        Archivo.Padding = New Padding(5, 20, 5, 0)
        Archivo.Size = New Size(99, 49)
        Archivo.Text = "Archivo"
        ' 
        ' archivoP1
        ' 
        archivoP1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP1.ImageTransparentColor = Color.Magenta
        archivoP1.Margin = New Padding(0, 20, 0, 0)
        archivoP1.Name = "archivoP1"
        archivoP1.Padding = New Padding(0, 5, 0, 1)
        archivoP1.Size = New Size(256, 34)
        archivoP1.Text = "Inicio"
        ' 
        ' archivoP2
        ' 
        archivoP2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP2.ImageTransparentColor = Color.Magenta
        archivoP2.Name = "archivoP2"
        archivoP2.Padding = New Padding(0, 5, 0, 1)
        archivoP2.Size = New Size(256, 34)
        archivoP2.Text = "Nuevo Libro"
        ' 
        ' ArchivoP4
        ' 
        ArchivoP4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ArchivoP4.Name = "ArchivoP4"
        ArchivoP4.Size = New Size(256, 30)
        ArchivoP4.Text = "Nuevo Cliente"
        ' 
        ' P3
        ' 
        P3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        P3.ImageTransparentColor = Color.Magenta
        P3.Name = "P3"
        P3.Padding = New Padding(0, 5, 0, 1)
        P3.Size = New Size(256, 34)
        P3.Text = "Cliente"
        ' 
        ' ArchivoPrestamo
        ' 
        ArchivoPrestamo.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ArchivoPrestamo.Name = "ArchivoPrestamo"
        ArchivoPrestamo.Size = New Size(256, 30)
        ArchivoPrestamo.Text = "Nuevo Préstamo"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(256, 30)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(253, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        SalirToolStripMenuItem.Margin = New Padding(0, 15, 0, 0)
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Padding = New Padding(0, 10, 0, 1)
        SalirToolStripMenuItem.Size = New Size(256, 39)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(6, 44)
        ' 
        ' ayuda
        ' 
        ayuda.DropDownItems.AddRange(New ToolStripItem() {btnEmpresa})
        ayuda.Name = "ayuda"
        ayuda.Padding = New Padding(5, 20, 5, 0)
        ayuda.Size = New Size(85, 49)
        ayuda.Text = "Ayuda"
        ' 
        ' btnEmpresa
        ' 
        btnEmpresa.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnEmpresa.Name = "btnEmpresa"
        btnEmpresa.Size = New Size(224, 30)
        btnEmpresa.Text = "Empresa"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 44)
        ' 
        ' version
        ' 
        version.DropDownItems.AddRange(New ToolStripItem() {BuscarToolStripMenuItem})
        version.Name = "version"
        version.Padding = New Padding(5, 20, 5, 0)
        version.Size = New Size(96, 49)
        version.Text = "Version"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BuscarToolStripMenuItem.Margin = New Padding(0, 20, 0, 0)
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.Size = New Size(224, 30)
        BuscarToolStripMenuItem.Text = "5.5"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(1075, 87)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 32)
        Label1.TabIndex = 11
        Label1.Text = "VISTA GENERAL"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), Image)
        BtnCerrar.Cursor = Cursors.Hand
        BtnCerrar.Location = New Point(1243, 10)
        BtnCerrar.Margin = New Padding(4, 3, 4, 3)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(40, 38)
        BtnCerrar.TabIndex = 12
        BtnCerrar.TabStop = False
        ' 
        ' BtnMin
        ' 
        BtnMin.Cursor = Cursors.Hand
        BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), Image)
        BtnMin.Location = New Point(1191, 10)
        BtnMin.Margin = New Padding(4, 3, 4, 3)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(40, 38)
        BtnMin.TabIndex = 13
        BtnMin.TabStop = False
        ' 
        ' ListaMostrar
        ' 
        ListaMostrar.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        ListaMostrar.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaMostrar.FormattingEnabled = True
        ListaMostrar.Items.AddRange(New Object() {"Libros Prestados", "Libros Devueltos", "Todos"})
        ListaMostrar.Location = New Point(26, 236)
        ListaMostrar.Name = "ListaMostrar"
        ListaMostrar.Size = New Size(359, 33)
        ListaMostrar.TabIndex = 34
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1306, 617)
        Controls.Add(ListaMostrar)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnMin)
        Controls.Add(Label1)
        Controls.Add(Menu)
        Controls.Add(DataGridView1)
        Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        CType(BtnCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnMin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents Archivo As ToolStripMenuItem
    Friend WithEvents archivoP1 As ToolStripMenuItem
    Friend WithEvents archivoP2 As ToolStripMenuItem
    Friend WithEvents P3 As ToolStripMenuItem
    Friend WithEvents ArchivoP4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ayuda As ToolStripMenuItem
    Friend WithEvents btnEmpresa As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents version As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents ListaMostrar As ComboBox
    Friend WithEvents ArchivoPrestamo As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
