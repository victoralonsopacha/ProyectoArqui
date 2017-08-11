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
    public partial class EditarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cedula = Convert.ToInt32(txtCedula.Text);
            string contraseña = txtContraseña.Text;
            string correo = txtCorreo.Text;

            Ng_ClsUsuario obj_user = new Ng_ClsUsuario();

            if (obj_user.actualizarUsuario(cedula, nombre, contraseña, correo) > 0)
            {
                string mensaje = @"<script type='text/javascript'> alert('¡Usuario Registrado!');
                               </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                Response.Redirect("Login.aspx");

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                string script = @"<script type='text/javascript'>
                
                    alert('ingrese cedula');
                    </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page),
              "PROYECTO_PRINCIPAL", script, false);
            }
            else
            {
                Cm_ClsUsuario usuario = new Cm_ClsUsuario();
                Ng_ClsUsuario user = new Ng_ClsUsuario();

                usuario = user.buscarUsuario(Convert.ToInt32(txtBuscar.Text));

                if (Convert.ToInt32(txtBuscar.Text).Equals(usuario.Cedula))
                {
                    txtNombre.Text = usuario.Nombre;
                    txtCedula.Text = Convert.ToString(usuario.Cedula);
                    txtContraseña.Text = usuario.Contraseña;
                    txtCorreo.Text = usuario.Correo;

                }
                else
                {
                    string script = @"<script type='text/javascript'>
                
                    alert('usuario no registrado');
                    </script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page),
                  "PROYECTO_PRINCIPAL", script, false);
                }
            }
        }
    }
}
