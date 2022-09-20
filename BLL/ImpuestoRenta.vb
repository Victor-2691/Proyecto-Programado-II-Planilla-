Imports System.Xml
Imports DAL

Public Class ImpuestoRenta


#Region "Variables"
    Public NuevoDaoImpuesto As New DAO_ImpuestoRenta
#End Region

#Region "IngresoImpuestoRentaBD"
    Public Function IngresarImpuestoRenta(ByVal LimiteInferior As Double, ByVal LimiteSuperior As Double, ByVal PorcentajeAplicado As Double) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDaoImpuesto.InsertarImpuestoRenta(LimiteInferior, LimiteSuperior, PorcentajeAplicado)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "LeerImpuestosRenta"
    Public Function ListarImpuestoRenta() As DataTable
        Try
            Return NuevoDaoImpuesto.ListarImpuestoRenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "ActualizarImpuestosRenta"
    Public Function ActualizarImpuestosRenta(ByVal CodigoImpuestoRenta As Integer, ByVal LimiteInferior As Double, ByVal LimiteSuperior As Double, ByVal MontoAplicable As Double) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDaoImpuesto.ActualizarImpuestoRenta(CodigoImpuestoRenta, LimiteInferior, LimiteSuperior, MontoAplicable)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "EliminarImpuestoRenta"
    Public Function EliminarImpuestoRenta(ByVal CodigoImpuestoRenta As Integer) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDaoImpuesto.Eliminar_ImpuestoRenta(CodigoImpuestoRenta)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region







End Class
