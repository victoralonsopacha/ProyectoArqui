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
    public partial class RegistrarActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlactividades.AutoPostBack = true;
                ddlProyecto.AutoPostBack = true;
            }
            
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            

        }
        private void llenarlistaActividad()
        {
            Ng_ClsActividad ng_actividad = new Ng_ClsActividad();
            ddlactividades.DataSource = ng_actividad.ObtenerActividad();
            ddlactividades.DataValueField = "id_act";
            ddlactividades.DataTextField = "nombre_act";
            ddlactividades.DataBind();
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnombreact.Text) || String.IsNullOrEmpty(txtdescripact.Text) || String.IsNullOrEmpty(txtestadoact.Text) || String.IsNullOrEmpty(txtfechafin.Text) || String.IsNullOrEmpty(txtfechainicio.Text))
            {
                errorFull();
            }else
            {
                int cedula = Convert.ToInt32(Session["Usuario"]);
                //procedimiento para el id del proyecto
                string nombre = txtnombreact.Text;
                string estado = txtestadoact.Text;
                string descr = txtdescripact.Text;
                string fechaInicio= txtfechainicio.Text;
                string fechaFin = txtfechafin.Text;
            
                Ng_ClsActividad ng_actividad = new Ng_ClsActividad();
                //cambiar el procedimiento para del insertar actividad
                /*
                if (ng_actividad.insertarActividad(cedula,pro_id,nombre, estado, descr, fechaInicio, fechaFin) > 0)
                {
                    string mensaje = @"<script type='text/javascript'> alert('¡Actividad Registrada!');
                                   </script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                    llenarlistaActividad();
                    limpiar();
                }
                 */
        }
    }
        private void limpiar()
        {
            txtnombreact.Text = null;
            txtestadoact.Text=null;
            txtdescripact.Text = null;
            txtfechainicio.Text = null;
            txtfechafin.Text=null;
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ddlactividades.SelectedValue);


            Ng_ClsActividad ng_actividad = new Ng_ClsActividad();
            if (ng_actividad.eliminarActividad(id) > 0)
            {

                string mensaje = @"<script type='text/javascript'>
                                   alert('¡Actividad Eliminada!');
                                    </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                llenarlistaActividad();
                limpiar();
        }
        
        }
        /*
        protected void ddlactividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ng_ClsActividad ng_actividad = new Ng_ClsActividad();
            int id = Convert.ToInt16(ddlactividades.SelectedValue);
            Cm_ClsActividad obj_act = ng_actividad.obtenerActividadId(id);
            mostrarActividad(obj_act);
        
        }
        */

        private void mostrarActividad(Cm_ClsActividad actividad)
        {
            txtnombreact.Text = actividad.Nombre_act;
            txtestadoact.Text = actividad.Estado_act;
            txtdescripact.Text = actividad.Descripcion_act;
            txtfechainicio.Text = actividad.FechaInicio_act;
            txtfechafin.Text = actividad.FechaFin_act;

        }

        protected void ddlactividades_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Ng_ClsActividad ng_actividad = new Ng_ClsActividad();
            int id = Convert.ToInt16(ddlactividades.SelectedValue);
            Cm_ClsActividad obj_act = ng_actividad.obtenerActividadId(id);
            mostrarActividad(obj_act);
        
        }

        protected void errorFull()
        {
            string script = @"<script type='text/javascript'>
                    alert('Todos los campos deben estar llenos');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        private void llenarlistaProyecto()
        {
            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            ddlProyecto.DataSource = ng_proyecto.ObtenerProyectos();
            ddlProyecto.DataValueField = "id_proy";
            ddlProyecto.DataTextField = "nombre_proy";
            ddlProyecto.DataBind();
        }




        protected void ddlProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            int id = Convert.ToInt16(ddlProyecto.SelectedValue);
            Cm_ClsProyecto obj_proy = ng_proyecto.obtenerProyectoId(id);
        }



    }
}
