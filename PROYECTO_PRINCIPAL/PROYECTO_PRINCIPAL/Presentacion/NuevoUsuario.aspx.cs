using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Datos;
using PROYECTO_PRINCIPAL.Negocio;

namespace PROYECTO_PRINCIPAL.Presentacion
{
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            string contraseña = txtPassword.Text;
            string correo = txtCorreo.Text;

            Ng_ClsUsuario obj_user = new Ng_ClsUsuario();

            if (obj_user.registrarUsuario(cedula, nombre, contraseña, correo) > 0)
            {
                string mensaje = @"<script type='text/javascript'> alert('¡Usuario Registrado!');
                               </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                Response.Redirect("Login.aspx");

            }
        }

        
    }
}