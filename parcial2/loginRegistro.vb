Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class loginRegistro


    Private Sub loginRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1

        Form1.Size = New Size(Form1.Width, Me.Height)

        'visibilidad
        PanelRegistro.Visible = False
        'TRANSICIÓN ====================================================
        RealizarTransicion()
    End Sub




    'TEXT BOX PLACEHOLDER ===============================================================================
    Private Sub textboxUsuario_GotFocus(sender As Object, e As EventArgs) Handles textboxUsuario.GotFocus
        If textboxUsuario.Text = "Usuario" Then
            textboxUsuario.Text = ""
        End If
    End Sub

    Private Sub textboxUsuario_LostFocus(sender As Object, e As EventArgs) Handles textboxUsuario.LostFocus
        If textboxUsuario.Text = "" Then
            textboxUsuario.Text = "Usuario"
            textboxUsuario.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub

    Private Sub TextBoxContraseña_GotFocus(sender As Object, e As EventArgs) Handles TextBoxContraseña.Enter
        If TextBoxContraseña.Text = "Contraseña" Then
            TextBoxContraseña.Text = ""
        End If
    End Sub

    Private Sub TextBoxContraseña_LostFocus(sender As Object, e As EventArgs) Handles TextBoxContraseña.Leave
        If TextBoxContraseña.Text = "" Then
            TextBoxContraseña.Text = "Contraseña"
            TextBoxContraseña.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub


    'REGISTRO ------------------------------------------------------------------------------------------------------------------

    'NOMBRE
    Private Sub TextBoxNombre_GotFocus(sender As Object, e As EventArgs) Handles TextBoxNombre.GotFocus
        If TextBoxNombre.Text = "Nombre" Then
            TextBoxNombre.Text = ""
        End If
    End Sub

    Private Sub TextBoxNombre_LostFocus(sender As Object, e As EventArgs) Handles TextBoxNombre.LostFocus
        If TextBoxNombre.Text = "" Then
            TextBoxNombre.Text = "Nombre"
            TextBoxNombre.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub

    'APELLIDO
    Private Sub TextBoxApellido_GotFocus(sender As Object, e As EventArgs) Handles TextBoxApellido.GotFocus
        If TextBoxApellido.Text = "Apellido" Then
            TextBoxApellido.Text = ""
        End If
    End Sub
    Private Sub TextBoxApellido_LostFocus(sender As Object, e As EventArgs) Handles TextBoxApellido.LostFocus
        If TextBoxApellido.Text = "" Then
            TextBoxApellido.Text = "Apellido"
            TextBoxApellido.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub

    'CORREO
    Private Sub TextBoxCorreo_GotFocus(sender As Object, e As EventArgs) Handles TextBoxCorreo.GotFocus
        If TextBoxCorreo.Text = "Correo" Then
            TextBoxCorreo.Text = ""
        End If
    End Sub
    Private Sub TextBoxCorreo_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCorreo.LostFocus
        If TextBoxCorreo.Text = "" Then
            TextBoxCorreo.Text = "Correo"
            TextBoxCorreo.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub

    'USUARIO
    Private Sub TextBoxUsuarioR_GotFocus(sender As Object, e As EventArgs) Handles TextBoxUsuarioR.GotFocus
        If TextBoxUsuarioR.Text = "Usuario" Then
            TextBoxUsuarioR.Text = ""
        End If
    End Sub
    Private Sub TextBoxUsuarioR_LostFocus(sender As Object, e As EventArgs) Handles TextBoxUsuarioR.LostFocus
        If TextBoxUsuarioR.Text = "" Then
            TextBoxUsuarioR.Text = "Usuario"
            TextBoxUsuarioR.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub

    'CONTRASEÑA
    Private Sub TextBoxContraseñaR_GotFocus(sender As Object, e As EventArgs) Handles TextBoxContraseñaR.GotFocus
        If TextBoxContraseñaR.Text = "Contraseña" Then
            TextBoxContraseñaR.Text = ""
        End If
    End Sub
    Private Sub TextBoxContraseñaR_LostFocus(sender As Object, e As EventArgs) Handles TextBoxContraseñaR.LostFocus
        If TextBoxContraseñaR.Text = "" Then
            TextBoxContraseñaR.Text = "Contraseña"
            TextBoxContraseñaR.ForeColor = Color.FromArgb(120, 127, 130) ' Opcional: cambiar el color del texto
        End If
    End Sub



    Private Sub LinkRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegistro.LinkClicked
        'VISIBILIDAD
        PanelRegistro.Visible = True
        PanelLogin.Visible = False
        LabelIncorrecto.Visible = False
        ' Animación de desvanecimiento
        RealizarTransicion()
        PictureBox1.Location = New Point(100, 100)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'VISIBILIDAD
        PanelRegistro.Visible = False
        PanelLogin.Visible = True
        ' Animación de desvanecimiento
        RealizarTransicion()
        PictureBox1.Location = New Point(713, 100)
    End Sub

    'FUNCIÓN DE TRANSICIÓN ===============================

    Private Sub RealizarTransicion()
        ' Animación de desvanecimiento
        Opacity = 0 ' Establecer la opacidad inicial en 0

        Dim fadeIn As New Timer()
        fadeIn.Interval = 10 ' Intervalo de tiempo para la animación
        fadeIn.Start()

        AddHandler fadeIn.Tick,
            Sub(s, args)
                If Opacity < 1 Then
                    Opacity += 0.05 ' Aumentar la opacidad gradualmente
                Else
                    fadeIn.Stop()
                End If
            End Sub
    End Sub

    'BOTÓN LOGIN---------------------------------------------------------------------------------

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        'LLAMADO DE FUNCIÓN
        If querysBd.Login(textboxUsuario.Text, TextBoxContraseña.Text) > 0 Then


            variablesGlobales.inicioSesion = True

            'SELECT
            querysBd.ObtenerUsuariosConRoles(textboxUsuario.Text.ToString())
            Debug.WriteLine(vbCrLf & vbCrLf & "DATOS:")
            Debug.WriteLine("ID: " & querysBd.usuarioID)
            Debug.WriteLine("Nombre: " & querysBd.nombre)
            Debug.WriteLine("Apellido: " & querysBd.apellido)
            Debug.WriteLine("Correo: " & querysBd.correo)
            Debug.WriteLine("Usuario: " & querysBd.UsuarioObtenido)
            Debug.WriteLine("ROL: " & querysBd.Rol & vbCrLf & vbCrLf)

            'VISIBILIDAD
            LabelIncorrecto.Visible = False

            Me.Close()

            If querysBd.Rol = "cliente" Then
                inicioCliente.Show()
                inicioCliente.Owner = Form1

                'VISIBILIDAD BOTONES INICIO
                Form1.btnAdministrar.Visible = False
                Form1.BtnItinerario.Visible = False
                'Form1.BtnReporte.Visible = False
                Form1.Location = New Point(Form1.Location.X, 70)
            Else
                inicioAdmin.Show()
                inicioAdmin.Owner = Form1

                'VISIBILIDAD BOTONES INICIO
                Form1.btnAdministrar.Visible = True
                Form1.BtnItinerario.Visible = True
                'Form1.BtnReporte.Visible = True

            End If
        Else
            LabelIncorrecto.Visible = True

        End If


    End Sub

    'BOTÓN REGISTRAR ---------------------------------------------------------------------------------

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If TextBoxNombre.Text = "Nombre" Then
            TextBoxNombre.BackColor = Color.FromArgb(255, 222, 222)

        ElseIf TextBoxApellido.Text = "Apellido" Then
            TextBoxApellido.BackColor = Color.FromArgb(255, 222, 222)
            TextBoxNombre.BackColor = Color.White

        ElseIf TextBoxCorreo.Text = "Correo" Then
            TextBoxCorreo.BackColor = Color.FromArgb(255, 222, 222)
            TextBoxNombre.BackColor = Color.White
            TextBoxApellido.BackColor = Color.White

        ElseIf TextBoxUsuarioR.Text = "Usuario" Then
            TextBoxUsuarioR.BackColor = Color.FromArgb(255, 222, 222)
            TextBoxNombre.BackColor = Color.White
            TextBoxApellido.BackColor = Color.White
            TextBoxCorreo.BackColor = Color.White

        ElseIf TextBoxContraseñaR.Text = "Contraseña" Then
            TextBoxContraseñaR.BackColor = Color.FromArgb(255, 222, 222)
            TextBoxNombre.BackColor = Color.White
            TextBoxApellido.BackColor = Color.White
            TextBoxCorreo.BackColor = Color.White
            TextBoxUsuarioR.BackColor = Color.White
        Else

            TextBoxContraseñaR.BackColor = Color.FromArgb(255, 222, 222)
            TextBoxNombre.BackColor = Color.White
            TextBoxApellido.BackColor = Color.White
            TextBoxCorreo.BackColor = Color.White
            TextBoxUsuarioR.BackColor = Color.White
            TextBoxContraseñaR.BackColor = Color.White

            'INSERT


            If querysBd.Registro(TextBoxNombre.Text, TextBoxApellido.Text, TextBoxUsuarioR.Text, TextBoxCorreo.Text, TextBoxContraseñaR.Text, 2) = 1 Then

                'VISIBILIDAD
                PanelRegistro.Visible = False
                PanelLogin.Visible = True
                ' Animación de desvanecimiento
                RealizarTransicion()
                PictureBox1.Location = New Point(713, 100)

                MessageBox.Show("Te haz Registrado Correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf querysBd.Registro(TextBoxNombre.Text, TextBoxApellido.Text, TextBoxUsuarioR.Text, TextBoxCorreo.Text, TextBoxContraseñaR.Text, 2) = 0 Then

                MessageBox.Show("El Usuario Ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                MessageBox.Show("Error al Realizar el Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub


End Class