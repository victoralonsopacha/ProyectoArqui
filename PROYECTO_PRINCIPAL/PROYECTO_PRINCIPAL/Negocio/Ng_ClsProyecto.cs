using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROYECTO_PRINCIPAL.Comun;
using PROYECTO_PRINCIPAL.Datos;

namespace PROYECTO_PRINCIPAL.Negocio
{
    public class Ng_ClsProyecto
    {
        Dt_ClsProyecto dt_proy = new Dt_ClsProyecto();

        public List<Cm_ClsProyecto> ObtenerProyectos()
        {
            return dt_proy.listarProyectos();
        }

        public int insertarProyecto(string nombre, string descr, string progreso)
        {

            return dt_proy.insertarProyecto(nombre, descr, "NO COMENZADO");
        }

        public int actualizarProyecto(int id, string nombre, string descr, string progreso)
        {
            return dt_proy.actualizarProyecto(id, nombre, descr, progreso);
        }

        public Cm_ClsProyecto obtenerProyectoId(int id)
        {

            return dt_proy.listarProyectoPorId(id);
        }

        public int eliminarProyecto(int id)
        {
            return dt_proy.eliminarProyecto(id);
        }
        
    }
}