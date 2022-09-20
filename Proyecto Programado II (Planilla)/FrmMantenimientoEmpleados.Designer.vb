<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimientoEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoEmpleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxActualizar = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPrimerApell = New System.Windows.Forms.TextBox()
        Me.LbPrimerApellido = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtCantidadHijos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Linformación = New System.Windows.Forms.Label()
        Me.TextSalarioBase = New System.Windows.Forms.TextBox()
        Me.SalarioBase = New System.Windows.Forms.Label()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.LbEstado = New System.Windows.Forms.Label()
        Me.ComboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.LEstaCivil = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.LabNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ToolTipMenuEmpleados = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxActualizar.SuspendLayout()
        CType(Me.DtgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxActualizar
        '
        Me.GroupBoxActualizar.AutoSize = True
        Me.GroupBoxActualizar.Controls.Add(Me.Button1)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtPrimerApell)
        Me.GroupBoxActualizar.Controls.Add(Me.LbPrimerApellido)
        Me.GroupBoxActualizar.Controls.Add(Me.BtnEliminar)
        Me.GroupBoxActualizar.Controls.Add(Me.BtnActualizar)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtCantidadHijos)
        Me.GroupBoxActualizar.Controls.Add(Me.Label2)
        Me.GroupBoxActualizar.Controls.Add(Me.Linformación)
        Me.GroupBoxActualizar.Controls.Add(Me.TextSalarioBase)
        Me.GroupBoxActualizar.Controls.Add(Me.SalarioBase)
        Me.GroupBoxActualizar.Controls.Add(Me.ComboEstado)
        Me.GroupBoxActualizar.Controls.Add(Me.LbEstado)
        Me.GroupBoxActualizar.Controls.Add(Me.ComboEstadoCivil)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtID)
        Me.GroupBoxActualizar.Controls.Add(Me.TextNombre)
        Me.GroupBoxActualizar.Controls.Add(Me.LEstaCivil)
        Me.GroupBoxActualizar.Controls.Add(Me.LbID)
        Me.GroupBoxActualizar.Controls.Add(Me.LabNombre)
        Me.GroupBoxActualizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxActualizar.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxActualizar.Name = "GroupBoxActualizar"
        Me.GroupBoxActualizar.Size = New System.Drawing.Size(1245, 228)
        Me.GroupBoxActualizar.TabIndex = 1
        Me.GroupBoxActualizar.TabStop = False
        Me.GroupBoxActualizar.Text = "Actualizar - Eliminar Empleados"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPrimerApell
        '
        Me.TxtPrimerApell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerApell.Location = New System.Drawing.Point(205, 78)
        Me.TxtPrimerApell.Name = "TxtPrimerApell"
        Me.TxtPrimerApell.ReadOnly = True
        Me.TxtPrimerApell.Size = New System.Drawing.Size(113, 24)
        Me.TxtPrimerApell.TabIndex = 44
        '
        'LbPrimerApellido
        '
        Me.LbPrimerApellido.AutoSize = True
        Me.LbPrimerApellido.Location = New System.Drawing.Point(92, 78)
        Me.LbPrimerApellido.Name = "LbPrimerApellido"
        Me.LbPrimerApellido.Size = New System.Drawing.Size(107, 17)
        Me.LbPrimerApellido.TabIndex = 43
        Me.LbPrimerApellido.Text = "Primer Apellido:"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(475, 141)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(107, 56)
        Me.BtnEliminar.TabIndex = 42
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(344, 141)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(107, 56)
        Me.BtnActualizar.TabIndex = 41
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtCantidadHijos
        '
        Me.TxtCantidadHijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadHijos.Location = New System.Drawing.Point(825, 78)
        Me.TxtCantidadHijos.MaxLength = 2
        Me.TxtCantidadHijos.Name = "TxtCantidadHijos"
        Me.TxtCantidadHijos.Size = New System.Drawing.Size(121, 24)
        Me.TxtCantidadHijos.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(635, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Cantidad Hijos Aplicables:"
        '
        'Linformación
        '
        Me.Linformación.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Linformación.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linformación.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Linformación.Location = New System.Drawing.Point(765, 128)
        Me.Linformación.Name = "Linformación"
        Me.Linformación.Size = New System.Drawing.Size(249, 82)
        Me.Linformación.TabIndex = 38
        Me.Linformación.Text = resources.GetString("Linformación.Text")
        Me.Linformación.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextSalarioBase
        '
        Me.TextSalarioBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSalarioBase.Location = New System.Drawing.Point(825, 32)
        Me.TextSalarioBase.Name = "TextSalarioBase"
        Me.TextSalarioBase.Size = New System.Drawing.Size(121, 24)
        Me.TextSalarioBase.TabIndex = 37
        '
        'SalarioBase
        '
        Me.SalarioBase.AutoSize = True
        Me.SalarioBase.Location = New System.Drawing.Point(678, 37)
        Me.SalarioBase.Name = "SalarioBase"
        Me.SalarioBase.Size = New System.Drawing.Size(92, 17)
        Me.SalarioBase.TabIndex = 36
        Me.SalarioBase.Text = "Salario Base:"
        '
        'ComboEstado
        '
        Me.ComboEstado.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ComboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Items.AddRange(New Object() {"Activo", "Inactivo", "Incapacitado"})
        Me.ComboEstado.Location = New System.Drawing.Point(490, 36)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(100, 24)
        Me.ComboEstado.TabIndex = 35
        '
        'LbEstado
        '
        Me.LbEstado.AutoSize = True
        Me.LbEstado.Location = New System.Drawing.Point(341, 39)
        Me.LbEstado.Name = "LbEstado"
        Me.LbEstado.Size = New System.Drawing.Size(143, 17)
        Me.LbEstado.TabIndex = 34
        Me.LbEstado.Text = "Estado de Empleado:"
        '
        'ComboEstadoCivil
        '
        Me.ComboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboEstadoCivil.FormattingEnabled = True
        Me.ComboEstadoCivil.Items.AddRange(New Object() {"Casado", "Soltero"})
        Me.ComboEstadoCivil.Location = New System.Drawing.Point(490, 83)
        Me.ComboEstadoCivil.Name = "ComboEstadoCivil"
        Me.ComboEstadoCivil.Size = New System.Drawing.Size(100, 24)
        Me.ComboEstadoCivil.TabIndex = 33
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(205, 115)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(113, 24)
        Me.TxtID.TabIndex = 32
        '
        'TextNombre
        '
        Me.TextNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombre.Location = New System.Drawing.Point(205, 39)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.ReadOnly = True
        Me.TextNombre.Size = New System.Drawing.Size(113, 24)
        Me.TextNombre.TabIndex = 31
        '
        'LEstaCivil
        '
        Me.LEstaCivil.AutoSize = True
        Me.LEstaCivil.Location = New System.Drawing.Point(371, 83)
        Me.LEstaCivil.Name = "LEstaCivil"
        Me.LEstaCivil.Size = New System.Drawing.Size(85, 17)
        Me.LEstaCivil.TabIndex = 30
        Me.LEstaCivil.Text = "Estado Civil:"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Location = New System.Drawing.Point(98, 115)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(90, 17)
        Me.LbID.TabIndex = 29
        Me.LbID.Text = "Identificación"
        '
        'LabNombre
        '
        Me.LabNombre.AutoSize = True
        Me.LabNombre.Location = New System.Drawing.Point(113, 39)
        Me.LabNombre.Name = "LabNombre"
        Me.LabNombre.Size = New System.Drawing.Size(62, 17)
        Me.LabNombre.TabIndex = 28
        Me.LabNombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 589)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(871, 77)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtgvEmpleados
        '
        Me.DtgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtgvEmpleados.Location = New System.Drawing.Point(0, 238)
        Me.DtgvEmpleados.Name = "DtgvEmpleados"
        Me.DtgvEmpleados.RowHeadersWidth = 51
        Me.DtgvEmpleados.RowTemplate.Height = 24
        Me.DtgvEmpleados.RowTemplate.ReadOnly = True
        Me.DtgvEmpleados.Size = New System.Drawing.Size(1203, 316)
        Me.DtgvEmpleados.TabIndex = 0
        '
        'FrmMantenimientoEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 773)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxActualizar)
        Me.Controls.Add(Me.DtgvEmpleados)
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimientoEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Empleados"
        Me.GroupBoxActualizar.ResumeLayout(False)
        Me.GroupBoxActualizar.PerformLayout()
        CType(Me.DtgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxActualizar As GroupBox
    Friend WithEvents TxtCantidadHijos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextSalarioBase As TextBox
    Friend WithEvents SalarioBase As Label
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents LbEstado As Label
    Friend WithEvents ComboEstadoCivil As ComboBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents LEstaCivil As Label
    Friend WithEvents LbID As Label
    Friend WithEvents LabNombre As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DtgvEmpleados As DataGridView
    Friend WithEvents TxtPrimerApell As TextBox
    Friend WithEvents LbPrimerApellido As Label
    Friend WithEvents ToolTipMenuEmpleados As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Linformación As Label
End Class
