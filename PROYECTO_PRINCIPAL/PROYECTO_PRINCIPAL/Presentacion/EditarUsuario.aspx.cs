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
                txtNombre.Text = cm_usuario.Nombre.ToString();
                txtEmail.Text = cm_usuario.Correo.ToString();
                txtContraseña.Text = cm_usuario.Contraseña.ToString();
            }           
        }

        

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //cm_usuario = ng_usuario.actualizarUsuario(Convert.ToInt32(Session["Usuario"]), txtNombre.Text, txtContraseña.Text, txtEmail.Text);
            Server.Transfer("Pincipal.aspx");            
        }
    }
}