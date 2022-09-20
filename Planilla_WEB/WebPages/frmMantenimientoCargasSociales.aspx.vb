Imports BLL
Public Class FrmCargasSociales
    Inherits System.Web.UI.Page
    Public CargasSociales As New CargasSociales
    Public DataCargasSocialesa As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            DataCargasSocialesa = CargasSociales.ListarCargas_Sociales
            GrvCargasSociales.DataSource = DataCargasSocialesa
            GrvCargasSociales.DataBind()
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

    Protected Sub GrvCargasSociales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrvCargasSociales.SelectedIndexChanged
        Try
            'Funcion para obtener la seleccion del Data y el codigo
            Dim row As GridViewRow
            row = GrvCargasSociales.SelectedRow
            Dim Codigo As Integer = CInt(row.Cells(1).Text)
            'Cargamos la informacion a los Texbox buscando con el numero de cedula los datos
            For Each FilasData As DataRow In DataCargasSocialesa.Rows
                If FilasData("Codigo") = Codigo Then
                    txtCodigo.Text = Codigo
                    cbTipoCargaSocial.Text = FilasData("Tipo Carga Social")
                    txtnombreCargaSocial.Text = FilasData("Concepto")
                    TxtMontoCarga.Text = FilasData("% Aplicable")
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

    Protected Sub BntActualizar_Click(sender As Object, e As EventArgs) Handles BntActualizar.Click
        Try
            Dim EstadoActualizar As Boolean = CargasSociales.ActualizarCargas_Sociales(CInt(txtCodigo.Text), cbTipoCargaSocial.SelectedValue, txtnombreCargaSocial.Text, CDbl(TxtMontoCarga.Text))
            If EstadoActualizar = True Then
                Dim message As String = "!Se actualizo con exito¡"
                Dim sb As New System.Text.StringBuilder()
                sb.Append("<script type = 'text/javascript'>")
                sb.Append("window.onload=function(){")
                sb.Append("alert('")
                sb.Append(message)
                sb.Append("')};")
                sb.Append("</script>")
                ClientScript.RegisterClientScriptBlock(Me.GetType(), "alert", sb.ToString())
                'Limpuiamos los Texbox
                txtCodigo.Text = ""
                txtnombreCargaSocial.Text = ""
                TxtMontoCarga.Text = ""
                cbTipoCargaSocial.ClearSelection()
                'Leemos de nuevo el Datagrv
                DataCargasSocialesa = CargasSociales.ListarCargas_Sociales
                GrvCargasSociales.DataSource = DataCargasSocialesa
                GrvCargasSociales.DataBind()

            Else
                Dim message As String = "Atencion, no se actualizo con exito"
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