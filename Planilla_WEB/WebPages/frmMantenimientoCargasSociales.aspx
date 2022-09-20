<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMantenimientoCargasSociales.aspx.vb" Inherits="Planilla_WEB.FrmCargasSociales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />
     <h1> Mantenimiento Cargas Sociales</h1>

    
    <h3>Actualizar</h3>

      <div class="mb-3">
    <label for="ingresodato1" class="form-label">Codigo</label>
      <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server"  required="required" Width="121px" ReadOnly="True"></asp:TextBox >
  </div>

 <br ><label for="ingresodato3" class="form-label">Tipo Carga Social</label>
<asp:DropDownList ID="cbTipoCargaSocial" runat="server" class="form-control" Width="148px" Height="40px" >
<asp:ListItem Value="Trabajador">Trabajador</asp:ListItem>
<asp:ListItem Value="Patrono">Patrono</asp:ListItem>
</asp:DropDownList>
<br >

      <div class="mb-3">
    <label for="ingresodato2" class="form-label">NombreCargaSocial</label>
      <asp:TextBox ID="txtnombreCargaSocial" CssClass="form-control" runat="server" placeholder="" required="required" Width="129px" Height="25px"></asp:TextBox>
  </div>
        <br />

   
      <div class="mb-3">
    <label for="ingresodato1" class="form-label">Monto % Carga Social</label>
      <asp:TextBox ID="TxtMontoCarga" CssClass="form-control" runat="server"  required="required" Width="152px" ReadOnly="False"></asp:TextBox >
      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TxtMontoCarga" Text="Ingrese solo numeros" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
  </div>

    <asp:GridView ID="GrvCargasSociales" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="324px">
        <Columns>
            <asp:CommandField AccessibleHeaderText="Selección" HeaderText="Selección" ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" HorizontalAlign="Center" VerticalAlign="Middle" />
        <SelectedRowStyle BackColor="#0099CC" BorderStyle="Double" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
     </asp:GridView>


    <asp:Button ID="BntActualizar" runat="server" Text="Actualizar" />


</asp:Content>
