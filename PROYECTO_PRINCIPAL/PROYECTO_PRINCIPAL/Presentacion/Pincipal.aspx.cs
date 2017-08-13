using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_PRINCIPAL.Presentacion
{
    public partial class Pincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre_usuario"] == null && Session["Usuario"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                txtNombre.Text = "Bienvenido: " + Convert.ToString(Session["nombre_usuario"]);
            }
        }


    }
}