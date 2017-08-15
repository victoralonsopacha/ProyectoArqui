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
    public partial class RegistrarTarea : System.Web.UI.Page
    {
        private static Cm_ClsActividad cm_tarea = new Cm_ClsActividad();
        private static Ng_ClsActividad ng_tarea = new Ng_ClsActividad();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                ddlActividad.AutoPostBack = true;
                ddlTarea.AutoPostBack = true;
            }

        }



        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreTarea.Text;
            
            string estado = txtEstadoTarea.Text;
            string fechaI = txtfechainicio.Text;
            string fechaF = txtfechafin.Text;

            cm_tarea = ng_tarea.obtenerActividadId(Convert.ToInt32(Session["Usuario"]));
            //int act_id = Convert.ToInt32(cm_tarea.Id_act.ToString());

            Ng_ClsTarea tarea = new Ng_ClsTarea();
            int act_id = Convert.ToInt32(txtIdActividad.Text);
            if (tarea.insertarTareaEnActividad(act_id,nombre,estado,fechaI,fechaF)>0)
            {
                string mensaje = @"<script type='text/javascript'> alert('¡Tarea Registrada!');
                               </script>";
            }

        

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_actividad = Convert.ToInt32(ddlActividad.SelectedIndex + 1);
            txtIdActividad.Text = Convert.ToString(id_actividad);
        }



    }
}