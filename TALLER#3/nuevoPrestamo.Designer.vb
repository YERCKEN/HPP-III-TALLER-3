<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoPrestamo
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        TextBoxBusquedad = New TextBox()
        Label2 = New Label()
        PanelSeleccionId = New Panel()
        Label8 = New Label()
        TextBoxId = New TextBox()
        BtnSeleccionar = New Button()
        panelIngresoDatos2 = New Panel()
        ListaMostrarLibros = New ComboBox()
        BtnVolver = New Button()
        NewClienteBtn = New Button()
        TextBoxObservacion = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBoxCosto = New TextBox()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        PanelSeleccionId.SuspendLayout()
        panelIngresoDatos2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(1017, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 32)
        Label1.TabIndex = 12
        Label1.Text = "PRESTAMO"
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
        DataGridView1.Location = New Point(23, 356)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1144, 250)
        DataGridView1.TabIndex = 13
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.WhiteSmoke
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.Red
        DataGridViewCellStyle4.Padding = New Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView2.ColumnHeadersHeight = 40
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView2.GridColor = Color.Silver
        DataGridView2.Location = New Point(378, 36)
        DataGridView2.Margin = New Padding(4, 3, 4, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 31
        DataGridView2.Size = New Size(466, 120)
        DataGridView2.TabIndex = 14
        ' 
        ' TextBoxBusquedad
        ' 
        TextBoxBusquedad.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxBusquedad.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxBusquedad.Location = New Point(3, 36)
        TextBoxBusquedad.Name = "TextBoxBusquedad"
        TextBoxBusquedad.Size = New Size(282, 36)
        TextBoxBusquedad.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(3, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 25)
        Label2.TabIndex = 49
        Label2.Text = "ID"
        ' 
        ' PanelSeleccionId
        ' 
        PanelSeleccionId.Controls.Add(Label8)
        PanelSeleccionId.Controls.Add(TextBoxId)
        PanelSeleccionId.Controls.Add(BtnSeleccionar)
        PanelSeleccionId.Controls.Add(Label2)
        PanelSeleccionId.Controls.Add(DataGridView2)
        PanelSeleccionId.Controls.Add(TextBoxBusquedad)
        PanelSeleccionId.Location = New Point(160, 91)
        PanelSeleccionId.Name = "PanelSeleccionId"
        PanelSeleccionId.Size = New Size(859, 169)
        PanelSeleccionId.TabIndex = 50
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label8.Location = New Point(3, 8)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 25)
        Label8.TabIndex = 54
        Label8.Text = "Nombre"
        ' 
        ' TextBoxId
        ' 
        TextBoxId.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxId.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxId.Location = New Point(3, 117)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.Size = New Size(136, 36)
        TextBoxId.TabIndex = 53
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSeleccionar.Cursor = Cursors.Hand
        BtnSeleccionar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSeleccionar.FlatAppearance.BorderSize = 0
        BtnSeleccionar.FlatStyle = FlatStyle.Flat
        BtnSeleccionar.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSeleccionar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSeleccionar.Location = New Point(145, 117)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(50, 36)
        BtnSeleccionar.TabIndex = 52
        BtnSeleccionar.Text = "✓"
        BtnSeleccionar.UseVisualStyleBackColor = False
        ' 
        ' panelIngresoDatos2
        ' 
        panelIngresoDatos2.Controls.Add(ListaMostrarLibros)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(NewClienteBtn)
        panelIngresoDatos2.Controls.Add(TextBoxObservacion)
        panelIngresoDatos2.Controls.Add(Label5)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(TextBoxCosto)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Location = New Point(173, 92)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(859, 191)
        panelIngresoDatos2.TabIndex = 52
        ' 
        ' ListaMostrarLibros
        ' 
        ListaMostrarLibros.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ListaMostrarLibros.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaMostrarLibros.FormattingEnabled = True
        ListaMostrarLibros.Items.AddRange(New Object() {"Libros Prestados", "Libros Devueltos", "Todos"})
        ListaMostrarLibros.Location = New Point(243, 36)
        ListaMostrarLibros.Name = "ListaMostrarLibros"
        ListaMostrarLibros.Size = New Size(370, 32)
        ListaMostrarLibros.TabIndex = 49
        ' 
        ' BtnVolver
        ' 
        BtnVolver.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnVolver.Cursor = Cursors.Hand
        BtnVolver.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnVolver.FlatAppearance.BorderSize = 0
        BtnVolver.FlatStyle = FlatStyle.Flat
        BtnVolver.Font = New Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnVolver.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnVolver.Location = New Point(710, 115)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(87, 68)
        BtnVolver.TabIndex = 48
        BtnVolver.Text = "🔙"
        BtnVolver.UseVisualStyleBackColor = False
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
        NewClienteBtn.Location = New Point(658, 29)
        NewClienteBtn.Name = "NewClienteBtn"
        NewClienteBtn.Size = New Size(185, 51)
        NewClienteBtn.TabIndex = 47
        NewClienteBtn.Text = "Ingresar"
        NewClienteBtn.UseVisualStyleBackColor = False
        ' 
        ' TextBoxObservacion
        ' 
        TextBoxObservacion.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxObservacion.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxObservacion.Location = New Point(5, 115)
        TextBoxObservacion.Multiline = True
        TextBoxObservacion.Name = "TextBoxObservacion"
        TextBoxObservacion.Size = New Size(608, 68)
        TextBoxObservacion.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label5.Location = New Point(5, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 25)
        Label5.TabIndex = 20
        Label5.Text = "Observación"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label6.Location = New Point(243, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 25)
        Label6.TabIndex = 16
        Label6.Text = "Libro"
        ' 
        ' TextBoxCosto
        ' 
        TextBoxCosto.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxCosto.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxCosto.Location = New Point(5, 31)
        TextBoxCosto.Name = "TextBoxCosto"
        TextBoxCosto.Size = New Size(214, 36)
        TextBoxCosto.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label7.Location = New Point(5, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 25)
        Label7.TabIndex = 18
        Label7.Text = "Costo"
        ' 
        ' nuevoPrestamo
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1192, 613)
        Controls.Add(panelIngresoDatos2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(PanelSeleccionId)
        FormBorderStyle = FormBorderStyle.None
        Name = "nuevoPrestamo"
        Text = "nuevoPrestamo"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        PanelSeleccionId.ResumeLayout(False)
        PanelSeleccionId.PerformLayout()
        panelIngresoDatos2.ResumeLayout(False)
        panelIngresoDatos2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBoxBusquedad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelSeleccionId As Panel
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents TextBoxObservacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCosto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents NewClienteBtn As Button
    Friend WithEvents ListaMostrarLibros As ComboBox
End Class
