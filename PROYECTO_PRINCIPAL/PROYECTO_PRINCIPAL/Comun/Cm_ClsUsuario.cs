using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_PRINCIPAL.Comun
{
    public class Cm_ClsUsuario
    {
        #region atributos
        private int cedula;
        private string nombre;
        private int password;
        private string correo;
        #endregion

        #region set y get
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

        #region constructores
        public Cm_ClsUsuario(string nombre, int password)
        {

            this.nombre = nombre;
            this.password = password;

        }

        public Cm_ClsUsuario() { }

        #endregion


    }
}