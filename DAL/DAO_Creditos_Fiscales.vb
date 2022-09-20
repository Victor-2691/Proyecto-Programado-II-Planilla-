Imports System.Data.SqlClient
Imports System.Configuration
Public Class DAO_Creditos_Fiscales
    'Variables Globales
    Public ConexionBD As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public ComandoBD As SqlCommand

#Region "InsertarCreditoFiscal"
    Public Function CreditosFiscalesInsertar(ByVal TipoCredito As String, ByVal MontoCredito As Double) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_InsertarCreditoFiscal", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Tipo_Credito ", TipoCredito)
            ComandoBD.Parameters.AddWithValue("@Monto_Aplicable ", MontoCredito)
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

#Region "ListarCreditosFiscales"
    Public Function ListarCreditosFiscales() As DataTable
        Dim Table As New DataTable
        Try
            ConexionBD.Open()
            ComandoBD = New SqlCommand("PA_Listar_CreditosFiscales", ConexionBD) 'Se indica el nombre del proceidmiento almacenado
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

#Region "ActualizarCreditoFiscal"
    Public Function ActualizarCreditosFiscales(ByVal codigoCredito As Integer, TipoCreditos As String, MontoCredito As Double) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_ActualizarCreditosFiscales", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Codigo", codigoCredito)
            ComandoBD.Parameters.AddWithValue("@TipoCredito", TipoCreditos)
            ComandoBD.Parameters.AddWithValue("@MontoCredito", MontoCredito)
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
