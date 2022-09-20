Imports BLL
Public Class frmConsultaPlanillas
    Inherits System.Web.UI.Page
    Public PlanillaEmpleados As New Planilla_Empleados
    Public DataPlanilla As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataPlanilla = PlanillaEmpleados.ListarPlanilla
        GridPlanillas.DataSource = DataPlanilla
        GridPlanillas.DataBind()
    End Sub

End Class