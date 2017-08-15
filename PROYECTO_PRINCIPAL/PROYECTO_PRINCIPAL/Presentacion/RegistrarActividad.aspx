<%@ Page Title="" theme="Tema1" Language="C#" MasterPageFile="~/Presentacion/GestionDeActividades.master" AutoEventWireup="true" CodeBehind="RegistrarActividad.aspx.cs" Inherits="PROYECTO_PRINCIPAL.Presentacion.RegistrarActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" integrity="sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js" integrity="sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn" crossorigin="anonymous"></script>
<h1>Registar Actividad</h1>
<h1>&nbsp;Actividad</h1>
<table style="width: 100%">
        <tr>
            <td style="width: 236px">
                <asp:Label ID="Label6" runat="server" Text="Seleccionar actividad:"></asp:Label>
            </td>
            <td style="width: 191px">
                <asp:DropDownList ID="ddlactividades" runat="server" 
                    DataSourceID="SqlDataSource2" DataTextField="NOMBRE" DataValueField="NOMBRE">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDDProyectoArquiConnectionString %>" 
                    SelectCommand="SELECT [NOMBRE] FROM [ACTIVIDAD] WHERE ([PRO_ID] = @PRO_ID)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtIdProyecto" Name="PRO_ID" 
                            PropertyName="Text" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td style="width: 188px">
                <asp:Label ID="Label7" runat="server" Text="Seleccionar Proyecto:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlProyecto" runat="server" DataSourceID="SqlDataSource1" 
                    DataTextField="NOMBRE" DataValueField="NOMBRE" 
                    onselectedindexchanged="ddlProyecto_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:BDDProyectoArquiConnectionString %>" 
                    SelectCommand="SELECT [NOMBRE] FROM [PROYECTO] ORDER BY [ID]">
                </asp:SqlDataSource>
            </td>
        </tr>
        
        <tr>
            <td style="width: 236px">
                <asp:Label ID="Label8" runat="server" Text="Id Proyecto"></asp:Label>
            </td>
            <td style="width: 191px">
                <asp:TextBox ID="txtIdProyecto" runat="server" Width="293px"></asp:TextBox>
            </td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        
        <tr>
            <td style="width: 236px">
                <asp:Label ID="Label1" runat="server" Text="Nombre de la actividad:"></asp:Label>
            </td>
            <td style="width: 191px">
                <asp:TextBox ID="txtnombreact" runat="server" Width="296px"></asp:TextBox>
            </td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                <asp:Label ID="Label3" runat="server" Text="Estado:"></asp:Label>
            </td>
            <td style="width: 191px">
                <asp:TextBox ID="txtestadoact" runat="server" Width="296px"></asp:TextBox>
            </td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>
            </td>
            <td style="width: 191px">
                <asp:TextBox ID="txtdescripact" runat="server" Height="27px" Width="295px"></asp:TextBox>
            </td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                <asp:Label ID="Label4" runat="server" Text="Fecha de inicio:"></asp:Label>
            </td>
            <td style="width: 191px">
                <asp:TextBox ID="txtfechainicio" runat="server" Width="296px" TextMode="Date"></asp:TextBox>
            </td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                <asp:Label ID="Label5" runat="server" Text="Fecha de fin:"></asp:Label>
            </td>
            <td style="width: 191px">
                <asp:TextBox ID="txtfechafin" runat="server" Width="296px" TextMode="Date"></asp:TextBox>
            </td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                &nbsp;</td>
            <td style="width: 191px">
                &nbsp;</td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                <asp:Button ID="btnregistrar" runat="server" Text="REGISTRAR" Height="52px" 
                    Width="170px" class="btn btn-info" onclick="btnregistrar_Click" />
            </td>
          
            <td>
                <asp:Button ID="btneliminar" runat="server" Text="ELIMINAR" 
                    class="btn btn-info" onclick="btneliminar_Click" Height="57px" 
                    Width="149px" />
            </td>
        </tr>
        <tr>
            <td style="width: 236px">
                &nbsp;</td>
            <td style="width: 191px">
                &nbsp;</td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                &nbsp;</td>
            <td style="width: 191px">
                &nbsp;</td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 236px">
                &nbsp;</td>
            <td style="width: 191px">
                &nbsp;</td>
            <td style="width: 188px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
