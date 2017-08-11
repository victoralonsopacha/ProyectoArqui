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
        private string contraseña;
        private string correo;
        #endregion

        #region set y get
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


        #endregion

        #region constructores
        public Cm_ClsUsuario(string nombre, string contraseña)
        {

            this.nombre = nombre;
            this.contraseña = contraseña;

        }

        public Cm_ClsUsuario(string nombre, int cedula, string contraseña, string correo)
        {

            this.nombre = nombre;
            this.cedula = cedula;
            this.contraseña = contraseña;
            this.correo = correo;
        }

        public Cm_ClsUsuario() { }

        #endregion


    }
}