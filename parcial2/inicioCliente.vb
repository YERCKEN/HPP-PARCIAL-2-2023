Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class inicioCliente
    Private Sub inicioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Location = New Point(Form1.Location.X, 70)
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        Form1.Size = New Size(Form1.Width, Me.Height)
        PanelPerfil.BackColor = Color.Transparent
        PanelPerfil.Parent = Me
        'DATOS delusuario
        LabelNombre.Text = querysBd.Nombre & " " & querysBd.Apellido
        LabelCorreo.Text = querysBd.Correo
        LabelUsuario.Text = querysBd.UsuarioObtenido
        LabelRol.Text = querysBd.Rol
        'ESTILO DROP BOX
        ListaTipoSoporte.ForeColor = Color.FromArgb(120, 127, 130)

        'CARGA DATA 

        DataGridView1.DataSource = querysBd.obtenerTicketsUsuario()

        DataGridView1.AutoSize = False

        DataGridView1.MaximumSize = New Size(1204, 262)
        DataGridView1.AutoResizeColumns()
        DataGridView1.ReadOnly = True


        DataGridView1.Columns("nombreUsuario").Visible = False
        DataGridView1.Columns("idTiket").HeaderText = "ID"
        DataGridView1.Columns("fechaInicio").HeaderText = "F.inicio"
        DataGridView1.Columns("fechaFinalizacion").HeaderText = "F.finalización"


        DataGridView1.Columns("idTiket").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("fechaInicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("fechaFinalizacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ' Configura la columna de observación como de varias líneas
        'Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
        ' cellStyle.WrapMode = DataGridViewTriState.True
        'DataGridView1.Columns("observacion").DefaultCellStyle = cellStyle

        'DataGridView1.Columns("observacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


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
        loginRegistro.Owner = Form1
        Form1.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Form1.Width) \ 2, (Screen.PrimaryScreen.WorkingArea.Height - Form1.Height) \ 2)
        Form1.Size = New Size(Form1.Width, loginRegistro.Height)
    End Sub

    Private Sub BtnNuevoT_Click(sender As Object, e As EventArgs) Handles BtnNuevoT.Click

        panelIngresoDatos2.Visible = True
        BtnNuevoT.Visible = False
        BtnFactura.Visible = False

    End Sub

    'BTN VOLVVER
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        panelIngresoDatos2.Visible = False
        BtnNuevoT.Visible = True
        BtnFactura.Visible = True

        TextBoxEquipo.Text = ""
        TextBoxObservacion.Text = ""
        ListaTipoSoporte.Text = ""
        RealizarTransicion()

    End Sub



    Private Sub BtnIngresarNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnIngresarNuevoTicket.Click
        If TextBoxEquipo.Text = "" Then
            TextBoxEquipo.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxEquipo.BackColor = Color.White

        ElseIf ListaTipoSoporte.Text = "" Then

            ListaTipoSoporte.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ListaTipoSoporte.BackColor = Color.White

        ElseIf TextBoxObservacion.Text = "" Then
            TextBoxObservacion.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxObservacion.BackColor = Color.White
        Else

            'realizar insersión
            If ListaTipoSoporte.Text = "Preventivo" Or ListaTipoSoporte.Text = "Correctivo" Or ListaTipoSoporte.Text = "Predictivo" Then

                querysBd.InsertarTicket(querysBd.UsuarioID, TextBoxObservacion.Text, ListaTipoSoporte.Text, TextBoxEquipo.Text)
                MessageBox.Show("El ticket ha sido insertado correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'CARGA DATA 
                DataGridView1.DataSource = querysBd.obtenerTicketsUsuario()
                RealizarTransicion()
            Else
                ListaTipoSoporte.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: Tipo de Soporte NO válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ListaTipoSoporte.BackColor = Color.White
            End If


        End If

    End Sub

    Private Sub PanelPerfil_Paint(sender As Object, e As PaintEventArgs) Handles PanelPerfil.Paint

    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click

    End Sub








    'Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
    '    panelNuevo2.Visible = False
    '    BtnNuevoT.Visible = True
    '    BtnFactura.Visible = True
    'End Sub
End Class