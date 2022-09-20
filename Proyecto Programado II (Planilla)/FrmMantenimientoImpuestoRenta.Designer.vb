<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoImpuestoRenta
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGrImpuestosRenta = New System.Windows.Forms.DataGridView()
        Me.CodigoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcetanj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControlmpuestoRenta = New System.Windows.Forms.TabControl()
        Me.TabMantenimientoCreditos = New System.Windows.Forms.TabPage()
        Me.TxtPorcentanjeApliAgregar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLimiteSuperiorAgregar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtLimiteInferiorAgregar = New System.Windows.Forms.TextBox()
        Me.LablMonto = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtPorcentajeActualizar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLimiteSuperiorActualizar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLimiInferiorActualizar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtCodigoActualizar = New System.Windows.Forms.TextBox()
        Me.LabCodigo = New System.Windows.Forms.Label()
        CType(Me.DataGrImpuestosRenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlmpuestoRenta.SuspendLayout()
        Me.TabMantenimientoCreditos.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrImpuestosRenta
        '
        Me.DataGrImpuestosRenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrImpuestosRenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrImpuestosRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrImpuestosRenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoCredito, Me.NombreCredito, Me.Monto, Me.Porcetanj})
        Me.DataGrImpuestosRenta.Location = New System.Drawing.Point(46, 337)
        Me.DataGrImpuestosRenta.Name = "DataGrImpuestosRenta"
        Me.DataGrImpuestosRenta.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrImpuestosRenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGrImpuestosRenta.RowHeadersWidth = 51
        Me.DataGrImpuestosRenta.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGrImpuestosRenta.RowTemplate.Height = 24
        Me.DataGrImpuestosRenta.RowTemplate.ReadOnly = True
        Me.DataGrImpuestosRenta.Size = New System.Drawing.Size(640, 202)
        Me.DataGrImpuestosRenta.TabIndex = 6
        '
        'CodigoCredito
        '
        Me.CodigoCredito.HeaderText = "Codigo"
        Me.CodigoCredito.MinimumWidth = 6
        Me.CodigoCredito.Name = "CodigoCredito"
        Me.CodigoCredito.ReadOnly = True
        Me.CodigoCredito.Width = 125
        '
        'NombreCredito
        '
        Me.NombreCredito.HeaderText = "Limite Inferior"
        Me.NombreCredito.MinimumWidth = 6
        Me.NombreCredito.Name = "NombreCredito"
        Me.NombreCredito.ReadOnly = True
        Me.NombreCredito.Width = 125
        '
        'Monto
        '
        Me.Monto.HeaderText = "Limite Superior"
        Me.Monto.MinimumWidth = 6
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 125
        '
        'Porcetanj
        '
        Me.Porcetanj.HeaderText = "Porcentaje Aplicable"
        Me.Porcetanj.MinimumWidth = 6
        Me.Porcetanj.Name = "Porcetanj"
        Me.Porcetanj.ReadOnly = True
        Me.Porcetanj.Width = 125
        '
        'TabControlmpuestoRenta
        '
        Me.TabControlmpuestoRenta.Controls.Add(Me.TabMantenimientoCreditos)
        Me.TabControlmpuestoRenta.Controls.Add(Me.TabPage2)
        Me.TabControlmpuestoRenta.Location = New System.Drawing.Point(46, 53)
        Me.TabControlmpuestoRenta.Name = "TabControlmpuestoRenta"
        Me.TabControlmpuestoRenta.SelectedIndex = 0
        Me.TabControlmpuestoRenta.Size = New System.Drawing.Size(640, 268)
        Me.TabControlmpuestoRenta.TabIndex = 5
        '
        'TabMantenimientoCreditos
        '
        Me.TabMantenimientoCreditos.Controls.Add(Me.TxtPorcentanjeApliAgregar)
        Me.TabMantenimientoCreditos.Controls.Add(Me.Label2)
        Me.TabMantenimientoCreditos.Controls.Add(Me.TxtLimiteSuperiorAgregar)
        Me.TabMantenimientoCreditos.Controls.Add(Me.Label1)
        Me.TabMantenimientoCreditos.Controls.Add(Me.BtnAgregar)
        Me.TabMantenimientoCreditos.Controls.Add(Me.TxtLimiteInferiorAgregar)
        Me.TabMantenimientoCreditos.Controls.Add(Me.LablMonto)
        Me.TabMantenimientoCreditos.Location = New System.Drawing.Point(4, 25)
        Me.TabMantenimientoCreditos.Name = "TabMantenimientoCreditos"
        Me.TabMantenimientoCreditos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMantenimientoCreditos.Size = New System.Drawing.Size(632, 239)
        Me.TabMantenimientoCreditos.TabIndex = 0
        Me.TabMantenimientoCreditos.Text = "Agregar"
        Me.TabMantenimientoCreditos.UseVisualStyleBackColor = True
        '
        'TxtPorcentanjeApliAgregar
        '
        Me.TxtPorcentanjeApliAgregar.Location = New System.Drawing.Point(177, 110)
        Me.TxtPorcentanjeApliAgregar.MaxLength = 12
        Me.TxtPorcentanjeApliAgregar.Name = "TxtPorcentanjeApliAgregar"
        Me.TxtPorcentanjeApliAgregar.Size = New System.Drawing.Size(116, 22)
        Me.TxtPorcentanjeApliAgregar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Porcentaje Aplicable:"
        '
        'TxtLimiteSuperiorAgregar
        '
        Me.TxtLimiteSuperiorAgregar.Location = New System.Drawing.Point(177, 65)
        Me.TxtLimiteSuperiorAgregar.MaxLength = 12
        Me.TxtLimiteSuperiorAgregar.Name = "TxtLimiteSuperiorAgregar"
        Me.TxtLimiteSuperiorAgregar.Size = New System.Drawing.Size(116, 22)
        Me.TxtLimiteSuperiorAgregar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Limite Superior:"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(353, 59)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(84, 68)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtLimiteInferiorAgregar
        '
        Me.TxtLimiteInferiorAgregar.Location = New System.Drawing.Point(177, 27)
        Me.TxtLimiteInferiorAgregar.MaxLength = 12
        Me.TxtLimiteInferiorAgregar.Name = "TxtLimiteInferiorAgregar"
        Me.TxtLimiteInferiorAgregar.Size = New System.Drawing.Size(116, 22)
        Me.TxtLimiteInferiorAgregar.TabIndex = 3
        '
        'LablMonto
        '
        Me.LablMonto.AutoSize = True
        Me.LablMonto.Location = New System.Drawing.Point(42, 27)
        Me.LablMonto.Name = "LablMonto"
        Me.LablMonto.Size = New System.Drawing.Size(92, 17)
        Me.LablMonto.TabIndex = 1
        Me.LablMonto.Text = "Limite Inferio:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtPorcentajeActualizar)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtLimiteSuperiorActualizar)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtLimiInferiorActualizar)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtCodigoActualizar)
        Me.TabPage2.Controls.Add(Me.LabCodigo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(632, 239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actualizar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtPorcentajeActualizar
        '
        Me.TxtPorcentajeActualizar.Location = New System.Drawing.Point(170, 137)
        Me.TxtPorcentajeActualizar.MaxLength = 9
        Me.TxtPorcentajeActualizar.Name = "TxtPorcentajeActualizar"
        Me.TxtPorcentajeActualizar.Size = New System.Drawing.Size(116, 22)
        Me.TxtPorcentajeActualizar.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Porcentaje Aplicable:"
        '
        'TxtLimiteSuperiorActualizar
        '
        Me.TxtLimiteSuperiorActualizar.Location = New System.Drawing.Point(170, 99)
        Me.TxtLimiteSuperiorActualizar.MaxLength = 12
        Me.TxtLimiteSuperiorActualizar.Name = "TxtLimiteSuperiorActualizar"
        Me.TxtLimiteSuperiorActualizar.Size = New System.Drawing.Size(116, 22)
        Me.TxtLimiteSuperiorActualizar.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Limite Superior:"
        '
        'TxtLimiInferiorActualizar
        '
        Me.TxtLimiInferiorActualizar.Location = New System.Drawing.Point(170, 61)
        Me.TxtLimiInferiorActualizar.MaxLength = 12
        Me.TxtLimiInferiorActualizar.Name = "TxtLimiInferiorActualizar"
        Me.TxtLimiInferiorActualizar.Size = New System.Drawing.Size(116, 22)
        Me.TxtLimiInferiorActualizar.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Limite Inferio:"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(358, 60)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 84)
        Me.BtnActualizar.TabIndex = 6
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtCodigoActualizar
        '
        Me.TxtCodigoActualizar.Location = New System.Drawing.Point(170, 22)
        Me.TxtCodigoActualizar.Name = "TxtCodigoActualizar"
        Me.TxtCodigoActualizar.ReadOnly = True
        Me.TxtCodigoActualizar.Size = New System.Drawing.Size(116, 22)
        Me.TxtCodigoActualizar.TabIndex = 3
        '
        'LabCodigo
        '
        Me.LabCodigo.AutoSize = True
        Me.LabCodigo.Location = New System.Drawing.Point(57, 25)
        Me.LabCodigo.Name = "LabCodigo"
        Me.LabCodigo.Size = New System.Drawing.Size(56, 17)
        Me.LabCodigo.TabIndex = 0
        Me.LabCodigo.Text = "Codigo:"
        '
        'FrmMantenimientoImpuestoRenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 659)
        Me.Controls.Add(Me.DataGrImpuestosRenta)
        Me.Controls.Add(Me.TabControlmpuestoRenta)
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimientoImpuestoRenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Impuestos Renta"
        CType(Me.DataGrImpuestosRenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlmpuestoRenta.ResumeLayout(False)
        Me.TabMantenimientoCreditos.ResumeLayout(False)
        Me.TabMantenimientoCreditos.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrImpuestosRenta As DataGridView
    Friend WithEvents TabControlmpuestoRenta As TabControl
    Friend WithEvents TabMantenimientoCreditos As TabPage
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtLimiteInferiorAgregar As TextBox
    Friend WithEvents LablMonto As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtCodigoActualizar As TextBox
    Friend WithEvents LabCodigo As Label
    Friend WithEvents TxtLimiteSuperiorAgregar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPorcentanjeApliAgregar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CodigoCredito As DataGridViewTextBoxColumn
    Friend WithEvents NombreCredito As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Porcetanj As DataGridViewTextBoxColumn
    Friend WithEvents TxtPorcentajeActualizar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtLimiteSuperiorActualizar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLimiInferiorActualizar As TextBox
    Friend WithEvents Label5 As Label
End Class
