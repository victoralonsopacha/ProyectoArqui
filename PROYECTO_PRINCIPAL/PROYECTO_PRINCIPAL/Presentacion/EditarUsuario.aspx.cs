using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROYECTO_PRINCIPAL.Datos;
using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Negocio;

namespace PROYECTO_PRINCIPAL.Presentacion
{
    public partial class EditarUsuario : System.Web.UI.Page
    {
        private static Cm_ClsUsuario cm_usuario = new Cm_ClsUsuario();
        private static Ng_ClsUsuario ng_usuario = new Ng_ClsUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                cm_usuario = ng_usuario.buscarUsuario(Convert.ToInt32(Session["Usuario"]));
                txtCedula.Text = cm_usuario.Cedula.ToString();
            }           
        }

        

        protected void btnEditar_Click(object sender, EventArgs e)
        {
                   
            //cm_usuario = ng_usuario.buscarUsuario(Convert.ToInt32(Session["Usuario"]));
            int cedula =Convert.ToInt32( txtCedula.Text);
            //txtCedula.Text=Convert.ToString( cedula);
            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string correo = txtEmail.Text;
            
            Ng_ClsUsuario dt_usuario = new Ng_ClsUsuario();
            if (dt_usuario.actualizarUsuario(cedula,nombre,contraseña,correo) > 0)
            {
                string mensaje = @"<script type='text/javascript'> alert('¡Usuario actualizado!');
                               </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                Server.Transfer("Login.aspx");  
            }

            //cm_usuario = ng_usuario.actualizarUsuario(txtCedula.Text, txtNombre.Text, txtContraseña.Text, txtEmail.Text);
                     
        }
    }
}