<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistroNuevoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditosFiscalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargasSocialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditosFiscalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagoDePlanillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroNuevoEmpleadoToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.PagoDePlanillaToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistroNuevoEmpleadoToolStripMenuItem
        '
        Me.RegistroNuevoEmpleadoToolStripMenuItem.Name = "RegistroNuevoEmpleadoToolStripMenuItem"
        Me.RegistroNuevoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.RegistroNuevoEmpleadoToolStripMenuItem.Text = "Registro Nuevo Empleado"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.CreditosFiscalesToolStripMenuItem, Me.CargasSocialesToolStripMenuItem, Me.CreditosFiscalesToolStripMenuItem1})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(124, 24)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'CreditosFiscalesToolStripMenuItem
        '
        Me.CreditosFiscalesToolStripMenuItem.Name = "CreditosFiscalesToolStripMenuItem"
        Me.CreditosFiscalesToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.CreditosFiscalesToolStripMenuItem.Text = "Impuesto Renta"
        '
        'CargasSocialesToolStripMenuItem
        '
        Me.CargasSocialesToolStripMenuItem.Name = "CargasSocialesToolStripMenuItem"
        Me.CargasSocialesToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.CargasSocialesToolStripMenuItem.Text = "Cargas Sociales"
        '
        'CreditosFiscalesToolStripMenuItem1
        '
        Me.CreditosFiscalesToolStripMenuItem1.Name = "CreditosFiscalesToolStripMenuItem1"
        Me.CreditosFiscalesToolStripMenuItem1.Size = New System.Drawing.Size(201, 26)
        Me.CreditosFiscalesToolStripMenuItem1.Text = "Creditos Fiscales"
        '
        'PagoDePlanillaToolStripMenuItem
        '
        Me.PagoDePlanillaToolStripMenuItem.Name = "PagoDePlanillaToolStripMenuItem"
        Me.PagoDePlanillaToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.PagoDePlanillaToolStripMenuItem.Text = "Pago de Planilla"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Programado_II__Planilla_.My.Resources.Resources.Captura
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistroNuevoEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoDePlanillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditosFiscalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargasSocialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditosFiscalesToolStripMenuItem1 As ToolStripMenuItem
End Class
