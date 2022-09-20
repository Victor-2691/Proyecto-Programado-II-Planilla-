Imports BLL
Public Class WebForm1
    Inherits System.Web.UI.Page
    Public NuevoEmpleado As New Empleado
    Public DataTableEmpleados As New DataTable
    Public NumeroCedulaObtenido As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            DataTableEmpleados = NuevoEmpleado.ListaEmpleadosCompleta
            GriedviewEmpleados.DataSource = DataTableEmpleados
            GriedviewEmpleados.DataBind()


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

    'Con este metodo se obtiene el ID de la fila seleccionada
    Protected Sub Seleccion(sender As Object, e As EventArgs) Handles GriedviewEmpleados.SelectedIndexChanged
        Try
            Dim row As GridViewRow
            row = GriedviewEmpleados.SelectedRow
            NumeroCedulaObtenido = CInt(row.Cells(1).Text)
            'Cargamos la informacion a los Texbox buscando con el numero de cedula los datos

            For Each FilasData As DataRow In DataTableEmpleados.Rows
                If FilasData("Cedula") = NumeroCedulaObtenido Then
                    txtcedula.Text = NumeroCedulaObtenido
                    txtnombre.Text = FilasData("Nombre Empleado")
                    txtapellido1.Text = FilasData("Primer Apellido")
                    txtHijosMenores.Text = FilasData("Cantidad Hijos")
                    txtSalarioBase.Text = FilasData("Salario Base")
                    cbEstadoEmpleado.Text = FilasData("Estado Empleado")
                    CbEstadoCivil.Text = FilasData("Estado Civil")
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

    Protected Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            'Llamamos al metodo actualizar y le pasamos los parametros obtenidos de la seleccion del usuario
            Dim EstadoActualizar As Boolean = NuevoEmpleado.ActualizarEmpleado(CInt(txtcedula.Text), CbEstadoCivil.SelectedValue, cbEstadoEmpleado.SelectedValue, CDbl(txtSalarioBase.Text), CInt(txtHijosMenores.Text))
            If EstadoActualizar = True Then
                Dim message As String = "!Empleado se ACTUALIZO con exito¡"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Else
                Dim message As String = "!Empleado no se pudo actualizar¡"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())

            End If
            'Limpiamos los Texbox
            txtcedula.Text = ""
            txtnombre.Text = ""
            txtapellido1.Text = ""
            txtHijosMenores.Text = ""
            txtSalarioBase.Text = ""
            cbEstadoEmpleado.ClearSelection()
            CbEstadoCivil.ClearSelection()
            'Llamamos al metodo Leer para mostrar los dato actualizados del DataGr
            DataTableEmpleados = NuevoEmpleado.ListaEmpleadosCompleta
            GriedviewEmpleados.DataSource = DataTableEmpleados
            GriedviewEmpleados.DataBind()
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

    Protected Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            'Llamamos al metodo Eliminar
            Dim EstadoEliminar As Boolean = NuevoEmpleado.EliminarEmpleado(CInt(txtcedula.Text))
            'Una vez eliminado el empleado actualizamos la tabla
            If EstadoEliminar = True Then
                Dim message As String = "!Empleado se Elimino con exito¡"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            Else
                Dim message As String = "!Empleado no se elimino¡"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
            End If
            DataTableEmpleados = NuevoEmpleado.ListaEmpleadosCompleta
            GriedviewEmpleados.DataSource = DataTableEmpleados
            GriedviewEmpleados.DataBind()
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