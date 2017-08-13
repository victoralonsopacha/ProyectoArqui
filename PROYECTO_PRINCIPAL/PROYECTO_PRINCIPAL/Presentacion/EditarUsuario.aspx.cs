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
        private static string nombre;
        private static string correo;
        private static string contraseña;
        private static Cm_ClsUsuario cm_usuario = new Cm_ClsUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            contraseña = Session["Usuario"].ToString();
        }

        

        protected void btnEditar_Click(object sender, EventArgs e)
        {

            Server.Transfer("Pincipal.aspx");
        }
    }
}