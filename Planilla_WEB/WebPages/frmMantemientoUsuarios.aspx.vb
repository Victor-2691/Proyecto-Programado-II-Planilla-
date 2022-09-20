Imports BLL
Public Class frmMantemientoUsuarios
    Inherits System.Web.UI.Page
    Public NuevoUsuario As New Usuariosvb
    Public NuevoDataUsuarios As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        NuevoDataUsuarios = NuevoUsuario.ListarUsuarios
        GriewUsuarios.DataSource = NuevoDataUsuarios
        GriewUsuarios.DataBind()
    End Sub

    Protected Sub GriewUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GriewUsuarios.SelectedIndexChanged
        Try
            'Funcion para obtener la seleccion del Data y el codigo
            Dim row As GridViewRow
            row = GriewUsuarios.SelectedRow
            Dim Codigo As Integer = CInt(row.Cells(2).Text)
            'Cargamos la informacion a los Texbox buscando con el numero de cedula los datos
            For Each FilasData As DataRow In NuevoDataUsuarios.Rows
                If FilasData("Nombre Usuario") = Codigo Then
                    txtUsuario.Text = Codigo
                    txtContraseña.Text = FilasData("Contraseña")
                    TxtCorreoElectronico.Text = FilasData("Correo Electronico")
                    txtNombre.Text = FilasData("Nombre Usuario")
                End If
            Next

        Catch ex As Exception
            Dim message As String = ex.Message
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
        End Try
    End Sub

    Protected Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            Dim EstadoAgregar As Boolean = NuevoUsuario.IngresaNuevoUsuario((txtUsuario.Text), (txtContraseña.Text), txtNombre.Text, TxtCorreoElectronico.Text, cbEstadoUsuario.SelectedValue)
            If EstadoAgregar = True Then
                Dim message As String = "El nuevo Usuario se agrego con exito"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                txtUsuario.Text = ""
                txtNombre.Text = ""
                txtContraseña.Text = ""
                TxtCorreoElectronico.Text = ""
                NuevoDataUsuarios = NuevoUsuario.ListarUsuarios
                GriewUsuarios.DataSource = NuevoDataUsuarios
                GriewUsuarios.DataBind()
            Else
                Dim message As String = "No se pudo ingresar el registro a la BD"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
            End If
        Catch ex As Exception
            Dim message As String = ex.Message
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
        End Try
    End Sub
End Class