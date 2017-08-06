﻿using System;
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

        public Cm_ClsUsuario login(string nombre, int password)
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
                    param2.DbType = DbType.Int32;
                    param2.ParameterName = "password";
                    param2.Value = password;
                    comando.Parameters.Add(param2);

                    conexion.Open();

                    using (DbDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            usuario = new Cm_ClsUsuario(
                                (string)lector["nombre"],
                                (int)lector["password"]);

                        }
                    }

                }

            }
            return usuario;
        }


    }


}