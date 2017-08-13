<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PROYECTO_PRINCIPAL.Presentacion.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" integrity="sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js" integrity="sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn" crossorigin="anonymous"></script>
    <link rel="Stylesheet" href=CSS/Estilos.css />
    <style type="text/css">
        .style1
        {
            width: 401px;
            height: 106px;
            text-align: center;
        }
        .style2
        {
            width: 762px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="container">
      </div>
      <br />
      <br /> 
      <div class= "menu"> 
      
      
          <table class="w-100">
              <tr>
                  <td class="style2">
                      <img alt="Logo" class="style1" 
                          src="http://localhost:55682/Presentacion/Imágenes/logo.png" /></td>
                  <td>
                      <asp:Button ID="btnRegistrarse" runat="server" Text="REGISTRARSE" 
                          class="btn btn-primary" onclick="btnRegistrarse_Click" />
                  </td>
              </tr>
              <tr>
                  <td class="style2">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
              </tr>
          </table>
      
      
      </div>


  <div class="login"> 
        <h1> Iniciar Sesión</h1>
        <br />
        <p> con tu cuenta de MeisterTask </p>    
          <asp:TextBox ID="txtNombre" placeholder="Ingrese su nombre" runat="server" class="form-control"></asp:TextBox>

    <br />  
               
          <asp:TextBox ID="txtPassword" runat="server"  placeholder="Ingrese su contraseña" class="form-control"  TextMode="Password" ></asp:TextBox>
    <br />
    
          <asp:Button ID="btnIngresar" runat="server" Text="Sign in" class="btn btn-primary" 
              onclick="btnIngresar_Click"/>
    </div>
    </form>
</div>
    </div>
    </form>
</body>
</html>
