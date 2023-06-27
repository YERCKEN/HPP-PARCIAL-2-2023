Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class loginRegistro
    Private Sub loginRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1


        'visibilidad
        PanelRegistro.Visible = False
        'TRANSICIÓN ====================================================

        Opacity = 0 ' Establecer la opacidad inicial en 0
        Dim fadeIn As New Timer()
        fadeIn.Interval = 20 ' Intervalo de tiempo para la animación
        fadeIn.Start()

        AddHandler fadeIn.Tick,
            Sub(s, args)
                If Opacity < 1 Then
                    Opacity += 0.05
                Else
                    fadeIn.Stop()
                End If
            End Sub
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

    Private Sub ActualizarBtn_Click(sender As Object, e As EventArgs) Handles ActualizarBtn.Click

    End Sub

    Private Sub LinkRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegistro.LinkClicked
        'VISIBILIDAD
        PanelRegistro.Visible = True
        PanelLogin.Visible = False
        PictureBox1.Location = New Point(100, 100)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'VISIBILIDAD
        PanelRegistro.Visible = False
        PanelLogin.Visible = True
        PictureBox1.Location = New Point(713, 100)
    End Sub


End Class