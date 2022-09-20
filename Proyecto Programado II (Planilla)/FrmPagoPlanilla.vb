Imports BLL
Public Class FrmPagoPlanilla

    Public RutaXmlEmpleados As String = Application.StartupPath + "\Archivos XML\Empleados.xml"
    Public RutaXmlCreditosFiscales As String = Application.StartupPath + "\Archivos XML\CreditosFiscales.xml"
    Public RutaXmlCargasSociales As String = Application.StartupPath + "\Archivos XML\CargasSociales.xml"
    Public RutaXmlImpuestosRenta As String = Application.StartupPath + "\Archivos XML\ImpuestosRenta.xml"

    Public CreditoFiscas As New CreditosFiscal
    Public CargasSoci As New CargasSociales
    Public ImpuestoRenta As New ImpuestoRenta
    Public ListaEmpleados As New List(Of Empleado)
    Public ObtenerIdentificacion As Integer
    Public EmpleadoPagoPlanilla As New Empleado
    Public ListaImpuestoRenta As New List(Of ImpuestoRenta)
    Public ListaCreditosFiscales As New List(Of CreditosFiscal)
    Public ListaCargasSoc As New List(Of CargasSociales)
    Public FechaActual As New Date



    Private Sub FrmPagoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim NuevoPlanilla As New Planilla_Empleados
            NuevoPlanilla.CalculaImpuestoRentaSubtotal(1800000)
            Dim DataTable As New DataTable
            DataTable = EmpleadoPagoPlanilla.ListaEmpleadosCompleta

            ' Esta propieda permite que cuando el usuario selecciona un campo del Dgv se seleccionen de forma completa la fila
            DtgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            'Con esta linea bloqueamos la seleccion multiple en el Dgv
            DtgvEmpleados.MultiSelect = False
            DtgvEmpleados.DataSource = DataTable



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ''Hacemos las lecturas de los XML necesarios para el calculo de la planilla
        'ListaImpuestoRenta = ImpuestoRenta.LeerXMLImpuestosRenta(RutaXmlImpuestosRenta)
        'ListaCreditosFiscales = CreditoFiscas.LeerxmlCreditosFiscal(RutaXmlCreditosFiscales)
        'ListaCargasSoc = CargasSoci.LeerXMLCargasSociales(RutaXmlCargasSociales)

        ''Obtenemos la fecha actual
        'FechaActual = Date.Now
        'LabelFecha.Text = FechaActual




    End Sub

    Private Sub DtgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgvEmpleados.CellClick
        Try
            'Obtenemos la cedula de la fila seleccionada
            ObtenerIdentificacion = Me.DtgvEmpleados.CurrentRow.Cells.Item(0).Value
            'Recorremos la lista para buscar la informacion asociada al empleado
            'Mostramos los datos seleccionados en los TEXT BOX 
            For Each Filas As DataGridViewRow In DtgvEmpleados.Rows
                'Solo mostramos los valores segun el ID selecionado
                If Filas.Cells("Cedula").Value = ObtenerIdentificacion Then
                    TxtID.Text = Filas.Cells("Cedula").Value
                    TextNombre.Text = Filas.Cells("Nombre Empleado").Value
                    TxtPrimerApell.Text = Filas.Cells("Primer Apellido").Value
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregarPlanilla_Click(sender As Object, e As EventArgs) Handles BtnAgregarPlanilla.Click
        Try
            'Validamos que todos los campos se completaran
            If (TxtHorasDobles.Text.Trim = "") Or (TxtHorasExtras.Text.Trim = "") Or (TxtHorasTrabajadas.Text.Trim = "") Then
                MsgBox("Se deben seleccionar un empleado y los campos de horas dobles, horas extras y horas trabajadas son obligatorios", MsgBoxStyle.Critical, "ALERTA")
            Else
                Try
                    'validar que el campo salario solo contenga numeros las validaciones de los demas campos se realizaron con KeyPress
                    'Confirmamos con el usuario si desea agregar el empleado para el calculo de planilla
                    Dim ConfirmacionAgregar As DialogResult
                    ConfirmacionAgregar = MsgBox("¿Esta seguro que desea agregar el empleado con cedula : " & CStr(ObtenerIdentificacion) & " para el calculo de planilla", MsgBoxStyle.YesNo, "Confirmación")
                    If ConfirmacionAgregar = Windows.Forms.DialogResult.Yes Then
                        'Buscamos los datos del empleado seleccionado con el nunmero de cedula obtenido del DATAGV
                        'Instanciamos un cliente nuevo para agregarloa a la lista del XML de planilla 
                        'Realizamos los calculos

                        'Dim NuevoPlanilla As New Planilla_Empleados
                        'Dim dt As New DataTable
                        'dt.Columns.Add("Cedula")
                        'dt.Columns.Add("Horas Laboradas")
                        'dt.Columns.Add("Horas Extras")
                        'dt.Columns.Add("Horas Dobles")
                        'Dim row As DataRow = dt.NewRow()
                        'row("Cedula") = ObtenerIdentificacion
                        'row("Horas Laboradas") = TxtHorasTrabajadas.Text
                        'row("Horas Extras") = TxtHorasExtras.Text
                        'row("Horas Dobles") = TxtHorasDobles.Text
                        'dt.Rows.Add(row)
                        Dim EmpleadoN As New Empleado
                        EmpleadoN.Pindentificacion = ObtenerIdentificacion
                        EmpleadoN.PhorasLaboradasSencillas = CDbl(TxtHorasTrabajadas.Text)
                        EmpleadoN.PhorasDobles = CDbl(TxtHorasDobles.Text)
                        EmpleadoN.PhorasExtras = CDbl(TxtHorasExtras.Text)
                        EmpleadoN.PfechaGeneracionPlanilla = FechaActual
                        ListaEmpleados.Add(EmpleadoN)
                        'Elminamos el elemento seleccionado
                        For Each r As DataGridViewRow In DtgvEmpleados.SelectedRows
                            Dim NumeroFilas As Integer = DtgvEmpleados.RowCount - 1
                            If NumeroFilas > 0 Then
                                DtgvEmpleados.Rows.Remove(r)
                            End If

                            If NumeroFilas = 1 Then
                                MsgBox("No quedan registros de empleados", MsgBoxStyle.Information, "Información")
                                Dim nuevaPlanilla As New Planilla_Empleados
                                Dim Estado As Boolean
                                Estado = nuevaPlanilla.IngresarPlanillaBD(ListaEmpleados)
                                If Estado = True Then
                                    MsgBox("Se agregaron todos los empleados con exito", MsgBoxStyle.Information, "Información")
                                End If


                            End If
                        Next

                        'NuevoPlanilla.IngresarPlanillaBD(Identificación, 240, 5, 12, FechaActual)



                    End If
                Catch ex As Exception
                    MsgBox("Los campos de horas trabajadas,extras y dobles solo reciben numeros enteros o decimales usando el . como separador", MsgBoxStyle.Critical, "ALERTA")
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ALERTA")
        End Try


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



    End Sub
End Class