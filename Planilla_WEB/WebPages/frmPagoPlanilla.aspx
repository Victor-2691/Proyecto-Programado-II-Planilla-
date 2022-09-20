<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmPagoPlanilla.aspx.vb" Inherits="Planilla_WEB.frmPagoPlanilla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />
    <h1> Calculo planilla</h1>
    <div class="mb-3">
         <asp:Label ID="LabeDate" runat="server" Text="Fecha:"></asp:Label> <asp:Label ID="LabelFecha" runat="server"></asp:Label>
         <br />

           <div class="mb-3">
    <label for="ingresodato3" class="form-label">Numero Cedula</label>
      <asp:TextBox ID="TxtCedula" CssClass="form-control" runat="server" placeholder="" required="required" Width="400px" ReadOnly="True"></asp:TextBox>
  </div>
           <div class="mb-3">
    <label for="ingresodato3" class="form-label">Nombre Empleado</label>
      <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="" required="required" Width="400px" ReadOnly="True"></asp:TextBox>
  </div>

     <div class="mb-3">
    <label for="ingresodato3" class="form-label">Primer apellido</label>
      <asp:TextBox ID="TxtPrimerApellido" CssClass="form-control" runat="server" placeholder="" required="required" Width="400px" ReadOnly="True"></asp:TextBox>
  </div>
    

  <div class="mb-3">
    <label for="ingresodato1" class="form-label">Horas Trabajadas</label>
      <asp:TextBox ID="txtHorasTrabajadas" CssClass="form-control" runat="server" placeholder="Ingrese horas trabajadas" required="required" Width="400px"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtHorasTrabajadas" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

     <div class="mb-3">
    <label for="ingresodato6" class="form-label">Horas Extras</label>
      <asp:TextBox ID="txtHorasExtras" CssClass="form-control" runat="server" placeholder="Ingrese horas extras" required="required" Width="400px"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtHorasExtras" Text="Ingrese las cantidades en numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

    <div class="mb-3">
    <label for="ingresodato6" class="form-label">Horas Dobles</label>
      <asp:TextBox ID="txtHorasDobles" CssClass="form-control" runat="server" placeholder="Ingrese horas dobles" required="required" Width="400px"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtHorasDobles" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        <asp:GridView ID="GrievEmpleadosPagoPlanillas" runat="server" Width="428px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:CommandField HeaderText="Selección" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Top" BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
  </div>
         <br />
         <asp:Button ID="BtnGenerarPlanilla" runat="server" Text="Generar Planilla" />


    </div>

    


</asp:Content>
