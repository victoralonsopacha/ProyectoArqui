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
    public class Dt_ClsProyecto
    {
        public Dt_ClsProyecto() { }

        public static string cadena
        {
            get { return ConfigurationManager.ConnectionStrings["conProy"].ConnectionString; }
        }

        public static string provider
        {
            get { return ConfigurationManager.ConnectionStrings["conProy"].ProviderName; }
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
                using (DbConnection conexion = factory.CreateConnection()) {
                    conexion.ConnectionString = cadena;
                    using(DbCommand comando = factory.CreateCommand()){
                        comando.Connection = conexion;
                        comando.CommandText = nombreProcedimiento;
                        comando.CommandType = CommandType.StoredProcedure; 

                        foreach(DbParameter param in parametros){
                            comando.Parameters.Add(param);
                        }

                        conexion.Open();
                        id = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) {
                throw;
            }

            return id;
        }

        public List<Cm_ClsProyecto> listarProyectos()
        {

            List<Cm_ClsProyecto> proyectos = new List<Cm_ClsProyecto>();
            string nombreProcedimiento = "consultarProyectos";
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
                            proyectos.Add(new Cm_ClsProyecto(
                                (int)lector["ID"],
                                (string)lector["NOMBRE"],
                                (string)lector["DESCRIPCION"],
                                (string)lector["PROGRESO"]
                                ));
                        }
                    }
                }
            }
            return proyectos;
        } 

        public int insertarProyecto(string nombre, string descr, string progreso)
        {

            List<DbParameter> parametros = new List<DbParameter>();

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

            return ejecutarProcedimientos("insertarProyecto", parametros);
        
        } 


     public int actualizarProyecto(int id, string nombre, string descr, string progreso)
        {
            List<DbParameter> parametros = new List<DbParameter>();

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
            
        }


     public Cm_ClsProyecto listarProyectoPorId(int id)
     {

         Cm_ClsProyecto obj_proy = new Cm_ClsProyecto();

         string procedimiento = "consultarProyectoPorID";

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
                         obj_proy = new Cm_ClsProyecto(id, (string)dr["NOMBRE"], 
                             (string)dr["DESCRIPCION"], (string)dr["PROGRESO"]);

                     }
                 }

             }

         }
         return obj_proy;
     }


     public int eliminarProyecto(int id)
     {
            List<DbParameter> parametros = new List<DbParameter>();
            DbParameter param = factory.CreateParameter();
            param.Value = id;
            param.ParameterName = "ID";
            parametros.Add(param);
            return ejecutarProcedimientos("eliminarProyecto", parametros);
      }
    }  
}
