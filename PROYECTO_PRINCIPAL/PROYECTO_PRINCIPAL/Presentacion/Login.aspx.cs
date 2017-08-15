using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROYECTO_PRINCIPAL.Datos;
using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Negocio;
using System.Data.SqlClient;

namespace PROYECTO_PRINCIPAL.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            Ng_ClsUsuario Ng_ClsUsuario = new Ng_ClsUsuario();
            Cm_ClsUsuario Dt_ClsUsuario = new Cm_ClsUsuario();
            Dt_ClsUsuario = Ng_ClsUsuario.login(txtNombre.Text,txtPassword.Text);

            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                errorFull();
            }else{

                if (txtPassword.Text.Equals(Dt_ClsUsuario.Contraseña) && txtNombre.Text.Equals(Dt_ClsUsuario.Nombre))
                {
                    string mensaje = @"<script type='text/javascript'>
                                   alert('INGRESO CORRECTO!!');
                                    </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTOPRINCIPAL", mensaje, false);
                    Session.Add("Usuario", Dt_ClsUsuario.Cedula);
                    Response.Redirect("Pincipal.aspx");
                }
                else
                {
                    string mensaje = @"<script type='text/javascript'>
                                   alert('INGRESO FALLIDO!!');
                                    </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTOPRINCIPAL", mensaje, false);
                }
            }
            
                
 
            


            

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoUsuario.aspx");
        }

        protected void errorFull()
        {
            string script = @"<script type='text/javascript'>
                    alert('Todos los campos deben estar llenos');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

    }
}