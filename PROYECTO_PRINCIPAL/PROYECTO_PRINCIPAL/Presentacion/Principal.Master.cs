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
    public partial class Principal : System.Web.UI.MasterPage
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
                lblMensaje.Text = "Hola: " + cm_usuario.Nombre.ToString();

            }
        }
    }
}