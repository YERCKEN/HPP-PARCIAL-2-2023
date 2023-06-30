Public Class inicioAdmin

    Dim query As String = "ObtenerTodosLosTickets"

    Private Sub inicioAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Location = New Point(Form1.Location.X, 30)
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1
        Form1.Size = New Size(Form1.Width, Me.Height)

        'DATOS delusuario
        LabelNombre.Text = querysBd.Nombre & " " & querysBd.Apellido
        LabelCorreo.Text = querysBd.Correo
        LabelUsuario.Text = querysBd.UsuarioObtenido
        LabelRol.Text = querysBd.Rol

        'CARGA DE DATOS
        DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)
        ListaMostrar.Text = "Todos"

        'EDICION
        DataGridView1.Columns("idTiket").HeaderText = "ID"
        DataGridView1.Columns("idTiket").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView1.Columns("idUsuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'DataGridView1.Columns("usuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("estado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView1.Columns("costoInicial").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("costoFinal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("fechaInicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns("fechaFinalizacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        DataGridView1.Columns("fechaInicio").HeaderText = "F.inicio"
        DataGridView1.Columns("fechaFinalizacion").HeaderText = "F.finalización"
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        PanelPerfil.Visible = Not PanelPerfil.Visible

        PictureBox1.Visible = Not PictureBox1.Visible
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        variablesGlobales.inicioSesion = False
        Me.Close()
        adminitrar.Close()
        loginRegistro.Show()
        loginRegistro.Owner = Form1

        Form1.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Form1.Width) \ 2, (Screen.PrimaryScreen.WorkingArea.Height - Form1.Height) \ 2)
        Form1.Size = New Size(Form1.Width, loginRegistro.Height)

    End Sub

    Private Sub ListaMostrar_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListaMostrar.SelectedValueChanged



        If ListaMostrar.Text = "En espera" Then

            query = "ObtenerTicketsConUsuariosEnEspera"
            DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)


        ElseIf ListaMostrar.Text = "En proceso" Then

            DataGridView1.DataSource = ObtenerTodosLosTicketsProcesoResaltado()

        ElseIf ListaMostrar.Text = "Terminado" Then

            query = "ObtenerTicketsConUsuariosTerminado"
            DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)

        ElseIf ListaMostrar.Text = "Todos" Then

            query = "ObtenerTodosLosTickets"
            DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)

        End If
        RealizarTransicion()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting


        If ListaMostrar.Text = "En proceso" Then

            If DataGridView1.Columns(e.ColumnIndex).Name = "fechaFinalizacion" Then
                Dim value = e.Value

                If Not DBNull.Value.Equals(value) Then
                    Dim fechaFinalizacion As Date = CDate(value)
                    Dim diasRestantes As Integer = (fechaFinalizacion - DateTime.Now).Days


                    ' Verificar si la fecha de finalización está próxima
                    ' Verificar si la fecha de finalización está próxima
                    If diasRestantes = 0 Then
                        ' MsgBox(diasRestantes)
                        e.CellStyle.BackColor = Color.FromArgb(255, 222, 222)
                        e.CellStyle.ForeColor = Color.Red

                        'MsgBox("Tikets con fecha de finalizacuón hoy")

                    ElseIf diasRestantes <= 3 Then
                        ' MsgBox(diasRestantes)
                        e.CellStyle.BackColor = Color.FromArgb(255, 222, 222)
                        e.CellStyle.ForeColor = Color.Red

                    ElseIf diasRestantes <= 5 And diasRestantes > 3 Then
                        'MsgBox(diasRestantes)

                        e.CellStyle.BackColor = Color.FromArgb(255, 234, 222)


                    ElseIf diasRestantes <= 7 And diasRestantes > 5 Then
                        ' MsgBox(diasRestantes)

                        e.CellStyle.BackColor = Color.FromArgb(255, 252, 222)

                    ElseIf diasRestantes <= 20 And diasRestantes > 7 Then
                        ' MsgBox(diasRestantes)

                        e.CellStyle.BackColor = Color.FromArgb(234, 255, 222)

                    End If

                End If
            End If
        End If
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

End Class