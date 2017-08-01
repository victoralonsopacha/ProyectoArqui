<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionDeUsuarios.aspx.cs" Inherits="PROYECTO_PRINCIPAL.Presentacion.GestionDeUsuarios" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" integrity="sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js" integrity="sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="form-group row">
        <div class="offset-sm-2 col-sm-10">
        
            <asp:Button ID="btnNuevoUsuario" runat="server" Text="Nuevo Usuario" 
                class="btn btn-primary" onclick="Button1_Click"/>
        </div>
    </div>

    <div class="form-group row">
        <div class="offset-sm-2 col-sm-10">
        
            <asp:Button ID="btnEditarUsuario" runat="server" Text="Editar Usuario" 
                class="btn btn-primary" onclick="btnEditarUsuario_Click"/>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
