Imports DAL

Public Class Empleado

#Region "Atributos"
    'Atributos de la planilla
    Private NumeroIdentificacion As Integer
    Private Nombre As String
    Private PrimerApellido As String
    Private SegundoApellido As String
    Private Nacionalidad As String
    Private CantidadHijos As Integer
    Private Sexo As String
    Private EstadoCivil As String
    Private TipoEmpleado As String
    Private EstadoEmpleado As String
    Private FechaIngreso As Date
    Private FechaNacimiento As Date
    Private SalarioBase As Double
    Private CargasSocialesEmpleado As Double
    Private CargasSocialesPatrono As Double
    Private ImpuestoRenta As Double
    Private SalarioNeto As Double
    Private HorasLaboradasSencillas As Double
    Private HorasExtras As Double
    Private HorasDobles As Double
    Private SalarioBruto As Double
    Private FechaGeneracionPlanilla As Date
    Public NuevoDAOEmpleado As New DAO_Empleados

#End Region

#Region "Propiedades"

    'Propiedaddes de la planilla, para manejo a nivel de capas

    Public Property Pindentificacion() As Integer
        Get
            Return NumeroIdentificacion
        End Get
        Set(ByVal value As Integer)
            NumeroIdentificacion = value
        End Set
    End Property



    Public Property Pnombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property


    Public Property PprimerApellido() As String
        Get
            Return PrimerApellido
        End Get
        Set(ByVal value As String)
            PrimerApellido = value
        End Set
    End Property


    Public Property PsegundoApellido() As String
        Get
            Return SegundoApellido
        End Get
        Set(ByVal value As String)
            SegundoApellido = value
        End Set
    End Property

    Public Property Pnacionalidad() As String
        Get
            Return Nacionalidad
        End Get
        Set(ByVal value As String)
            Nacionalidad = value
        End Set
    End Property

    Public Property PcantidadHijos() As Integer
        Get
            Return CantidadHijos
        End Get
        Set(ByVal value As Integer)
            CantidadHijos = value
        End Set
    End Property

    Public Property Psexo() As String
        Get
            Return Sexo
        End Get
        Set(ByVal value As String)
            Sexo = value
        End Set
    End Property


    Public Property PestadoCivil() As String
        Get
            Return EstadoCivil
        End Get
        Set(ByVal value As String)
            EstadoCivil = value
        End Set
    End Property


    Public Property PsalarioBase() As Double
        Get
            Return SalarioBase
        End Get
        Set(ByVal value As Double)
            SalarioBase = value
        End Set
    End Property

    Public Property PtipoEmpleado() As String
        Get
            Return TipoEmpleado
        End Get
        Set(ByVal value As String)
            TipoEmpleado = value
        End Set
    End Property


    Public Property PestadoEmpleado() As String
        Get
            Return EstadoEmpleado
        End Get
        Set(ByVal value As String)
            EstadoEmpleado = value
        End Set
    End Property

    Public Property PfechaIngreso() As Date
        Get
            Return FechaIngreso
        End Get
        Set(ByVal value As Date)
            FechaIngreso = value
        End Set
    End Property


    Public Property PfechaNacimiento() As Date
        Get
            Return FechaNacimiento
        End Get
        Set(ByVal value As Date)
            FechaNacimiento = value
        End Set
    End Property

    Public Property PcargasSociales() As Double
        Get
            Return CargasSocialesEmpleado
        End Get
        Set(ByVal value As Double)
            CargasSocialesEmpleado = value
        End Set
    End Property


    Public Property PcargasSocialesPatrono() As Double
        Get
            Return CargasSocialesPatrono
        End Get
        Set(ByVal value As Double)
            CargasSocialesPatrono = value
        End Set
    End Property


    Public Property PImpuestosRenta() As Double
        Get
            Return ImpuestoRenta
        End Get
        Set(ByVal value As Double)
            ImpuestoRenta = value
        End Set
    End Property

    Private CreditosFiscales As Double
    Public Property PcreditosFiscales() As Double
        Get
            Return CreditosFiscales
        End Get
        Set(ByVal value As Double)
            CreditosFiscales = value
        End Set
    End Property


    Public Property PsalarioNeto() As Double
        Get
            Return SalarioNeto
        End Get
        Set(ByVal value As Double)
            SalarioNeto = value
        End Set
    End Property


    Public Property PhorasLaboradasSencillas() As Double
        Get
            Return HorasLaboradasSencillas
        End Get
        Set(ByVal value As Double)
            HorasLaboradasSencillas = value
        End Set
    End Property


    Public Property PhorasExtras() As Double
        Get
            Return HorasExtras
        End Get
        Set(ByVal value As Double)
            HorasExtras = value
        End Set
    End Property

    Public Property PhorasDobles() As Double
        Get
            Return HorasDobles
        End Get
        Set(ByVal value As Double)
            HorasDobles = value
        End Set
    End Property


    Public Property PsalarioBruto() As Double
        Get
            Return SalarioBruto
        End Get
        Set(ByVal value As Double)
            SalarioBruto = value
        End Set
    End Property


    Public Property PfechaGeneracionPlanilla() As Date
        Get
            Return FechaGeneracionPlanilla
        End Get
        Set(ByVal value As Date)
            FechaGeneracionPlanilla = value
        End Set
    End Property

#End Region

#Region "IngresodeEmpleados"

    'Se llama al metodo para ingresar empleado
    'Y se valida que los cabios se hayan hecho
    Public Function IngresarEmpleadoBD(ByVal ID_Empleado As Integer, ByVal NombreEmpleado As String, ByVal PrimerApellido As String, ByVal SegundoApellido As String, ByVal Nacionalidad As String, ByVal Sexo As String, ByVal EstadoCivil As String, ByVal FechaIngreso As Date, ByVal FechaNacimiento As Date, ByVal EstadoEmpleado As String, ByVal TipoEmpleado As String, ByVal SalarioBase As Double, ByVal CantidadHijos As Integer) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDAOEmpleado.InsertarEmpleado(ID_Empleado, NombreEmpleado, PrimerApellido, SegundoApellido, Nacionalidad, Sexo, EstadoCivil, FechaIngreso, FechaNacimiento, EstadoEmpleado, TipoEmpleado, SalarioBase, CantidadHijos)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "LeerEmpleados"

    'se llama a la funcion que lee todos los empleados, y se retorna en un dataTable
    Public Function ListaEmpleadosCompleta() As DataTable
        Try
            Return NuevoDAOEmpleado.ListarEmpleados()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "ActualizarEmpleado"
    'Se llama al metodo de actualizacion en capa DAL y se validan que los cambios se hayan hecho
    Public Function ActualizarEmpleado(ByVal ID_Empleado As Integer, ByVal EstadoCivil As String, ByVal EstadoEmpleado As String, ByVal SalarioBase As Double, ByVal CantidadHijos As Integer) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDAOEmpleado.ActualizarEmpleado(ID_Empleado, EstadoCivil, EstadoEmpleado, SalarioBase, CantidadHijos)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "EliminarEmpleado"
    'Se llama al metodo de eliminar empleado, y se valida que el cambio se efectue
    Public Function EliminarEmpleado(ByVal ID_Empleado) As Boolean
        Dim EstadoInsertar As Boolean
        Try
            EstadoInsertar = NuevoDAOEmpleado.Eliminar_Empleado(ID_Empleado)
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region


#Region "LeerEmpleadosActivos-Incapacitados"
    Public Function ListaEmpleados_Incapacitados_Activos() As DataTable
        Try
            Return NuevoDAOEmpleado.ListarEmpleados_Activos_Incapacitados
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
