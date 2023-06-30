<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicioAdmin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(inicioAdmin))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        ListaMostrar = New ComboBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(btnPerfil, ComponentModel.ISupportInitialize).BeginInit()
        PanelPerfil.SuspendLayout()
        CType(btnCerrarSesion, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPerfil
        ' 
        btnPerfil.Cursor = Cursors.Hand
        btnPerfil.Image = My.Resources.Resources.PERFIl
        btnPerfil.Location = New Point(1183, 12)
        btnPerfil.Name = "btnPerfil"
        btnPerfil.Size = New Size(60, 60)
        btnPerfil.TabIndex = 2
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
        PanelPerfil.Location = New Point(829, 35)
        PanelPerfil.Name = "PanelPerfil"
        PanelPerfil.Size = New Size(414, 413)
        PanelPerfil.TabIndex = 3
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
        DataGridView1.Location = New Point(41, 477)
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
        DataGridView1.TabIndex = 4
        ' 
        ' ListaMostrar
        ' 
        ListaMostrar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListaMostrar.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        ListaMostrar.FormattingEnabled = True
        ListaMostrar.Items.AddRange(New Object() {"En espera", "En proceso", "Terminado", "Todos"})
        ListaMostrar.Location = New Point(56, 327)
        ListaMostrar.Name = "ListaMostrar"
        ListaMostrar.Size = New Size(359, 33)
        ListaMostrar.TabIndex = 63
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label2.Location = New Point(56, 285)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 64
        Label2.Text = "Mostrar"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(641, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(465, 352)
        PictureBox1.TabIndex = 65
        PictureBox1.TabStop = False
        ' 
        ' inicioAdmin
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1288, 828)
        Controls.Add(Label2)
        Controls.Add(ListaMostrar)
        Controls.Add(DataGridView1)
        Controls.Add(btnPerfil)
        Controls.Add(PanelPerfil)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "inicioAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "inicioAdmin"
        CType(btnPerfil, ComponentModel.ISupportInitialize).EndInit()
        PanelPerfil.ResumeLayout(False)
        PanelPerfil.PerformLayout()
        CType(btnCerrarSesion, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPerfil As PictureBox
    Friend WithEvents PanelPerfil As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCerrarSesion As PictureBox
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents LabelRol As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListaMostrar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
