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

            Dt_ClsUsuario DtUsuario = new Dt_ClsUsuario();
            return DtUsuario.login(nombre, contraseña);
        }

        public Cm_ClsUsuario registrarUsuario(int cedula, string nombre, string contraseña, string correo)
        {
            Dt_ClsUsuario dt_usuario = new Dt_ClsUsuario();
            return dt_usuario.registrarUsuario(cedula, nombre, contraseña, correo);
        }

    }
}