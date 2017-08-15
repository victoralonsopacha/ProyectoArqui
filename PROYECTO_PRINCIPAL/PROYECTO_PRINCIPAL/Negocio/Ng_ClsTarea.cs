using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Datos;


namespace PROYECTO_PRINCIPAL.Negocio
{
    public class Ng_ClsTarea
    {
        Dt_ClsTarea dt_tarea = new Dt_ClsTarea();

        public List<Cm_ClsTarea> obtenerTareas()
        {
            return dt_tarea.listarTareas();
        }
        public int insertarTareaEnActividad(int act_id, string nombre, string estado, string fechainicio, string fechafin)
        {
           
            return dt_tarea.insertarTareaEnActividad(act_id,nombre,estado,fechainicio,fechafin);
        }


        public int eliminarProyecto(int id)
        {
            return dt_tarea.eliminarTarea(id);
        }

    }
}