Imports System.Data.SqlClient
Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class adminitrar
    Dim query As String = "ObtenerTodosLosTickets"
    Dim contadorDot As Integer = 0
    Dim contadorDot2 As Integer = 0


    Private Sub adminitrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Location = New Point(Form1.Location.X, 30)
        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49)
        Form1.Size = New Size(Form1.Width, Me.Height)

        'iniciación del la fecha
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.ForeColor = Color.FromArgb(83, 97, 98)

        'data grid view ESTILO Y LLENADO

        'CARGA DE DATOS
        DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)
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


    Private Sub RealizarTransicion(ByVal formulario As Form)
        formulario.Opacity = 0 ' Establecer la opacidad inicial en 0

        Dim fadeIn As New Timer()
        fadeIn.Interval = 10 ' Intervalo de tiempo para la animación
        fadeIn.Start()

        AddHandler fadeIn.Tick,
        Sub(s, args)
            If formulario.Opacity < 1 Then
                formulario.Opacity += 0.05 ' Aumentar la opacidad gradualmente
            Else
                fadeIn.Stop()
            End If
        End Sub
    End Sub


    Private Sub TextBoxId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxId.TextChanged
        ' Obtiene el número ingresado en el TextBox
        Dim numero As Integer
        If Integer.TryParse(TextBoxId.Text, numero) Then
            ' Aplica el filtro al origen de datos del DataGridView
            DataGridView1.DataSource.DefaultView.RowFilter = $"idTiket = {numero}"
        Else
            ' Si no se ingresa un número válido, muestra todas las filas
            DataGridView1.DataSource.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        query = "ObtenerTicketsConUsuariosEnEspera"
        DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)
        mostrarSelecion()
        'panelIngresoDatos2.Visible = True
        'panelIngresoDatos2.Enabled = False

        LabelActividad.Text = "Aceptar Ticket"
        LabelActividad.BackColor = Color.FromArgb(0, 171, 118)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 171, 118)
        PictureBox1.Image = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\5. PARCIALES\PARCIAL #2\parcial2\parcial2\IMG\ACEPTAR.png")

        LabelActividad.Visible = True
        RealizarTransicion(Me)

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        DataGridView1.DataSource = ObtenerTodosLosTicketsProcesoResaltado()
        mostrarSelecion()

        'panelIngresoDatos2.Visible = True
        'panelIngresoDatos2.Enabled = False
        LabelActividad.Text = "Actualizar Ticket"
        LabelActividad.BackColor = Color.FromArgb(67, 116, 255)

        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 116, 255)

        PictureBox1.Image = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\5. PARCIALES\PARCIAL #2\parcial2\parcial2\IMG\actualizar.png")

        LabelActividad.Visible = True
        RealizarTransicion(Me)
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        query = "ObtenerTodosLosTickets"
        DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)
        mostrarSelecion()

        LabelActividad.Text = "Eliminar Ticket"
        LabelActividad.BackColor = Color.FromArgb(250, 80, 80)
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 80, 80)

        PictureBox1.Image = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\5. PARCIALES\PARCIAL #2\parcial2\parcial2\IMG\eliminar 3.png")
        LabelActividad.Visible = True
        RealizarTransicion(Me)
    End Sub



    Private Sub BtnIngresarNuevoTicket_Click(sender As Object, e As EventArgs) Handles BtnIngresarNuevoTicket.Click



        If TextBoxEquipo.Text = "" Then
            TextBoxEquipo.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxEquipo.BackColor = Color.White

        ElseIf TextBoxObservacion.Text = "" Then
            TextBoxObservacion.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxObservacion.BackColor = Color.White

        ElseIf TextBoxCostoInicial.Text = "" Then
            TextBoxCostoInicial.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxCostoInicial.BackColor = Color.White

        ElseIf TextBoxCostoFinal.Text = "" Then
            TextBoxCostoFinal.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Campo Vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxCostoFinal.BackColor = Color.White

        Else

            'realizar insersión
            If ListaTipoSoporte.Text = "Preventivo" Or ListaTipoSoporte.Text = "Correctivo" Or ListaTipoSoporte.Text = "Predictivo" Then

                If ListaEstado.Text = "En espera" Or ListaEstado.Text = "En proceso" Or ListaEstado.Text = "Terminado" Then

                    'UPDATE SEGÚN --------------------------------------------------------------------------
                    If LabelActividad.Text = "Aceptar Ticket" Then

                        querysBd.ActualizarTickets(ListaEstado.Text, ListaTipoSoporte.Text, TextBoxEquipo.Text, TextBoxCostoInicial.Text, TextBoxCostoFinal.Text, DateTime.Now.ToString("yyyy-MM-dd"), DateTimePicker1.Text, TextBoxObservacion.Text)
                        query = "ObtenerTicketsConUsuariosEnEspera"
                        DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)

                    ElseIf LabelActividad.Text = "Actualizar Ticket" Then
                        querysBd.ActualizarTickets(ListaEstado.Text, ListaTipoSoporte.Text, TextBoxEquipo.Text, TextBoxCostoInicial.Text, TextBoxCostoFinal.Text, querysBd.fechaInicio, DateTimePicker1.Text, TextBoxObservacion.Text)
                        DataGridView1.DataSource = ObtenerTodosLosTicketsProcesoResaltado()

                    End If

                    RealizarTransicion(Me)

                Else
                    ListaEstado.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("ERROR: Tipo de Estado NO válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ListaEstado.BackColor = Color.White
                End If

            Else
                ListaTipoSoporte.BackColor = Color.FromArgb(255, 222, 222)
                MessageBox.Show("ERROR: Tipo de Soporte NO válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ListaTipoSoporte.BackColor = Color.White

            End If

        End If

        PictureBox1.Visible = False
        panelIngresoDatos2.Visible = False
        mostrarSelecion()
    End Sub


    Sub mostrarSelecion()
        PanelBotones.Visible = False
        PanelSelecion.Visible = True
        RealizarTransicion(Me)
    End Sub
    Sub mostrarBotones()
        PanelBotones.Visible = True
        PanelSelecion.Visible = False
        RealizarTransicion(Me)
    End Sub

    Private Sub BtnSalirSeleccion_Click(sender As Object, e As EventArgs) Handles BtnSalirSeleccion.Click
        mostrarBotones()
        LabelActividad.Visible = False
        If LabelActividad.Text = "Actualizar Ticket" Or LabelActividad.Text = "Aceptar Ticket" Then
            panelIngresoDatos2.Visible = False
            PictureBox1.Visible = False
        End If
        query = "ObtenerTodosLosTickets"
        DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)

        PictureBox1.Visible = True
        PictureBox1.Image = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\5. PARCIALES\PARCIAL #2\parcial2\parcial2\IMG\ADMINISTRACION.png")



        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 116, 255)
        RealizarTransicion(Me)
    End Sub



    'CONTROL DE TEXBOXT COSTOS
    Private Sub TextBoxCostoInicial_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCostoInicial.TextChanged
        If TextBoxCostoInicial.Text.Count(Function(c) c = ".") = 0 And contadorDot = 1 Then
            contadorDot = 0
        End If

        If LabelActividad.Text = "Aceptar Ticket" Then
            TextBoxCostoFinal.Enabled = False
            TextBoxCostoFinal.Text = TextBoxCostoInicial.Text
        End If

    End Sub

    'CONTROL DE TEXBOXT
    Private Sub TextBoxCostoInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCostoInicial.KeyPress
        'CANCELACIÓN
        If contadorDot = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxCostoInicial.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot += 1
                End If

                TextBoxCostoInicial.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxCostoInicial.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxCostoInicial.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub TextBoxCostoFinal_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCostoFinal.TextChanged
        If TextBoxCostoFinal.Text.Count(Function(c) c = ".") = 0 And contadorDot2 = 1 Then
            contadorDot2 = 0
        End If



    End Sub

    Private Sub TextBoxCostoFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCostoFinal.KeyPress
        'CANCELACIÓN
        If contadorDot2 = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxCostoFinal.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot2 += 1
                End If

                TextBoxCostoFinal.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxCostoFinal.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxCostoFinal.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click

        'SI NO ESTÁ VACÍO
        If TextBoxId.Text <> "" Then

            'CONTROL DETERMINAR SI EL ID EXISTE Y HACER EL UPDATE
            Dim idBuscado As Integer
            If Integer.TryParse(Convert.ToInt32(TextBoxId.Text), idBuscado) Then
                Dim existeId As Boolean = False

                For Each fila As DataGridViewRow In DataGridView1.Rows
                    Dim valorCelda As Integer
                    If fila.Cells("idTiket").Value IsNot Nothing AndAlso Integer.TryParse(fila.Cells("idTiket").Value.ToString(), valorCelda) Then
                        If valorCelda = idBuscado Then
                            existeId = True
                            Exit For
                        End If
                    End If
                Next

                'SI EL ID EXISTE
                If existeId Then

                    PictureBox1.Visible = False

                    If LabelActividad.Text = "Aceptar Ticket" Then

                        If querysBd.selectTicketEnEspera(Convert.ToInt32(TextBoxId.Text)) = 1 Then

                            If LabelActividad.Text <> "Eliminar Ticket" Then
                                panelIngresoDatos2.Visible = True
                                PanelSelecion.Visible = False
                            End If

                            TextBoxEquipo.Text = querysBd.equipo
                            ListaEstado.Text = querysBd.estado
                            ListaTipoSoporte.Text = querysBd.tipoSoporte
                            LabelUsuario.Text = querysBd.usuario
                            LabelId.Text = querysBd.idUsuario
                            TextBoxObservacion.Text = querysBd.Observacion


                        End If

                    ElseIf LabelActividad.Text = "Actualizar Ticket" Then

                        If querysBd.selectTickets(Convert.ToInt32(TextBoxId.Text)) = 1 Then

                            If LabelActividad.Text <> "Eliminar Ticket" Then
                                panelIngresoDatos2.Visible = True
                                PanelSelecion.Visible = False
                            End If

                            TextBoxEquipo.Text = querysBd.equipo
                            ListaEstado.Text = querysBd.estado
                            ListaTipoSoporte.Text = querysBd.tipoSoporte
                            LabelUsuario.Text = querysBd.usuario
                            LabelId.Text = querysBd.idUsuario
                            TextBoxObservacion.Text = querysBd.Observacion

                            TextBoxCostoFinal.Text = querysBd.costoFinal
                            TextBoxCostoInicial.Text = querysBd.costoInicio

                            DateTimePicker1.Text = querysBd.fechaFinalizacion



                        End If

                        'ELIMICACIÓN
                    Else
                        SystemSounds.Exclamation.Play()
                        LabelMensaje.Text = "¿ Seguro quieres eliminar el ticket #" & TextBoxId.Text & " ?"
                        PanelConfirmación.Visible = True

                        PanelSelecion.Visible = False
                    End If

                    RealizarTransicion(Me)
                Else
                    MessageBox.Show("El ID No Se Encuentra Entre Las Tuplas Mostradas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Por favor, ingresa un valor entero válido.")
            End If

        Else


            TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
            MessageBox.Show("ERROR: Ingrese un Valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxId.BackColor = Color.White

        End If

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        panelIngresoDatos2.Visible = False
        PanelSelecion.Visible = Visible
        PictureBox1.Visible = True
        RealizarTransicion(Me)
    End Sub


    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting


        If LabelActividad.Text = "Actualizar Ticket" Then

            If DataGridView1.Columns(e.ColumnIndex).Name = "fechaFinalizacion" Then
                Dim value = e.Value

                If Not DBNull.Value.Equals(value) Then
                    Dim fechaFinalizacion As Date = CDate(value)
                    Dim diasRestantes As Integer = (fechaFinalizacion - DateTime.Now).Days


                    ' Verificar si la fecha de finalización está próxima
                    If diasRestantes <= 3 And diasRestantes >= 0 Then

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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        PanelSelecion.Visible = True
        PictureBox1.Visible = True
        PanelConfirmación.Visible = False
        RealizarTransicion(Me)
    End Sub


    Private Sub TextBoxId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxId.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxId.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            TextBoxId.BackColor = Color.White

        End If
    End Sub


    'QUERY ELIMINAR REGISTRO---------------------------------------------------------------------------------------

    Private Function EliminarTicket(idTicket As Integer) As Boolean
        Dim query As String = "DELETE FROM Tickets WHERE idTiket = @idTicket"

        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idTicket", idTicket)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el registro: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub BtnAceptarEliminacion_Click(sender As Object, e As EventArgs) Handles BtnAceptarEliminacion.Click

        If EliminarTicket(TextBoxId.Text) Then

            MessageBox.Show("El registro se eliminó correctamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("No se encontró ningún registro con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        PanelSelecion.Visible = True
        PictureBox1.Visible = True
        PanelConfirmación.Visible = False
        query = "ObtenerTodosLosTickets"
        DataGridView1.DataSource = querysBd.ObtenerTodosLosTickets(query)
        RealizarTransicion(Me)
    End Sub
End Class
