Imports BLL

Public Class FrmMantenimientoCreditosFiscales
#Region "Variables"
    Public ListaCreditosFiscales As New List(Of CreditosFiscal)
    Public NuevaLista As New List(Of CreditosFiscal)
    Public NuevoCredito As New CreditosFiscal
    Public EstadoAgregado As Boolean
    Public EstadoActualizado As Boolean
    Public Codigo As Integer
    Public RutaXmlCreditosFiscales As String = Application.StartupPath + "\Archivos XML\CreditosFiscales.xml"
    Public CodigoCapturado As Integer
    Public CreditoActualizar As New CreditosFiscal
#End Region

    Private Sub FrmMantenimientoCreditosFiscales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    'Mostrar los datos actuales en el Data
        '    Try
        '        ' Esta propieda permite que cuando el usuario selecciona un campo del Dgv se seleccionen de forma completa la fila
        '        DataGrCreditosFiscales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '        'Con esta linea bloqueamos la seleccion multiple en el Dgv
        '        DataGrCreditosFiscales.MultiSelect = False
        '        'Leer XMLCreditosFiscales
        '        ListaCreditosFiscales = NuevoCredito.LeerxmlCreditosFiscal(RutaXmlCreditosFiscales)
        '        For Each Lista In ListaCreditosFiscales
        '            DataGrCreditosFiscales.Rows.Add(Lista.Pcodigo, Lista.PTipoCreditoFiscal, "₡ " & Lista.PmontoAplicable)
        '        Next
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try

        'End Sub
        'Private Sub TxtNombreCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreCredito.KeyPress
        '    'Con esta funciona se captura el tecleado del usuario y se determina si lo que ingreso por teclado
        '    ' Solo si lo ingresado es un numero se habilara la escritura, el contro para borrado y el control del espacio
        '    If Char.IsLetter(e.KeyChar) Then
        '        e.Handled = False
        '    ElseIf Char.IsControl(e.KeyChar) Then
        '        e.Handled = False
        '    ElseIf Char.IsSeparator(e.KeyChar) Then
        '        e.Handled = False
        '    Else
        '        e.Handled = True
        '        MsgBox("El campo nombre del credito fiscal solo recibe letras", MsgBoxStyle.Critical, "ALERTA")
        '    End If
        'End Sub
        'Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        '    Try
        '        Try
        '            If (TxtMontoAplicable.Text.Trim = "") Or (TxtNombreCredito.Text.Trim = "") Then
        '                MsgBox("Por favor llenar todos los campos son obligatorios", MsgBoxStyle.Information, "Información")
        '            Else
        '                NuevoCredito.PmontoAplicable = CDbl(TxtMontoAplicable.Text)
        '                NuevoCredito.PTipoCreditoFiscal = TxtNombreCredito.Text.Trim
        '                EstadoAgregado = NuevoCredito.IngresarCreditosBD(TxtNombreCredito.Text.Trim, CDbl(TxtMontoAplicable.Text))
        '                'VALIDAMOS EL INGRESO
        '                If EstadoAgregado = True Then
        '                    MsgBox("El nuevo credito fiscal, se agrego con exito", MsgBoxStyle.Information, "Información")
        '                    'Limpiamos controles y mostramos el data actualizado
        '                    TxtMontoAplicable.Clear()
        '                    TxtNombreCredito.Clear()
        '                    DataGrCreditosFiscales.Rows.Clear()
        '                    ListaCreditosFiscales = NuevoCredito.LeerxmlCreditosFiscal(RutaXmlCreditosFiscales)
        '                    For Each Lista In ListaCreditosFiscales
        '                        DataGrCreditosFiscales.Rows.Add(Lista.Pcodigo, Lista.PTipoCreditoFiscal, "₡ " & Lista.PmontoAplicable)
        '                    Next
        '                Else
        '                    MsgBox("No se agrego el credito fiscal", MsgBoxStyle.Critical, "ALERTA")

        '                End If

        '            End If
        '        Catch ex As Exception
        '            MsgBox("El campo Monto Credito Fiscal solo recibe valores numericos", MsgBoxStyle.Critical, "ALERTA")
        '            MessageBox.Show(ex.Message)
        '        End Try

        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try

        'End Sub

        'Private Sub TxtMontoAplicable_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtMontoAplicable.MouseMove
        '    ToolTipCreditosFiscales.SetToolTip(TxtMontoAplicable, "Por favor si ingresa decimales utilizar el . como separador")
        'End Sub

        'Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        '    Try
        '        'Validamos que todos los campos se completaran
        '        If (TxtMontoAplicarModificar.Text = "") Or (TxtNombreActualizar.Text.Trim = "") Then
        '            MsgBox("Se deben seleccionar un credito y no dejar campos vacios", MsgBoxStyle.Critical, "ALERTA")
        '        Else
        '            'validar que el campo salario solo contenga numeros las validaciones de los demas campos se realizaron con KeyPress
        '            Try
        '                CreditoActualizar.PmontoAplicable = CDbl(TxtMontoAplicarModificar.Text.Trim)
        '                CreditoActualizar.PTipoCreditoFiscal = TxtNombreActualizar.Text.Trim
        '                CreditoActualizar.Pcodigo = CInt(TxtCodigoModificar.Text.Trim)

        '                EstadoActualizado = CreditoActualizar.AcutalizarCreditosFiscalesXML(RutaXmlCreditosFiscales, CreditoActualizar)
        '                If EstadoActualizado = True Then
        '                    MsgBox("El credito se actualizo con exito", MsgBoxStyle.Information)
        '                    'Limpiamos el Data para volver a leerlo con los datos actualizados
        '                    DataGrCreditosFiscales.Rows.Clear()
        '                    'Limpiamos los campos de texto
        '                    TxtCodigoModificar.Clear()
        '                    TxtNombreActualizar.Clear()
        '                    TxtMontoAplicarModificar.Clear()
        '                    'Lllamamos al metodo Leer que se encarga de extraer la información del XML y regresarla en una lista
        '                    NuevaLista = CreditoActualizar.LeerxmlCreditosFiscal(RutaXmlCreditosFiscales)
        '                    For Each Lista In NuevaLista
        '                        DataGrCreditosFiscales.Rows.Add(Lista.Pcodigo, Lista.PTipoCreditoFiscal, "₡ " & Lista.PmontoAplicable)
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

        ''Metodo para capturar la informacion del DATA
        'Private Sub DataGrCreditosFiscales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrCreditosFiscales.CellClick
        '    Try
        '        'Obtenemos el codigo de la fila seleccionada
        '        'Mostramos los valores obtenidos en los Text Box
        '        CodigoCapturado = Me.DataGrCreditosFiscales.CurrentRow.Cells.Item(0).Value
        '        'Recorremos la lista para buscar la informacion asociada al empleado
        '        For Each Lista In ListaCreditosFiscales
        '            If CodigoCapturado = Lista.Pcodigo Then
        '                TxtCodigoModificar.Text = CStr(Lista.Pcodigo)
        '                TxtNombreActualizar.Text = Lista.PTipoCreditoFiscal
        '                TxtMontoAplicarModificar.Text = CStr(Lista.PmontoAplicable)
        '            End If
        '        Next
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try

    End Sub

End Class