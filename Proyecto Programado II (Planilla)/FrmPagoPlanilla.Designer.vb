<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoPlanilla
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.GroupBoxActualizar = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHorasDobles = New System.Windows.Forms.TextBox()
        Me.TxtPrimerApell = New System.Windows.Forms.TextBox()
        Me.LbPrimerApellido = New System.Windows.Forms.Label()
        Me.BtnAgregarPlanilla = New System.Windows.Forms.Button()
        Me.TxtHorasExtras = New System.Windows.Forms.TextBox()
        Me.TxtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.SalarioBase = New System.Windows.Forms.Label()
        Me.LbEstad = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.LEstaCivil = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.LabNombre = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DatagPlanilla = New System.Windows.Forms.DataGridView()
        Me.IDENTI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nomb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Primer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalarioBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargasSociales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DtgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxActualizar.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DatagPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(878, 571)
        Me.TabControl1.TabIndex = 46
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.LabelFecha)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DtgvEmpleados)
        Me.TabPage1.Controls.Add(Me.GroupBoxActualizar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(870, 542)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar Empleado Planilla"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(632, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(124, 492)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(0, 24)
        Me.LabelFecha.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 492)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha:"
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
        Me.DtgvEmpleados.Location = New System.Drawing.Point(3, 217)
        Me.DtgvEmpleados.Name = "DtgvEmpleados"
        Me.DtgvEmpleados.RowHeadersWidth = 51
        Me.DtgvEmpleados.RowTemplate.Height = 24
        Me.DtgvEmpleados.RowTemplate.ReadOnly = True
        Me.DtgvEmpleados.Size = New System.Drawing.Size(741, 245)
        Me.DtgvEmpleados.TabIndex = 5
        '
        'GroupBoxActualizar
        '
        Me.GroupBoxActualizar.AutoSize = True
        Me.GroupBoxActualizar.Controls.Add(Me.Label1)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtHorasDobles)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtPrimerApell)
        Me.GroupBoxActualizar.Controls.Add(Me.LbPrimerApellido)
        Me.GroupBoxActualizar.Controls.Add(Me.BtnAgregarPlanilla)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtHorasExtras)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtHorasTrabajadas)
        Me.GroupBoxActualizar.Controls.Add(Me.SalarioBase)
        Me.GroupBoxActualizar.Controls.Add(Me.LbEstad)
        Me.GroupBoxActualizar.Controls.Add(Me.TxtID)
        Me.GroupBoxActualizar.Controls.Add(Me.TextNombre)
        Me.GroupBoxActualizar.Controls.Add(Me.LEstaCivil)
        Me.GroupBoxActualizar.Controls.Add(Me.LbID)
        Me.GroupBoxActualizar.Controls.Add(Me.LabNombre)
        Me.GroupBoxActualizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxActualizar.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxActualizar.Name = "GroupBoxActualizar"
        Me.GroupBoxActualizar.Size = New System.Drawing.Size(864, 162)
        Me.GroupBoxActualizar.TabIndex = 4
        Me.GroupBoxActualizar.TabStop = False
        Me.GroupBoxActualizar.Text = "Actualizar - Eliminar Empleados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(600, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 15)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Agregar Empleado para el calculo"
        '
        'TxtHorasDobles
        '
        Me.TxtHorasDobles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHorasDobles.Location = New System.Drawing.Point(449, 117)
        Me.TxtHorasDobles.MaxLength = 2
        Me.TxtHorasDobles.Name = "TxtHorasDobles"
        Me.TxtHorasDobles.Size = New System.Drawing.Size(121, 24)
        Me.TxtHorasDobles.TabIndex = 45
        '
        'TxtPrimerApell
        '
        Me.TxtPrimerApell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrimerApell.Location = New System.Drawing.Point(147, 73)
        Me.TxtPrimerApell.Name = "TxtPrimerApell"
        Me.TxtPrimerApell.ReadOnly = True
        Me.TxtPrimerApell.Size = New System.Drawing.Size(113, 24)
        Me.TxtPrimerApell.TabIndex = 44
        '
        'LbPrimerApellido
        '
        Me.LbPrimerApellido.AutoSize = True
        Me.LbPrimerApellido.Location = New System.Drawing.Point(14, 73)
        Me.LbPrimerApellido.Name = "LbPrimerApellido"
        Me.LbPrimerApellido.Size = New System.Drawing.Size(107, 17)
        Me.LbPrimerApellido.TabIndex = 43
        Me.LbPrimerApellido.Text = "Primer Apellido:"
        '
        'BtnAgregarPlanilla
        '
        Me.BtnAgregarPlanilla.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAgregarPlanilla.BackgroundImage = Global.Proyecto_Programado_II__Planilla_.My.Resources.Resources.agregar_archivo
        Me.BtnAgregarPlanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAgregarPlanilla.CausesValidation = False
        Me.BtnAgregarPlanilla.Location = New System.Drawing.Point(680, 24)
        Me.BtnAgregarPlanilla.Name = "BtnAgregarPlanilla"
        Me.BtnAgregarPlanilla.Size = New System.Drawing.Size(77, 73)
        Me.BtnAgregarPlanilla.TabIndex = 41
        Me.BtnAgregarPlanilla.UseVisualStyleBackColor = False
        '
        'TxtHorasExtras
        '
        Me.TxtHorasExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHorasExtras.Location = New System.Drawing.Point(449, 76)
        Me.TxtHorasExtras.MaxLength = 2
        Me.TxtHorasExtras.Name = "TxtHorasExtras"
        Me.TxtHorasExtras.Size = New System.Drawing.Size(121, 24)
        Me.TxtHorasExtras.TabIndex = 40
        '
        'TxtHorasTrabajadas
        '
        Me.TxtHorasTrabajadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHorasTrabajadas.Location = New System.Drawing.Point(449, 34)
        Me.TxtHorasTrabajadas.Name = "TxtHorasTrabajadas"
        Me.TxtHorasTrabajadas.Size = New System.Drawing.Size(121, 24)
        Me.TxtHorasTrabajadas.TabIndex = 37
        '
        'SalarioBase
        '
        Me.SalarioBase.AutoSize = True
        Me.SalarioBase.Location = New System.Drawing.Point(309, 122)
        Me.SalarioBase.Name = "SalarioBase"
        Me.SalarioBase.Size = New System.Drawing.Size(98, 17)
        Me.SalarioBase.TabIndex = 36
        Me.SalarioBase.Text = "Horas Dobles:"
        '
        'LbEstad
        '
        Me.LbEstad.AutoSize = True
        Me.LbEstad.Location = New System.Drawing.Point(308, 39)
        Me.LbEstad.Name = "LbEstad"
        Me.LbEstad.Size = New System.Drawing.Size(126, 17)
        Me.LbEstad.TabIndex = 34
        Me.LbEstad.Text = "Horas Trabajadas:"
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtID.Location = New System.Drawing.Point(147, 115)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(113, 24)
        Me.TxtID.TabIndex = 32
        '
        'TextNombre
        '
        Me.TextNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombre.Location = New System.Drawing.Point(147, 32)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.ReadOnly = True
        Me.TextNombre.Size = New System.Drawing.Size(113, 24)
        Me.TextNombre.TabIndex = 31
        '
        'LEstaCivil
        '
        Me.LEstaCivil.AutoSize = True
        Me.LEstaCivil.Location = New System.Drawing.Point(308, 81)
        Me.LEstaCivil.Name = "LEstaCivil"
        Me.LEstaCivil.Size = New System.Drawing.Size(93, 17)
        Me.LEstaCivil.TabIndex = 30
        Me.LEstaCivil.Text = "Horas Extras:"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Location = New System.Drawing.Point(31, 115)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(90, 17)
        Me.LbID.TabIndex = 29
        Me.LbID.Text = "Identificación"
        '
        'LabNombre
        '
        Me.LabNombre.AutoSize = True
        Me.LabNombre.Location = New System.Drawing.Point(44, 32)
        Me.LabNombre.Name = "LabNombre"
        Me.LabNombre.Size = New System.Drawing.Size(62, 17)
        Me.LabNombre.TabIndex = 28
        Me.LabNombre.Text = "Nombre:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DatagPlanilla)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(870, 542)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Calculo Planilla"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DatagPlanilla
        '
        Me.DatagPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagPlanilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDENTI, Me.Nomb, Me.Primer, Me.SalarioBruto, Me.CargasSociales, Me.ImR, Me.Sn, Me.Fecha})
        Me.DatagPlanilla.Location = New System.Drawing.Point(61, 114)
        Me.DatagPlanilla.Name = "DatagPlanilla"
        Me.DatagPlanilla.RowHeadersWidth = 51
        Me.DatagPlanilla.RowTemplate.Height = 24
        Me.DatagPlanilla.Size = New System.Drawing.Size(724, 320)
        Me.DatagPlanilla.TabIndex = 0
        '
        'IDENTI
        '
        Me.IDENTI.HeaderText = "Identificación"
        Me.IDENTI.MinimumWidth = 6
        Me.IDENTI.Name = "IDENTI"
        Me.IDENTI.Width = 125
        '
        'Nomb
        '
        Me.Nomb.HeaderText = "Nombre "
        Me.Nomb.MinimumWidth = 6
        Me.Nomb.Name = "Nomb"
        Me.Nomb.Width = 125
        '
        'Primer
        '
        Me.Primer.HeaderText = "Primer Apellido"
        Me.Primer.MinimumWidth = 6
        Me.Primer.Name = "Primer"
        Me.Primer.Width = 125
        '
        'SalarioBruto
        '
        Me.SalarioBruto.HeaderText = "Salario Bruto"
        Me.SalarioBruto.MinimumWidth = 6
        Me.SalarioBruto.Name = "SalarioBruto"
        Me.SalarioBruto.Width = 125
        '
        'CargasSociales
        '
        Me.CargasSociales.HeaderText = "Cargas Sociales (Monto Rebajo)"
        Me.CargasSociales.MinimumWidth = 6
        Me.CargasSociales.Name = "CargasSociales"
        Me.CargasSociales.Width = 125
        '
        'ImR
        '
        Me.ImR.HeaderText = "Impuesto Renta (Rebajo)"
        Me.ImR.MinimumWidth = 6
        Me.ImR.Name = "ImR"
        Me.ImR.Width = 125
        '
        'Sn
        '
        Me.Sn.HeaderText = "Salario Neto (A pagar)"
        Me.Sn.MinimumWidth = 6
        Me.Sn.Name = "Sn"
        Me.Sn.Width = 125
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha Generado Planilla"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 125
        '
        'FrmPagoPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 636)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmPagoPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPagoPlanilla"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DtgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxActualizar.ResumeLayout(False)
        Me.GroupBoxActualizar.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DatagPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBoxActualizar As GroupBox
    Friend WithEvents TxtHorasDobles As TextBox
    Friend WithEvents TxtPrimerApell As TextBox
    Friend WithEvents LbPrimerApellido As Label
    Friend WithEvents BtnAgregarPlanilla As Button
    Friend WithEvents TxtHorasExtras As TextBox
    Friend WithEvents TxtHorasTrabajadas As TextBox
    Friend WithEvents SalarioBase As Label
    Friend WithEvents LbEstad As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents LEstaCivil As Label
    Friend WithEvents LbID As Label
    Friend WithEvents LabNombre As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DtgvEmpleados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DatagPlanilla As DataGridView
    Friend WithEvents IDENTI As DataGridViewTextBoxColumn
    Friend WithEvents Nomb As DataGridViewTextBoxColumn
    Friend WithEvents Primer As DataGridViewTextBoxColumn
    Friend WithEvents SalarioBruto As DataGridViewTextBoxColumn
    Friend WithEvents CargasSociales As DataGridViewTextBoxColumn
    Friend WithEvents ImR As DataGridViewTextBoxColumn
    Friend WithEvents Sn As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
