<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimientoCreditosFiscales
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabMantenimientoCreditos = New System.Windows.Forms.TabPage()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtMontoAplicable = New System.Windows.Forms.TextBox()
        Me.TxtNombreCredito = New System.Windows.Forms.TextBox()
        Me.LablMonto = New System.Windows.Forms.Label()
        Me.LabelNombreCreditoFisca = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtMontoAplicarModificar = New System.Windows.Forms.TextBox()
        Me.TxtNombreActualizar = New System.Windows.Forms.TextBox()
        Me.TxtCodigoModificar = New System.Windows.Forms.TextBox()
        Me.LabMontoAplica = New System.Windows.Forms.Label()
        Me.LabNombre = New System.Windows.Forms.Label()
        Me.LabCodigo = New System.Windows.Forms.Label()
        Me.ToolTipCreditosFiscales = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGrCreditosFiscales = New System.Windows.Forms.DataGridView()
        Me.CodigoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabMantenimientoCreditos.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrCreditosFiscales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabMantenimientoCreditos)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(38, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 196)
        Me.TabControl1.TabIndex = 0
        '
        'TabMantenimientoCreditos
        '
        Me.TabMantenimientoCreditos.Controls.Add(Me.BtnAgregar)
        Me.TabMantenimientoCreditos.Controls.Add(Me.TxtMontoAplicable)
        Me.TabMantenimientoCreditos.Controls.Add(Me.TxtNombreCredito)
        Me.TabMantenimientoCreditos.Controls.Add(Me.LablMonto)
        Me.TabMantenimientoCreditos.Controls.Add(Me.LabelNombreCreditoFisca)
        Me.TabMantenimientoCreditos.Location = New System.Drawing.Point(4, 25)
        Me.TabMantenimientoCreditos.Name = "TabMantenimientoCreditos"
        Me.TabMantenimientoCreditos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMantenimientoCreditos.Size = New System.Drawing.Size(564, 167)
        Me.TabMantenimientoCreditos.TabIndex = 0
        Me.TabMantenimientoCreditos.Text = "Agregar"
        Me.TabMantenimientoCreditos.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(338, 15)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(84, 68)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtMontoAplicable
        '
        Me.TxtMontoAplicable.Location = New System.Drawing.Point(180, 61)
        Me.TxtMontoAplicable.MaxLength = 5
        Me.TxtMontoAplicable.Name = "TxtMontoAplicable"
        Me.TxtMontoAplicable.Size = New System.Drawing.Size(116, 22)
        Me.TxtMontoAplicable.TabIndex = 3
        '
        'TxtNombreCredito
        '
        Me.TxtNombreCredito.Location = New System.Drawing.Point(180, 25)
        Me.TxtNombreCredito.Name = "TxtNombreCredito"
        Me.TxtNombreCredito.Size = New System.Drawing.Size(116, 22)
        Me.TxtNombreCredito.TabIndex = 2
        '
        'LablMonto
        '
        Me.LablMonto.AutoSize = True
        Me.LablMonto.Location = New System.Drawing.Point(23, 61)
        Me.LablMonto.Name = "LablMonto"
        Me.LablMonto.Size = New System.Drawing.Size(112, 17)
        Me.LablMonto.TabIndex = 1
        Me.LablMonto.Text = "Monto Aplicable:"
        '
        'LabelNombreCreditoFisca
        '
        Me.LabelNombreCreditoFisca.AutoSize = True
        Me.LabelNombreCreditoFisca.Location = New System.Drawing.Point(23, 25)
        Me.LabelNombreCreditoFisca.Name = "LabelNombreCreditoFisca"
        Me.LabelNombreCreditoFisca.Size = New System.Drawing.Size(151, 17)
        Me.LabelNombreCreditoFisca.TabIndex = 0
        Me.LabelNombreCreditoFisca.Text = "Nombre Credito Fiscal:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtMontoAplicarModificar)
        Me.TabPage2.Controls.Add(Me.TxtNombreActualizar)
        Me.TabPage2.Controls.Add(Me.TxtCodigoModificar)
        Me.TabPage2.Controls.Add(Me.LabMontoAplica)
        Me.TabPage2.Controls.Add(Me.LabNombre)
        Me.TabPage2.Controls.Add(Me.LabCodigo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(564, 167)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actualizar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(353, 27)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(98, 84)
        Me.BtnActualizar.TabIndex = 6
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtMontoAplicarModificar
        '
        Me.TxtMontoAplicarModificar.Location = New System.Drawing.Point(130, 119)
        Me.TxtMontoAplicarModificar.Name = "TxtMontoAplicarModificar"
        Me.TxtMontoAplicarModificar.Size = New System.Drawing.Size(100, 22)
        Me.TxtMontoAplicarModificar.TabIndex = 5
        '
        'TxtNombreActualizar
        '
        Me.TxtNombreActualizar.Location = New System.Drawing.Point(130, 71)
        Me.TxtNombreActualizar.Name = "TxtNombreActualizar"
        Me.TxtNombreActualizar.Size = New System.Drawing.Size(100, 22)
        Me.TxtNombreActualizar.TabIndex = 4
        '
        'TxtCodigoModificar
        '
        Me.TxtCodigoModificar.Location = New System.Drawing.Point(130, 24)
        Me.TxtCodigoModificar.Name = "TxtCodigoModificar"
        Me.TxtCodigoModificar.ReadOnly = True
        Me.TxtCodigoModificar.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodigoModificar.TabIndex = 3
        '
        'LabMontoAplica
        '
        Me.LabMontoAplica.AutoSize = True
        Me.LabMontoAplica.Location = New System.Drawing.Point(16, 119)
        Me.LabMontoAplica.Name = "LabMontoAplica"
        Me.LabMontoAplica.Size = New System.Drawing.Size(112, 17)
        Me.LabMontoAplica.TabIndex = 2
        Me.LabMontoAplica.Text = "Monto Aplicable:"
        '
        'LabNombre
        '
        Me.LabNombre.AutoSize = True
        Me.LabNombre.Location = New System.Drawing.Point(35, 71)
        Me.LabNombre.Name = "LabNombre"
        Me.LabNombre.Size = New System.Drawing.Size(62, 17)
        Me.LabNombre.TabIndex = 1
        Me.LabNombre.Text = "Nombre:"
        '
        'LabCodigo
        '
        Me.LabCodigo.AutoSize = True
        Me.LabCodigo.Location = New System.Drawing.Point(35, 27)
        Me.LabCodigo.Name = "LabCodigo"
        Me.LabCodigo.Size = New System.Drawing.Size(56, 17)
        Me.LabCodigo.TabIndex = 0
        Me.LabCodigo.Text = "Codigo:"
        '
        'DataGrCreditosFiscales
        '
        Me.DataGrCreditosFiscales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrCreditosFiscales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrCreditosFiscales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrCreditosFiscales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoCredito, Me.NombreCredito, Me.Monto})
        Me.DataGrCreditosFiscales.Location = New System.Drawing.Point(29, 228)
        Me.DataGrCreditosFiscales.Name = "DataGrCreditosFiscales"
        Me.DataGrCreditosFiscales.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrCreditosFiscales.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrCreditosFiscales.RowHeadersWidth = 51
        Me.DataGrCreditosFiscales.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGrCreditosFiscales.RowTemplate.Height = 24
        Me.DataGrCreditosFiscales.RowTemplate.ReadOnly = True
        Me.DataGrCreditosFiscales.Size = New System.Drawing.Size(581, 150)
        Me.DataGrCreditosFiscales.TabIndex = 4
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
        Me.NombreCredito.HeaderText = "Nombre Credito"
        Me.NombreCredito.MinimumWidth = 6
        Me.NombreCredito.Name = "NombreCredito"
        Me.NombreCredito.ReadOnly = True
        Me.NombreCredito.Width = 125
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto Aplicable"
        Me.Monto.MinimumWidth = 6
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 125
        '
        'FrmMantenimientoCreditosFiscales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 568)
        Me.Controls.Add(Me.DataGrCreditosFiscales)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimientoCreditosFiscales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Creditos Fiscales"
        Me.TabControl1.ResumeLayout(False)
        Me.TabMantenimientoCreditos.ResumeLayout(False)
        Me.TabMantenimientoCreditos.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGrCreditosFiscales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabMantenimientoCreditos As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LabelNombreCreditoFisca As Label
    Friend WithEvents LablMonto As Label
    Friend WithEvents TxtMontoAplicable As TextBox
    Friend WithEvents TxtNombreCredito As TextBox
    Friend WithEvents ToolTipCreditosFiscales As ToolTip
    Friend WithEvents DataGrCreditosFiscales As DataGridView
    Friend WithEvents CodigoCredito As DataGridViewTextBoxColumn
    Friend WithEvents NombreCredito As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LabNombre As Label
    Friend WithEvents LabCodigo As Label
    Friend WithEvents LabMontoAplica As Label
    Friend WithEvents TxtCodigoModificar As TextBox
    Friend WithEvents TxtNombreActualizar As TextBox
    Friend WithEvents TxtMontoAplicarModificar As TextBox
    Friend WithEvents BtnActualizar As Button
End Class
