Imports BLL
Public Class frmPagoPlanilla
    Inherits System.Web.UI.Page
    Public NuevoEmpleado As New Empleado
    Public NuevaPlanilla As New Planilla_Empleados
    Public DataEmpleados As New DataTable
    Public FechaActual As New Date
    Public EstadoPlanilla As Boolean
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Mostramos el Grievw con los empleados ya agregados
            DataEmpleados = NuevoEmpleado.ListaEmpleados_Incapacitados_Activos
            GrievEmpleadosPagoPlanillas.DataSource = DataEmpleados
            GrievEmpleadosPagoPlanillas.DataBind()
            'Asignamos la fecha actual al Label
            FechaActual = Date.Now
            LabelFecha.Text = FechaActual.ToShortDateString

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

    Protected Sub GrievEmpleadosPagoPlanillas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrievEmpleadosPagoPlanillas.SelectedIndexChanged
        Try
            Dim row As GridViewRow
            row = GrievEmpleadosPagoPlanillas.SelectedRow
            Dim NumeroCedulaObtenido As Integer = CInt(row.Cells(1).Text)
            'Cargamos la informacion a los Texbox buscando con el numero de cedula los datos
            'Recorremos el dataGriew para asignar los campos de cada empleado
            For Each FilasData As DataRow In DataEmpleados.Rows
                If FilasData("Cedula") = NumeroCedulaObtenido Then
                    TxtCedula.Text = NumeroCedulaObtenido
                    txtNombre.Text = FilasData("Nombre Empleado")
                    TxtPrimerApellido.Text = FilasData("Primer Apellido")
                End If
            Next

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

    Protected Sub BtnGenerarPlanilla_Click(sender As Object, e As EventArgs) Handles BtnGenerarPlanilla.Click
        Try
            EstadoPlanilla = NuevaPlanilla.IngresarPlanillaBD(CInt(TxtCedula.Text), CDbl(txtHorasTrabajadas.Text), CDbl(txtHorasExtras.Text), CDbl(txtHorasDobles.Text), LabelFecha.Text)
            If EstadoPlanilla = True Then
                Dim message As String = "El calculo de planilla para el empleado se realizo con exito"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message.ToString)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                TxtCedula.Text = ""
                txtNombre.Text = ""
                TxtPrimerApellido.Text = ""
                txtHorasDobles.Text = ""
                txtHorasExtras.Text = ""
                txtHorasTrabajadas.Text = ""
            Else
                Dim message As String = "No se Registro con exito"
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