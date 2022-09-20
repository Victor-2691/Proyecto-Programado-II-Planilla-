<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMantenimientoImpuestoRenta.aspx.vb" Inherits="Planilla_WEB.frmImpuestoRenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />
    <h1> Mantenimiento Impuesto de Renta</h1>


    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Codigo</label>
      <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server" placeholder="Ingrese el codigo" required="required" Width="400px" ReadOnly="True"></asp:TextBox >
  </div>

    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Salario Desde</label>
      <asp:TextBox ID="txtLimiteInferior" CssClass="form-control" runat="server" placeholder="Ingrese el limite inferior" required="required" Width="400px"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtLimiteInferior" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Salario Hasta</label>
      <asp:TextBox ID="txtLimiteSuperior" CssClass="form-control" runat="server" placeholder="Ingrese el limite superior" required="required" Width="400px"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtLimiteSuperior" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

        <div class="mb-3">
    <label for="ingresodato1" class="form-label">Porcentaje Aplicable</label>
      <asp:TextBox ID="TxtPorcentajeAplicable" CssClass="form-control" runat="server" placeholder="Ingrese el monto aplicable" required="required" Width="400px"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TxtPorcentajeAplicable" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>



    <asp:GridView ID="GriewImpuestoRenta" runat="server" Width="414px">
        <Columns>
            <asp:CommandField HeaderText="Selección" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
    </asp:GridView>
    <br />
    <asp:Button ID="BtnAgregar" runat="server" Text="Aregar" />
    <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" />
    <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" />

</asp:Content>
