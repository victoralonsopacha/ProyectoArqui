using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Datos;

namespace PROYECTO_PRINCIPAL.Negocio
{
    public class Ng_ClsUsuario
    {
        public Cm_ClsUsuario login(string nombre, string contraseña)
        {

            Dt_ClsUsuario dt_Usuario = new Dt_ClsUsuario();
            return dt_Usuario.login(nombre, contraseña);
        }
        public int registrarUsuario(int cedula, string nombre, string contraseña, string correo)
        {
            Dt_ClsUsuario dt_usuario = new Dt_ClsUsuario();
            return dt_usuario.registrarUsuario(nombre, cedula, contraseña, correo);
        }

        public int actualizarUsuario(int cedula, string nombre, string contraseña, string correo)
        {
            Dt_ClsUsuario dt_usuario = new Dt_ClsUsuario();
            return dt_usuario.actualizarUsuario(nombre, cedula, contraseña, correo);
        }

        public Cm_ClsUsuario buscarUsuario(int cedula)
        {

            Dt_ClsUsuario dt_Usuario = new Dt_ClsUsuario();
            return dt_Usuario.buscarUsuario(cedula);
        }

    }
}