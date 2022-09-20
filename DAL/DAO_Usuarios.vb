Imports System.Data.SqlClient
Imports System.Configuration
Public Class DAO_Usuarios
    'Variables Globales
    Public ConexionBD As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public ComandoBD As SqlCommand

#Region "Insertar NuevoUsuario"
    Public Function InsertarNuevoUsuario(ByVal Usuario As String, ByVal Contraseña As String, ByVal Nombre As String, ByVal CorreoElectronico As String, ByVal EstadoUsuari As String) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_Insertar_Usuario", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Usuario", Usuario)
            ComandoBD.Parameters.AddWithValue("@Contraseña", Contraseña)
            ComandoBD.Parameters.AddWithValue("@Nombre", Nombre)
            ComandoBD.Parameters.AddWithValue("@Correo_Electronico", CorreoElectronico)
            ComandoBD.Parameters.AddWithValue("@Estado_Usuario", EstadoUsuari)
            'Validamos cuantas filas se afectaron con el procedimiento si es mayor a 0 significa que se ejecuto con exito
            FilasAfectadas = ComandoBD.ExecuteNonQuery
            'Cerramos la conexion a la base de datos
            ConexionBD.Close()
            'validamos las fila afectadas para cambiar el estado del booleano
            If FilasAfectadas > 0 Then
                EstadoInsertar = True
            End If
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "ActualizarUsuario"
    Public Function ActualizarUsuario(ByVal Usuario As String, ByVal Contraseña As String, ByVal Nombre As String, ByVal CorreoElectronico As String, ByVal EstadoUsuari As String) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_ActualizarUsuarios", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Usuario", Usuario)
            ComandoBD.Parameters.AddWithValue("@Contraseña", Contraseña)
            ComandoBD.Parameters.AddWithValue("@Nombre", Nombre)
            ComandoBD.Parameters.AddWithValue("@Correo_Electronico", CorreoElectronico)
            ComandoBD.Parameters.AddWithValue("@Estado_Usuario", EstadoUsuari)
            'Validamos cuantas filas se afectaron con el procedimiento si es mayor a 0 significa que se ejecuto con exito
            FilasAfectadas = ComandoBD.ExecuteNonQuery
            'Cerramos la conexion a la base de datos
            ConexionBD.Close()
            'validamos las fila afectadas para cambiar el estado del booleano
            If FilasAfectadas > 0 Then
                EstadoInsertar = True
            End If
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try



    End Function
#End Region

#Region "EliminarUsuario"
    Public Function Eliminar_Usuario(ByVal Usuario As String)
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_EliminarUsuario", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@usuario", Usuario)
            'Validamos cuantas filas se afectaron con el procedimiento si es mayor a 0 significa que se ejecuto con exito
            FilasAfectadas = ComandoBD.ExecuteNonQuery
            'Cerramos la conexion a la base de datos
            ConexionBD.Close()
            'validamos las fila afectadas para cambiar el estado del booleano
            If FilasAfectadas > 0 Then
                EstadoInsertar = True
            End If
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region


#Region "ListarUsuarios"
    Public Function ListarUsuarios() As DataTable
        Dim Table As New DataTable
        Try
            ConexionBD.Open()
            ComandoBD = New SqlCommand("PA_ListarUsuarios", ConexionBD) 'Se indica el nombre del proceidmiento almacenado
            'Se debe indicar el tipo de transaccion
            ComandoBD.CommandType = CommandType.StoredProcedure
            Dim dataAdapter As New SqlDataAdapter(ComandoBD)
            'Guardamos las filas consultadas en el dataTable
            dataAdapter.Fill(Table)
            'Returnamos el DataTable
            ConexionBD.Close()
            Return Table
        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region


End Class
