using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Prueba2
{
    internal class D_Usuarios
    {
        public DataTable Listado_cl(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "Select Usuarios.userId, Nombres, Paterno, Materno, Sueldo, FechaIngreso " +
                                   "FROM usuarios "+
                                   "INNER JOIN empleados ON usuarios.userId = empleados.userId "+
                                   "where Nombres like '"+cTexto+"' "+
                                   "ORDER BY usuarios.userId DESC limit 10"
                ;


                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }



        public string Guardar_ar(int nOpcion, P_Usuarios oAr)
        {
            string Rpta = "";
            string Sqltarea = "";
            //string Sqltarea2 = "";
            MySqlConnection SqlCon = new MySqlConnection();
            MySqlConnection SqlCon2 = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();

                Console.WriteLine(nOpcion);

                if (nOpcion == 1)  //Nuevo Registro
                {
                    Sqltarea = "Insert into usuarios (Nombres, Paterno, Materno )"+
                                                                        "values('"+oAr.Nombre+"', " +
                                                                                "'"+oAr.Paterno+"', " +
                                                                                "'" + oAr.Materno+"'); "+ 
                                                                                " Insert into empleados (Sueldo, FechaIngreso )"+
                                                                                "values('" + oAr.sueldo + "', " +
                                                                                "'" + oAr.FechaIngreso + "');";
                }
                else //Actualizar Registro 
                {
                   Sqltarea = "update empleados set sueldo ='"+oAr.sueldo+"'" +
                              "where userId IN (Select userId from usuarios where userId = '"+oAr.userId+"')";
                }
                Console.WriteLine(Sqltarea);
               
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
               
            }
            return Rpta;
        }
    }
}
