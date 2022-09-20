<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMantenimientoEmpleados.aspx.vb" Inherits="Planilla_WEB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />
     <h1> Mantenimiento Empleados</h1>
    
    
    <div class="mb-3">
    <label for="ingresodato2" class="form-label">Nombre</label>
      <asp:TextBox ID="txtnombre" CssClass="form-control" runat="server" placeholder="Ingrese su nombre" required="required" Width="400px " ReadOnly="True"></asp:TextBox>   
    </div>

           <div class="mb-3">
    <label for="ingresodato3" class="form-label">Primer apellido</label>
      <asp:TextBox ID="txtapellido1" CssClass="form-control" runat="server" placeholder="Ingrese su apellido" required="required" Width="400px" ReadOnly="True"></asp:TextBox>
  </div>

     
  <div class="mb-3">
    <label for="ingresodato1" class="form-label">Cédula empleado</label>
      <asp:TextBox ID="txtcedula" CssClass="form-control" runat="server" placeholder="Ingrese su cédula" required="required" Width="400px" ReadOnly="True"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtcedula" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

     <div class="mb-3">
    <label for="ingresodato6" class="form-label">Cantidad hijos menores</label>
      <asp:TextBox ID="txtHijosMenores" CssClass="form-control" runat="server" placeholder="Ingrese la cantidad de hijos menores" required="required" Width="400px"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtHijosMenores" Text="Ingrese las cantidades en numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

    <div class="mb-3">
    <label for="ingresodato6" class="form-label">Salario base por mes</label>
      <asp:TextBox ID="txtSalarioBase" CssClass="form-control" runat="server" placeholder="Ingrese su salario base mensual" required="required" Width="400px"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtSalarioBase" Text="Ingrese el salario solo en numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>


    <label for="ingresodato3" class="form-label">Estado empleado</label>
        <asp:DropDownList ID="cbEstadoEmpleado" runat="server" class="form-control" Width="400px">
            <asp:ListItem Value="Activo">Activo</asp:ListItem>
            <asp:ListItem Value="Inactivo">Inactivo</asp:ListItem>
            <asp:ListItem Value="Incapacitado">Incapacitado</asp:ListItem>
        </asp:DropDownList>
 
    <br >
    <label for="ingresodato3" class="form-label">Estado civil</label>
        <asp:DropDownList ID="CbEstadoCivil" runat="server" class="form-control" Width="400px">
            <asp:ListItem Value="Casado">Casado</asp:ListItem>
            <asp:ListItem Value="Soltero">Soltero</asp:ListItem>
        </asp:DropDownList>
    <br />
 
    <div>
        <asp:GridView ID="GriedviewEmpleados" runat="server"  BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="563px" DataKeyNames="Cedula">
            <Columns>
                <asp:CommandField HeaderText="Selección" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" Font-Size="Smaller" HorizontalAlign="Center" VerticalAlign="Middle" Width="10px" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>
    
    <br />
    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" Width="78px" />
    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" />

</asp:Content>
