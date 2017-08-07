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

            Ng_ClsUsuario ng_ClsUsuario = new Ng_ClsUsuario();
            Cm_ClsUsuario dt_ClsUsuario = new Cm_ClsUsuario();
            dt_ClsUsuario = ng_ClsUsuario.login(txtNombre.Text, txtPassword.Text);



            if (txtNombre.Text.Equals(dt_ClsUsuario.Nombre) && txtPassword.Text.Equals(dt_ClsUsuario.Contraseña))
            {
                string mensaje = @"<script type='text/javascript'>
                                   alert('INGRESO CORRECTO!!');
                                    </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                Session.Add("Usuario", dt_ClsUsuario.Contraseña);
                Response.Redirect("Pincipal.aspx");
            }
            else
            {
                string mensaje = @"<script type='text/javascript'>
                                   alert('INGRESO FALLIDO!!');
                                    </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
            }

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoUsuario.aspx");
        }

    }
}