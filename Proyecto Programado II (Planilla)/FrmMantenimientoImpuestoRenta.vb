Imports BLL
Public Class FrmMantenimientoImpuestoRenta
    Public RutaXmlImpuestosRenta As String = Application.StartupPath + "\Archivos XML\ImpuestosRenta.xml"
    Public NuevoImpueso As New ImpuestoRenta
    Public NuevaLista As New List(Of ImpuestoRenta)
    Public EstadoActualizar As Boolean
    Public ImpuestoActualizar As New ImpuestoRenta
    Public EstadoNuevoIngreso As Boolean
    Public NuevoCodigo As Integer
    Public CodigoCapturado As Integer
    Public ListaActualizada As New List(Of ImpuestoRenta)



    Private Sub FrmMantenimientoImpuestoRenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Mostrar los datos actuales en el Data


        'Try
        '    ' Esta propieda permite que cuando el usuario selecciona un campo del Dgv se seleccionen de forma completa la fila
        '    DataGrImpuestosRenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    'Con esta linea bloqueamos la seleccion multiple en el Dgv
        '    DataGrImpuestosRenta.MultiSelect = False
        '    'Leer XMLCreditosFiscales
        '    NuevaLista = NuevoImpueso.LeerXMLImpuestosRenta(RutaXmlImpuestosRenta)
        '    For Each Lista In NuevaLista
        '        DataGrImpuestosRenta.Rows.Add(CStr(Lista.PcodigoImpuesto), CStr("₡ " & Lista.PlimiteInferior), CStr("₡ " & Lista.PlimiteSuperior), CStr(Lista.PporcetanjeAplicable))
        '    Next
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


    End Sub

    Private Sub TabMantenimientoCreditos_Click(sender As Object, e As EventArgs) Handles TabMantenimientoCreditos.Click

    End Sub

    'Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
    '    Try
    '        Try
    '            If (TxtLimiteInferiorAgregar.Text.Trim = "") Or (TxtLimiteSuperiorAgregar.Text.Trim = "") Or (TxtPorcentanjeApliAgregar.Text.Trim = "") Then
    '                MsgBox("Por favor llenar todos los campos son obligatorios", MsgBoxStyle.Information, "Información")
    '            Else
    '                NuevoImpueso.PlimiteInferior = CDbl(TxtLimiteInferiorAgregar.Text.Trim)
    '                NuevoImpueso.PlimiteSuperior = CDbl(TxtLimiteSuperiorAgregar.Text.Trim)
    '                NuevoImpueso.PporcetanjeAplicable = CDbl(TxtPorcentanjeApliAgregar.Text.Trim)
    '                'Con esta funcion obtenemos el numero de nodos de xml para asignarle un codigo al nuevo registro de forma automatica
    '                NuevoCodigo = NuevoImpueso.CuentaNodosXML(RutaXmlImpuestosRenta)
    '                NuevoCodigo += 1
    '                NuevoImpueso.PcodigoImpuesto = NuevoCodigo
    '                'Lllamamos la funcion que nos permite ingresar un nuevo registro en el XML
    '                EstadoNuevoIngreso = NuevoImpueso.AgregarCreditosNuevos(RutaXmlImpuestosRenta, NuevoImpueso)
    '                'VALIDAMOS EL INGRESO
    '                If EstadoNuevoIngreso = True Then
    '                    MsgBox("El nuevo Impuesto de Renta, se agrego con exito", MsgBoxStyle.Information, "Información")
    '                    'Limpiamos controles y mostramos el data actualizado
    '                    TxtLimiteInferiorAgregar.Clear()
    '                    TxtLimiteSuperiorAgregar.Clear()
    '                    TxtPorcentanjeApliAgregar.Clear()
    '                    DataGrImpuestosRenta.Rows.Clear()
    '                    ListaActualizada = NuevoImpueso.LeerXMLImpuestosRenta(RutaXmlImpuestosRenta)
    '                    For Each Lista In ListaActualizada
    '                        DataGrImpuestosRenta.Rows.Add(CStr(Lista.PcodigoImpuesto), CStr("₡ " & Lista.PlimiteInferior), CStr("₡ " & Lista.PlimiteSuperior), CStr(Lista.PporcetanjeAplicable))
    '                    Next
    '                Else
    '                    MsgBox("No se agrego el credito fiscal", MsgBoxStyle.Critical, "ALERTA")

    '                End If

    '            End If
    '        Catch ex As Exception
    '            MsgBox("Todos los campos solo reciben valores numericos", MsgBoxStyle.Critical, "ALERTA")
    '            MessageBox.Show(ex.Message)
    '        End Try

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    'End Sub



    'Private Sub DataGrImpuestosRenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrImpuestosRenta.CellClick
    '    Try
    '        'Obtenemos el codigo de la fila seleccionada
    '        'Mostramos los valores obtenidos en los Text Box
    '        CodigoCapturado = Me.DataGrImpuestosRenta.CurrentRow.Cells.Item(0).Value
    '        'Recorremos la lista para buscar la informacion asociada al empleado
    '        For Each Lista In NuevaLista
    '            If CodigoCapturado = Lista.PcodigoImpuesto Then
    '                TxtCodigoActualizar.Text = CStr(Lista.PcodigoImpuesto)
    '                TxtLimiInferiorActualizar.Text = CStr(Lista.PlimiteInferior)
    '                TxtLimiteSuperiorActualizar.Text = CStr(Lista.PlimiteSuperior)
    '                TxtPorcentajeActualizar.Text = CStr(Lista.PporcetanjeAplicable)
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
    '    Try
    '        'Validamos que todos los campos se completaran
    '        If (TxtLimiInferiorActualizar.Text = "") Or (TxtLimiteSuperiorActualizar.Text.Trim = "") Or (TxtPorcentajeActualizar.Text.Trim = "") Then
    '            MsgBox("Se deben seleccionar una fila para actualizar y no dejar valores en blaco", MsgBoxStyle.Critical, "ALERTA")
    '        Else
    '            'validar que el campo salario solo contenga numeros las validaciones de los demas campos se realizaron con KeyPress
    '            Try
    '                ImpuestoActualizar.PlimiteInferior = CDbl(TxtLimiInferiorActualizar.Text.Trim)
    '                ImpuestoActualizar.PlimiteSuperior = CDbl(TxtLimiteSuperiorActualizar.Text.Trim)
    '                ImpuestoActualizar.PporcetanjeAplicable = CDbl(TxtPorcentajeActualizar.Text.Trim)
    '                ImpuestoActualizar.PcodigoImpuesto = CInt(TxtCodigoActualizar.Text.Trim)

    '                EstadoActualizar = ImpuestoActualizar.AcutalizarImpuestoRentaXML(RutaXmlImpuestosRenta, ImpuestoActualizar)
    '                If EstadoActualizar = True Then
    '                    MsgBox("El impuesto se actualizo con exito", MsgBoxStyle.Information)
    '                    'Limpiamos el Data para volver a leerlo con los datos actualizados
    '                    DataGrImpuestosRenta.Rows.Clear()
    '                    'Limpiamos los campos de texto
    '                    TxtLimiInferiorActualizar.Clear()
    '                    TxtLimiteSuperiorActualizar.Clear()
    '                    TxtPorcentajeActualizar.Clear()
    '                    'Lllamamos al metodo Leer que se encarga de extraer la información del XML y regresarla en una lista
    '                    ListaActualizada = ImpuestoActualizar.LeerXMLImpuestosRenta(RutaXmlImpuestosRenta)
    '                    For Each Lista In ListaActualizada
    '                        DataGrImpuestosRenta.Rows.Add(CStr(Lista.PcodigoImpuesto), CStr("₡ " & Lista.PlimiteInferior), CStr("₡ " & Lista.PlimiteSuperior), CStr(Lista.PporcetanjeAplicable))
    '                    Next
    '                Else
    '                    MsgBox("No se pudo actualizar el empleado", MsgBoxStyle.Critical, "ALERTA")
    '                End If

    '            Catch ex As Exception
    '                MsgBox("El campo monto credito solo recibe numeros enteros o decimales usando el . como separador", MsgBoxStyle.Critical, "ALERTA")
    '                MessageBox.Show(ex.Message)
    '            End Try
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ALERTA")
    '    End Try

    'End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TxtLimiteSuperiorActualizar_TextChanged(sender As Object, e As EventArgs) Handles TxtLimiteSuperiorActualizar.TextChanged

    End Sub

    Private Sub TxtPorcentanjeApliAgregar_TextChanged(sender As Object, e As EventArgs) Handles TxtPorcentanjeApliAgregar.TextChanged

    End Sub

    Private Sub TxtPorcentajeActualizar_TextChanged(sender As Object, e As EventArgs) Handles TxtPorcentajeActualizar.TextChanged

    End Sub
End Class