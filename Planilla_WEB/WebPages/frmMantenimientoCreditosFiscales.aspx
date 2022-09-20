<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMantenimientoCreditosFiscales.aspx.vb" Inherits="Planilla_WEB.frmCreditosSociales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />
    <h1> Mantenimiento creditos fiscales</h1>

    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Codigo</label>
      <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server" placeholder="Ingrese el codigo" required="required" Width="400px"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtCodigo" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Tipo de credito</label>
      <asp:TextBox ID="txtTipoCredito" CssClass="form-control" runat="server" placeholder="Ingrese tipo de credito" required="required" Width="400px"></asp:TextBox >
  </div>

    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Monto Aplicable</label>
      <asp:TextBox ID="txtMontoAplicable" CssClass="form-control" runat="server" placeholder="Ingrese el monto aplicable" required="required" Width="400px"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtMontoAplicable" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

    <br>
        <asp:GridView ID="GriewCreditosFiscales" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="293px">
            <Columns>
                <asp:CommandField HeaderText="Selección" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" Font-Overline="False" ForeColor="#FFFFCC" HorizontalAlign="Center" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" BorderStyle="Dotted" ForeColor="#330099" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <br />
    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" />

 

    


</asp:Content>
