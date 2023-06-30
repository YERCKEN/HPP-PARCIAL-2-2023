Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Module querysBd

    Public UsuarioID As Integer
    Public Nombre As String
    Public Apellido As String
    Public UsuarioObtenido As String
    Public Correo As String
    Public Rol As String

    'SELECT
    Public ticketId As Integer
    Public usuario As String
    Public idUsuario As Integer
    Public estado As String
    Public tipoSoporte As String
    Public equipo As String
    Public costoInicio As Decimal
    Public costoFinal As Decimal
    Public fechaInicio As Date
    Public fechaFinalizacion As Date
    Public Observacion As String



    'FUNCIÓN LOGIN==============================================================================================================
    Public Function Login(usuario As String, contraseña As String) As Integer
        Dim resultado As Integer = 0

        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            ' Abrir la conexión
            connection.Open()

            ' Crear un comando SQL que llame al procedimiento almacenado
            Using command As New SqlCommand("VerificarLogin", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros al comando
                command.Parameters.AddWithValue("@usuario", usuario)
                command.Parameters.AddWithValue("@contraseña", contraseña)

                ' Ejecutar el comando y obtener el resultado
                resultado = CInt(command.ExecuteScalar())
            End Using
        End Using

        ' Devolver el resultado
        Return resultado
    End Function



    'FUNCIÓN RESGISTRO ===================================================================================================================================================

    ' Función para registrar un nuevo usuario
    Public Function Registro(nombre As String, apellido As String, usuario As String, correo As String, contraseña As String, rolId As Integer) As Integer
        Dim resultado As Integer = 0

        ' Crear la conexión a la base de datos
        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear el comando SQL para llamar al procedimiento almacenado
                Using command As New SqlCommand("InsertarUsuario", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Pasar los parámetros al comando
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellido", apellido)
                    command.Parameters.AddWithValue("@usuario", usuario)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@contraseña", contraseña)
                    command.Parameters.AddWithValue("@rolId", rolId)

                    ' Ejecutar el comando y obtener el resultado
                    resultado = Convert.ToInt32(command.ExecuteScalar())
                End Using
            Catch ex As Exception
                ' Manejar cualquier excepción que pueda ocurrir durante el proceso
                Console.WriteLine("Error en el registro: " & ex.Message)
            End Try
        End Using

        ' Retornar el resultado obtenido del procedimiento almacenado
        Return resultado
    End Function

    'FUCIÓN SELECCIÓN DE DATOS ==============================================================================================================

    Public Function ObtenerUsuariosConRoles(ByVal usuario As String)


        Dim connection As New SqlConnection(variablesGlobales.cadenaConexion)

        Try
            ' Abrir la conexión
            connection.Open()

            ' Crear el comando para ejecutar el procedimiento almacenado
            Dim command As New SqlCommand("ObtenerUsuariosConRoles", connection)
            command.CommandType = CommandType.StoredProcedure

            ' Parámetro de entrada
            command.Parameters.AddWithValue("@usuario", usuario)

            ' Ejecutar el comando y obtener el resultado en un lector de datos
            Dim reader As SqlDataReader = command.ExecuteReader()

            ' Leer los datos obtenidos
            If reader.Read() Then
                UsuarioID = CInt(reader("UsuarioID"))
                Nombre = reader("Nombre").ToString()
                Apellido = reader("Apellido").ToString()
                UsuarioObtenido = reader("Usuario").ToString()
                Correo = reader("Correo").ToString()
                Rol = reader("Rol").ToString()
            End If

            ' Cerrar el lector de datos
            reader.Close()
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Error al obtener los datos: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try



    End Function


    'obTener tikets de cada usuario
    Public Function obtenerTicketsUsuario() As DataTable

        Dim query As String = "EXEC ObtenerTicketsPorUsuario @idUsuario"

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idUsuario", UsuarioID)

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

    'insertar nuevo tiket ================================================================================================
    Public Sub InsertarTicket(idUsuario As Integer, observacion As String, tipoSoporte As String, equipo As String)
        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            connection.Open()
            Dim command As New SqlCommand("InsertarTicket", connection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@idUsuario", idUsuario)
            command.Parameters.AddWithValue("@observacion", observacion)
            command.Parameters.AddWithValue("@tipoSoporte", tipoSoporte)
            command.Parameters.AddWithValue("@equipo", equipo)

            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ObtenerTodosLosTickets(query As String) As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            Try
                connection.Open()

                ' Crear el comando y asignar el nombre del procedimiento almacenado
                Dim command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear el adaptador y llenar la tabla
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)



            Catch ex As Exception
                MessageBox.Show("Error al obtener los tickets con usuarios: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return dataTable
    End Function

    Public Function ObtenerTodosLosTicketsProcesoResaltado() As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            Try
                connection.Open()

                ' Crear el comando y asignar el nombre del procedimiento almacenado
                Dim command As New SqlCommand("ObtenerTicketsConUsuariosEnProceso", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear el adaptador y llenar la tabla
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dataTable)

                ' Ordenar la tabla por la columna 'fechaFinalizacion'
                dataTable.DefaultView.Sort = "fechaFinalizacion ASC"
                dataTable = dataTable.DefaultView.ToTable()

            Catch ex As Exception
                MessageBox.Show("Error al obtener los tickets con usuarios: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return dataTable
    End Function



    'SELECCI+ÓN DEL TIKET
    Public Function selectTicketEnEspera(ByVal idTicket As Integer) As Integer
        Dim valor As Integer = 1
        Dim connection As New SqlConnection(variablesGlobales.cadenaConexion)
        Dim command As New SqlCommand("VerificarTicket", connection)
        command.CommandType = CommandType.StoredProcedure

        ' Parámetro de entrada
        command.Parameters.AddWithValue("@idTiket", idTicket)

        Try
            connection.Open()

            ' Ejecutar el procedimiento almacenado
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                ' Si se encontraron resultados, guardar los datos en variables
                While reader.Read()

                    ticketId = reader.GetInt32(reader.GetOrdinal("idTiket"))
                    usuario = reader.GetString(reader.GetOrdinal("usuario"))
                    idUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario"))
                    estado = reader.GetString(reader.GetOrdinal("estado"))
                    tipoSoporte = reader.GetString(reader.GetOrdinal("tipoSoporte"))
                    equipo = reader.GetString(reader.GetOrdinal("equipo"))
                    Observacion = reader.GetString(reader.GetOrdinal("Observacion"))




                End While
            Else
                ' Si no se encontraron resultados, lanzar una excepción
                Throw New Exception("El ID de ticket no existe.")
                valor = 0
            End If

            reader.Close()
        Catch ex As Exception
            ' Manejar la excepción
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            valor = 0

        Finally
            connection.Close()
        End Try

        Return valor

    End Function

    Public Function selectTickets(ByVal idTicket As Integer) As Integer
        Dim valor As Integer = 1
        Dim connection As New SqlConnection(variablesGlobales.cadenaConexion)
        Dim command As New SqlCommand("VerificarTicket", connection)
        command.CommandType = CommandType.StoredProcedure

        ' Parámetro de entrada
        command.Parameters.AddWithValue("@idTiket", idTicket)

        Try
            connection.Open()

            ' Ejecutar el procedimiento almacenado
            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                ' Si se encontraron resultados, guardar los datos en variables
                While reader.Read()

                    ticketId = reader.GetInt32(reader.GetOrdinal("idTiket"))
                    usuario = reader.GetString(reader.GetOrdinal("usuario"))
                    idUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario"))
                    estado = reader.GetString(reader.GetOrdinal("estado"))
                    tipoSoporte = reader.GetString(reader.GetOrdinal("tipoSoporte"))
                    equipo = reader.GetString(reader.GetOrdinal("equipo"))
                    Observacion = reader.GetString(reader.GetOrdinal("Observacion"))

                    costoInicio = reader.GetDecimal(reader.GetOrdinal("costoInicial"))
                    costoFinal = reader.GetDecimal(reader.GetOrdinal("costoFinal"))


                    fechaInicio = reader.GetDateTime(reader.GetOrdinal("fechaInicio"))
                    fechaFinalizacion = reader.GetDateTime(reader.GetOrdinal("fechaFinalizacion"))


                    'MsgBox("FECHA FINALIZACIÓN : " & fechaFinalizacion)

                End While
            Else
                ' Si no se encontraron resultados, lanzar una excepción
                Throw New Exception("El ID de ticket no existe.")
                valor = 0
            End If

            reader.Close()
        Catch ex As Exception
            ' Manejar la excepción
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            valor = 0

        Finally
            connection.Close()
        End Try

        Return valor

    End Function


    Public Sub ActualizarTickets(estado As String, tipoSoporte As String, equipo As String, costoInicial As Decimal, costoFinal As Decimal, fechaInicio As Date, fechaFinalizacion As Date, observacion As String)
        Using connection As New SqlConnection(variablesGlobales.cadenaConexion)
            connection.Open()

            Using command As New SqlCommand("ActualizarTicket", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Parámetros del procedimiento almacenado
                command.Parameters.AddWithValue("@idTicket", ticketId)
                command.Parameters.AddWithValue("@idUsuario", idUsuario)
                command.Parameters.AddWithValue("@estado", estado)
                command.Parameters.AddWithValue("@tipoSoporte", tipoSoporte)
                command.Parameters.AddWithValue("@equipo", equipo)
                command.Parameters.AddWithValue("@costoInicial", costoInicial)
                command.Parameters.AddWithValue("@costoFinal", costoFinal)
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
                command.Parameters.AddWithValue("@fechaFinalizacion", fechaFinalizacion)
                command.Parameters.AddWithValue("@observacion", observacion)

                ' Ejecutar el comando
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
