Imports System.Data.SqlClient
Imports System.Configuration
Public Class DAO_ImpuestoRenta
    'Variables Globales
    Public ConexionBD As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public ComandoBD As SqlCommand

#Region "Insertar NuevoImpuestoRenta"
    Public Function InsertarImpuestoRenta(ByVal LimiteInferior As Double, ByVal LimiteSuperior As Double, ByVal PorcentajeAplicable As Double) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_InsertarImpuestosRenta", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Limite_inferior", LimiteInferior)
            ComandoBD.Parameters.AddWithValue("@Limite_superior", LimiteSuperior)
            ComandoBD.Parameters.AddWithValue("@Porcentaje_Aplicable", PorcentajeAplicable)
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

#Region "ActualizarImpuestoRenta"
    Public Function ActualizarImpuestoRenta(ByVal CodigoImpuesto As Integer, LimiteInferior As Double, LimiteSuperior As Double, PorcentajeAplicable As Double) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_ActualizarImpuestoRenta", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@codigo", CodigoImpuesto)
            ComandoBD.Parameters.AddWithValue("@limiteinferior", LimiteInferior)
            ComandoBD.Parameters.AddWithValue("@LimiteSuperior", LimiteSuperior)
            ComandoBD.Parameters.AddWithValue("@PorcentajeAplicable", PorcentajeAplicable)
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

#Region "EliminarImpuestoRenta"
    Public Function Eliminar_ImpuestoRenta(ByVal CodigoImpuestoRenta As Integer)
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_EliminarImpuestoRenta", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@codigo", CodigoImpuestoRenta)
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


#Region "ListarImpuestoRenta"
    Public Function ListarImpuestoRenta() As DataTable
        Dim Table As New DataTable
        Try
            ConexionBD.Open()
            ComandoBD = New SqlCommand("PA_ListarImpuesto_Renta", ConexionBD) 'Se indica el nombre del proceidmiento almacenado
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
