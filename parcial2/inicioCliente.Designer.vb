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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Label1 = New Label()
        CType(btnPerfil, ComponentModel.ISupportInitialize).BeginInit()
        PanelPerfil.SuspendLayout()
        CType(btnCerrarSesion, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelPerfil.BackgroundImage = CType(resources.GetObject("PanelPerfil.BackgroundImage"), Image)
        PanelPerfil.Controls.Add(Label5)
        PanelPerfil.Controls.Add(LabelUsuario)
        PanelPerfil.Controls.Add(Label4)
        PanelPerfil.Controls.Add(btnCerrarSesion)
        PanelPerfil.Controls.Add(LabelCorreo)
        PanelPerfil.Controls.Add(LabelRol)
        PanelPerfil.Controls.Add(LabelNombre)
        PanelPerfil.Location = New Point(801, 126)
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
        DataGridView1.Location = New Point(72, 277)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 31
        DataGridView1.Size = New Size(1143, 262)
        DataGridView1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(72, 231)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 32)
        Label1.TabIndex = 55
        Label1.Text = "tickets"
        ' 
        ' inicioCliente
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1288, 572)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(PanelPerfil)
        Controls.Add(btnPerfil)
        FormBorderStyle = FormBorderStyle.None
        Name = "inicioCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "inicioCliente"
        CType(btnPerfil, ComponentModel.ISupportInitialize).EndInit()
        PanelPerfil.ResumeLayout(False)
        PanelPerfil.PerformLayout()
        CType(btnCerrarSesion, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents Label1 As Label
End Class
