Imports BLL
Public Class FrmRegistroEmpleados

    Dim Estado As Boolean
    Dim RutaXmlEmpleados As String = Application.StartupPath + "\Archivos XML\Empleados.xml"
    Dim NuevoEmpleado As New Empleado

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            'Validamos que todos los campos se completaran
            If (TextNacioanlidad.Text.Trim = "") Or (TxtID.Text.Trim = "") Or (TxtPrimerApell.Text.Trim = "") Or (TxtSegundoApell.Text.Trim = "") Or (TextNacioanlidad.Text.Trim = "") Or (ComboSexo.Text = "") Or (ComboEstadoCivil.Text = "") Or (DateTimeFechaNacimiento.ToString = "") Or (ComboTipoEmpleado.Text = "") Or (DateTimeFechaIngreso.ToString = "") Or (TextSalarioBase.Text.Trim = "") Or (TxtCantidadHijos.Text.Trim = "") Or (ComboEstado.Text = "") Then
                MsgBox("Se deben completar todos los datos son obligatorios", MsgBoxStyle.Critical, "ALERTA")
            Else
                'validar que el campo salario solo contenga numeros las validaciones de los demas campos se realizaron con KeyPress
                Try
                    Estado = NuevoEmpleado.IngresarEmpleadoBD(CInt(TxtID.Text.Trim), TextNombre.Text.Trim, TxtPrimerApell.Text.Trim, TxtSegundoApell.Text.Trim, TextNacioanlidad.Text.Trim, ComboSexo.Text, ComboEstadoCivil.Text, Format(DateTimeFechaIngreso.Value, "dd/MM/yyyy"), Format(DateTimeFechaNacimiento.Value, "dd/MM/yyyy"), ComboEstado.Text, ComboTipoEmpleado.Text, CDbl(TextSalarioBase.Text.Trim), CInt(TxtCantidadHijos.Text.Trim))

                    If Estado = True Then
                        MsgBox("Se registro con exito el nuevo empleado", MsgBoxStyle.Information, "¡EXITO!")
                    Else
                        MsgBox("El empleado que intenta agregar ya existe en la base de datos", MsgBoxStyle.Critical, "ALERTA")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ALERTA")
                    ' MsgBox("El campo salario solo recibe numeros enteros o decimales usando el . como separador", MsgBoxStyle.Critical, "ALERTA")
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ALERTA")
        End Try

    End Sub

#Region "Validaciones de TexBox"
    Private Sub TextNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNombre.KeyPress
        'Con esta funciona se captura el tecleado del usuario y se determina si lo que ingreso por teclado
        ' Solo si lo ingresado es un numero se habilara la escritura, el contro para borrado y el control del espacio
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("El campo nombre solo recibe letras", MsgBoxStyle.Critical, "ALERTA")
        End If
    End Sub

    Private Sub TxtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtID.KeyPress
        'Con esta funciona se captura el tecleado del usuario y se determina si lo que ingreso por teclado
        ' Solo si lo ingresado es un numero se habilara la escritura, el contro para borrado y el control del espacio
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            'En caso de que lo ingreaso sea diferente a un numero se le notifica al usuario
            e.Handled = True
            MsgBox("El campo Cedula solo recibe numeros", MsgBoxStyle.Critical, "ALERTA")
        End If
    End Sub

    Private Sub TxtPrimerApell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrimerApell.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("El campo Primer Apellido solo recibe letras", MsgBoxStyle.Critical, "ALERTA")
        End If
    End Sub

    Private Sub TxtSegundoApell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSegundoApell.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("El campo Segundo Apellido solo recibe letras", MsgBoxStyle.Critical, "ALERTA")
        End If
    End Sub

    Private Sub TextNacioanlidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNacioanlidad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("El campo nacionalidad solo recibe letras", MsgBoxStyle.Critical, "ALERTA")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidadHijos.KeyPress
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

    Private Sub FrmRegistroEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#End Region



End Class