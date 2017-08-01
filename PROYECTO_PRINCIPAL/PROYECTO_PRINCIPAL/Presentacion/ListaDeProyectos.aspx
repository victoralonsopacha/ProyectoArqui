<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Principal.Master" AutoEventWireup="true" CodeBehind="ListaDeProyectos.aspx.cs" Inherits="PROYECTO_PRINCIPAL.Presentacion.ListaDeProyectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuContextual" runat="server">
<center> <h1>LISTA DE PROYECTOS</h1> </center>
<center> 
    <br />
    <asp:Button ID="btnNuevoProyecto" runat="server" Text="Nuevo Proyecto" 
        class="btn btn-primary" onclick="btnNuevoProyecto_Click" 
        BackColor="#6666FF" ForeColor="White" Height="37px" Width="159px"/> </center>
<center> <asp:Table ID="Table1" runat="server">
        </asp:Table> </center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
</asp:Content>
