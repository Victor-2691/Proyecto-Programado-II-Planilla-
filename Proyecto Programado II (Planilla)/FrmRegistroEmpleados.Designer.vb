<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistroEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroEmpleados))
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LabNombre = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.LbPrimerApellido = New System.Windows.Forms.Label()
        Me.LSegundoApellido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LaSexo = New System.Windows.Forms.Label()
        Me.LEstaCivil = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtPrimerApell = New System.Windows.Forms.TextBox()
        Me.TxtSegundoApell = New System.Windows.Forms.TextBox()
        Me.TextNacioanlidad = New System.Windows.Forms.TextBox()
        Me.ComboSexo = New System.Windows.Forms.ComboBox()
        Me.ComboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.LTipoEmpleado = New System.Windows.Forms.Label()
        Me.ComboTipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.LbEstado = New System.Windows.Forms.Label()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.DateTimeFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.LfechaNacimiento = New System.Windows.Forms.Label()
        Me.DateTimeFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.SalarioBase = New System.Windows.Forms.Label()
        Me.TextSalarioBase = New System.Windows.Forms.TextBox()
        Me.Linformación = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCantidadHijos = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.ToolTipMenuEmpleados = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.SystemColors.Window
        Me.LabelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Salmon
        Me.LabelTitulo.Location = New System.Drawing.Point(140, 9)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(339, 22)
        Me.LabelTitulo.TabIndex = 0
        Me.LabelTitulo.Text = "REGISTRO DE EMPLEADOS NUEVOS"
        '
        'LabNombre
        '
        Me.LabNombre.AutoSize = True
        Me.LabNombre.Location = New System.Drawing.Point(48, 62)
        Me.LabNombre.Name = "LabNombre"
        Me.LabNombre.Size = New System.Drawing.Size(62, 17)
        Me.LabNombre.TabIndex = 1
        Me.LabNombre.Text = "Nombre:"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Location = New System.Drawing.Point(33, 101)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(90, 17)
        Me.LbID.TabIndex = 2
        Me.LbID.Text = "Identificación"
        '
        'LbPrimerApellido
        '
        Me.LbPrimerApellido.AutoSize = True
        Me.LbPrimerApellido.Location = New System.Drawing.Point(27, 135)
        Me.LbPrimerApellido.Name = "LbPrimerApellido"
        Me.LbPrimerApellido.Size = New System.Drawing.Size(107, 17)
        Me.LbPrimerApellido.TabIndex = 3
        Me.LbPrimerApellido.Text = "Primer Apellido:"
        '
        'LSegundoApellido
        '
        Me.LSegundoApellido.AutoSize = True
        Me.LSegundoApellido.Location = New System.Drawing.Point(12, 172)
        Me.LSegundoApellido.Name = "LSegundoApellido"
        Me.LSegundoApellido.Size = New System.Drawing.Size(123, 17)
        Me.LSegundoApellido.TabIndex = 4
        Me.LSegundoApellido.Text = "Segundo Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nacionalidad:"
        '
        'LaSexo
        '
        Me.LaSexo.AutoSize = True
        Me.LaSexo.Location = New System.Drawing.Point(48, 257)
        Me.LaSexo.Name = "LaSexo"
        Me.LaSexo.Size = New System.Drawing.Size(43, 17)
        Me.LaSexo.TabIndex = 6
        Me.LaSexo.Text = "Sexo:"
        '
        'LEstaCivil
        '
        Me.LEstaCivil.AutoSize = True
        Me.LEstaCivil.Location = New System.Drawing.Point(25, 300)
        Me.LEstaCivil.Name = "LEstaCivil"
        Me.LEstaCivil.Size = New System.Drawing.Size(85, 17)
        Me.LEstaCivil.TabIndex = 7
        Me.LEstaCivil.Text = "Estado Civil:"
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(140, 62)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(100, 22)
        Me.TextNombre.TabIndex = 8
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(140, 101)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 22)
        Me.TxtID.TabIndex = 9
        '
        'TxtPrimerApell
        '
        Me.TxtPrimerApell.Location = New System.Drawing.Point(140, 135)
        Me.TxtPrimerApell.Name = "TxtPrimerApell"
        Me.TxtPrimerApell.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrimerApell.TabIndex = 10
        '
        'TxtSegundoApell
        '
        Me.TxtSegundoApell.Location = New System.Drawing.Point(140, 172)
        Me.TxtSegundoApell.Name = "TxtSegundoApell"
        Me.TxtSegundoApell.Size = New System.Drawing.Size(100, 22)
        Me.TxtSegundoApell.TabIndex = 11
        '
        'TextNacioanlidad
        '
        Me.TextNacioanlidad.Location = New System.Drawing.Point(140, 211)
        Me.TextNacioanlidad.Name = "TextNacioanlidad"
        Me.TextNacioanlidad.Size = New System.Drawing.Size(100, 22)
        Me.TextNacioanlidad.TabIndex = 12
        '
        'ComboSexo
        '
        Me.ComboSexo.BackColor = System.Drawing.SystemColors.Window
        Me.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSexo.FormattingEnabled = True
        Me.ComboSexo.Items.AddRange(New Object() {"Masculino", "Femenino" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboSexo.Location = New System.Drawing.Point(140, 254)
        Me.ComboSexo.Name = "ComboSexo"
        Me.ComboSexo.Size = New System.Drawing.Size(100, 24)
        Me.ComboSexo.TabIndex = 13
        '
        'ComboEstadoCivil
        '
        Me.ComboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstadoCivil.FormattingEnabled = True
        Me.ComboEstadoCivil.Items.AddRange(New Object() {"Casado", "Soltero"})
        Me.ComboEstadoCivil.Location = New System.Drawing.Point(140, 300)
        Me.ComboEstadoCivil.Name = "ComboEstadoCivil"
        Me.ComboEstadoCivil.Size = New System.Drawing.Size(100, 24)
        Me.ComboEstadoCivil.TabIndex = 14
        '
        'LTipoEmpleado
        '
        Me.LTipoEmpleado.AutoSize = True
        Me.LTipoEmpleado.Location = New System.Drawing.Point(305, 62)
        Me.LTipoEmpleado.Name = "LTipoEmpleado"
        Me.LTipoEmpleado.Size = New System.Drawing.Size(127, 17)
        Me.LTipoEmpleado.TabIndex = 15
        Me.LTipoEmpleado.Text = "Tipo de Empleado:"
        '
        'ComboTipoEmpleado
        '
        Me.ComboTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipoEmpleado.FormattingEnabled = True
        Me.ComboTipoEmpleado.Items.AddRange(New Object() {"Interino", "Propiedad"})
        Me.ComboTipoEmpleado.Location = New System.Drawing.Point(453, 59)
        Me.ComboTipoEmpleado.Name = "ComboTipoEmpleado"
        Me.ComboTipoEmpleado.Size = New System.Drawing.Size(100, 24)
        Me.ComboTipoEmpleado.TabIndex = 16
        '
        'LbEstado
        '
        Me.LbEstado.AutoSize = True
        Me.LbEstado.Location = New System.Drawing.Point(289, 101)
        Me.LbEstado.Name = "LbEstado"
        Me.LbEstado.Size = New System.Drawing.Size(143, 17)
        Me.LbEstado.TabIndex = 17
        Me.LbEstado.Text = "Estado de Empleado:"
        '
        'ComboEstado
        '
        Me.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Items.AddRange(New Object() {"Activo"})
        Me.ComboEstado.Location = New System.Drawing.Point(453, 101)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(100, 24)
        Me.ComboEstado.TabIndex = 18
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(315, 138)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(102, 17)
        Me.LFecha.TabIndex = 19
        Me.LFecha.Text = "Fecha Ingreso:"
        '
        'DateTimeFechaIngreso
        '
        Me.DateTimeFechaIngreso.Location = New System.Drawing.Point(453, 135)
        Me.DateTimeFechaIngreso.MaxDate = New Date(2021, 12, 31, 0, 0, 0, 0)
        Me.DateTimeFechaIngreso.MinDate = New Date(1951, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaIngreso.Name = "DateTimeFechaIngreso"
        Me.DateTimeFechaIngreso.Size = New System.Drawing.Size(159, 22)
        Me.DateTimeFechaIngreso.TabIndex = 20
        '
        'LfechaNacimiento
        '
        Me.LfechaNacimiento.AutoSize = True
        Me.LfechaNacimiento.Location = New System.Drawing.Point(2, 347)
        Me.LfechaNacimiento.Name = "LfechaNacimiento"
        Me.LfechaNacimiento.Size = New System.Drawing.Size(121, 17)
        Me.LfechaNacimiento.TabIndex = 21
        Me.LfechaNacimiento.Text = "Fecha Nacimiento"
        '
        'DateTimeFechaNacimiento
        '
        Me.DateTimeFechaNacimiento.Location = New System.Drawing.Point(140, 342)
        Me.DateTimeFechaNacimiento.MaxDate = New Date(2006, 12, 31, 0, 0, 0, 0)
        Me.DateTimeFechaNacimiento.MinDate = New Date(1951, 1, 1, 0, 0, 0, 0)
        Me.DateTimeFechaNacimiento.Name = "DateTimeFechaNacimiento"
        Me.DateTimeFechaNacimiento.Size = New System.Drawing.Size(195, 22)
        Me.DateTimeFechaNacimiento.TabIndex = 22
        Me.DateTimeFechaNacimiento.Value = New Date(2000, 12, 31, 0, 0, 0, 0)
        '
        'SalarioBase
        '
        Me.SalarioBase.AutoSize = True
        Me.SalarioBase.Location = New System.Drawing.Point(315, 182)
        Me.SalarioBase.Name = "SalarioBase"
        Me.SalarioBase.Size = New System.Drawing.Size(92, 17)
        Me.SalarioBase.TabIndex = 23
        Me.SalarioBase.Text = "Salario Base:"
        '
        'TextSalarioBase
        '
        Me.TextSalarioBase.Location = New System.Drawing.Point(453, 177)
        Me.TextSalarioBase.Name = "TextSalarioBase"
        Me.TextSalarioBase.Size = New System.Drawing.Size(100, 22)
        Me.TextSalarioBase.TabIndex = 24
        '
        'Linformación
        '
        Me.Linformación.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linformación.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Linformación.Location = New System.Drawing.Point(289, 241)
        Me.Linformación.Name = "Linformación"
        Me.Linformación.Size = New System.Drawing.Size(249, 82)
        Me.Linformación.TabIndex = 25
        Me.Linformación.Text = resources.GetString("Linformación.Text")
        Me.Linformación.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Cantidad Hijos Aplicables:"
        '
        'TxtCantidadHijos
        '
        Me.TxtCantidadHijos.Location = New System.Drawing.Point(453, 216)
        Me.TxtCantidadHijos.MaxLength = 2
        Me.TxtCantidadHijos.Name = "TxtCantidadHijos"
        Me.TxtCantidadHijos.Size = New System.Drawing.Size(100, 22)
        Me.TxtCantidadHijos.TabIndex = 27
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregar.Location = New System.Drawing.Point(92, 409)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(449, 67)
        Me.BtnAgregar.TabIndex = 28
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'FrmRegistroEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 566)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtCantidadHijos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Linformación)
        Me.Controls.Add(Me.TextSalarioBase)
        Me.Controls.Add(Me.SalarioBase)
        Me.Controls.Add(Me.DateTimeFechaNacimiento)
        Me.Controls.Add(Me.LfechaNacimiento)
        Me.Controls.Add(Me.DateTimeFechaIngreso)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.ComboEstado)
        Me.Controls.Add(Me.LbEstado)
        Me.Controls.Add(Me.ComboTipoEmpleado)
        Me.Controls.Add(Me.LTipoEmpleado)
        Me.Controls.Add(Me.ComboEstadoCivil)
        Me.Controls.Add(Me.ComboSexo)
        Me.Controls.Add(Me.TextNacioanlidad)
        Me.Controls.Add(Me.TxtSegundoApell)
        Me.Controls.Add(Me.TxtPrimerApell)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.LEstaCivil)
        Me.Controls.Add(Me.LaSexo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LSegundoApellido)
        Me.Controls.Add(Me.LbPrimerApellido)
        Me.Controls.Add(Me.LbID)
        Me.Controls.Add(Me.LabNombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.MaximizeBox = False
        Me.Name = "FrmRegistroEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistroEmpleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LabNombre As Label
    Friend WithEvents LbID As Label
    Friend WithEvents LbPrimerApellido As Label
    Friend WithEvents LSegundoApellido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LaSexo As Label
    Friend WithEvents LEstaCivil As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtPrimerApell As TextBox
    Friend WithEvents TxtSegundoApell As TextBox
    Friend WithEvents TextNacioanlidad As TextBox
    Friend WithEvents ComboSexo As ComboBox
    Friend WithEvents ComboEstadoCivil As ComboBox
    Friend WithEvents LTipoEmpleado As Label
    Friend WithEvents ComboTipoEmpleado As ComboBox
    Friend WithEvents LbEstado As Label
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents LFecha As Label
    Friend WithEvents DateTimeFechaIngreso As DateTimePicker
    Friend WithEvents LfechaNacimiento As Label
    Friend WithEvents DateTimeFechaNacimiento As DateTimePicker
    Friend WithEvents SalarioBase As Label
    Friend WithEvents TextSalarioBase As TextBox
    Friend WithEvents Linformación As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCantidadHijos As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents ToolTipMenuEmpleados As ToolTip
End Class
