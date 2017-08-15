using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Common;
using System.Data;
using PROYECTO_PRINCIPAL.Comun;

namespace PROYECTO_PRINCIPAL.Datos
{
    public class Dt_ClsTarea
    {
        public Dt_ClsTarea() { }

        public static string cadena
        {
            get { return ConfigurationManager.ConnectionStrings["conProyecto"].ConnectionString; }
        }

        public static string provider
        {
            get { return ConfigurationManager.ConnectionStrings["conProyecto"].ProviderName; }
        }

        public static DbProviderFactory factory
        {
            get { return DbProviderFactories.GetFactory(provider); }
        }


        private static int ejecutarProcedimientos(string nombreProcedimiento, List<DbParameter> parametros)
        {
            int id = 0;
            try
            {
                using (DbConnection conexion = factory.CreateConnection())
                {
                    conexion.ConnectionString = cadena;
                    using (DbCommand comando = factory.CreateCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = nombreProcedimiento;
                        comando.CommandText = nombreProcedimiento;
                        comando.CommandType = CommandType.StoredProcedure;

                        foreach (DbParameter param in parametros)
                        {
                            comando.Parameters.Add(param);
                        }

                        conexion.Open();
                        id = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }


            return id;
        }

        public int insertarTareaEnActividad(int act_id,string nombre,string estado,string fechainicio,string fechafin)
        {

            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param3 = factory.CreateParameter();
            param3.Value = act_id;
            param3.ParameterName = "ACT_ID";
            parametros.Add(param3);

            DbParameter param = factory.CreateParameter();
            param.Value = nombre;
            param.ParameterName = "NOMBRE";
            parametros.Add(param);

            DbParameter param1 = factory.CreateParameter();
            param1.Value = estado;
            param1.ParameterName = "ESTADO";
            parametros.Add(param1);

            DbParameter param4 = factory.CreateParameter();
            param4.Value = fechainicio;
            param4.ParameterName = "FECHAINICIO";
            parametros.Add(param4);

            DbParameter param5 = factory.CreateParameter();
            param5.Value = fechafin;
            param5.ParameterName = "FECHAFIN";
            parametros.Add(param5);

            return ejecutarProcedimientos("insertarTareaEnActividad", parametros);

        } 
    }
}