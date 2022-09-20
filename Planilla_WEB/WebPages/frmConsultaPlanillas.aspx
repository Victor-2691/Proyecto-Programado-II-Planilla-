<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmConsultaPlanillas.aspx.vb" Inherits="Planilla_WEB.frmConsultaPlanillas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

            <link href="/CSS/Estilos.css" rel="Stylesheet" type="text/css" />
     <h1> Consulta de Planillas</h1>
    <asp:Label ID="Label1" runat="server" Text="Seleccione Mes"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Seleccione Año"></asp:Label>

    <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" />
    <asp:GridView ID="GridPlanillas" runat="server" Height="272px" Width="882px">
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:GridView>
</asp:Content>
