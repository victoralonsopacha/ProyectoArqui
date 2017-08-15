using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTO_PRINCIPAL.Comun
{
    public class Cm_ClsTarea
    {
        #region atributos

        private int id;
        private int act_id;

     
        private string nombre;
        private string estado;
        private string descripcion;
        private string fechainicio;
        private string fechafin;
     
        #endregion

        #region set y get
        public int Act_id
        {
            get { return act_id; }
            set { act_id = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Fechainicio
        {
            get { return fechainicio; }
            set { fechainicio = value; }
        }
        public string Fechafin
        {
            get { return fechafin; }
            set { fechafin = value; }
        }

        #endregion

        #region constructores

        public Cm_ClsTarea(int id,string nombre,string estado,string descripcion,string fechainicio,string fechafin)
        {
            this.id = id;
            this.nombre = nombre;
            this.estado = estado;
            this.descripcion = descripcion;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
        }
        public Cm_ClsTarea(int id,int act_id, string nombre, string estado, string descripcion, string fechainicio, string fechafin)
        {
            
            this.id = id;
            this.act_id = act_id;
            this.nombre = nombre;
            this.estado = estado;
            this.descripcion = descripcion;
            this.fechainicio = fechainicio;
            this.fechafin = fechafin;
        }

        public Cm_ClsTarea() { }
        #endregion
    }
}