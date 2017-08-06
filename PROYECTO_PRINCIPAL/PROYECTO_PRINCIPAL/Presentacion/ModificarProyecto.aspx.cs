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
    public partial class ModificarProyecto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //mostrarProyecto();
                //llenarlista();
                ddlproyectos.AutoPostBack = true;
            }
        }

        protected void ddlproyectos_TextChanged(object sender, EventArgs e)
        {
            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            int id = Convert.ToInt16(ddlproyectos.SelectedValue);
            Cm_ClsProyecto obj_proy = ng_proyecto.obtenerProyectoId(id);
            mostrarProyecto(obj_proy);
        }

        private void limpiar()
        {
            txtnombreproy.Text = null;
            txtdescripproy.Text = null;
            txtprogresoproy.Text = null;
        }

        protected void bnmodificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ddlproyectos.SelectedValue);
            string nombre = txtnombreproy.Text;
            string descr = txtdescripproy.Text;
            string progreso = txtprogresoproy.Text;

            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            if (ng_proyecto.actualizarProyecto(id,nombre, descr, progreso) > 0)
            {

                string mensaje = @"<script type='text/javascript'>
                                   alert('¡Proyecto Actualizado!');
                                    </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "Bodega Pepito", mensaje, false);
                //llenarlista();
                limpiar();
        }
      }


        private void mostrarProyecto(Cm_ClsProyecto proyecto)
        {
            txtnombreproy.Text = proyecto.Nombre_proy;
            txtdescripproy.Text = proyecto.Descripcion_proy;
            txtprogresoproy.Text = proyecto.Progreso_proy;

        }
    }
}