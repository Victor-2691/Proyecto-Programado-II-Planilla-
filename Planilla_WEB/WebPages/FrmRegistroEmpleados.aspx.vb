Imports BLL
Public Class FrmRegistroEmpleados

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    Protected Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim NuevoEmpleado As New Empleado
        Dim EstadoEmpleado As Boolean
        Try

            EstadoEmpleado = NuevoEmpleado.IngresarEmpleadoBD(txtcedula.Text, txtnombre.Text, txtapellido1.Text, txtApellido2.Text, txtNacionalidad.Text, cbSexo.Text, cbEstadoEmpleado.SelectedValue, FechaIngreso.SelectedDate, FechaNacimiento.SelectedDate, cbEstadoEmpleado.SelectedValue, cbTipoEmpleado.SelectedValue, txtSalarioBase.Text, txtHijosMenores.Text)
            If EstadoEmpleado = True Then
                Dim message As String = "El Empleado se registro con exito"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message.ToString)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                txtnombre.Text = ""
                txtApellido2.Text = ""
                txtapellido1.Text = ""
                txtcedula.Text = ""
                txtNacionalidad.Text = ""
                txtSalarioBase.Text = ""


            Else
                Dim message As String = "Ocurrio un problema para el registro del empleado"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message.ToString)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())


            End If

        Catch ex As Exception
            Dim message As String = ex.Message
            Dim sb As New System.Text.StringBuilder()
            sb.Append("<script type = 'text/javascript'>")
            sb.Append("window.onload=function(){")
            sb.Append("alert('")
            sb.Append(message.ToString)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())

        End Try
    End Sub
End Class