Imports DAL
Public Class Usuariosvb
    Public NuevoDaoUsuarioas As New DAO_Usuarios


#Region "InsertarNuevoUsuario"
    Public Function IngresaNuevoUsuario(ByVal Usuario As String, ByVal Contraseña As String, ByVal Nombre As String, ByVal CorreoElectronico As String, ByVal EstadoUsuari As String) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDaoUsuarioas.InsertarNuevoUsuario(Usuario, Contraseña, Nombre, CorreoElectronico, EstadoUsuari)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "LeerUsuarios"
    Public Function ListarUsuarios() As DataTable
        Try
            Return NuevoDaoUsuarioas.ListarUsuarios
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "ActualizarUsuarios"
    Public Function ActualizarUsuarios(ByVal Usuario As String, ByVal Contraseña As String, ByVal Nombre As String, ByVal CorreoElectronico As String, ByVal EstadoUsuari As String) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDaoUsuarioas.ActualizarUsuario(Usuario, Contraseña, Nombre, CorreoElectronico, EstadoUsuari)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "EliminarUsuarios"
    Public Function EliminarUsuarios(ByVal Usuario As String) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDaoUsuarioas.Eliminar_Usuario(Usuario)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region


End Class
