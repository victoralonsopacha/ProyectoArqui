<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoUsuario.aspx.cs" Inherits="PROYECTO_PRINCIPAL.Presentacion.NuevoUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nuevo Usuario</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" integrity="sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js" integrity="sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn" crossorigin="anonymous"></script>
    <link href="CSS/Estilos.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            width: 251px;
        }
        .style3
        {
            width: 356px;
        }
        .style4
        {
            width: 348px;
        }
    </style>

</head>
<body style="background-image : url(Imágenes/fondoprincipal.jpg)">
<br />



    <form id="form1" runat="server">
    <table class="login">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                <center><H1>NUEVO USUARIO</H1></td></center>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
        <asp:Label ID="Label1" runat="server" Text="Nombre:" class="col-sm-2 col-form-label"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
          <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
            </td>
            <td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtNombre" Display="Dynamic" 
                    ErrorMessage="Campo Obligatorio" ToolTip="Campo Obligatorio">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
        <asp:Label ID="Label4" runat="server" Text="Cedula:" 
            class="col-sm-2 col-form-label"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
          <asp:TextBox ID="txtCedula" runat="server" class="form-control"></asp:TextBox>        
            </td>
            <td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtCedula" Display="Dynamic" 
                    ErrorMessage="Campo Obligatorio" ToolTip="Campo Obligatorio">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="txtCedula" Display="Dynamic" 
                    ErrorMessage="Escriba un valor valido numerico" MaximumValue="9999999999" 
                    MinimumValue="1111111111" ToolTip="Escriba un valor correcto" Type="Currency"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
       <asp:Label ID="Label5" runat="server" Text="Correo: " class="col-sm-2 col-form-label"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
          <asp:TextBox ID="txtCorreo" runat="server" class="form-control"></asp:TextBox>
            </td>
            <td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtCorreo" Display="Dynamic" 
                    ErrorMessage="Campo Obligatorio" ToolTip="Campo Obligatorio">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtCorreo" Display="Dynamic" 
                    ErrorMessage="Correoelectronico no valido" ForeColor="#CC0000" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
        <asp:Label ID="Label2" runat="server" Text="Password:" class="col-sm-2 col-form-label"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
          <asp:TextBox ID="txtPass" runat="server" class="form-control" 
              TextMode="Password" ></asp:TextBox>
            </td>
            <td class="style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtPass" Display="Dynamic" ErrorMessage="Campo Obligatorio" 
                    ToolTip="Campo Obligatorio">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
            <center> <asp:Button ID="btnAgregar" runat="server" Text="Agregar" 
              class="btn btn-primary" onclick="btnAgregar_Click"/>
            </td></center>
            <td class="style2">
                &nbsp;</td>
        </tr>
    </table>
    <div>
    <div class="container">
    </div>
        <div class="form-group row">   
      <div class="col-sm-4">    
      </div>
    </div>
    <div class="form-group row">   
      <div class="col-sm-4">    
      </div>
    </div>
    <center><h1> &nbsp;</h1>

    <div class="form-group row">   
      <div class="col-sm-4">    
      </div>
    </div>
    <div class="form-group row">   
      <div class="col-sm-4">    
      </div>
    </div>
        <div class="form-group row">   
      <div class="col-sm-4">       
      </div>
    </div>
    <div class="form-group row">   
      <div class="col-sm-4">       
      </div>
    </div>
    <div class="form-group row">
      <div class="offset-sm-2 col-sm-10">     
      </div>

      </center>
    </div>
    </form>
</div>
    </div>
    </form>
</body>
</html>
