<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginRegistro
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
        textboxUsuario = New TextBox()
        TextBoxContraseña = New TextBox()
        BtnLogin = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        LinkRegistro = New LinkLabel()
        PanelLogin = New Panel()
        LabelIncorrecto = New Label()
        PanelRegistro = New Panel()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        BtnRegistrar = New Button()
        TextBoxContraseñaR = New TextBox()
        TextBoxUsuarioR = New TextBox()
        TextBoxCorreo = New TextBox()
        TextBoxApellido = New TextBox()
        TextBoxNombre = New TextBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelLogin.SuspendLayout()
        PanelRegistro.SuspendLayout()
        SuspendLayout()
        ' 
        ' textboxUsuario
        ' 
        textboxUsuario.BackColor = Color.White
        textboxUsuario.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        textboxUsuario.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        textboxUsuario.Location = New Point(23, 143)
        textboxUsuario.Name = "textboxUsuario"
        textboxUsuario.ShortcutsEnabled = False
        textboxUsuario.Size = New Size(377, 34)
        textboxUsuario.TabIndex = 48
        textboxUsuario.Text = "Usuario"
        textboxUsuario.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxContraseña
        ' 
        TextBoxContraseña.BackColor = Color.White
        TextBoxContraseña.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxContraseña.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBoxContraseña.Location = New Point(23, 216)
        TextBoxContraseña.Name = "TextBoxContraseña"
        TextBoxContraseña.ShortcutsEnabled = False
        TextBoxContraseña.Size = New Size(377, 34)
        TextBoxContraseña.TabIndex = 49
        TextBoxContraseña.Text = "Contraseña"
        TextBoxContraseña.TextAlign = HorizontalAlignment.Center
        TextBoxContraseña.UseSystemPasswordChar = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(23, 314)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(377, 51)
        BtnLogin.TabIndex = 53
        BtnLogin.Text = "Iniciar Sesión"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label1.Location = New Point(152, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 46)
        Label1.TabIndex = 54
        Label1.Text = "Login"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.login
        PictureBox1.Location = New Point(713, 92)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(456, 409)
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label2.Location = New Point(53, 404)
        Label2.Name = "Label2"
        Label2.Size = New Size(190, 25)
        Label2.TabIndex = 56
        Label2.Text = "No tienes cuenta?, "
        ' 
        ' LinkRegistro
        ' 
        LinkRegistro.ActiveLinkColor = Color.FromArgb(CByte(255), CByte(97), CByte(122))
        LinkRegistro.AutoSize = True
        LinkRegistro.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        LinkRegistro.LinkColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        LinkRegistro.Location = New Point(237, 404)
        LinkRegistro.Name = "LinkRegistro"
        LinkRegistro.Size = New Size(109, 25)
        LinkRegistro.TabIndex = 57
        LinkRegistro.TabStop = True
        LinkRegistro.Text = "Regístrate"
        ' 
        ' PanelLogin
        ' 
        PanelLogin.Controls.Add(LabelIncorrecto)
        PanelLogin.Controls.Add(LinkRegistro)
        PanelLogin.Controls.Add(Label1)
        PanelLogin.Controls.Add(Label2)
        PanelLogin.Controls.Add(textboxUsuario)
        PanelLogin.Controls.Add(TextBoxContraseña)
        PanelLogin.Controls.Add(BtnLogin)
        PanelLogin.Location = New Point(156, 56)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(430, 470)
        PanelLogin.TabIndex = 58
        ' 
        ' LabelIncorrecto
        ' 
        LabelIncorrecto.AutoSize = True
        LabelIncorrecto.BackColor = Color.FromArgb(CByte(255), CByte(222), CByte(222))
        LabelIncorrecto.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        LabelIncorrecto.ForeColor = Color.Red
        LabelIncorrecto.Location = New Point(61, 267)
        LabelIncorrecto.Name = "LabelIncorrecto"
        LabelIncorrecto.Padding = New Padding(20, 5, 20, 5)
        LabelIncorrecto.Size = New Size(302, 32)
        LabelIncorrecto.TabIndex = 58
        LabelIncorrecto.Text = "usuario o contraseña incorrecta"
        LabelIncorrecto.Visible = False
        ' 
        ' PanelRegistro
        ' 
        PanelRegistro.Controls.Add(LinkLabel1)
        PanelRegistro.Controls.Add(Label4)
        PanelRegistro.Controls.Add(BtnRegistrar)
        PanelRegistro.Controls.Add(TextBoxContraseñaR)
        PanelRegistro.Controls.Add(TextBoxUsuarioR)
        PanelRegistro.Controls.Add(TextBoxCorreo)
        PanelRegistro.Controls.Add(TextBoxApellido)
        PanelRegistro.Controls.Add(TextBoxNombre)
        PanelRegistro.Controls.Add(Label3)
        PanelRegistro.Location = New Point(639, 23)
        PanelRegistro.Name = "PanelRegistro"
        PanelRegistro.Size = New Size(573, 504)
        PanelRegistro.TabIndex = 59
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.FromArgb(CByte(255), CByte(97), CByte(122))
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        LinkLabel1.Location = New Point(336, 470)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(65, 25)
        LinkLabel1.TabIndex = 63
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label4.Location = New Point(152, 470)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 25)
        Label4.TabIndex = 62
        Label4.Text = "Ya tienes cuenta?, "
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        BtnRegistrar.Cursor = Cursors.Hand
        BtnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        BtnRegistrar.FlatAppearance.BorderSize = 0
        BtnRegistrar.FlatStyle = FlatStyle.Flat
        BtnRegistrar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnRegistrar.ForeColor = Color.White
        BtnRegistrar.Location = New Point(33, 404)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(516, 51)
        BtnRegistrar.TabIndex = 61
        BtnRegistrar.Text = "Registrar"
        BtnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' TextBoxContraseñaR
        ' 
        TextBoxContraseñaR.BackColor = Color.White
        TextBoxContraseñaR.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxContraseñaR.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBoxContraseñaR.Location = New Point(33, 332)
        TextBoxContraseñaR.Name = "TextBoxContraseñaR"
        TextBoxContraseñaR.ShortcutsEnabled = False
        TextBoxContraseñaR.Size = New Size(516, 34)
        TextBoxContraseñaR.TabIndex = 60
        TextBoxContraseñaR.Text = "Contraseña"
        TextBoxContraseñaR.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxUsuarioR
        ' 
        TextBoxUsuarioR.BackColor = Color.White
        TextBoxUsuarioR.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxUsuarioR.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBoxUsuarioR.Location = New Point(33, 263)
        TextBoxUsuarioR.Name = "TextBoxUsuarioR"
        TextBoxUsuarioR.ShortcutsEnabled = False
        TextBoxUsuarioR.Size = New Size(516, 34)
        TextBoxUsuarioR.TabIndex = 59
        TextBoxUsuarioR.Text = "Usuario"
        TextBoxUsuarioR.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxCorreo
        ' 
        TextBoxCorreo.BackColor = Color.White
        TextBoxCorreo.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCorreo.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBoxCorreo.Location = New Point(33, 191)
        TextBoxCorreo.Name = "TextBoxCorreo"
        TextBoxCorreo.ShortcutsEnabled = False
        TextBoxCorreo.Size = New Size(516, 34)
        TextBoxCorreo.TabIndex = 58
        TextBoxCorreo.Text = "Correo"
        TextBoxCorreo.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxApellido
        ' 
        TextBoxApellido.BackColor = Color.White
        TextBoxApellido.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxApellido.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBoxApellido.Location = New Point(303, 109)
        TextBoxApellido.Name = "TextBoxApellido"
        TextBoxApellido.ShortcutsEnabled = False
        TextBoxApellido.Size = New Size(246, 34)
        TextBoxApellido.TabIndex = 57
        TextBoxApellido.Text = "Apellido"
        TextBoxApellido.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.BackColor = Color.White
        TextBoxNombre.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxNombre.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBoxNombre.Location = New Point(33, 109)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.ShortcutsEnabled = False
        TextBoxNombre.Size = New Size(246, 34)
        TextBoxNombre.TabIndex = 56
        TextBoxNombre.Text = "Nombre"
        TextBoxNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(83), CByte(97), CByte(98))
        Label3.Location = New Point(205, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 46)
        Label3.TabIndex = 55
        Label3.Text = "Registro"
        ' 
        ' loginRegistro
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1288, 572)
        Controls.Add(PanelRegistro)
        Controls.Add(PictureBox1)
        Controls.Add(PanelLogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "loginRegistro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginRegistro"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelLogin.ResumeLayout(False)
        PanelLogin.PerformLayout()
        PanelRegistro.ResumeLayout(False)
        PanelRegistro.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents textboxUsuario As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkRegistro As LinkLabel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents PanelRegistro As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents TextBoxContraseñaR As TextBox
    Friend WithEvents TextBoxUsuarioR As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelIncorrecto As Label
End Class
