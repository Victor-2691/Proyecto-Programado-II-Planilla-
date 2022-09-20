Imports System.Data.SqlClient
Imports System.Configuration

Public Class DAO_Cargas_Sociales
    'Se declaran las variables de conexion a la base de datos
    'Y se declaran los comandon de sql
    'Variables Globales
    Public ConexionBD As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
    Public ComandoBD As SqlCommand

#Region "ListarCargasSociales"
    'Empieza la funcion de tipo dataTable que carga las listas de las cargas sociales
    Public Function ListarCargas_Sociales() As DataTable
        Dim Table As New DataTable
        Try
            'Se crea o abre la conexion a SQL
            ConexionBD.Open()
            'Se llama al comando ubicado en el Query de la Base de Datos
            ComandoBD = New SqlCommand("PA_ListarCargas_Sociales", ConexionBD) 'Se indica el nombre del proceidmiento almacenado
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


#Region "ActualizarCargasSociales"
    'Metodo actualiza los datos ya guardados en la base de datos 
    Public Function ActualizarCargasSociales(ByVal codigo As Integer, TipoCargaSocial As String, NombreCargaSocial As String, ByVal MontoPorcentual As Double) As Boolean
        Dim EstadoInsertar As Boolean = False
        Dim FilasAfectadas As Integer
        Try
            'Se inicia la conexion a la BD desde el APP.CONFIGURATION 
            'ConexionBD = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
            ConexionBD.Open()
            'Con el sql Comand debemos enviarle por parametro el nombre de procedimiento almacenado y la conexion
            ComandoBD = New SqlCommand("PA_AcutalizarCargas_Sociales", ConexionBD)
            'Indicamos el tipo de comando en este caso procedimiento almancenado
            ComandoBD.CommandType = CommandType.StoredProcedure
            'indicamos el nombre del parametro en el procedimiento y el valor que le enviamos
            ComandoBD.Parameters.AddWithValue("@Codigo", codigo)
            ComandoBD.Parameters.AddWithValue("@TipoCarga", TipoCargaSocial)
            ComandoBD.Parameters.AddWithValue("@NombreCarga", NombreCargaSocial)
            ComandoBD.Parameters.AddWithValue("@MontoPorcentual", MontoPorcentual)
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
