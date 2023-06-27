Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class inicioCliente
    Private Sub inicioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1

        'DATOS delusuario
        LabelNombre.Text = querysBd.Nombre & " " & querysBd.Apellido
        LabelCorreo.Text = querysBd.Correo
        LabelUsuario.Text = querysBd.UsuarioObtenido


        'CARGA DATA 

        DataGridView1.DataSource = querysBd.obtenerTicketsUsuario()
        DataGridView1.Columns("nombreUsuario").Visible = False

    End Sub


    'click en perfil=================================================================================
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        RealizarTransicion()
        PanelPerfil.Visible = Not PanelPerfil.Visible

    End Sub






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

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click

        variablesGlobales.inicioSesion = False
        Me.Close()
        loginRegistro.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class