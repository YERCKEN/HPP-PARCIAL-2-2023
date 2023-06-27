Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Drawing

Public Class inicioCliente
    Private Sub inicioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        PanelPerfil.BackColor = Color.Transparent
        PanelPerfil.Parent = Me
        'DATOS delusuario
        LabelNombre.Text = querysBd.Nombre & " " & querysBd.Apellido
        LabelCorreo.Text = querysBd.Correo
        LabelUsuario.Text = querysBd.UsuarioObtenido


        'CARGA DATA 

        DataGridView1.DataSource = querysBd.obtenerTicketsUsuario()

        DataGridView1.AutoResizeColumns()

        DataGridView1.Columns("nombreUsuario").Visible = False
        DataGridView1.Columns("idTiket").HeaderText = "ID"
        DataGridView1.Columns("fechaInicio").HeaderText = "F.inicio"
        DataGridView1.Columns("fechaFinalizacion").HeaderText = "F.finalización"


        DataGridView1.Columns("idTiket").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("fechaInicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("fechaFinalizacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("observacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


    End Sub


    'click en perfil=================================================================================
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        'RealizarTransicion()
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

    Private Sub BtnNuevoT_Click(sender As Object, e As EventArgs) Handles BtnNuevoT.Click

        panelIngresoDatos2.Visible = True
        BtnNuevoT.Visible = False
        BtnFactura.Visible = False

    End Sub



    'Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
    '    panelNuevo2.Visible = False
    '    BtnNuevoT.Visible = True
    '    BtnFactura.Visible = True
    'End Sub
End Class