using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Negocio;

namespace PROYECTO_PRINCIPAL.Presentacion
{
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        private static Cm_ClsUsuario cm_usuario = new Cm_ClsUsuario();
        private static Ng_ClsUsuario ng_usuario = new Ng_ClsUsuario();
        private int cedula;
        private string nombre;
        private string contraseña;
        private string correo;

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            cedula = Convert.ToInt32(txtCedula.Text);
            nombre = txtNombre.Text;
            contraseña = txtPass.Text;
            correo = txtCorreo.Text;
            cm_usuario = ng_usuario.registrarUsuario(cedula, nombre, contraseña, correo);          
            Session.Add("cedula_usuario", cedula);
            Session.Add("contraseña_usuario", contraseña);
            Session.Add("nombre_usuario", nombre);
            Server.Transfer("Pincipal.aspx");
        }


    }
}