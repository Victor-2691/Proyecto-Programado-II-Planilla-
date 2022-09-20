Imports System.Xml
Imports DAL

Public Class CreditosFiscal

#Region "Variables"
    'Variable de conexion en a capa DAL
    Public NuevoCreditoDao As New DAO_Creditos_Fiscales


#End Region

#Region "IngresoCreditosFiscalesBD"
    Public Function IngresarCreditosBD(ByVal TipoCredito As String, ByVal MontoCredito As Double) As Boolean
        'se inserta informaci[on y se valida que los cambio se hayan hecho
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoCreditoDao.CreditosFiscalesInsertar(TipoCredito, MontoCredito)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "LeerCreditosFiscales"
    Public Function ListaEmpleadosCompleta() As DataTable
        Try
            'Se llama al metodo de lectura en la capa DAL y se extrae la informacion
            'mediante un datatable
            Return NuevoCreditoDao.ListarCreditosFiscales
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "ActualizarCreditosFiscales"
    Public Function ActualizarCreditosFiscales(ByVal CodigoCreditoFiscal As Integer, ByVal TipoCreditoFiscal As String, ByVal MontoCreditoFiscal As Double) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            'Se llama a la funcion de editar en la capa DAL y se valida que los cambios se hayan hecho
            EstadoInsertar = NuevoCreditoDao.ActualizarCreditosFiscales(CodigoCreditoFiscal, TipoCreditoFiscal, MontoCreditoFiscal)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region





End Class
