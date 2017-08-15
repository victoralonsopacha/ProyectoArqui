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
        public List<Cm_ClsTarea> listarTareas()
        {

            List<Cm_ClsTarea> tareas = new List<Cm_ClsTarea>();
            string nombreProcedimiento = "consultarTarea";
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
                        while (lector.Read())
                        {
                            tareas.Add(new Cm_ClsTarea(
                                (int)lector["ID"],
                                (int)lector["ACT_ID"],
                                (string)lector["NOMBRE"],
                                (string)lector["ESTADO"],
                                (string)lector["FECHAINICIO"],
                                (string)lector["FECHAFIN"]
                                ));
                        }
                    }
                }
            }
            return tareas;
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
                         obj_act = new Cm_ClsActividad((int)dr["ID"], (string)dr["NOMBRE"], (string)dr["ESTADO"],
                             (string)dr["DESCRIPCION"], (string)dr["FECHAINICIO"], (string)dr["FECHAFIN"]);

                     }
                 }

             }

         }
         return obj_act;
     }

         public int eliminarTarea(int id)
         {
             List<DbParameter> parametros = new List<DbParameter>();
             DbParameter param = factory.CreateParameter();
             param.Value = id;
             param.ParameterName = "ID";
             parametros.Add(param);
             return ejecutarProcedimientos("eliminarTarea", parametros);
         }

         public Cm_ClsTarea listarTareaPorId(int id)
         {

             Cm_ClsTarea obj_proy = new Cm_ClsTarea();

             string procedimiento = "consultarTareaPorId";

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
                             obj_proy = new Cm_ClsTarea(id,  (string)dr["NOMBRE"],
                                 (string)dr["ESTADO"], (string)dr["FECHAINICIO"], (string)dr["FECHAFIN"]);

                         }
                     }

                 }

             }
             return obj_proy;
         }
    }
}