<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmRegistroEmpleados.aspx.vb" Inherits="Planilla_WEB.FrmRegistroEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />

    <h1> Registros Empleados</h1>

  <div class="mb-3">
    <label for="ingresodato1" class="form-label">Cédula empleado</label>
      <asp:TextBox ID="txtcedula" CssClass="form-control" runat="server" placeholder="Ingrese su cédula" required="required" Width="400px"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtcedula" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>
   
  <div class="mb-3">
    <label for="ingresodato2" class="form-label">Nombre</label>
      <asp:TextBox ID="txtnombre" CssClass="form-control" runat="server" placeholder="Ingrese su nombre" required="required" Width="400px"></asp:TextBox>
  </div>
        <br />

    <div class="mb-3">
    <label for="ingresodato3" class="form-label">Primer apellido</label>
      <asp:TextBox ID="txtapellido1" CssClass="form-control" runat="server" placeholder="Ingrese su apellido" required="required" Width="400px"></asp:TextBox>
  </div>
        <br />

    <div class="mb-3">
    <label for="ingresodato3" class="form-label">Segundo apellido</label>
      <asp:TextBox ID="txtApellido2" CssClass="form-control" runat="server" placeholder="Ingrese su segundo apellido" required="required" Width="400px"></asp:TextBox>
  </div>
        <br />

    <div class="mb-3">
    <label for="ingresodato6" class="form-label">Fecha Nacimiento</label>
        <asp:Calendar ID="FechaNacimiento" runat="server"></asp:Calendar>
  </div>
        <br />

  <div class="mb-3">
    <label for="ingresodato4" class="form-label">Nacionalidad</label>
      <asp:TextBox ID="txtNacionalidad" CssClass="form-control" runat="server" placeholder="Ingrese su Nacionalidad" required="required" Width="400px"></asp:TextBox>
  </div>
        <br />

    <div class="mb-3">
    <label for="ingresodato6" class="form-label">Hijos menores de edad o menores de 23 (estudiantes)</label>
      <asp:TextBox ID="txtHijosMenores" CssClass="form-control" runat="server" placeholder="Ingrese la cantidad de hijos menores" required="required" Width="400px"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtHijosMenores" Text="Ingrese las cantidades en numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>
   
    <div class="mb-3">
    <label for="ingresodato6" class="form-label">Salario base por mes</label>
      <asp:TextBox ID="txtSalarioBase" CssClass="form-control" runat="server" placeholder="Ingrese su salario base mensual" required="required" Width="400px"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtSalarioBase" Text="Ingrese el salario solo en numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>
    

    <div><label for="ingresodato3" class="form-label">Tipo de empleado</label>
        <asp:DropDownList ID="cbTipoEmpleado" runat="server" class="form-control" Width="400px" >
            <asp:ListItem Value="Interino">Interino</asp:ListItem>
            <asp:ListItem Value="Propiedad">Propiedad</asp:ListItem>
        </asp:DropDownList></div>
    <br />

    <div>    
        <label for="ingresodato3" class="form-label">Sexo</label>
        <asp:DropDownList ID="cbSexo" runat="server" class="form-control" Width="400px">
            <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
            <asp:ListItem Value="Femenino">Femenino</asp:ListItem>
        </asp:DropDownList></div>
    <br />
    
    <div>
            <label for="ingresodato3" class="form-label">Estado empleado</label>
        <asp:DropDownList ID="cbEstadoEmpleado" runat="server" class="form-control" Width="400px">
            <asp:ListItem Value="Activo">Activo</asp:ListItem>
        </asp:DropDownList>

    </div>
    
    <br />
    <div>   
           <label for="ingresodato3" class="form-label">Estado civil</label>
        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" Width="400px">
            <asp:ListItem Value="Casado">Casado</asp:ListItem>
            <asp:ListItem Value="Soltero">Soltero</asp:ListItem>
        </asp:DropDownList>

    </div>
    <br />

    
    <div class="mb-3">
    
        <label for="fechaIngreso">Fecha de Ingreso:</label>
        <asp:Calendar ID="FechaIngreso" runat="server"></asp:Calendar>

  </div>
     <br />

    <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" Class="btn" />
    

</asp:Content>
