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
        public Cm_ClsUsuario login(string nombre, int password)
        {

            Dt_ClsUsuario DtUsuario = new Dt_ClsUsuario();
            return DtUsuario.login(nombre, password);
        }


    }
}