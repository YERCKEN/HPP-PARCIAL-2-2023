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
        ActualizarBtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        LinkRegistro = New LinkLabel()
        PanelLogin = New Panel()
        PanelRegistro = New Panel()
        LinkLabel1 = New LinkLabel()
        Label4 = New Label()
        Button1 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
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
        ' 
        ' ActualizarBtn
        ' 
        ActualizarBtn.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        ActualizarBtn.Cursor = Cursors.Hand
        ActualizarBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        ActualizarBtn.FlatAppearance.BorderSize = 0
        ActualizarBtn.FlatStyle = FlatStyle.Flat
        ActualizarBtn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ActualizarBtn.ForeColor = Color.White
        ActualizarBtn.Location = New Point(23, 314)
        ActualizarBtn.Name = "ActualizarBtn"
        ActualizarBtn.Size = New Size(377, 51)
        ActualizarBtn.TabIndex = 53
        ActualizarBtn.Text = "Iniciar Sesión"
        ActualizarBtn.UseVisualStyleBackColor = False
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
        PanelLogin.Controls.Add(LinkRegistro)
        PanelLogin.Controls.Add(Label1)
        PanelLogin.Controls.Add(Label2)
        PanelLogin.Controls.Add(textboxUsuario)
        PanelLogin.Controls.Add(TextBoxContraseña)
        PanelLogin.Controls.Add(ActualizarBtn)
        PanelLogin.Location = New Point(156, 56)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(430, 470)
        PanelLogin.TabIndex = 58
        ' 
        ' PanelRegistro
        ' 
        PanelRegistro.Controls.Add(LinkLabel1)
        PanelRegistro.Controls.Add(Label4)
        PanelRegistro.Controls.Add(Button1)
        PanelRegistro.Controls.Add(TextBox5)
        PanelRegistro.Controls.Add(TextBox4)
        PanelRegistro.Controls.Add(TextBox3)
        PanelRegistro.Controls.Add(TextBox2)
        PanelRegistro.Controls.Add(TextBox1)
        PanelRegistro.Controls.Add(Label3)
        PanelRegistro.Location = New Point(639, 38)
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
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(67), CByte(116), CByte(255))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(33, 404)
        Button1.Name = "Button1"
        Button1.Size = New Size(516, 51)
        Button1.TabIndex = 61
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.White
        TextBox5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBox5.Location = New Point(33, 332)
        TextBox5.Name = "TextBox5"
        TextBox5.ShortcutsEnabled = False
        TextBox5.Size = New Size(516, 34)
        TextBox5.TabIndex = 60
        TextBox5.Text = "Contraseña"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.White
        TextBox4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBox4.Location = New Point(33, 263)
        TextBox4.Name = "TextBox4"
        TextBox4.ShortcutsEnabled = False
        TextBox4.Size = New Size(516, 34)
        TextBox4.TabIndex = 59
        TextBox4.Text = "Usuario"
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBox3.Location = New Point(33, 191)
        TextBox3.Name = "TextBox3"
        TextBox3.ShortcutsEnabled = False
        TextBox3.Size = New Size(516, 34)
        TextBox3.TabIndex = 58
        TextBox3.Text = "Correo"
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBox2.Location = New Point(303, 109)
        TextBox2.Name = "TextBox2"
        TextBox2.ShortcutsEnabled = False
        TextBox2.Size = New Size(246, 34)
        TextBox2.TabIndex = 57
        TextBox2.Text = "Apellido"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(148), CByte(153), CByte(156))
        TextBox1.Location = New Point(33, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.ShortcutsEnabled = False
        TextBox1.Size = New Size(246, 34)
        TextBox1.TabIndex = 56
        TextBox1.Text = "Nombre"
        TextBox1.TextAlign = HorizontalAlignment.Center
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
    Friend WithEvents ActualizarBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkRegistro As LinkLabel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents PanelRegistro As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
End Class
