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
    public class Dt_ClsUsuario
    {
        public Dt_ClsUsuario() { }

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

        public Cm_ClsUsuario login(string nombre, string contraseña)
        {
            Cm_ClsUsuario usuario = new Cm_ClsUsuario();
            string PROYECTO_PRINCIPAL = "LOGINUSUARIO";
            using (DbConnection conexion = factory.CreateConnection())
            {
                conexion.ConnectionString = cadena;
                using (DbCommand comando = factory.CreateCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = PROYECTO_PRINCIPAL;
                    comando.CommandType = CommandType.StoredProcedure;


                    DbParameter param1 = comando.CreateParameter();
                    param1.DbType = DbType.String;
                    param1.ParameterName = "nombre";
                    param1.Value = nombre;
                    comando.Parameters.Add(param1);

                    DbParameter param2 = comando.CreateParameter();
                    param2.DbType = DbType.String;
                    param2.ParameterName = "contraseña";
                    param2.Value = contraseña;
                    comando.Parameters.Add(param2);

                    conexion.Open();

                    using (DbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            usuario = new Cm_ClsUsuario(
                                (string)lector["nombre"],
                                (string)lector["contraseña"],
                                (int)lector["cedula"]);

                        }
                    }

                }

            }
            return usuario;
        }


        public Cm_ClsUsuario registrarUsuario(int cedula, string nombre, string contraseña,string correo )
        {
            Cm_ClsUsuario usuario = new Cm_ClsUsuario();
            string PROYECTO_PRINCIPAL = "registrarUsuario";
            using (DbConnection conexion = factory.CreateConnection())
            {
                conexion.ConnectionString = cadena;
                using (DbCommand comando = factory.CreateCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = PROYECTO_PRINCIPAL;
                    comando.CommandType = CommandType.StoredProcedure;

                    DbParameter param1 = comando.CreateParameter();
                    param1.DbType = DbType.Int32;
                    param1.ParameterName = "cedula";
                    param1.Value = cedula;
                    comando.Parameters.Add(param1);

                    DbParameter param2 = comando.CreateParameter();
                    param2.DbType = DbType.String;
                    param2.ParameterName = "nombre";
                    param2.Value = nombre;
                    comando.Parameters.Add(param2);

                    DbParameter param3 = comando.CreateParameter();
                    param3.DbType = DbType.String;
                    param3.ParameterName = "contraseña";
                    param3.Value = contraseña;
                    comando.Parameters.Add(param3);

                    DbParameter param4 = comando.CreateParameter();
                    param4.DbType = DbType.String;
                    param4.ParameterName = "correo";
                    param4.Value = correo;
                    comando.Parameters.Add(param4);

                    conexion.Open();

                    using (DbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            usuario = new Cm_ClsUsuario(
                                (int)lector["cedula"],
                                (string)lector["nombre"],
                                (string)lector["contraseña"],
                                (string)lector["correo"]
                            );
                                
                        }
                    }

                }

            }
            return usuario;
        }

        public Cm_ClsUsuario buscarUsuario(int cedula)
        {
            Cm_ClsUsuario usuario = new Cm_ClsUsuario();
            string PROYECTO_PRINCIPAL = "buscarUsuario";
            using (DbConnection conexion = factory.CreateConnection())
            {
                conexion.ConnectionString = cadena;
                using (DbCommand comando = factory.CreateCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = PROYECTO_PRINCIPAL;
                    comando.CommandType = CommandType.StoredProcedure;


                    DbParameter param1 = comando.CreateParameter();
                    param1.DbType = DbType.Int32;
                    param1.ParameterName = "cedula";
                    param1.Value = cedula;
                    comando.Parameters.Add(param1);

                    conexion.Open();

                    using (DbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            usuario = new Cm_ClsUsuario(
                                (int)lector["cedula"],
                                (string)lector["nombre"],
                                (string)lector["contraseña"],
                                (string)lector["correo"]
                                );
                        }
                    }
                }
            }
            return usuario;
        }

        public int actualizarUsuario(int cedula, string nombre, string contraseña, string correo)
        {
            List<DbParameter> parametros = new List<DbParameter>();

            DbParameter param0 = factory.CreateParameter();
            param0.Value = cedula;
            param0.ParameterName = "cedula";
            parametros.Add(param0);

            DbParameter param = factory.CreateParameter();
            param.Value = nombre;
            param.ParameterName = "nombre";
            parametros.Add(param);

            DbParameter param1 = factory.CreateParameter();
            param1.Value = contraseña;
            param1.ParameterName = "contraseña";
            parametros.Add(param1);

            DbParameter param2 = factory.CreateParameter();
            param2.Value = correo;
            param2.ParameterName = "correo";
            parametros.Add(param2);

            return ejecutarProcedimientos("actualizarUsuario", parametros);

        }



    }


}