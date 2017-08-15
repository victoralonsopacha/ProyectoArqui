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
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            
            if (!IsPostBack)
            {
                ddlactividades.AutoPostBack = true;
                ddlProyecto.AutoPostBack = true;
            }
            


        }


        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnombreact.Text) || String.IsNullOrEmpty(txtdescripact.Text) || String.IsNullOrEmpty(txtestadoact.Text) || String.IsNullOrEmpty(txtfechafin.Text) || String.IsNullOrEmpty(txtfechainicio.Text))
            {
                errorFull();
            }else
            {
                int cedula = Convert.ToInt32(Session["Usuario"]);
                
                string nombre = txtnombreact.Text;
                string estado = txtestadoact.Text;
                string descr = txtdescripact.Text;
                string fechaInicio= txtfechainicio.Text;
                string fechaFin = txtfechafin.Text;
                int pro_id = Convert.ToInt32(txtIdProyecto.Text);
            
                Ng_ClsActividad ng_actividad = new Ng_ClsActividad();
                               
                if (ng_actividad.insertarActividad(cedula,pro_id,nombre, estado, descr, fechaInicio, fechaFin) > 0)
                {
                    string mensaje = @"<script type='text/javascript'> alert('¡Actividad Registrada!');
                                   </script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
                    
                    limpiar();
                }
                 
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
                
                limpiar();
        }
        
        }


        protected void errorFull()
        {
            string script = @"<script type='text/javascript'>
                    alert('Todos los campos deben estar llenos');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void ddlProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_proyecto = Convert.ToInt32(ddlProyecto.SelectedIndex + 1);
            txtIdProyecto.Text = Convert.ToString(id_proyecto);
        }






    }
}
