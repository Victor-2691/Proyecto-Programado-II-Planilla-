Imports System.IO
Imports BLL
Public Class FrmPrincipal
    Public RutaXmlEmpleados As String = Application.StartupPath + "\Archivos XML\Empleados.xml"
    Public RutaXmlCreditosFiscales As String = Application.StartupPath + "\Archivos XML\CreditosFiscales.xml"
    Public RutaXmlCargasSociales As String = Application.StartupPath + "\Archivos XML\CargasSociales.xml"
    Public RutaXmlImpuestosRenta As String = Application.StartupPath + "\Archivos XML\ImpuestosRenta.xml"
    Public EmpleadoN As New Empleado
    Public CreditoFiscas As New CreditosFiscal
    Public CargasSoci As New CargasSociales
    Public ImpuestoRenta As New ImpuestoRenta

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Los Archivos XML fueron creados y precargados previamente
        ''Pero se validan que los archivos existen dentro del proyecto ya que son indispensables para realizar los calculos de la planilla
        ''En caso de que alguno de los archivos hubiese sido borrado se llaman a los metodos para que los vuelva a generar
        'Try
        '    'Se valida el XML de Empleados
        '    If File.Exists(RutaXmlEmpleados) Then
        '        'Si el archivo ya existe no es necesario crearlo 
        '    Else
        '        'Si el archivo no existo lo creamos 
        '        ''EmpleadoN.GenerarXMLEmpleados(RutaXmlEmpleados)
        '    End If

        '    'Se valida el XML de CreditosFiscales
        '    If File.Exists(RutaXmlCreditosFiscales) Then
        '        'Si el archivo ya existe no es necesario crearlo 
        '    Else
        '        'Si el archivo no existe lo creamos
        '        CreditoFiscas.GenerarXMLCreditosFiscales(RutaXmlCreditosFiscales)
        '    End If

        '    'Se valida el XML de Cargas Sociales
        '    If File.Exists(RutaXmlCargasSociales) Then
        '        'Si el archivo ya existe no es necesario crearlo 
        '    Else
        '        'Si el archivo no existe lo creamos
        '        CargasSoci.GenerarXMLCargasSociales(RutaXmlCargasSociales)
        '    End If

        '    'Se valida el XML de Impuesto Renta
        '    If File.Exists(RutaXmlImpuestosRenta) Then
        '        'Si el archivo ya existe no es necesario crearlo 
        '    Else
        '        'Si el archivo no existe lo creamos
        '        ImpuestoRenta.GenerarXMLCargasSociales(RutaXmlImpuestosRenta)
        ''    End If


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim FrmAcercade As New Acercade
        FrmAcercade.MdiParent = Me
        FrmAcercade.Show()
    End Sub

    Private Sub RegistroNuevoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroNuevoEmpleadoToolStripMenuItem.Click
        Dim FrmRegistro As New FrmRegistroEmpleados
        FrmRegistro.MdiParent = Me
        FrmRegistro.Show()


    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim FrmManteEmpleados As New FrmMantenimientoEmpleados
        FrmManteEmpleados.MdiParent = Me
        FrmManteEmpleados.Show()

    End Sub

    Private Sub CreditosFiscalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreditosFiscalesToolStripMenuItem1.Click
        Dim FrmCreditosF As New FrmMantenimientoCreditosFiscales
        FrmCreditosF.MdiParent = Me
        FrmCreditosF.Show()
    End Sub

    Private Sub CreditosFiscalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditosFiscalesToolStripMenuItem.Click
        Dim FrmImpuestoRenta As New FrmMantenimientoImpuestoRenta
        FrmImpuestoRenta.MdiParent = Me
        FrmImpuestoRenta.Show()
    End Sub

    Private Sub CargasSocialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargasSocialesToolStripMenuItem.Click
        'Dim frmCargasS As New FrmMantenimientoCargasSocial
        'frmCargasS.MdiParent = Me
        'frmCargasS.Show()
    End Sub

    Private Sub PagoDePlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoDePlanillaToolStripMenuItem.Click
        Dim frmPagoPlanilla As New FrmPagoPlanilla
        frmPagoPlanilla.MdiParent = Me
        frmPagoPlanilla.Show()
    End Sub
End Class
