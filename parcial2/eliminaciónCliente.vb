Imports System.Data.SqlClient
Imports System.Media

Public Class eliminaciónCliente


    Private Sub eliminaciónCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Form1.Width) \ 2, (Screen.PrimaryScreen.WorkingArea.Height - Form1.Height) \ 2)



        Me.Location = New Point(Form1.Location.X, Form1.Location.Y + 49) ' Establecer la nueva ubicación de Form4 en relación con Form1

        DataGridView1.DataSource = obtenerDatosUsuarios()

        DataGridView1.Columns("id").HeaderText = "ID"
        DataGridView1.Columns("id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells




    End Sub

    'busquedad
    Private Sub TextBoxBusquedad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusquedad.TextChanged
        ' Obtener el texto ingresado en el TextBox de búsqueda
        Dim filtro As String = TextBoxBusquedad.Text.Trim()

        ' Obtener la vista de la tabla de datos del DataGridView
        Dim vista As DataView = DirectCast(DataGridView1.DataSource, DataTable).DefaultView

        ' Aplicar el filtro al campo "usuario" en la vista de datos
        vista.RowFilter = $"usuario LIKE '%{filtro}%'"
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



    'FUNCIÓN OBTENER LOS DATOS===================================================================================================
    Public Function obtenerDatosUsuarios() As DataTable
        ' Cadena de conexión a la base de datos

        ' Consulta SQL para obtener los datos de usuarios con nombre de rol
        Dim query As String = "SELECT U.id, U.nombre, U.apellido, U.usuario, U.correo, U.contraseña, R.rol " &
                              "FROM Usuarios U " &
                              "INNER JOIN Roles R ON U.rolId = R.id"

        ' Crear una tabla para almacenar los datos de usuarios
        Dim dataTable As New DataTable()

        Try
            ' Crear la conexión a la base de datos
            Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
                ' Crear el adaptador de datos
                Using adapter As New SqlDataAdapter(query, connection)
                    ' Llenar la tabla de datos con los resultados de la consulta
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            ' Manejar cualquier error de conexión o consulta aquí
            MessageBox.Show("Error al obtener los datos de usuarios: " & ex.Message)
        End Try

        ' Retornar la tabla de datos
        Return dataTable
    End Function


    'función eliminacipon
    Public Sub Eliminacion(idUsuario As Integer)


        ' Iniciar una transacción en SQL Server
        Dim transaction As SqlTransaction = Nothing

        Try
            ' Crear la conexión a la base de datos
            Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
                ' Abrir la conexión
                connection.Open()

                ' Iniciar la transacción
                transaction = connection.BeginTransaction()

                Try
                    ' Eliminar los registros relacionados en la tabla "Tickets"
                    Dim deleteTicketsQuery As String = "DELETE FROM Tickets WHERE idUsuario = @idUsuario"
                    Using deleteTicketsCommand As New SqlCommand(deleteTicketsQuery, connection, transaction)
                        deleteTicketsCommand.Parameters.AddWithValue("@idUsuario", idUsuario)
                        deleteTicketsCommand.ExecuteNonQuery()
                    End Using

                    ' Eliminar el usuario en la tabla "Usuarios"
                    Dim deleteUsuarioQuery As String = "DELETE FROM Usuarios WHERE id = @idUsuario"
                    Using deleteUsuarioCommand As New SqlCommand(deleteUsuarioQuery, connection, transaction)
                        deleteUsuarioCommand.Parameters.AddWithValue("@idUsuario", idUsuario)
                        deleteUsuarioCommand.ExecuteNonQuery()
                    End Using

                    ' Confirmar la transacción si todo fue exitoso
                    transaction.Commit()

                    MessageBox.Show("El usuario y sus registros en Tickets han sido eliminados correctamente.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    ' Si ocurre algún error, deshacer la transacción
                    transaction.Rollback()

                    MessageBox.Show("Error al eliminar el usuario y sus registros en Tickets: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            End Using
        Catch ex As Exception
            ' Manejar cualquier error de conexión aquí
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Function ExisteIdEnDataGridView(id As Integer) As Boolean
        For Each fila As DataGridViewRow In DataGridView1.Rows
            ' Obtener el valor de la celda correspondiente al ID en la fila actual
            Dim valorCelda As Integer = Convert.ToInt32(fila.Cells("id").Value)

            ' Verificar si el ID coincide con el valor ingresado en el TextBox
            If valorCelda = id Then
                Return True ' El ID existe en el DataGridView
            End If
        Next

        Return False ' El ID no existe en el DataGridView
    End Function


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        If TextBoxId.Text <> "" Then

            If ExisteIdEnDataGridView(TextBoxId.Text) Then
                DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 80, 80)
                SystemSounds.Exclamation.Play()
                LabelMensaje.Text = "¿ Seguro quieres eliminar el Usuario con ID: " & TextBoxId.Text & " ?"
                PanelConfirmación.Visible = True
                PanelSelecion.Visible = False
            Else
                MessageBox.Show("El ID no está en la tabla o no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxId.Text = ""
                TextBoxBusquedad.Text = ""
            End If


        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        PanelConfirmación.Visible = False
        PanelSelecion.Visible = True
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 116, 255)

    End Sub

    Private Sub BtnAceptarEliminacion_Click(sender As Object, e As EventArgs) Handles BtnAceptarEliminacion.Click



        Eliminacion(TextBoxId.Text)


        PanelConfirmación.Visible = False
        PanelSelecion.Visible = True
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 116, 255)
        TextBoxId.Text = ""
        TextBoxBusquedad.Text = ""
        DataGridView1.DataSource = obtenerDatosUsuarios()


    End Sub
End Class