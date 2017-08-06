using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_PRINCIPAL.Comun
{
    public class Cm_ClsProyecto
    {
        #region atributos
            private int id_proy;
            private String nombre_proy;
            private String descripcion_proy;
            private String progreso_proy;

        #endregion

        #region constructores


        public int Id_proy
        {
            get { return id_proy; }
            set { id_proy = value; }
        }
        public String Nombre_proy
        {
            get { return nombre_proy; }
            set { nombre_proy = value; }
        }

        public String Descripcion_proy
        {
            get { return descripcion_proy; }
            set { descripcion_proy = value; }
        }

        public String Progreso_proy
        {
            get { return progreso_proy; }
            set { progreso_proy = value; }
        }
        #endregion

        public Cm_ClsProyecto(int id_proy, string nombre_proy, string descripcion_proy,string progreso_proy )
        {
            this.id_proy = id_proy;
            this.nombre_proy = nombre_proy;
            this.descripcion_proy = descripcion_proy;
            this.progreso_proy = progreso_proy;
        }

        public Cm_ClsProyecto() { }

    }
}