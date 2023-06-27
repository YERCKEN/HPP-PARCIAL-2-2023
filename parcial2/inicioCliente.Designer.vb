<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicioCliente
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(inicioCliente))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnPerfil = New PictureBox()
        PanelPerfil = New Panel()
        Label5 = New Label()
        LabelUsuario = New Label()
        Label4 = New Label()
        btnCerrarSesion = New PictureBox()
        LabelCorreo = New Label()
        LabelRol = New Label()
        LabelNombre = New Label()
        DataGridView1 = New DataGridView()
        BtnFactura = New Button()
        BtnNuevoT = New Button()
        panelIngresoDatos2 = New Panel()
        ListaMostrarLibros = New ComboBox()
        BtnVolver = New Button()
        NewClienteBtn = New Button()
        TextBoxObservacion = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        TextBoxCosto = New TextBox()
        Label7 = New Label()
        CType(btnPerfil, ComponentModel.ISupportInitialize).BeginInit()
        PanelPerfil.SuspendLayout()
        CType(btnCerrarSesion, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        panelIngresoDatos2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPerfil
        ' 
        btnPerfil.Cursor = Cursors.Hand
        btnPerfil.Image = My.Resources.Resources.PERFIl
        btnPerfil.Location = New Point(1155, 39)
        btnPerfil.Name = "btnPerfil"
        btnPerfil.Size = New Size(60, 60)
        btnPerfil.TabIndex = 0
        btnPerfil.TabStop = False
        ' 
        ' PanelPerfil
        ' 
        PanelPerfil.BackColor = Color.Transparent
        PanelPerfil.BackgroundImage = CType(resources.GetObject("PanelPerfil.BackgroundImage"), Image)
        PanelPerfil.Controls.Add(Label5)
        PanelPerfil.Controls.Add(LabelUsuario)
        PanelPerfil.Controls.Add(Label4)
        PanelPerfil.Controls.Add(btnCerrarSesion)
        PanelPerfil.Controls.Add(LabelCorreo)
        PanelPerfil.Controls.Add(LabelRol)
        PanelPerfil.Controls.Add(LabelNombre)
        PanelPerfil.Location = New Point(801, 82)
        PanelPerfil.Name = "PanelPerfil"
        PanelPerfil.Size = New Size(414, 413)
        PanelPerfil.TabIndex = 1
        PanelPerfil.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label5.Location = New Point(55, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 25)
        Label5.TabIndex = 61
        Label5.Text = "Usuario"
        ' 
        ' LabelUsuario
        ' 
        LabelUsuario.AutoSize = True
        LabelUsuario.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelUsuario.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        LabelUsuario.Location = New Point(55, 153)
        LabelUsuario.Name = "LabelUsuario"
        LabelUsuario.Size = New Size(65, 25)
        LabelUsuario.TabIndex = 60
        LabelUsuario.Text = "edwar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label4.Location = New Point(55, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 25)
        Label4.TabIndex = 59
        Label4.Text = "Correo"
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Cursor = Cursors.Hand
        btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), Image)
        btnCerrarSesion.Location = New Point(189, 308)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(41, 51)
        btnCerrarSesion.TabIndex = 58
        btnCerrarSesion.TabStop = False
        ' 
        ' LabelCorreo
        ' 
        LabelCorreo.AutoSize = True
        LabelCorreo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LabelCorreo.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        LabelCorreo.Location = New Point(55, 237)
        LabelCorreo.Name = "LabelCorreo"
        LabelCorreo.Size = New Size(187, 25)
        LabelCorreo.TabIndex = 57
        LabelCorreo.Text = "edwar@Correo.com"
        ' 
        ' LabelRol
        ' 
        LabelRol.AutoSize = True
        LabelRol.Font = New Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point)
        LabelRol.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        LabelRol.Location = New Point(166, 59)
        LabelRol.Name = "LabelRol"
        LabelRol.Size = New Size(86, 29)
        LabelRol.TabIndex = 56
        LabelRol.Text = "Admin"
        ' 
        ' LabelNombre
        ' 
        LabelNombre.AutoSize = True
        LabelNombre.Font = New Font("Montserrat", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        LabelNombre.ForeColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        LabelNombre.Location = New Point(103, 22)
        LabelNombre.Name = "LabelNombre"
        LabelNombre.Size = New Size(224, 35)
        LabelNombre.TabIndex = 55
        LabelNombre.Text = "Edwar Gonzalez"
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
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
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
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(43, 505)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1204, 262)
        DataGridView1.TabIndex = 3
        ' 
        ' BtnFactura
        ' 
        BtnFactura.BackColor = Color.FromArgb(CByte(12), CByte(202), CByte(102))
        BtnFactura.Cursor = Cursors.Hand
        BtnFactura.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnFactura.FlatAppearance.BorderSize = 0
        BtnFactura.FlatStyle = FlatStyle.Flat
        BtnFactura.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnFactura.ForeColor = Color.White
        BtnFactura.Location = New Point(131, 308)
        BtnFactura.Name = "BtnFactura"
        BtnFactura.Size = New Size(458, 51)
        BtnFactura.TabIndex = 58
        BtnFactura.Text = "Factura.xlsx"
        BtnFactura.UseVisualStyleBackColor = False
        ' 
        ' BtnNuevoT
        ' 
        BtnNuevoT.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnNuevoT.Cursor = Cursors.Hand
        BtnNuevoT.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnNuevoT.FlatAppearance.BorderSize = 0
        BtnNuevoT.FlatStyle = FlatStyle.Flat
        BtnNuevoT.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNuevoT.ForeColor = Color.White
        BtnNuevoT.Location = New Point(131, 223)
        BtnNuevoT.Name = "BtnNuevoT"
        BtnNuevoT.Size = New Size(458, 51)
        BtnNuevoT.TabIndex = 57
        BtnNuevoT.Text = "Nuevo"
        BtnNuevoT.UseVisualStyleBackColor = False
        ' 
        ' panelIngresoDatos2
        ' 
        panelIngresoDatos2.Controls.Add(ListaMostrarLibros)
        panelIngresoDatos2.Controls.Add(BtnVolver)
        panelIngresoDatos2.Controls.Add(NewClienteBtn)
        panelIngresoDatos2.Controls.Add(TextBoxObservacion)
        panelIngresoDatos2.Controls.Add(Label1)
        panelIngresoDatos2.Controls.Add(Label6)
        panelIngresoDatos2.Controls.Add(TextBoxCosto)
        panelIngresoDatos2.Controls.Add(Label7)
        panelIngresoDatos2.Location = New Point(43, 189)
        panelIngresoDatos2.Name = "panelIngresoDatos2"
        panelIngresoDatos2.Size = New Size(681, 270)
        panelIngresoDatos2.TabIndex = 59
        panelIngresoDatos2.Visible = False
        ' 
        ' ListaMostrarLibros
        ' 
        ListaMostrarLibros.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ListaMostrarLibros.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ListaMostrarLibros.FormattingEnabled = True
        ListaMostrarLibros.Items.AddRange(New Object() {"Libros Prestados", "Libros Devueltos", "Todos"})
        ListaMostrarLibros.Location = New Point(5, 112)
        ListaMostrarLibros.Name = "ListaMostrarLibros"
        ListaMostrarLibros.Size = New Size(275, 32)
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
        BtnVolver.Location = New Point(415, 176)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(87, 68)
        BtnVolver.TabIndex = 48
        BtnVolver.Text = "🔙"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' NewClienteBtn
        ' 
        NewClienteBtn.BackColor = Color.FromArgb(CByte(82), CByte(235), CByte(163))
        NewClienteBtn.Cursor = Cursors.Hand
        NewClienteBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        NewClienteBtn.FlatAppearance.BorderSize = 0
        NewClienteBtn.FlatStyle = FlatStyle.Flat
        NewClienteBtn.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NewClienteBtn.ForeColor = Color.White
        NewClienteBtn.Location = New Point(379, 46)
        NewClienteBtn.Name = "NewClienteBtn"
        NewClienteBtn.Size = New Size(185, 51)
        NewClienteBtn.TabIndex = 47
        NewClienteBtn.Text = "Ingresar"
        NewClienteBtn.UseVisualStyleBackColor = False
        ' 
        ' TextBoxObservacion
        ' 
        TextBoxObservacion.Font = New Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxObservacion.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        TextBoxObservacion.Location = New Point(4, 197)
        TextBoxObservacion.Multiline = True
        TextBoxObservacion.Name = "TextBoxObservacion"
        TextBoxObservacion.Size = New Size(276, 68)
        TextBoxObservacion.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label1.Location = New Point(4, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 27)
        Label1.TabIndex = 20
        Label1.Text = "Observación"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label6.Location = New Point(5, 79)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 27)
        Label6.TabIndex = 16
        Label6.Text = "Libro"
        ' 
        ' TextBoxCosto
        ' 
        TextBoxCosto.Font = New Font("Microsoft Sans Serif", 14.999999F, FontStyle.Bold, GraphicsUnit.Point)
        TextBoxCosto.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        TextBoxCosto.Location = New Point(5, 31)
        TextBoxCosto.Name = "TextBoxCosto"
        TextBoxCosto.Size = New Size(275, 36)
        TextBoxCosto.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Label7.Location = New Point(5, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 27)
        Label7.TabIndex = 18
        Label7.Text = "Costo"
        ' 
        ' inicioCliente
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1288, 800)
        Controls.Add(panelIngresoDatos2)
        Controls.Add(BtnFactura)
        Controls.Add(BtnNuevoT)
        Controls.Add(btnPerfil)
        Controls.Add(PanelPerfil)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "inicioCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "inicioCliente"
        CType(btnPerfil, ComponentModel.ISupportInitialize).EndInit()
        PanelPerfil.ResumeLayout(False)
        PanelPerfil.PerformLayout()
        CType(btnCerrarSesion, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        panelIngresoDatos2.ResumeLayout(False)
        panelIngresoDatos2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPerfil As PictureBox
    Friend WithEvents PanelPerfil As Panel
    Friend WithEvents LabelRol As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents btnCerrarSesion As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents panelNuevoT As Panel
    Friend WithEvents BtnNuevoT As Button
    Friend WithEvents BtnFactura As Button
    Friend WithEvents panelIngresoDatos2 As Panel
    Friend WithEvents ListaMostrarLibros As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents NewClienteBtn As Button
    Friend WithEvents TextBoxObservacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCosto As TextBox
    Friend WithEvents Label7 As Label
End Class
