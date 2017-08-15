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
    public class Dt_ClsActividad
    {
        public Dt_ClsActividad() { }

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

        public List<Cm_ClsActividad> listarActividad()
        {

            List<Cm_ClsActividad> actividad = new List<Cm_ClsActividad>();
            string nombreProcedimiento = "consultarActividad";
              using (DbConnection conexion = factory.CreateConnection())
              {
                conexion.ConnectionString = cadena;
                using (DbCommand comando = factory.CreateCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = nombreProcedimiento;
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (DbDataReader lector = comando.ExecuteReader()) 
                    {
                        while(lector.Read())
                        {
                            actividad.Add(new Cm_ClsActividad(
                                (int)lector["ID"],
                                (string)lector["NOMBRE"],
                                (string)lector["ESTADO"],
                                (string)lector["DESCRIPCION"],
                                (string)lector["FECHAINICIO"],
                                (string)lector["FECHAFIN"]
                                ));
                        }
                    }
                }
            }
            return actividad;
        } 

        public int insertarActividad(int cedula,int pro_id,string nombre,string estado, string descr, string fechaInicio, string fechaFin)
        {

            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param1 = factory.CreateParameter();
            param1.Value = cedula;
            param1.ParameterName = "CEDULA";
            parametros.Add(param1);

            DbParameter param2 = factory.CreateParameter();
            param2.Value = pro_id;
            param2.ParameterName = "PRO_ID";
            parametros.Add(param2);

            DbParameter param3 = factory.CreateParameter();
            param3.Value = nombre;
            param3.ParameterName = "NOMBRE";
            parametros.Add(param3);

            DbParameter param4 = factory.CreateParameter();
            param4.Value = estado;
            param4.ParameterName = "ESTADO";
            parametros.Add(param4);

            DbParameter param5 = factory.CreateParameter();
            param5.Value = descr;
            param5.ParameterName = "DESCRIPCION";
            parametros.Add(param5);

            DbParameter param6 = factory.CreateParameter();
            param6.Value = fechaInicio;
            param6.ParameterName = "FECHAINICIO";
            parametros.Add(param6);

            DbParameter param7 = factory.CreateParameter();
            param7.Value = fechaInicio;
            param7.ParameterName = "FECHAFIN";
            parametros.Add(param7);

            return ejecutarProcedimientos("insertarActividad", parametros);
        
        } 


     /*public int actualizarProyecto(int id, string nombre, string descr, string progreso)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param0 = factory.CreateParameter();
            param0.Value = id;
            param0.ParameterName = "ID";
            parametros.Add(param0);

            DbParameter param = factory.CreateParameter();
            param.Value = nombre;
            param.ParameterName = "NOMBRE";
            parametros.Add(param);

            DbParameter param1 = factory.CreateParameter();
            param1.Value = descr;
            param1.ParameterName = "DESCRIPCION";
            parametros.Add(param1);

            DbParameter param4 = factory.CreateParameter();
            param4.Value = progreso;
            param4.ParameterName = "PROGRESO";
            parametros.Add(param4);

            return ejecutarProcedimientos("actualizarProyecto", parametros);
            
        }*/


     public Cm_ClsActividad listarActividadPorId(int id)
     {

         Cm_ClsActividad obj_act = new Cm_ClsActividad();

         string procedimiento = "consultarActividadPorID";

         using (DbConnection con = factory.CreateConnection())
         {

             con.ConnectionString = cadena;

             using (DbCommand cmd = factory.CreateCommand())
             {

                 cmd.Connection = con;
                 cmd.CommandText = procedimiento;
                 cmd.CommandType = CommandType.StoredProcedure;

                 DbParameter param = cmd.CreateParameter();
                 param.DbType = DbType.Int32;
                 param.ParameterName = "ID";
                 param.Value = id;

                 cmd.Parameters.Add(param);
                 con.Open();

                 using (DbDataReader dr = cmd.ExecuteReader())
                 {
                     if (dr.Read())
                     {
                         obj_act = new Cm_ClsActividad(id, (string)dr["NOMBRE"],(string)dr["ESTADO"],
                             (string)dr["DESCRIPCION"], (string)dr["FECHAINICIO"], (string)dr["FECHAFIN"]);

                     }
                 }

             }

         }
         return obj_act;
     }


     public int eliminarActividad(int id)
     {
            List<DbParameter> parametros = new List<DbParameter>();
            DbParameter param = factory.CreateParameter();
            param.Value = id;
            param.ParameterName = "ID";
            parametros.Add(param);
            return ejecutarProcedimientos("eliminarActividad", parametros);
      }
    }  
}


  