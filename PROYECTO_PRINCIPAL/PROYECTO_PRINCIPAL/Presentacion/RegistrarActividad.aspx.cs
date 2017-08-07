using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROYECTO_PRINCIPAL.Presentacion
{
    public partial class RegistrarActividad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombreact.Text;
            string descr = txtdescripact.Text;
            
            Ng_ClsProyecto ng_proyecto = new Ng_ClsProyecto();
            if (ng_proyecto.insertarProyecto(nombre, descr, progreso)>0)
            {
            string mensaje = @"<script type='text/javascript'> alert('¡Proyecto Registrado!');
                               </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "PROYECTO_PRINCIPAL", mensaje, false);
            llenarlista();
            limpiar();
        }
    }
}