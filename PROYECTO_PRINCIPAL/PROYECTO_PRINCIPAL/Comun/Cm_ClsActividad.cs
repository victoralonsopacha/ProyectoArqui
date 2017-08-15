using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_PRINCIPAL.Comun
{
    public class Cm_ClsActividad
    {
        #region atributos
        private int id_act;
        private String nombre_act;
        private String estado_act;
        private String descripcion_act;
        private String fechaInicio_act;
        private String fechaFin_act;
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private int pro_id;

        public int Pro_id
        {
            get { return pro_id; }
            set { pro_id = value; }
        }
        #endregion

        #region constructores

        public int Id_act
        {
            get { return id_act; }
            set { id_act = value; }
        }

        public String Nombre_act
        {
            get { return nombre_act; }
            set { nombre_act = value; }
        }

        public String Estado_act
        {
            get { return estado_act; }
            set { estado_act = value; }
        }

        public String Descripcion_act
        {
            get { return descripcion_act; }
            set { descripcion_act = value; }
        }

        public String FechaInicio_act
        {
            get { return fechaInicio_act; }
            set { fechaInicio_act = value; }
        }

        public String FechaFin_act
        {
            get { return fechaFin_act; }
            set { fechaFin_act = value; }
        }
        #endregion
    
    public Cm_ClsActividad(int id_act, string nombre_act,string estado_act, string descripcion_act,string fechaInicio_act,string fechaFin_act )
        {
            this.id_act = id_act;
            this.nombre_act= nombre_act;
            this.estado_act = estado_act;
            this.descripcion_act = descripcion_act;
            this.fechaInicio_act= fechaInicio_act;
            this.fechaFin_act = fechaFin_act;
        }

    public Cm_ClsActividad(int id_act,int cedula,int pro_id ,string nombre_act, string estado_act, string descripcion_act, string fechaInicio_act, string fechaFin_act)
    {

        this.id_act = id_act;
        this.cedula = cedula;
        this.pro_id = pro_id;
        this.nombre_act = nombre_act;
        this.estado_act = estado_act;
        this.descripcion_act = descripcion_act;
        this.fechaInicio_act = fechaInicio_act;
        this.fechaFin_act = fechaFin_act;
    }



        public Cm_ClsActividad() { }
}
}

