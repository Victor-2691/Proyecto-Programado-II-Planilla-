Imports System.Data.SqlClient
Imports System.Configuration
Public Class DAO_Planilla_Empleados
    'Variables Globales
    Public ConexionBD As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public ComandoBD As SqlCommand

#Region "Insertar Planilla"
    Public Function InsertarPlanilla(ByVal ID_Empleado As Integer, ByVal HorasLaboradas As Double, ByVal HorasExtras As Double, ByVal HorasDobles As Double, ByVal SalarioBruto As Double, ByVal CargasSociales As Double, ByVal ImpuestoRenta As Double, ByVal SalarioNeto As Double, ByVal FechaGeneracionPlanilla As Date) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_InsertarPlanilla", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@ID_Empleado", ID_Empleado)
            ComandoBD.Parameters.AddWithValue("@Horas_Laboradas", HorasLaboradas)
            ComandoBD.Parameters.AddWithValue("@Horas_Extras", HorasExtras)
            ComandoBD.Parameters.AddWithValue("@Horas_Dobles ", HorasDobles)
            ComandoBD.Parameters.AddWithValue("@Salrio_Bruto", SalarioBruto)
            ComandoBD.Parameters.AddWithValue("@Cargas_Sociales", CargasSociales)
            ComandoBD.Parameters.AddWithValue("@Impuesto_Renta", ImpuestoRenta)
            ComandoBD.Parameters.AddWithValue("@Salario_Neto", SalarioNeto)
            ComandoBD.Parameters.AddWithValue("@Fecha_Generacio_Planilla", FechaGeneracionPlanilla)
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

#Region "LeerPlanilla"
    Public Function ListarPlanilla() As DataTable
        Dim Table As New DataTable
        Try
            ConexionBD.Open()
            ComandoBD = New SqlCommand("PA_ListarPlanilla", ConexionBD) 'Se indica el nombre del proceidmiento almacenado
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
