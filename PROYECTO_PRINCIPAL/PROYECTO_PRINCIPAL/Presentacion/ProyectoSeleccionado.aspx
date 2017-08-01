<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Principal.Master" AutoEventWireup="true" CodeBehind="ProyectoSeleccionado.aspx.cs" Inherits="PROYECTO_PRINCIPAL.Presentacion.ProyectoSeleccionado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuContextual" runat="server">
 <center> <table class="style1">
        <tr>
            <td class="style2">
                Actividades Terminadas</td>
            <td class="style3">
                <asp:TextBox ID="txtActividadesTerminadas" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Actividades Pendientes</td>
            <td class="style3">
                <asp:TextBox ID="txtActividadesPendientes" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table> </center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<center> <h1> Proyecto Seleccionado</h1>  </center> 
    
        <center> <asp:Button ID="btnregresar" runat="server" Text="Pagina Principal" 
            onclick="btnregresar_Click" type="button" class="btn btn-primary" 
            BackColor="#3366FF" ForeColor="White" Height="35px" Width="184px" /> </center>
</asp:Content>
