using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Clases.CapaDatos
{
    
     public class ClsConexion
     {
            private string NombreServidor = "";
            private string NombreBaseDatos = "";
            private string UserBaseDatos = "";
            private string Password = "";

            public SqlConnection Conexion;
            private string CadenaConexion  { get; }

            public ClsConexion()
            {
                CadenaConexion= $"Server = {NombreServidor}; Database = {NombreBaseDatos}; User Id = {UserBaseDatos}; Password = {Password}";
               
            }

           
            public DataTable ConsultaTablaDirecta(String sqll)
            {
                 using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                 {
                     try
                     {
                    conexion.Open();
                    SqlDataReader dr;
                    SqlCommand cmd = new SqlCommand(sqll, conexion);
                    dr = cmd.ExecuteReader();

                    var dataTable = new DataTable();
                    dataTable.Load(dr);
                    return dataTable;

                     }
                     catch (Exception ex)
                     {
                    Console.WriteLine("ups error=" + ex.Message);
                    return null;
                     }
                 }
            }

        public int EjecutarSQLDirecto(string sqll)
        {

            int status = -1;
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {

                try
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(sqll, conexion);
                    status = cmd.ExecuteNonQuery();
                    return status;

                }
                catch (Exception ex)
                {

                    return status;
                }
            }

        }





     }





    
}

