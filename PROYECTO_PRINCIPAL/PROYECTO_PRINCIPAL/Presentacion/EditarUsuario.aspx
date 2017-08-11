<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="PROYECTO_PRINCIPAL.Presentacion.EditarUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Editar Usuario</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" integrity="sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js" integrity="sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
<div class="container">
  <form>

    <div class="form-group row">   
        <asp:Label ID="Label5" runat="server" Text="Buscar Usuario:" class="col-sm-2 col-form-label"></asp:Label>
      <div class="col-sm-4">    
          <asp:TextBox ID="txtBuscar" runat="server" class="form-control"></asp:TextBox>
      </div>
      <div class="col-sm-4">            
          <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" 
              onclick="btnBuscar_Click" />
      </div>
    </div>

    <div class="form-group row">   
        <asp:Label ID="Label1" runat="server" Text="Nombre:" class="col-sm-2 col-form-label"></asp:Label>
      <div class="col-sm-4">    
          <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
      </div>
    </div>
    <div class="form-group row">   
        <asp:Label ID="Label3" runat="server" Text="Cedula:" 
            class="col-sm-2 col-form-label"></asp:Label>
      <div class="col-sm-4">    
          <asp:TextBox ID="txtCedula" runat="server" class="form-control"></asp:TextBox>
      </div>
    </div>
    <div class="form-group row">   
        <asp:Label ID="Label4" runat="server" Text="Password:" 
            class="col-sm-2 col-form-label"></asp:Label>
      <div class="col-sm-4">    
          <asp:TextBox ID="txtContraseña" runat="server" class="form-control"></asp:TextBox>
      </div>
    </div>
    <div class="form-group row">   
        <asp:Label ID="Label2" runat="server" Text="Email:" 
            class="col-sm-2 col-form-label"></asp:Label>
      <div class="col-sm-4">       
          <asp:TextBox ID="txtCorreo" runat="server" class="form-control" ></asp:TextBox>
      </div>
    </div>
    <div class="form-group row">
      <div class="offset-sm-2 col-sm-10">     
          <asp:Button ID="btnActualizar" runat="server" Text="ActualizarRegistro" class="btn btn-primary" 
              onclick="btnEditar_Click" />
      </div>
    </div>
  </form>
</div>
    </div>
    </form>
</body>
</html>
