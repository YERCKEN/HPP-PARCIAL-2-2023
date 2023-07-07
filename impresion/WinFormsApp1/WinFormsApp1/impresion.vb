Imports Microsoft.Office.Interop

Imports System.Data.SqlClient
Imports System.Media

Public Class impresion

    Public cadenaConexion As String = "Data source =YERCKEN\SQLEXPRESS; Initial Catalog=parcial2Hpp; integrated security = true"
    Public Property UserID As Integer

    Dim idTickets As String = ""
    Dim nombresUsuarios As String = ""
    Dim estados As String = ""
    Dim tiposSoporte As String = ""
    Dim equipos As String = ""
    Dim costosIniciales As String = ""
    Dim costosFinales As String = ""
    Dim fechasInicio As String = ""
    Dim fechasFinalizacion As String = ""
    Dim observaciones As String = ""

    Dim idTicketParam As String = ""

    Private Sub impresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = obtenerTicketsUsuario()
        Dim UserID As Integer = Me.UserID

        MsgBox("ID RECOGIDO :  " & UserID)
    End Sub


    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click


        imprimirFactura()


    End Sub

    Sub imprimirFactura()
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlApp As Excel.Application



        Dim savePath As String = "C:\Users\edkac\Downloads\Factura.xlsx"

        Try
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add()
            xlWorkSheet = CType(xlWorkBook.Sheets("Hoja1"), Excel.Worksheet)

            'Personaliza el tipo de letra.
            xlWorkSheet.Range("B2:F24").Font.Name = "Arial"

            xlWorkSheet.Range("B2:F24").RowHeight = 100 ' Establece la altura de la fila a 30 puntos

            'Personaliza el tamaño de letra de las celdas.
            xlWorkSheet.Range("B2").Font.Size = 72
            xlWorkSheet.Range("D2:F8").Font.Size = 10
            xlWorkSheet.Range("B9:F23").Font.Size = 10
            xlWorkSheet.Range("B4:F24").Font.Size = 12
            xlWorkSheet.Range("D4:F4").Font.Size = 22
            ' Cambiar el color de letra de¡ las celdas

            xlWorkSheet.Range("A1:L24").Interior.Color = Color.White


            xlWorkSheet.Range("B2:C8").Font.Name = "Astrolab" ' Establece la fuente a Arial


            xlWorkSheet.Range("B2:F10").Font.Color = Color.White

            xlWorkSheet.Range("D3:F3").Font.Color = Color.FromArgb(83, 97, 98)

            'EMPRESA JK		
            xlWorkSheet.Range("D4:F4").Font.Color = Color.FromArgb(67, 116, 255)

            xlWorkSheet.Range("D5:F5").Font.Color = Color.FromArgb(83, 97, 98)





            xlWorkSheet.Range("B2:C8").Font.Color = Color.FromArgb(67, 116, 255)

            xlWorkSheet.Range("D6:F6").Font.Color = Color.FromArgb(83, 97, 98)
            xlWorkSheet.Range("D7:F7").Font.Color = Color.FromArgb(83, 97, 98)
            xlWorkSheet.Range("B11:B16").Font.Color = Color.White
            xlWorkSheet.Range("B17:F17").Font.Color = Color.White
            xlWorkSheet.Range("B19:F21").Font.Color = Color.White
            xlWorkSheet.Range("B23:F24").Font.Color = Color.White
            ' Hace que el texto sea negrita.
            xlWorkSheet.Range("B2:F8").Font.Bold = True
            xlWorkSheet.Range("B9:B16").Font.Bold = True
            xlWorkSheet.Range("C9:F10").Font.Bold = True
            xlWorkSheet.Range("B17:F17").Font.Bold = True
            xlWorkSheet.Range("B19:F19").Font.Bold = True
            xlWorkSheet.Range("B20").Font.Bold = True
            xlWorkSheet.Range("B21:F21").Font.Bold = True
            xlWorkSheet.Range("B23").Font.Bold = True
            xlWorkSheet.Range("B24:F24").Font.Bold = True
            ' Establecer el ancho y la altura de las celdas
            'columnas
            xlWorkSheet.Range("B1").ColumnWidth = 28.57
            xlWorkSheet.Range("C1").ColumnWidth = 28.14
            xlWorkSheet.Range("D1").ColumnWidth = 14.14
            xlWorkSheet.Range("E1").ColumnWidth = 31.43
            xlWorkSheet.Range("F1").ColumnWidth = 22.57
            'filas
            xlWorkSheet.Range("G2:G16").RowHeight = 16
            xlWorkSheet.Range("G4").RowHeight = 36
            xlWorkSheet.Range("G17").RowHeight = 23
            xlWorkSheet.Range("G18").RowHeight = 52
            xlWorkSheet.Range("G20:G23").RowHeight = 19
            xlWorkSheet.Range("G19").RowHeight = 50
            ' Personaliza el color de  fondo.
            'color black
            xlWorkSheet.Range("B2:C8").Interior.Color = Color.White
            xlWorkSheet.Range("D2:F2").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("D4:F4").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("D6:F6").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("D8:F8").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("D10:F10").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("B11:B16").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("B19:F19").Interior.Color = Color.FromArgb(67, 116, 255)
            'color darkgray
            xlWorkSheet.Range("D3:F3").Interior.Color = Color.White
            xlWorkSheet.Range("D5:F5").Interior.Color = Color.White
            xlWorkSheet.Range("D7:F7").Interior.Color = Color.White

            xlWorkSheet.Range("D2:F8").Interior.Color = Color.White


            xlWorkSheet.Range("B9:B10").Interior.Color = Color.DarkGray
            xlWorkSheet.Range("D9").Interior.Color = Color.DarkGray
            xlWorkSheet.Range("B17:F17").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("B21:F21").Interior.Color = Color.White
            xlWorkSheet.Range("B20").Interior.Color = Color.White
            xlWorkSheet.Range("B23").Interior.Color = Color.White
            'color gray
            xlWorkSheet.Range("B9:F10").Interior.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("C9:F10").Interior.Color = Color.White
            xlWorkSheet.Range("C9:F10").Font.Color = Color.FromArgb(83, 97, 98)

            xlWorkSheet.Range("C9:C16").Font.Color = Color.FromArgb(149, 160, 161)
            xlWorkSheet.Range("E11:F12").Font.Color = Color.FromArgb(149, 160, 161)
            xlWorkSheet.Range("F11:F16").Font.Color = Color.FromArgb(149, 160, 161)

            xlWorkSheet.Range("E9:F9").Font.Color = Color.FromArgb(149, 160, 161)

            xlWorkSheet.Range("C20:F20").Interior.Color = Color.White
            xlWorkSheet.Range("C23:F23").Interior.Color = Color.White
            'color white
            xlWorkSheet.Range("D11:F11").Interior.Color = Color.White
            xlWorkSheet.Range("D13:F13").Interior.Color = Color.White
            xlWorkSheet.Range("D15:F15").Interior.Color = Color.White
            xlWorkSheet.Range("B18:F18").Interior.Color = Color.White

            xlWorkSheet.Range("B18:F18").Interior.Color = Color.White

            'color smoke white
            xlWorkSheet.Range("D12:F12").Interior.Color = Color.White
            xlWorkSheet.Range("D14:F14").Interior.Color = Color.White
            xlWorkSheet.Range("D16:F16").Interior.Color = Color.White
            xlWorkSheet.Range("B22:F22").Font.Color = Color.FromArgb(149, 160, 161)



            'LABELS DE LOS DATOS TIKETS
            xlWorkSheet.Range("B9:B16").Font.Color = Color.FromArgb(83, 97, 98)

            xlWorkSheet.Range("B9:B16").Interior.Color = Color.White


            ' Agrega datos a la hoja de trabajo.           Formato de tabla
            'fila , columna
            '--------------------------------------------------
            'Logo JK
            xlWorkSheet.Cells(2, 2) = "JK"
            '--------------------------------------------------------------
            'info de RUC
            'fila, columna

            xlWorkSheet.Cells(3, 4) = "Comprobante de Factura Electronica"
            xlWorkSheet.Cells(4, 4) = "EMPRESA JK"
            xlWorkSheet.Cells(5, 4) = "R.U.C 000000-0000-000000"
            xlWorkSheet.Cells(6, 4) = "DAVID, AV. 3RA, ENTRE AV. OBALDIA Y AV. BALBOA"
            xlWorkSheet.Cells(7, 4) = "Telefono: 665-1412  o 923-9234"
            xlWorkSheet.Cells(8, 4) = "FACTURA"
            '--------------------------------------------------------------
            'info del cliente
            'fila, columna



            xlWorkSheet.Cells(9, 2) = "Usuario"
            xlWorkSheet.Cells(11, 2) = "No.Usuario"
            xlWorkSheet.Cells(12, 2) = "Equipo"
            xlWorkSheet.Cells(13, 2) = "Tipo de Soporte"
            xlWorkSheet.Cells(14, 2) = "Estado"
            xlWorkSheet.Cells(15, 2) = "Fecha de Inicio"
            xlWorkSheet.Cells(16, 2) = "Fecha de Finalización"


            '-------------------------------------------------------------

            xlWorkSheet.Cells(9, 3) = nombresUsuarios
            xlWorkSheet.Cells(9, 5) = idTicketParam

            xlWorkSheet.Cells(11, 3) = UserID
            xlWorkSheet.Cells(12, 3) = equipos
            xlWorkSheet.Cells(13, 3) = tiposSoporte
            xlWorkSheet.Cells(14, 3) = estados
            xlWorkSheet.Cells(15, 3) = fechasInicio
            xlWorkSheet.Cells(16, 3) = fechasFinalizacion
            xlWorkSheet.Cells(18, 2) = observaciones


            xlWorkSheet.Cells(11, 6) = costosIniciales
            xlWorkSheet.Cells(12, 6) = costosFinales

            xlWorkSheet.Cells(16, 6) = costosFinales




            'tabla de costos
            'fila, columna
            xlWorkSheet.Cells(9, 4) = "No.Ticket"
            xlWorkSheet.Cells(10, 5) = "Descripcion"
            xlWorkSheet.Cells(11, 5) = "CostoInicial"
            xlWorkSheet.Cells(12, 5) = "CostoFinal"

            xlWorkSheet.Cells(10, 6) = "Precio"
            xlWorkSheet.Cells(14, 5) = "Sub total"
            '.Cells(15, 5) = "Impuesto (7%)"
            xlWorkSheet.Cells(16, 5) = "Total"
            '----------------------------------------------------------
            'informacion adicional
            xlWorkSheet.Cells(17, 2) = "Observacion de Costos Extras"

            xlWorkSheet.Cells(19, 2) = "GRACIAS POR PREFERIRNOS"
            '*********************************************************
            'centrar y combinar 
            ' Combinar celdas
            'logo
            xlWorkSheet.Range("B2:C8").Merge()
            'encabezado
            xlWorkSheet.Range("D2:F2").Merge()
            xlWorkSheet.Range("D3:F3").Merge()
            xlWorkSheet.Range("D4:F4").Merge()
            xlWorkSheet.Range("D5:F5").Merge()
            xlWorkSheet.Range("D6:F6").Merge()
            xlWorkSheet.Range("D7:F7").Merge()
            xlWorkSheet.Range("D8:F8").Merge()
            'datos de cliente
            ' xlWorkSheet.Range("B9:B10").Merge()
            'xlWorkSheet.Range("C9:C10").Merge()
            'Tabla Precios
            xlWorkSheet.Range("E9:F9").Merge()
            'otros Datos
            xlWorkSheet.Range("B17:F17").Merge()
            xlWorkSheet.Range("B18:F18").Merge()
            xlWorkSheet.Range("B19:F19").Merge()
            xlWorkSheet.Range("C20:F20").Merge()
            xlWorkSheet.Range("C21:F21").Merge()
            xlWorkSheet.Range("C22:F22").Merge()
            xlWorkSheet.Range("C23:F23").Merge()
            xlWorkSheet.Range("B24:F24").Merge()


            ' Centra el contenido de cada celda.
            xlWorkSheet.Range("B2:F8").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B9:B16").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("D9").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("D10:F10").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("D11:D16").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("E11:E13").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("E14:E16").HorizontalAlignment = Excel.Constants.xlRight
            xlWorkSheet.Range("B17:F17").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B19:F19").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B20").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B21:F21").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B22:F22").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B23").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B24:F24").HorizontalAlignment = Excel.Constants.xlCenter
            ' Alinear el texto en el medio de la celda
            xlWorkSheet.Range("B2:F8").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("B9:B16").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("D9").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("D10:F10").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("D11:D16").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("E11:E13").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("D10:F10").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("E14:E16").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("B17:F17").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("B19:F19").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range("B20:F24").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



            xlWorkSheet.Range("B18:F18").HorizontalAlignment = Excel.Constants.xlCenter
            xlWorkSheet.Range("B18:F18").Font.Color = Color.FromArgb(149, 160, 161)

            'LABELS DE LOS DATOS TIKETS
            'xlWorkSheet.Range("F11:F16").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            xlWorkSheet.Range("F11:F16").NumberFormat = "$#,##0.00"
            xlWorkSheet.Range("B9:B16").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

            xlWorkSheet.Range("C9:C16").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'LABELS TIPOS DE PAGO
            xlWorkSheet.Range("B20").Font.Color = Color.FromArgb(67, 116, 255)
            xlWorkSheet.Range("B23").Font.Color = Color.FromArgb(67, 116, 255)

            ' Autoajustar contenido
            ' Autoajustar el alto de la fila 1

            xlWorkSheet.Range("C11").WrapText = True
            xlWorkSheet.Range("C14").WrapText = True
            xlWorkSheet.Range("C15").WrapText = True
            xlWorkSheet.Range("E11").WrapText = True
            xlWorkSheet.Range("E12").WrapText = True
            xlWorkSheet.Range("B18:F18").WrapText = True

            xlWorkSheet.Range("E9:F9").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            'VALORES


            ' Guardar el archivo
            xlWorkBook.SaveAs(savePath)

            ' Cerrar y liberar recursos
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MessageBox.Show("Archivo guardado con éxito.")
        Catch ex As Exception
            MessageBox.Show("No se pudo guardar el archivo. Asegúrate de que el archivo no esté abierto en otra aplicación.")
        End Try




    End Sub




    Public Function obtenerTicketsUsuario() As DataTable

        Dim query As String = "EXEC ObtenerTicketsPorUsuario @idUsuario"

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idUsuario", UserID)

                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                Catch ex As Exception
                    ' Manejar excepciones aquí
                End Try
            End Using
        End Using

        Return dataTable
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
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

    Private Function ExisteIdEnDataGridView(id As Integer) As Boolean
        For Each fila As DataGridViewRow In DataGridView1.Rows
            ' Obtener el valor de la celda correspondiente al ID en la fila actual
            Dim valorCelda As Integer = Convert.ToInt32(fila.Cells("idTiket").Value)

            ' Verificar si el ID coincide con el valor ingresado en el TextBox
            If valorCelda = id Then
                Return True ' El ID existe en el DataGridView
            End If
        Next

        Return False ' El ID no existe en el DataGridView
    End Function

    Private Sub BtnSeleccionarTicket_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarTicket.Click
        If TextBoxId.Text <> "" Then

            If ExisteIdEnDataGridView(TextBoxId.Text) Then
                BtnFactura.Visible = True

                idTicketParam = TextBoxId.Text

                obtenerTicketsUsuario(UserID, nombresUsuarios, estados, tiposSoporte, equipos, costosIniciales, costosFinales, fechasInicio, fechasFinalizacion, observaciones, idTicketParam)
                MessageBox.Show("ID del Ticket: " & idTicketParam & vbCrLf &
                "Nombre del Usuario: " & nombresUsuarios & vbCrLf &
                "Estado: " & estados & vbCrLf &
                "Tipo de Soporte: " & tiposSoporte & vbCrLf &
                "Equipo: " & equipos & vbCrLf &
                "Costo Inicial: " & costosIniciales & vbCrLf &
                "Costo Final: " & costosFinales & vbCrLf &
                "Fecha de Inicio: " & fechasInicio & vbCrLf &
                "Fecha de Finalización: " & fechasFinalizacion & vbCrLf &
                "Observaciones: " & observaciones)







                'idTickets = ""
                'nombresUsuarios = ""
                'estados = ""
                'tiposSoporte = ""
                'equipos = ""
                'costosIniciales = ""
                'costosFinales = ""
                'fechasInicio = ""
                'fechasFinalizacion = ""
                'observaciones = ""

                'idTicketParam = ""
            Else
                MessageBox.Show("El ID no está en la tabla o no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxId.Text = ""
                BtnFactura.Visible = False

            End If


        End If
    End Sub

    Public Sub obtenerTicketsUsuario(ByRef idTicket As String,
                                 ByRef nombreUsuario As String,
                                 ByRef estado As String,
                                 ByRef tipoSoporte As String,
                                 ByRef equipo As String,
                                 ByRef costoInicial As String,
                                 ByRef costoFinal As String,
                                 ByRef fechaInicio As String,
                                 ByRef fechaFinalizacion As String,
                                 ByRef observacion As String,
                                 ByVal idTicketParam As Integer)

        Dim query As String = "EXEC ObtenerTicketsPo @idTicket"

        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idTicket", idTicketParam)

                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        idTicket = reader.GetInt32(0).ToString()
                        nombreUsuario = reader.GetString(1)
                        estado = reader.GetString(2)
                        tipoSoporte = reader.GetString(3)
                        equipo = reader.GetString(4)
                        costoInicial = reader.GetDecimal(5).ToString()
                        costoFinal = reader.GetDecimal(6).ToString()
                        fechaInicio = reader.GetDateTime(7).ToString()
                        fechaFinalizacion = reader.GetDateTime(8).ToString()
                        observacion = reader.GetString(9)
                    End If
                Catch ex As Exception
                    ' Manejar excepciones aquí
                End Try
            End Using
        End Using
    End Sub


End Class