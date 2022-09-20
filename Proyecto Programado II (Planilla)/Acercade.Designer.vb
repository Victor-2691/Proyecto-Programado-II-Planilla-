<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acercade
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
        Me.LabInform = New System.Windows.Forms.Label()
        Me.LabEstudiante = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabInform
        '
        Me.LabInform.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInform.ForeColor = System.Drawing.Color.DarkRed
        Me.LabInform.Location = New System.Drawing.Point(81, 9)
        Me.LabInform.Name = "LabInform"
        Me.LabInform.Size = New System.Drawing.Size(268, 143)
        Me.LabInform.TabIndex = 0
        Me.LabInform.Text = "Curso: TI-131" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nombre Curso: Programación II" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Profesor: Róger Rodriguez López" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Co" &
    "legio Universitario de Cartago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "II Cuatrimestre 2021"
        Me.LabInform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabEstudiante
        '
        Me.LabEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.LabEstudiante.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEstudiante.Location = New System.Drawing.Point(43, 410)
        Me.LabEstudiante.Name = "LabEstudiante"
        Me.LabEstudiante.Size = New System.Drawing.Size(382, 33)
        Me.LabEstudiante.TabIndex = 1
        Me.LabEstudiante.Text = "Estudiante: Victor Salgado Martinez"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Programado_II__Planilla_.My.Resources.Resources.logo_cuc_color
        Me.PictureBox1.Location = New System.Drawing.Point(81, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Acercade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 474)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabEstudiante)
        Me.Controls.Add(Me.LabInform)
        Me.MaximizeBox = False
        Me.Name = "Acercade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acercade"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabInform As Label
    Friend WithEvents LabEstudiante As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
