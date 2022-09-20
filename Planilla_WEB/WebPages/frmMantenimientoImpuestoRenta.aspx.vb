Imports BLL
Public Class frmImpuestoRenta
    Inherits System.Web.UI.Page
    Public ImpuestoRenta As New ImpuestoRenta
    Public DataImpuesto As New DataTable



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            DataImpuesto = ImpuestoRenta.ListarImpuestoRenta()
            GriewImpuestoRenta.DataSource = DataImpuesto
            GriewImpuestoRenta.DataBind()
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

    Protected Sub GriewImpuestoRenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GriewImpuestoRenta.SelectedIndexChanged
        Try
            'Funcion para obtener la seleccion del Data y el codigo
            Dim row As GridViewRow
            row = GriewImpuestoRenta.SelectedRow
            Dim Codigo As Integer = CInt(row.Cells(1).Text)
            'Cargamos la informacion a los Texbox buscando con el numero de cedula los datos
            For Each FilasData As DataRow In DataImpuesto.Rows
                If FilasData("Codigo") = Codigo Then
                    txtCodigo.Text = Codigo
                    txtLimiteInferior.Text = FilasData("Salario desde")
                    txtLimiteSuperior.Text = FilasData("Salario hasta")
                    TxtPorcentajeAplicable.Text = FilasData("Porcentaje Aplicable")
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
            Dim EstadoAgregar As Boolean = ImpuestoRenta.IngresarImpuestoRenta(CDbl(txtLimiteInferior.Text), CDbl(txtLimiteSuperior.Text), CDbl(TxtPorcentajeAplicable.Text))
            If EstadoAgregar = True Then
                Dim message As String = "El nuevo Impuesto se AGREGO con EXITO"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                txtCodigo.Text = ""
                txtLimiteInferior.Text = ""
                txtLimiteSuperior.Text = ""
                TxtPorcentajeAplicable.Text = ""
                DataImpuesto = ImpuestoRenta.ListarImpuestoRenta()
                GriewImpuestoRenta.DataSource = DataImpuesto
                GriewImpuestoRenta.DataBind()
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

    Protected Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            Dim EstadoActualizar As Boolean = ImpuestoRenta.ActualizarImpuestosRenta(CInt(txtCodigo.Text), CDbl(txtLimiteInferior.Text), CDbl(txtLimiteSuperior.Text), CDbl(TxtPorcentajeAplicable.Text))
            If EstadoActualizar = True Then
                Dim message As String = "Se ACTUALIZO con EXITO"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                txtCodigo.Text = ""
                txtLimiteInferior.Text = ""
                txtLimiteSuperior.Text = ""
                TxtPorcentajeAplicable.Text = ""
                DataImpuesto = ImpuestoRenta.ListarImpuestoRenta()
                GriewImpuestoRenta.DataSource = DataImpuesto
                GriewImpuestoRenta.DataBind()

            Else
                Dim message As String = "No se actualizo"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
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
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
        End Try



    End Sub

    Protected Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim EstadoEliminar As Boolean = ImpuestoRenta.EliminarImpuestoRenta(CInt(txtCodigo.Text))

            If EstadoEliminar = True Then
                Dim message As String = "Se ELIMINO con Exito"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                txtCodigo.Text = ""
                txtLimiteInferior.Text = ""
                txtLimiteSuperior.Text = ""
                TxtPorcentajeAplicable.Text = ""
                DataImpuesto = ImpuestoRenta.ListarImpuestoRenta()
                GriewImpuestoRenta.DataSource = DataImpuesto
                GriewImpuestoRenta.DataBind()
            Else
                Dim message As String = "No se Elimino"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
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
            sb.Append(message)
            sb.Append("')};")
            sb.Append("</script>")
            ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
        End Try
    End Sub
End Class