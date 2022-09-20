<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMantemientoUsuarios.aspx.vb" Inherits="Planilla_WEB.frmMantemientoUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />
    <h1> Mantenimiento Usuarios</h1>


    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Usuario</label>
      <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server" placeholder="Ingrese Usuario" required="required" Width="400px"></asp:TextBox >
  </div>

    <div class="mb-3">
    <label for="ingresodato1" class="form-label">Nombre</label>
      <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="Ingrese Nombre" required="required" Width="400px"></asp:TextBox >
  </div>

        <div class="mb-3">
    <label for="ingresodato1" class="form-label">CorreoElectronico</label>
      <asp:TextBox ID="TxtCorreoElectronico" CssClass="form-control" runat="server" placeholder="Ingrese correo" required="required" Width="400px"></asp:TextBox >
      
  </div>

      <label for="ingresodato3" class="form-label">Perfil de Usuario</label>
        <asp:DropDownList ID="cbEstadoUsuario" runat="server" class="form-control" Width="400px">
            <asp:ListItem Value="Admin">Admin</asp:ListItem>
            <asp:ListItem Value="RH">RG</asp:ListItem>
        </asp:DropDownList>

        <div class="mb-3">
    <label for="ingresodato1" class="form-label">Contraseña</label>
      <asp:TextBox ID="txtContraseña" CssClass="form-control" runat="server" placeholder="Ingrese la Contraseña" required="required" Width="400px"></asp:TextBox >
  </div>


    <asp:GridView ID="GriewUsuarios" runat="server" Width="775px" Height="169px">
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
