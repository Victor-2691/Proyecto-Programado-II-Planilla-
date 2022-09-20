Imports System.Xml
Imports DAL

Public Class CargasSociales

#Region "Variables"
    'Variable de tipo DAL para extraer informaci[on de la BD
    Public NuevoDaoCargaSociales As New DAO_Cargas_Sociales
#End Region


#Region "LeerCargasSociales"
    Public Function ListarCargas_Sociales() As DataTable
        Try
            'Se extrae la informaci[on de la Base de datos 
            Return NuevoDaoCargaSociales.ListarCargas_Sociales
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "ActualizarCargas_Sociales"
    Public Function ActualizarCargas_Sociales(ByVal Codigo As Integer, ByVal TipoCargaSocial As String, ByVal NombreCarga_Social As String, ByVal MontoPorcentual As Double) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            'Se actualiza la información de la Base de Datos
            EstadoInsertar = NuevoDaoCargaSociales.ActualizarCargasSociales(Codigo, TipoCargaSocial, NombreCarga_Social, MontoPorcentual)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region







End Class
