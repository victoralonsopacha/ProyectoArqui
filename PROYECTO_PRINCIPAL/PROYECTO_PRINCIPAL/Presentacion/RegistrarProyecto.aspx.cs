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
    public partial class RegistrarProyecto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        private void llenarlista() {
            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            ddlproyectos.DataSource = ng_proyecto.ObtenerProyectos();
            ddlproyectos.DataValueField = "id_proy";
            ddlproyectos.DataTextField = "nombre_proy";
            ddlproyectos.DataBind();
        
        
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombreproy.Text;
            string descr = txtdescripproy.Text;
            string progreso = txtprogresoproy.Text;

            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            if (ng_proyecto.insertarProyecto(nombre, descr, progreso)>0)
            {
            string mensaje = @"<script type='text/javascript'> alert('¡Proyecto Registrado!');
                               </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
            llenarlista();
            }
        }

    }
}