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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        Menu = New MenuStrip()
        Archivo = New ToolStripMenuItem()
        archivoP1 = New ToolStripMenuItem()
        archivoP2 = New ToolStripMenuItem()
        ArchivoP4 = New ToolStripMenuItem()
        P3 = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        ayuda = New ToolStripMenuItem()
        TIP = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
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
        DataGridView1.BackgroundColor = Color.WhiteSmoke
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Red
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(26, 316)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1144, 250)
        DataGridView1.TabIndex = 1
        ' 
        ' Menu
        ' 
        Menu.BackColor = Color.Transparent
        Menu.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Menu.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Menu.GripMargin = New Padding(2, 60, 60, 2)
        Menu.ImageScalingSize = New Size(20, 20)
        Menu.Items.AddRange(New ToolStripItem() {Archivo, toolStripSeparator5, ayuda, toolStripSeparator2, version})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Padding = New Padding(0)
        Menu.RenderMode = ToolStripRenderMode.Professional
        Menu.Size = New Size(1192, 48)
        Menu.TabIndex = 10
        Menu.Text = "MenuStrip1"
        ' 
        ' Archivo
        ' 
        Archivo.DropDownItems.AddRange(New ToolStripItem() {archivoP1, archivoP2, ArchivoP4, P3, ToolStripSeparator1, SalirToolStripMenuItem})
        Archivo.Margin = New Padding(20, 0, 0, 0)
        Archivo.Name = "Archivo"
        Archivo.Padding = New Padding(5, 20, 5, 0)
        Archivo.Size = New Size(92, 48)
        Archivo.Text = "Archivo"
        ' 
        ' archivoP1
        ' 
        archivoP1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP1.ImageTransparentColor = Color.Magenta
        archivoP1.Margin = New Padding(0, 20, 0, 0)
        archivoP1.Name = "archivoP1"
        archivoP1.Padding = New Padding(0, 5, 0, 1)
        archivoP1.Size = New Size(224, 32)
        archivoP1.Text = "Inicio"
        ' 
        ' archivoP2
        ' 
        archivoP2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        archivoP2.ImageTransparentColor = Color.Magenta
        archivoP2.Name = "archivoP2"
        archivoP2.Padding = New Padding(0, 5, 0, 1)
        archivoP2.Size = New Size(224, 32)
        archivoP2.Text = "Nuevo Libro"
        ' 
        ' ArchivoP4
        ' 
        ArchivoP4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        ArchivoP4.Name = "ArchivoP4"
        ArchivoP4.Size = New Size(224, 28)
        ArchivoP4.Text = "Nuevo Cliente"
        ' 
        ' P3
        ' 
        P3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        P3.ImageTransparentColor = Color.Magenta
        P3.Name = "P3"
        P3.Padding = New Padding(0, 5, 0, 1)
        P3.Size = New Size(224, 32)
        P3.Text = "Cliente"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(221, 6)
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        SalirToolStripMenuItem.Margin = New Padding(0, 15, 0, 0)
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Padding = New Padding(0, 10, 0, 1)
        SalirToolStripMenuItem.Size = New Size(224, 37)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(6, 43)
        ' 
        ' ayuda
        ' 
        ayuda.DropDownItems.AddRange(New ToolStripItem() {TIP, ToolStripSeparator3, btnEmpresa})
        ayuda.Name = "ayuda"
        ayuda.Padding = New Padding(5, 20, 5, 0)
        ayuda.Size = New Size(81, 48)
        ayuda.Text = "Ayuda"
        ' 
        ' TIP
        ' 
        TIP.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TIP.Margin = New Padding(0, 20, 0, 0)
        TIP.Name = "TIP"
        TIP.Size = New Size(172, 28)
        TIP.Text = "Tip"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(169, 6)
        ' 
        ' btnEmpresa
        ' 
        btnEmpresa.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        btnEmpresa.Name = "btnEmpresa"
        btnEmpresa.Size = New Size(172, 28)
        btnEmpresa.Text = "Empresa"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Margin = New Padding(0, 0, 0, 5)
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(6, 43)
        ' 
        ' version
        ' 
        version.DropDownItems.AddRange(New ToolStripItem() {BuscarToolStripMenuItem})
        version.Name = "version"
        version.Padding = New Padding(5, 20, 5, 0)
        version.Size = New Size(91, 48)
        version.Text = "Version"
        ' 
        ' BuscarToolStripMenuItem
        ' 
        BuscarToolStripMenuItem.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BuscarToolStripMenuItem.Margin = New Padding(0, 20, 0, 0)
        BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        BuscarToolStripMenuItem.Size = New Size(116, 28)
        BuscarToolStripMenuItem.Text = "1.9"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(904, 101)
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
        BtnCerrar.Location = New Point(1124, 10)
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
        BtnMin.Location = New Point(1072, 10)
        BtnMin.Margin = New Padding(4, 3, 4, 3)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(40, 38)
        BtnMin.TabIndex = 13
        BtnMin.TabStop = False
        ' 
        ' ListaMostrar
        ' 
        ListaMostrar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ListaMostrar.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaMostrar.FormattingEnabled = True
        ListaMostrar.Items.AddRange(New Object() {"Libros Prestados", "Libros Devueltos", "Todos"})
        ListaMostrar.Location = New Point(26, 236)
        ListaMostrar.Name = "ListaMostrar"
        ListaMostrar.Size = New Size(359, 35)
        ListaMostrar.TabIndex = 34
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1192, 618)
        Controls.Add(ListaMostrar)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnMin)
        Controls.Add(Label1)
        Controls.Add(Menu)
        Controls.Add(DataGridView1)
        Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
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
    Friend WithEvents TIP As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnEmpresa As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents version As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents ListaMostrar As ComboBox
End Class
