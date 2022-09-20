Imports System.Data.SqlClient
Imports System.Configuration
Public Class DAO_Empleados
    'Variables Globales
    Public ConexionBD As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public ComandoBD As SqlCommand

#Region "Insertar Empleado"
    Public Function InsertarEmpleado(ByVal ID_Empleado As Integer, ByVal NombreEmpleado As String, ByVal PrimerApellido As String, ByVal SegundoApellido As String, ByVal Nacionalidad As String, ByVal Sexo As String, ByVal EstadoCivil As String, ByVal FechaIngreso As Date, ByVal FechaNacimiento As Date, ByVal EstadoEmpleado As String, ByVal TipoEmpleado As String, ByVal SalarioBase As Double, ByVal CantidadHijos As Integer) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_NuevoIngreso_Empleado", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Id_Empleado", ID_Empleado)
            ComandoBD.Parameters.AddWithValue("@Nombre", NombreEmpleado)
            ComandoBD.Parameters.AddWithValue("@Primer_Apellido", PrimerApellido)
            ComandoBD.Parameters.AddWithValue("@Segundo_Apellido", SegundoApellido)
            ComandoBD.Parameters.AddWithValue("@Nacionalidad", Nacionalidad)
            ComandoBD.Parameters.AddWithValue("@Sexo", Sexo)
            ComandoBD.Parameters.AddWithValue("@Estado_Civil", EstadoCivil)
            ComandoBD.Parameters.AddWithValue("@Fecha_Ingreso", FechaIngreso)
            ComandoBD.Parameters.AddWithValue("@Fecha_Nacimiento", FechaNacimiento)
            ComandoBD.Parameters.AddWithValue("@Tipo_Empleado", TipoEmpleado)
            ComandoBD.Parameters.AddWithValue("@SalarioBase", SalarioBase)
            ComandoBD.Parameters.AddWithValue("@CantidadHijos", CantidadHijos)
            ComandoBD.Parameters.AddWithValue("@Estado_Empleado", EstadoEmpleado)
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

#Region "LeerEmpleadosBD_Completa"
    Public Function ListarEmpleados() As DataTable
        Dim Table As New DataTable
        Try
            ConexionBD.Open()
            ComandoBD = New SqlCommand("PA_ListarEmpleados", ConexionBD) 'Se indica el nombre del proceidmiento almacenado
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

#Region "LeerEmpleados_Incapacitados_Activos"
    Public Function ListarEmpleados_Activos_Incapacitados() As DataTable
        Dim Table As New DataTable
        Try
            ConexionBD.Open()
            ComandoBD = New SqlCommand("Leer_Empleados_Activos_Incapacitados", ConexionBD) 'Se indica el nombre del proceidmiento almacenado
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


#Region "EliminarEmpleado"
    Public Function Eliminar_Empleado(ByVal ID_Empleado As Integer)
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_Eliminar_Empleado", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@IDEmpleado", ID_Empleado)
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



#Region "Actualizar Empleado"
    Public Function ActualizarEmpleado(ByVal ID_Empleado As Integer, ByVal EstadoCivil As String, ByVal EstadoEmpleado As String, ByVal SalarioBase As Double, ByVal CantidadHijos As Integer) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_Modificar_Empleado", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Id_Empleado", ID_Empleado)
            ComandoBD.Parameters.AddWithValue("@Estado_Civil", EstadoCivil)
            ComandoBD.Parameters.AddWithValue("@Estado_Empleado", EstadoEmpleado)
            ComandoBD.Parameters.AddWithValue("@SalarioBase", SalarioBase)
            ComandoBD.Parameters.AddWithValue("@CantidadHijos", CantidadHijos)

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



End Class
