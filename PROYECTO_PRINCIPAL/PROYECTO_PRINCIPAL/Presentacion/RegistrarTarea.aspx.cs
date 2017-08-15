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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreTarea.Text;
            //string descripcion = txtDescripcionTarea.Text;
            string estado = txtEstadoTarea.Text;
            string fechaI = txtfechainicio.Text;
            string fechaF = txtfechafin.Text;

            Ng_ClsTarea ng_tarea = new Ng_ClsTarea();
            if (ng_tarea.insertarTareaEnActividad(act_id,nombre,estado,fechaI,fechaF)>0)
            {
                string mensaje = @"<script type='text/javascript'> alert('¡Tarea Registrada!');
                               </script>";
            }

        

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {

        }

    }
}