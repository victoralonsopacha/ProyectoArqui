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
    public partial class EliminarActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlactividades.AutoPostBack = true;
            }

        }
        private void llenarlista()
        {
            Ng_ClsActividad ng_actividad = new Ng_ClsActividad();
            ddlactividades.DataSource = ng_actividad.ObtenerActividad();
            ddlactividades.DataValueField = "id_act";
            ddlactividades.DataTextField = "nombre_act";
            ddlactividades.DataBind();


        }

        protected void ddlactividades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}