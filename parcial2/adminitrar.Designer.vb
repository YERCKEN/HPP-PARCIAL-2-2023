<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminitrar
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(adminitrar))
        panelIngresoDatos2 = New Panel()
        LabelUsuario = New Label()
        LabelId = New Label()
        Label8 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBoxCostoFinal = New TextBox()
        Label4 = New Label()
        TextBoxCostoInicial = New TextBox()
        Label3 = New Label()
        ListaEstado = New ComboBox()
        Label2 = New Label()
        ListaTipoSoporte = New ComboBox()
        BtnVolver = New Button()
        BtnIngresarNuevoTicket = New Button()
        TextBoxObservacion = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        TextBoxEquipo = New TextBox()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        PanelBotones = New Panel()
        BtnEliminar = New Button()
        BtnActualizar = New Button()
        BtnAceptar = New Button()
        PanelSelecion = New Panel()
        BtnSalirSeleccion = New Button()
        TextBoxId = New TextBox()
        BtnSeleccionar = New Button()
        Label9 = New Label()
        LabelActividad = New Label()
        PictureBox1 = New PictureBox()
        PanelConfirmación = New Panel()
        BtnAceptarEliminacion = New Button()
        BtnCancelar = New Button()
        LabelIncorrecto = New Label()
        panelIngresoDatos2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelBotones.SuspendLayout()
        PanelSelecion.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelConfirmación.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelIngresoDatos2
        ' 
        panelIngresoDatos2.Controls.Add(LabelUsuario)
        panelIngresoDatos2.Controls.Add(LabelId)
        panelIngresoDatos2.Controls.Add(Label8)
        panelIngresoDatos2.Controls.Add(DateTimePicker1)
        panelIngresoDatos2.Controls.Add(TextBoxCostoFinal)
        panelIngresoDatos2.Controls.Add(Label4)
        panelIngresoDatos2.Controls.Add(TextBoxCostoInicial)
        panelIngresoDatos2.Controls.Add(Label3)
        panelIngresoDatos2.Controls.Add(ListaEstado)
        panelIngresoDatos2.Controls.Add(Label2)
        panelIngresoDatos2.Controls.Add(ListaTipoSoporte)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(BtnIngresarNuevoTicket)
        panelIngresoDatos2.Controls.Add(TextBoxObservacion)
        panelIngresoDatos2.Controls.Add(Label1)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(TextBoxEquipo)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Location = New Point(41, 33)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(760, 455)
        panelIngresoDatos2.TabIndex = 60
        panelIngresoDatos2.Visible = False
        ' 
        ' LabelUsuario
        ' 
        LabelUsuario.AutoSize = True
        LabelUsuario.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelUsuario.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        LabelUsuario.Location = New Point(80, 23)
        LabelUsuario.Name = "LabelUsuario"
        LabelUsuario.Size = New Size(115, 35)
        LabelUsuario.TabIndex = 60
        LabelUsuario.Text = "Usuario"
        ' 
        ' LabelId
        ' 
        LabelId.AutoSize = True
        LabelId.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelId.ForeColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        LabelId.Location = New Point(0, 23)
        LabelId.Name = "LabelId"
        LabelId.Size = New Size(44, 35)
        LabelId.TabIndex = 59
        LabelId.Text = "ID"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label8.Location = New Point(506, 115)
        Label8.Name = "Label8"
        Label8.Size = New Size(240, 27)
        Label8.TabIndex = 58
        Label8.Text = "Fecha de Finalización"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CalendarForeColor = Color.Gray
        DateTimePicker1.CalendarTitleBackColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker1.CalendarTitleForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(506, 163)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(183, 30)
        DateTimePicker1.TabIndex = 57
        ' 
        ' TextBoxCostoFinal
        ' 
        TextBoxCostoFinal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCostoFinal.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxCostoFinal.Location = New Point(506, 281)
        TextBoxCostoFinal.Name = "TextBoxCostoFinal"
        TextBoxCostoFinal.Size = New Size(183, 30)
        TextBoxCostoFinal.TabIndex = 54
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label4.Location = New Point(506, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 27)
        Label4.TabIndex = 55
        Label4.Text = "Costo Final"
        ' 
        ' TextBoxCostoInicial
        ' 
        TextBoxCostoInicial.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCostoInicial.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxCostoInicial.Location = New Point(259, 284)
        TextBoxCostoInicial.Name = "TextBoxCostoInicial"
        TextBoxCostoInicial.Size = New Size(207, 30)
        TextBoxCostoInicial.TabIndex = 52
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label3.Location = New Point(259, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 27)
        Label3.TabIndex = 53
        Label3.Text = "Costo Inicial"
        ' 
        ' ListaEstado
        ' 
        ListaEstado.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaEstado.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaEstado.FormattingEnabled = True
        ListaEstado.Items.AddRange(New Object() {"En espera", "En proceso", "Terminado"})
        ListaEstado.Location = New Point(3, 281)
        ListaEstado.Name = "ListaEstado"
        ListaEstado.Size = New Size(206, 33)
        ListaEstado.TabIndex = 51
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label2.Location = New Point(3, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 27)
        Label2.TabIndex = 50
        Label2.Text = "Estado"
        ' 
        ' ListaTipoSoporte
        ' 
        ListaTipoSoporte.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaTipoSoporte.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaTipoSoporte.FormattingEnabled = True
        ListaTipoSoporte.Items.AddRange(New Object() {"Preventivo", "Correctivo", "Predictivo"})
        ListaTipoSoporte.Location = New Point(3, 166)
        ListaTipoSoporte.Name = "ListaTipoSoporte"
        ListaTipoSoporte.Size = New Size(206, 33)
        ListaTipoSoporte.TabIndex = 49
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
        BtnVolver.Location = New Point(657, 379)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(87, 68)
        BtnVolver.TabIndex = 48
        BtnVolver.Text = "🔙"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' BtnIngresarNuevoTicket
        ' 
        BtnIngresarNuevoTicket.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnIngresarNuevoTicket.Cursor = Cursors.Hand
        BtnIngresarNuevoTicket.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnIngresarNuevoTicket.FlatAppearance.BorderSize = 0
        BtnIngresarNuevoTicket.FlatStyle = FlatStyle.Flat
        BtnIngresarNuevoTicket.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnIngresarNuevoTicket.ForeColor = Color.White
        BtnIngresarNuevoTicket.Location = New Point(472, 379)
        BtnIngresarNuevoTicket.Name = "BtnIngresarNuevoTicket"
        BtnIngresarNuevoTicket.Size = New Size(179, 68)
        BtnIngresarNuevoTicket.TabIndex = 47
        BtnIngresarNuevoTicket.Text = "Actualizar Datos"
        BtnIngresarNuevoTicket.UseVisualStyleBackColor = False
        ' 
        ' TextBoxObservacion
        ' 
        TextBoxObservacion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxObservacion.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxObservacion.Location = New Point(0, 379)
        TextBoxObservacion.Multiline = True
        TextBoxObservacion.Name = "TextBoxObservacion"
        TextBoxObservacion.Size = New Size(466, 71)
        TextBoxObservacion.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(-1, 334)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 27)
        Label1.TabIndex = 20
        Label1.Text = "Observación"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label6.Location = New Point(3, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(180, 27)
        Label6.TabIndex = 16
        Label6.Text = "Tipo de Soporte"
        ' 
        ' TextBoxEquipo
        ' 
        TextBoxEquipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxEquipo.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxEquipo.Location = New Point(259, 166)
        TextBoxEquipo.Name = "TextBoxEquipo"
        TextBoxEquipo.Size = New Size(207, 30)
        TextBoxEquipo.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label7.Location = New Point(259, 121)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 27)
        Label7.TabIndex = 18
        Label7.Text = "Equipo"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        DataGridViewCellStyle1.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
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
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(41, 549)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1204, 318)
        DataGridView1.TabIndex = 61
        ' 
        ' PanelBotones
        ' 
        PanelBotones.Controls.Add(BtnEliminar)
        PanelBotones.Controls.Add(BtnActualizar)
        PanelBotones.Controls.Add(BtnAceptar)
        PanelBotones.Location = New Point(172, 160)
        PanelBotones.Name = "PanelBotones"
        PanelBotones.Size = New Size(425, 199)
        PanelBotones.TabIndex = 67
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.BackColor = Color.FromArgb(CByte(250), CByte(80), CByte(80))
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnEliminar.FlatAppearance.BorderSize = 0
        BtnEliminar.FlatStyle = FlatStyle.Flat
        BtnEliminar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnEliminar.ForeColor = Color.White
        BtnEliminar.Location = New Point(19, 118)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(369, 68)
        BtnEliminar.TabIndex = 50
        BtnEliminar.Text = "Eliminar Ticket"
        BtnEliminar.UseVisualStyleBackColor = False
        ' 
        ' BtnActualizar
        ' 
        BtnActualizar.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnActualizar.Cursor = Cursors.Hand
        BtnActualizar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnActualizar.FlatAppearance.BorderSize = 0
        BtnActualizar.FlatStyle = FlatStyle.Flat
        BtnActualizar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnActualizar.ForeColor = Color.White
        BtnActualizar.Location = New Point(221, 23)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(167, 68)
        BtnActualizar.TabIndex = 49
        BtnActualizar.Text = "Actualizar Ticket"
        BtnActualizar.UseVisualStyleBackColor = False
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.BackColor = Color.FromArgb(CByte(0), CByte(171), CByte(118))
        BtnAceptar.Cursor = Cursors.Hand
        BtnAceptar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnAceptar.FlatAppearance.BorderSize = 0
        BtnAceptar.FlatStyle = FlatStyle.Flat
        BtnAceptar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAceptar.ForeColor = Color.White
        BtnAceptar.Location = New Point(19, 19)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(169, 68)
        BtnAceptar.TabIndex = 48
        BtnAceptar.Text = "Aceptar Ticket"
        BtnAceptar.UseVisualStyleBackColor = False
        ' 
        ' PanelSelecion
        ' 
        PanelSelecion.Controls.Add(BtnSalirSeleccion)
        PanelSelecion.Controls.Add(TextBoxId)
        PanelSelecion.Controls.Add(BtnSeleccionar)
        PanelSelecion.Controls.Add(Label9)
        PanelSelecion.Location = New Point(172, 219)
        PanelSelecion.Name = "PanelSelecion"
        PanelSelecion.Size = New Size(425, 96)
        PanelSelecion.TabIndex = 68
        PanelSelecion.Visible = False
        ' 
        ' BtnSalirSeleccion
        ' 
        BtnSalirSeleccion.BackColor = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        BtnSalirSeleccion.Cursor = Cursors.Hand
        BtnSalirSeleccion.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnSalirSeleccion.FlatAppearance.BorderSize = 0
        BtnSalirSeleccion.FlatStyle = FlatStyle.Flat
        BtnSalirSeleccion.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSalirSeleccion.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnSalirSeleccion.Location = New Point(358, 34)
        BtnSalirSeleccion.Name = "BtnSalirSeleccion"
        BtnSalirSeleccion.Size = New Size(50, 50)
        BtnSalirSeleccion.TabIndex = 57
        BtnSalirSeleccion.Text = "🔙"
        BtnSalirSeleccion.UseVisualStyleBackColor = False
        ' 
        ' TextBoxId
        ' 
        TextBoxId.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxId.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxId.Location = New Point(19, 43)
        TextBoxId.Name = "TextBoxId"
        TextBoxId.Size = New Size(267, 36)
        TextBoxId.TabIndex = 56
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
        BtnSeleccionar.Location = New Point(301, 34)
        BtnSeleccionar.Name = "BtnSeleccionar"
        BtnSeleccionar.Size = New Size(51, 50)
        BtnSeleccionar.TabIndex = 55
        BtnSeleccionar.Text = "✓"
        BtnSeleccionar.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label9.Location = New Point(19, 15)
        Label9.Name = "Label9"
        Label9.Size = New Size(33, 25)
        Label9.TabIndex = 54
        Label9.Text = "ID"
        ' 
        ' LabelActividad
        ' 
        LabelActividad.AutoSize = True
        LabelActividad.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        LabelActividad.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelActividad.ForeColor = Color.White
        LabelActividad.Location = New Point(1026, 0)
        LabelActividad.Name = "LabelActividad"
        LabelActividad.Padding = New Padding(10, 5, 50, 5)
        LabelActividad.Size = New Size(60, 45)
        LabelActividad.TabIndex = 63
        LabelActividad.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(640, 101)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(465, 352)
        PictureBox1.TabIndex = 69
        PictureBox1.TabStop = False
        ' 
        ' PanelConfirmación
        ' 
        PanelConfirmación.AllowDrop = True
        PanelConfirmación.BackColor = Color.FromArgb(CByte(255), CByte(222), CByte(222))
        PanelConfirmación.Controls.Add(BtnAceptarEliminacion)
        PanelConfirmación.Controls.Add(BtnCancelar)
        PanelConfirmación.Controls.Add(LabelIncorrecto)
        PanelConfirmación.Location = New Point(343, 185)
        PanelConfirmación.Name = "PanelConfirmación"
        PanelConfirmación.Size = New Size(602, 152)
        PanelConfirmación.TabIndex = 70
        PanelConfirmación.Visible = False
        ' 
        ' BtnAceptarEliminacion
        ' 
        BtnAceptarEliminacion.BackColor = Color.White
        BtnAceptarEliminacion.Cursor = Cursors.Hand
        BtnAceptarEliminacion.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnAceptarEliminacion.FlatAppearance.BorderSize = 0
        BtnAceptarEliminacion.FlatStyle = FlatStyle.Flat
        BtnAceptarEliminacion.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAceptarEliminacion.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        BtnAceptarEliminacion.Location = New Point(142, 90)
        BtnAceptarEliminacion.Name = "BtnAceptarEliminacion"
        BtnAceptarEliminacion.Size = New Size(144, 41)
        BtnAceptarEliminacion.TabIndex = 64
        BtnAceptarEliminacion.Text = "Aceptar"
        BtnAceptarEliminacion.UseVisualStyleBackColor = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.FromArgb(CByte(250), CByte(80), CByte(80))
        BtnCancelar.Cursor = Cursors.Hand
        BtnCancelar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnCancelar.FlatAppearance.BorderSize = 0
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancelar.ForeColor = Color.White
        BtnCancelar.Location = New Point(318, 90)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(144, 41)
        BtnCancelar.TabIndex = 63
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' LabelIncorrecto
        ' 
        LabelIncorrecto.AutoSize = True
        LabelIncorrecto.BackColor = Color.FromArgb(CByte(255), CByte(222), CByte(222))
        LabelIncorrecto.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelIncorrecto.ForeColor = Color.FromArgb(CByte(250), CByte(80), CByte(80))
        LabelIncorrecto.Location = New Point(20, 20)
        LabelIncorrecto.Name = "LabelIncorrecto"
        LabelIncorrecto.Padding = New Padding(20, 5, 20, 5)
        LabelIncorrecto.Size = New Size(562, 45)
        LabelIncorrecto.TabIndex = 62
        LabelIncorrecto.Text = "¿ Seguro quieres eliminar el ticket #1 ?"
        ' 
        ' adminitrar
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1288, 906)
        Controls.Add(PanelConfirmación)
        Controls.Add(PictureBox1)
        Controls.Add(LabelActividad)
        Controls.Add(PanelSelecion)
        Controls.Add(PanelBotones)
        Controls.Add(panelIngresoDatos2)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminitrar"
        Text = "adminitrar"
        panelIngresoDatos2.ResumeLayout(False)
        panelIngresoDatos2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelBotones.ResumeLayout(False)
        PanelSelecion.ResumeLayout(False)
        PanelSelecion.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelConfirmación.ResumeLayout(False)
        PanelConfirmación.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents ListaEstado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListaTipoSoporte As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnIngresarNuevoTicket As Button
    Friend WithEvents TextBoxObservacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEquipo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBoxCostoFinal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCostoInicial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelId As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelBotones As Panel
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents PanelSelecion As Panel
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSalirSeleccion As Button
    Friend WithEvents LabelActividad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelConfirmación As Panel
    Friend WithEvents BtnAceptarEliminacion As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LabelIncorrecto As Label
End Class
