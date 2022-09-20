Imports BLL

Public Class FrmMantenimientoEmpleados
    Public NuevoEmpleado As New Empleado
    Public EmpleadoActualizar As New Empleado
    Public EstadoActualizado As Boolean
    Public Identificación As Integer
    Public FechaActual As Date
    Private Sub FrmMantenimientoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Esta propieda permite que cuando el usuario selecciona un campo del Dgv se seleccionen de forma completa la fila
        DtgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'Con esta linea bloqueamos la seleccion multiple en el Dgv
        DtgvEmpleados.MultiSelect = False
        Try
            'Llamamos al metedo Leer y le enviamos el la informacion del dataset al DataGriewvew
            DtgvEmpleados.DataSource = NuevoEmpleado.ListaEmpleadosCompleta
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Obtenemos la fecha actual

        FechaActual = Date.Now



    End Sub

    'Con este metodo capturamos la infomracion seleccionada por el usuario
    Private Sub DtgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgvEmpleados.CellClick
        Try
            'Obtenemos la cedula de la fila seleccionada
            Identificación = Me.DtgvEmpleados.CurrentRow.Cells.Item(0).Value
            'Recorremos de nuevo el Data con la informacion obtenida de la BD, pero esta vez solo mostramos los numeros segun el ID seleccionado

            For Each Filas As DataGridViewRow In DtgvEmpleados.Rows
                'Solo mostramos los valores segun el ID selecionado
                If Filas.Cells("Cedula").Value = Identificación Then
                    TxtID.Text = Filas.Cells("Cedula").Value
                    TextNombre.Text = Filas.Cells("Nombre Empleado").Value
                    TxtPrimerApell.Text = Filas.Cells("Primer Apellido").Value
                    ComboEstado.Text = Filas.Cells("Estado Empleado").Value
                    ComboEstadoCivil.Text = Filas.Cells("Estado Civil").Value
                    TextSalarioBase.Text = (Filas.Cells("Salario Base").Value)
                    TxtCantidadHijos.Text = (Filas.Cells("Cantidad Hijos").Value)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

#Region "Actualizar Empleado"
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            'Validamos que todos los campos se completaran
            If (ComboEstadoCivil.Text = "") Or (TextSalarioBase.Text.Trim = "") Or (TxtCantidadHijos.Text.Trim = "") Or (ComboEstado.Text = "") Then
                MsgBox("Se deben seleccionar un empleado y no dejar campos vacios", MsgBoxStyle.Critical, "ALERTA")
            Else
                'validar que el campo salario solo contenga numeros las validaciones de los demas campos se realizaron con KeyPress
                Try
                    EstadoActualizado = NuevoEmpleado.ActualizarEmpleado(Identificación, ComboEstadoCivil.Text, ComboEstado.Text, CDbl(TextSalarioBase.Text.Trim), CInt(TxtCantidadHijos.Text.Trim))
                    If EstadoActualizado = True Then
                        MsgBox("El empleado : " & TextNombre.Text & " se actualizo con exito", MsgBoxStyle.Information, "¡EXITO!")
                        'Limpiamos los campos de texto
                        TxtCantidadHijos.Clear()
                        TextSalarioBase.Clear()
                        TextNombre.Clear()
                        TxtPrimerApell.Clear()
                        TxtID.Clear()
                        'Llamamos al metedo leer y mostramos la tabla actualizada
                        DtgvEmpleados.DataSource = NuevoEmpleado.ListaEmpleadosCompleta
                    Else
                        MsgBox("No se pudo actualizar el empleado", MsgBoxStyle.Critical, "ALERTA")
                    End If

                Catch ex As Exception
                    'MsgBox("El campo salario solo recibe numeros enteros o decimales usando el . como separador", MsgBoxStyle.Critical, "ALERTA")
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ALERTA")
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ALERTA")
        End Try

    End Sub
#End Region

#Region "Eliminar Empleado"

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim EstadoElimnado As Boolean
        Dim ConfirmacionEliminar As DialogResult
        Try
            'validamos que el usuario seleccione un empleado
            If TextNombre.Text = "" Then
                MsgBox("Debe seleccionar un empleado para poder eliminarlo", MsgBoxStyle.Information, "Atención")
            Else
                ConfirmacionEliminar = MsgBox("¿Esta seguro que desea eliminar el empleado con cedula :?" & CStr(Identificación), MsgBoxStyle.YesNo, "Confirmación")
                If ConfirmacionEliminar = Windows.Forms.DialogResult.Yes Then
                    EstadoElimnado = NuevoEmpleado.EliminarEmpleado(Identificación)
                    If EstadoElimnado = True Then
                        MsgBox("El empleado se elimino con exito", MsgBoxStyle.Information, "Eliminado")
                        'Limpiamos los campos de texto
                        TxtCantidadHijos.Clear()
                        TextSalarioBase.Clear()
                        TextNombre.Clear()
                        TxtPrimerApell.Clear()
                        TxtID.Clear()
                        DtgvEmpleados.DataSource = NuevoEmpleado.ListaEmpleadosCompleta
                    Else
                        MsgBox("No se pudo eliminar el empleado", MsgBoxStyle.Critical, "error")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ALERTA")
        End Try
    End Sub

#End Region



#Region "Validaciones de TexBox"
    Private Sub TxtCantidadHijos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidadHijos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            'En caso de que lo ingreaso sea diferente a un numero se le notifica al usuario
            e.Handled = True
            MsgBox("El campo cantidad de hijos solo recibe numeros", MsgBoxStyle.Critical, "ALERTA")
        End If
    End Sub

#End Region

#Region "TooTipInformación"
    Private Sub TextSalarioBase_MouseMove(sender As Object, e As MouseEventArgs) Handles TextSalarioBase.MouseMove
        ToolTipMenuEmpleados.SetToolTip(TextSalarioBase, "Por favor si ingresa decimales utilizar el . como separador")
    End Sub

    Private Sub TxtCantidadHijos_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtCantidadHijos.MouseMove
        ToolTipMenuEmpleados.SetToolTip(TxtCantidadHijos, "Por favor leer las instrucciones para llenar este campo")
    End Sub

    Private Sub GroupBoxActualizar_Enter(sender As Object, e As EventArgs) Handles GroupBoxActualizar.Enter

    End Sub

    Private Sub DtgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgvEmpleados.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub TxtCantidadHijos_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidadHijos.TextChanged

    End Sub






#End Region

End Class