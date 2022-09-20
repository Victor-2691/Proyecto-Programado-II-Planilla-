Imports BLL
Public Class frmCreditosSociales
    Inherits System.Web.UI.Page
    Public NuevoCreditoFiscal As New CreditosFiscal
    Public DataCreditosFiscales As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            DataCreditosFiscales = NuevoCreditoFiscal.ListaEmpleadosCompleta
            GriewCreditosFiscales.DataSource = DataCreditosFiscales
            GriewCreditosFiscales.DataBind()
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

    Protected Sub GriewCreditosFiscales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GriewCreditosFiscales.SelectedIndexChanged

        Try
            'Funcion para obtener la seleccion del Data y el codigo
            Dim row As GridViewRow
            row = GriewCreditosFiscales.SelectedRow
            Dim Codigo As Integer = CInt(row.Cells(1).Text)
            'Cargamos la informacion a los Texbox buscando con el numero de cedula los datos
            For Each FilasData As DataRow In DataCreditosFiscales.Rows
                If FilasData("Codigo") = Codigo Then
                    txtCodigo.Text = Codigo
                    txtTipoCredito.Text = FilasData("Tipo Credito Fiscal")
                    txtMontoAplicable.Text = FilasData("Monto Aplicable")
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
            Dim EstadoActualizar As Boolean = NuevoCreditoFiscal.ActualizarCreditosFiscales(CInt(txtCodigo.Text), txtTipoCredito.Text, CDbl(txtMontoAplicable.Text))
            If EstadoActualizar = True Then
                Dim message As String = "!Se ACTUALIZO con EXITO¡"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                txtCodigo.Text = ""
                txtMontoAplicable.Text = ""
                txtTipoCredito.Text = ""
                DataCreditosFiscales = NuevoCreditoFiscal.ListaEmpleadosCompleta
                GriewCreditosFiscales.DataSource = DataCreditosFiscales
                GriewCreditosFiscales.DataBind()

            Else
                Dim message As String = "!Ocurrio un error al actualizar¡"
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