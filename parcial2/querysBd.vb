Imports System.Data.SqlClient

Module querysBd

    Public UsuarioID As Integer
    Public Nombre As String
    Public Apellido As String
    Public UsuarioObtenido As String
    Public Correo As String
    Public Rol As String



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

End Module
