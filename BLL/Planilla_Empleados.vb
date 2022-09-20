Imports DAL
Public Class Planilla_Empleados
    Public NuevoDaoImpuestoRenta As New DAO_ImpuestoRenta
    Public NuevoDaoCreditosFiscales As New DAO_Creditos_Fiscales
    Public NuevoEmpleado As New DAO_Empleados
    Public NuevoDaoCargasSociales As New DAO_Cargas_Sociales
    Public NuevoDaoPlanilla As New DAO_Planilla_Empleados
    Public DataTable_Empleados As New DataTable




#Region "CalculaSalarioBruto"
    Public Function CalculoSalarioBruto(ByVal ID_Empleado As Integer, ByVal HorasLaboradasSencillas As Double, ByVal HorasDobles As Double, ByVal horasExtras As Double) As Double
        Try
            'Obtenemos el salario base del empleado a calcular mediante el numero de ID
            Dim SalarioBase As Double
            DataTable_Empleados = NuevoEmpleado.ListarEmpleados
            'Buscamos en el data la informacion que necesitamos del empleado
            For Each FilasData As DataRow In DataTable_Empleados.Rows
                If FilasData("Cedula") = ID_Empleado Then
                    SalarioBase = FilasData("Salario Base")

                End If
            Next
            Dim SalarioBruto As Double
            Dim SalarioHora As Double
            SalarioHora = SalarioBase / 240
            SalarioBruto = (SalarioHora * HorasLaboradasSencillas) + ((SalarioHora * 1.5) * horasExtras) + ((SalarioHora * 2) * HorasDobles)
            Return SalarioBruto

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "CalculaImpuestoSubTotalRentaSalario"
    Public Function CalculaImpuestoRentaSubtotal(ByVal SalarioBruto As Double) As Double
        Dim TotalImpuestoRenta As Double
        Dim Impuesto10 As Double
        Dim Impuesto15 As Double
        Dim impuesto20 As Double
        Dim Bandera10 As Boolean
        Dim Bandera15 As Boolean
        Dim Bandera20 As Boolean
        Dim LimiteInferior10 As Double
        Dim LimiteSuperior10 As Double
        Dim LimiteInferior15 As Double
        Dim LimiteSuperior15 As Double
        Dim LimiteInferior20 As Double
        Dim unused As New DataTable
        'Leemos la informacion de la tabla y la guardamos en un DataSet
        Dim DatatableImpuestos As DataTable = NuevoDaoImpuestoRenta.ListarImpuestoRenta
        Try
            'Obtenemos los limites de la base de datos mediante los codigos de la tabla Impuestos Renta

            For Each FilasData As DataRow In DatatableImpuestos.Rows
                If FilasData("Codigo") = 1 Then
                    LimiteInferior10 = FilasData("Salario desde")
                    LimiteSuperior10 = FilasData("Salario hasta")

                End If

                If FilasData("Codigo") = 3 Then
                    LimiteInferior15 = FilasData("Salario desde")
                    LimiteSuperior15 = FilasData("Salario hasta")
                End If

                If FilasData("Codigo") = 4 Then
                    LimiteInferior20 = FilasData("Salario desde")
                End If
            Next
            'Una vez tenemos los limites inferiores y superiores debemos buscar cual es el limite maximo segun el salario del empleado
            If (SalarioBruto > LimiteInferior10) Then
                Bandera10 = True
            End If

            If (SalarioBruto > LimiteInferior15) Then
                Bandera15 = True
            End If

            If (SalarioBruto > LimiteInferior20) Then
                Bandera20 = True
            End If
            'Debemos calcular segun los posibles escenarios del salario bruto del empleado
            'Calculo del impuesto donde el salario bruto aplica en las 3 categorias
            If (Bandera10 = True) And (Bandera15 = True) And (Bandera20 = True) Then
                Impuesto10 = (LimiteSuperior10 - LimiteInferior10) * 10 / 100
                Impuesto15 = (LimiteSuperior15 - LimiteInferior15) * 15 / 100
                impuesto20 = (SalarioBruto - LimiteInferior20) * 20 / 100
                TotalImpuestoRenta = Impuesto10 + Impuesto15 + impuesto20
            End If
            'Calculo del impuesto opcion salario ingresa categoria 10% y 15%
            If (Bandera10 = True) And (Bandera15 = True) Then
                Impuesto10 = (LimiteSuperior10 - LimiteInferior10) * 10 / 100
                Impuesto15 = (SalarioBruto - LimiteInferior15) * 15 / 100
                TotalImpuestoRenta = Impuesto10 + Impuesto15
            End If
            'Calculo salario solo ingresa categoria 10%
            If (Bandera10 = True) And (Bandera15 = False) Then
                TotalImpuestoRenta = (SalarioBruto - LimiteInferior10) * 10 / 100
            End If
            Return TotalImpuestoRenta

        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region

#Region "CalculoCreditosFiscales"

    Public Function CalculaCreditosFiscales(ByVal ID_Empleado As Integer) As Double

        Try
            Dim TotalCreditosFiscales As Double
            Dim SubtotalHijos As Double
            Dim SubTotalMatrimoni As Integer
            Dim MontoCoyugue As Double
            Dim MontoHijos As Double
            Dim CantidadHijos As Integer
            Dim EstadoCivil As String
            'Obtenemos los datos de la tabla empleados necesarios para el calculo del credito fiscal
            'Buscamos en el data la informacion que necesitamos del empleado
            For Each FilasData As DataRow In DataTable_Empleados.Rows
                If FilasData("Cedula") = ID_Empleado Then
                    CantidadHijos = FilasData("Cantidad Hijos")
                    EstadoCivil = FilasData("Estado Civil")

                End If
            Next
            'Leemos la informacion de la tabla creditos fiscales
            'Mediante el codigo del credito ubicamos lo que debemos calcular
            Dim DatatableCreditos As DataTable = NuevoDaoCreditosFiscales.ListarCreditosFiscales

            For Each FilasData As DataRow In DatatableCreditos.Rows
                If FilasData("Codigo") = 1 Then
                    MontoCoyugue = FilasData("Monto Aplicable")
                End If

                If FilasData("Codigo") = 2 Then
                    MontoHijos = FilasData("Monto Aplicable")
                End If
            Next

            If CantidadHijos > 0 Then
                SubtotalHijos = CantidadHijos * MontoHijos
            End If

            If EstadoCivil = "Casado" Then
                SubTotalMatrimoni = MontoCoyugue
            End If

            TotalCreditosFiscales = SubtotalHijos + SubTotalMatrimoni
            Return TotalCreditosFiscales

        Catch ex As Exception
            Throw ex
        End Try


    End Function

#End Region

#Region "CalculoTotalImpuestoRenta"
    Public Function TotaImpuestoRentaMenosCreditosFiscales(ByVal ImpuestoRenta_Subtotal As Double, ByVal CreditosFiscales As Double) As Double
        'Con esta funcion calculamos el total del impuesto de renta para poder restarle los creditos fiscales

        Try
            Dim ImpuestoRentaTotal As Double
            ImpuestoRentaTotal = ImpuestoRenta_Subtotal - CreditosFiscales
            'Debemos validar si el monto es negativo, quiere decir que el empleado aplica para creditos fiscales pero su salario no aplica para impuesto de renta
            'Por lo cual si el monto es negativo debemos retornar un 0
            If ImpuestoRentaTotal < 0 Then
                ImpuestoRentaTotal = 0
            End If
            Return ImpuestoRentaTotal
        Catch ex As Exception
            Throw ex
        End Try


    End Function

#End Region

#Region "CalculoCargasSocialesTrabajador"
    Public Function CalculaCargasSocialesTrabajador(ByVal SalarioBruto As Double)
        Try
            Dim SEM As Double
            Dim IVM As Double
            Dim BP As Double
            Dim MontoCargasSociales

            'Leemos la informacion de la tabla creditos fiscales
            'Mediante el codigo del credito ubicamos lo que debemos calcular
            Dim DatatableCargasSociales As DataTable = NuevoDaoCargasSociales.ListarCargas_Sociales

            For Each FilasData As DataRow In DatatableCargasSociales.Rows
                'Codigo 1 pertenece al SEM del trabajador
                If FilasData("Codigo") = 1 Then
                    SEM = FilasData("% Aplicable")
                End If
                'Codigo 2 pertenece al IVM del trabajador
                If FilasData("Codigo") = 2 Then
                    IVM = FilasData("% Aplicable")
                End If
                'Codigo 3 pertenece al Banco Popular del trabajador
                If FilasData("Codigo") = 3 Then
                    BP = FilasData("% Aplicable")
                End If
            Next
            'Sacamos los porcetanjes correspondientes al salario bruto y retornamos el monto total a deducir
            MontoCargasSociales = (SalarioBruto * SEM / 100) + (SalarioBruto * IVM / 100) + (SalarioBruto * BP / 100)
            Return MontoCargasSociales

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "CalculoSalarioNeto"
    Public Function CalculoSalarioNeto(ByVal SalarioBruto As Double, ByVal CargasSociales As Double, ByVal ImpuestoRenta As Double)
        Try
            Dim SalarioNeto As Double
            SalarioNeto = SalarioBruto - CargasSociales - ImpuestoRenta
            Return SalarioNeto

        Catch ex As Exception
            Throw
        End Try

    End Function

#End Region


#Region "InsertarPlanillaBD"
    Public Function IngresarPlanillaBD(ByVal ListaEmpleados As List(Of Empleado)) As Boolean
        'Con esta funcion llamamos a las funciones necesarias para realizar el calculo de la planilla y insertamos ese calculo en la base de datos
        Dim CantidadEmpleados As Integer = ListaEmpleados.Count
        Dim EstadoInsertar As Boolean
        Dim ContadorFilasAfectadas As Integer
        Try
            For Each Lista In ListaEmpleados
                Dim SalarioBruto As Double = CalculoSalarioBruto(Lista.Pindentificacion, Lista.PhorasLaboradasSencillas, Lista.PhorasDobles, Lista.PhorasExtras)
                Dim SubtotalImpuestoRenta As Double = CalculaImpuestoRentaSubtotal(SalarioBruto)
                Dim CreditosFiscales As Double = CalculaCreditosFiscales(Lista.Pindentificacion)
                Dim TotalImpuestoRenta As Double = TotaImpuestoRentaMenosCreditosFiscales(SubtotalImpuestoRenta, CreditosFiscales)
                Dim Cargas_Sociales As Double = CalculaCargasSocialesTrabajador(SalarioBruto)
                Dim SalarioNeto As Double = CalculoSalarioNeto(SalarioBruto, Cargas_Sociales, TotalImpuestoRenta)
                EstadoInsertar = NuevoDaoPlanilla.InsertarPlanilla(Lista.Pindentificacion, Lista.PhorasLaboradasSencillas, Lista.PhorasExtras, Lista.PhorasDobles, SalarioBruto, Cargas_Sociales, TotalImpuestoRenta, SalarioNeto, Lista.PfechaGeneracionPlanilla)
                'Validamos las filas afectadas de acuerdo al numero de empleados de la lista para calcular la planilla
                If EstadoInsertar = True Then
                    ContadorFilasAfectadas += 1
                End If
            Next
            'Las filas afectadas deben ser la misma cantidad de empleados agregados a la planilla
            If ContadorFilasAfectadas = CantidadEmpleados Then
                EstadoInsertar = True
            Else
                EstadoInsertar = False
            End If
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region


#Region "InsertarPlanillaBD"
    Public Function IngresarPlanillaBD(ByVal ID_Empleado As Integer, ByVal HorasLaboradas As Double, ByVal HorasExtras As Double, ByVal HorasDobles As Double, ByVal FechaGeneracionPlanilla As Date) As Boolean
        'Con esta funcion llamamos a las funciones necesarias para realizar el calculo de la planilla y insertamos ese calculo en la base de datos
        Dim EstadoInsertar As Boolean
        Try
            Dim SalarioBruto As Double = CalculoSalarioBruto(ID_Empleado, HorasLaboradas, HorasDobles, HorasExtras)
            Dim SubtotalImpuestoRenta As Double = CalculaImpuestoRentaSubtotal(SalarioBruto)
            Dim CreditosFiscales As Double = CalculaCreditosFiscales(ID_Empleado)
            Dim TotalImpuestoRenta As Double = TotaImpuestoRentaMenosCreditosFiscales(SubtotalImpuestoRenta, CreditosFiscales)
            Dim Cargas_Sociales As Double = CalculaCargasSocialesTrabajador(SalarioBruto)
            Dim SalarioNeto As Double = CalculoSalarioNeto(SalarioBruto, Cargas_Sociales, TotalImpuestoRenta)
            EstadoInsertar = NuevoDaoPlanilla.InsertarPlanilla(ID_Empleado, HorasLaboradas, HorasExtras, HorasDobles, SalarioBruto, Cargas_Sociales, TotalImpuestoRenta, SalarioNeto, FechaGeneracionPlanilla)
            'Validamos las filas afectadas de acuerdo al numero de empleados de la lista para calcular la planilla
            Return EstadoInsertar
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region



#Region "LeerPlanilla"
    Public Function ListarPlanilla() As DataTable
        Try
            Return NuevoDaoPlanilla.ListarPlanilla
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region





End Class
