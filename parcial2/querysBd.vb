Imports System.Data.SqlClient

Module querysBd

    'FUNCIÓN LOGIN------------------------------------------------------------------------------
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

    'FUNCIÓN RESGISTRO 


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

End Module
