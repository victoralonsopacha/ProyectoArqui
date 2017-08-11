using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Datos;

namespace PROYECTO_PRINCIPAL.Negocio
{
    public class Ng_ClsActividad
    {
        Dt_ClsActividad dt_act = new Dt_ClsActividad();

        public List<Cm_ClsActividad> ObtenerActividad()
        {
            return dt_act.listarActividad();
        }

        public int insertarActividad(string nombre,string estado, string descr, string fechaInicio, string fechaFin)
        {

            return dt_act.insertarActividad(nombre,"ABIERTA", descr, fechaInicio, fechaFin);
        }


        public Cm_ClsActividad obtenerActividadId(int id)
        {

            return dt_act.listarActividadPorId(id);
        }

        public int eliminarActividad(int id)
        {
            return dt_act.eliminarActividad(id);
        }
        
    }
}