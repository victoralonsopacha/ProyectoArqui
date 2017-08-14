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
                ddlproyectos.AutoPostBack = true;
            }
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string valor= Convert.ToString(Session["Usuario"]);
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
            int cedula = Convert.ToInt32(Session["Usuario"]);

            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            if (ng_proyecto.insertarProyecto(cedula,nombre, descr, progreso)>0)
            {
            string mensaje = @"<script type='text/javascript'> alert('¡Proyecto Registrado!');
                               </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
            llenarlista();
            limpiar();
            }
        }


        private void limpiar()
        {
            txtnombreproy.Text = null;
            txtdescripproy.Text = null;
            txtprogresoproy.Text = null;
        }

        protected void ddlproyectos_TextChanged(object sender, EventArgs e)
        {
            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            int id = Convert.ToInt16(ddlproyectos.SelectedValue);
            Cm_ClsProyecto obj_proy = ng_proyecto.obtenerProyectoId(id);
            mostrarProyecto(obj_proy);
        }

        private void mostrarProyecto(Cm_ClsProyecto proyecto)
        {
            txtnombreproy.Text = proyecto.Nombre_proy;
            txtdescripproy.Text = proyecto.Descripcion_proy;
            txtprogresoproy.Text = proyecto.Progreso_proy;

        }


        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ddlproyectos.SelectedValue);
            string nombre = txtnombreproy.Text;
            string descr = txtprogresoproy.Text;
            string progreso = txtprogresoproy.Text;


            Ng_ClsProyecto ng_producto = new Ng_ClsProyecto();
            if (ng_producto.actualizarProyecto(id,nombre, descr, progreso) > 0)
            {

                string mensaje = @"<script type='text/javascript'>
                                   alert('¡Proyecto Actualizado!');
                                    </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                llenarlista();
                limpiar();
            }
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(ddlproyectos.SelectedValue);


            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            if (ng_proyecto.eliminarProyecto(id) > 0)
            {

                string mensaje = @"<script type='text/javascript'>
                                   alert('¡Proyecto Eliminado!');
                                    </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                llenarlista();
                limpiar();
        }

        }
    }
}