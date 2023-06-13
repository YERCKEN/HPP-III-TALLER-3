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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        TextBoxBusquedad = New TextBox()
        Label2 = New Label()
        PanelSeleccionId = New Panel()
        panelIngresoDatos2 = New Panel()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        TextBox3 = New TextBox()
        BtnSeleccionar = New Button()
        panelIngresoDatos = New Panel()
        EstadoCb = New ComboBox()
        ObservacionTb = New TextBox()
        Label4 = New Label()
        LabelTítulo = New Label()
        CostoTb = New TextBox()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        PanelSeleccionId.SuspendLayout()
        panelIngresoDatos2.SuspendLayout()
        panelIngresoDatos.SuspendLayout()
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
        DataGridView1.Location = New Point(23, 308)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1144, 250)
        DataGridView1.TabIndex = 13
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.WhiteSmoke
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.Red
        DataGridViewCellStyle3.Padding = New Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView2.ColumnHeadersHeight = 40
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        DataGridView2.Location = New Point(507, 27)
        DataGridView2.Margin = New Padding(4, 3, 4, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 31
        DataGridView2.Size = New Size(432, 101)
        DataGridView2.TabIndex = 14
        ' 
        ' TextBoxBusquedad
        ' 
        TextBoxBusquedad.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxBusquedad.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxBusquedad.Location = New Point(147, 13)
        TextBoxBusquedad.Name = "TextBoxBusquedad"
        TextBoxBusquedad.Size = New Size(282, 36)
        TextBoxBusquedad.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label2.Location = New Point(86, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 25)
        Label2.TabIndex = 49
        Label2.Text = "ID"
        ' 
        ' PanelSeleccionId
        ' 
        PanelSeleccionId.Controls.Add(panelIngresoDatos2)
        PanelSeleccionId.Controls.Add(Label8)
        PanelSeleccionId.Controls.Add(TextBox3)
        PanelSeleccionId.Controls.Add(BtnSeleccionar)
        PanelSeleccionId.Controls.Add(Label2)
        PanelSeleccionId.Controls.Add(DataGridView2)
        PanelSeleccionId.Controls.Add(TextBoxBusquedad)
        PanelSeleccionId.Location = New Point(23, 92)
        PanelSeleccionId.Name = "PanelSeleccionId"
        PanelSeleccionId.Size = New Size(961, 210)
        PanelSeleccionId.TabIndex = 50
        ' 
        ' panelIngresoDatos2
        ' 
        panelIngresoDatos2.Controls.Add(ComboBox1)
        panelIngresoDatos2.Controls.Add(TextBox1)
        panelIngresoDatos2.Controls.Add(Label5)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(TextBox2)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Enabled = False
        panelIngresoDatos2.Location = New Point(350, 40)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(754, 191)
        panelIngresoDatos2.TabIndex = 52
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(561, 49)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(169, 39)
        ComboBox1.TabIndex = 21
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBox1.Location = New Point(181, 105)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(552, 68)
        TextBox1.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label5.Location = New Point(16, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 25)
        Label5.TabIndex = 20
        Label5.Text = "Observación:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label6.Location = New Point(469, 54)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 25)
        Label6.TabIndex = 16
        Label6.Text = "Estado:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBox2.Location = New Point(182, 52)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(214, 36)
        TextBox2.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label7.Location = New Point(90, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 25)
        Label7.TabIndex = 18
        Label7.Text = "Costo:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label8.Location = New Point(32, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 25)
        Label8.TabIndex = 54
        Label8.Text = "Nombre"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBox3.Location = New Point(147, 90)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(136, 36)
        TextBox3.TabIndex = 53
        ' 
        ' BtnSeleccionar
        ' 
        BtnSeleccionar.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSeleccionar.Cursor = Cursors.Hand
        BtnSeleccionar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSeleccionar.FlatAppearance.BorderSize = 0
        BtnSeleccionar.FlatStyle = FlatStyle.Flat
        BtnSeleccionar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSeleccionar.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSeleccionar.Location = New Point(289, 84)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(140, 51)
        BtnSeleccionar.TabIndex = 52
        BtnSeleccionar.Text = "Seleccionar"
        BtnSeleccionar.UseVisualStyleBackColor = False
        ' 
        ' panelIngresoDatos
        ' 
        panelIngresoDatos.Controls.Add(EstadoCb)
        panelIngresoDatos.Controls.Add(ObservacionTb)
        panelIngresoDatos.Controls.Add(Label4)
        panelIngresoDatos.Controls.Add(LabelTítulo)
        panelIngresoDatos.Controls.Add(CostoTb)
        panelIngresoDatos.Controls.Add(Label3)
        panelIngresoDatos.Enabled = False
        panelIngresoDatos.Location = New Point(357, 329)
        panelIngresoDatos.Name = "panelIngresoDatos"
        panelIngresoDatos.Size = New Size(754, 191)
        panelIngresoDatos.TabIndex = 51
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
        ' nuevoPrestamo
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1192, 570)
        Controls.Add(DataGridView1)
        Controls.Add(panelIngresoDatos)
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
        panelIngresoDatos.ResumeLayout(False)
        panelIngresoDatos.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBoxBusquedad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelSeleccionId As Panel
    Friend WithEvents panelIngresoDatos As Panel
    Friend WithEvents EstadoCb As ComboBox
    Friend WithEvents ObservacionTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTítulo As Label
    Friend WithEvents CostoTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
