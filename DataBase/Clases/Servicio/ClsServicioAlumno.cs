using DataBase.Clases.CapaDatos;
using DataBase.Clases.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Clases.Servicio
{
    public class ClsServicioAlumno
    {
        ClsConexion cone = new ClsConexion();
        static void Main(string[] args) { }//Colocado para resolver el error CS5001

        public void lee(string instruccion)
        {
            DataTable respuesta = cone.ConsultaTablaDirecta(instruccion);

            foreach (DataRow dr in respuesta.Rows)
            {
                Console.WriteLine($"Carnet={dr["carnet"]} Nombre={dr["nombre"]} Seccion={dr["seccion"]} P1={dr["parcial1"]}");
            }
        }

        public DataTable ConsultaSQL(string instruccion)
        {
            DataTable respuesta = cone.ConsultaTablaDirecta(instruccion);
            return respuesta;
        }

        public int CrearAlumno(MdAlumnos alu)
        {
           
                string instruccion = $"insert into tb_alumnos (carnet,nombre,correo,clase,seccion,parcial1,parcial2,parcial3) values('{alu.carnet}','{alu.nombre}','{alu.correo}','{alu.clase}','{alu.seccion}','{alu.parcial1}','{alu.parcial2}','{alu.parcial3}')";
                return cone.EjecutarSQLDirecto(instruccion);
            
           
                
        }

        public MdAlumnos ObtenerAlumno(string carnet)
        {

            MdAlumnos alu = new MdAlumnos();

            DataTable resp = cone.ConsultaTablaDirecta($"select * from tb_alumnos where carnet ='{carnet}'");
            if (resp.Rows.Count > 0)
            {   
               
                foreach (DataRow item in resp.Rows)
                {
                    alu.idAlumno = Convert.ToInt32(item["idAlumno"]);
                    alu.carnet = item["carnet"].ToString();
                    alu.nombre = item["nombre"].ToString();
                    alu.seccion = item["seccion"].ToString();
                    alu.clase = item["clase"].ToString();
                    alu.correo = item["correo"].ToString();
                    alu.parcial1 = Convert.ToInt32(item["parcial1"]);
                    alu.parcial2 = Convert.ToInt32(item["parcial2"]);
                    alu.parcial3 = Convert.ToInt32(item["parcial3"]);

                }
                return alu;
            }
            else
            {
                return null;
            }
        }

        public int actualizarAlumno(MdAlumnos alu)
        {
            string instruccion = $"update tb_alumnos set nombre = '{alu.nombre}', correo = '{alu.correo}', clase = '{alu.clase}', seccion= '{alu.seccion}', parcial1= {alu.parcial1}, parcial2= {alu.parcial2}, parcial3= {alu.parcial3} where carnet='{alu.carnet}'";
            return cone.EjecutarSQLDirecto(instruccion);
        }

        

        public int BorrarAlumno(MdAlumnos alu)
        {
            string instruccion = $"delete from tb_alumnos where carnet = '{alu.carnet}'";
            return cone.EjecutarSQLDirecto(instruccion);

        }
    }
}
