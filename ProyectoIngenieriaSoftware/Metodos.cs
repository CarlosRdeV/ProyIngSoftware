using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIngenieriaSoftware.Recursos
{
    public class Metodos
    {
        public static string nombre = "";
        public static string edad = "";
        public static string direccion = "";
        public static string correo = "";


        public static string cad_con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\ProyectoIngenieriaSoftware\Recursos\escuela.mdb";
        public static OleDbConnection con;

        //Metodo de Conexion
        public static OleDbConnection Conectar()
        {
            try
            {
                con = new OleDbConnection(cad_con);
               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            return con;
        }


       


        public static void CrearAlumno(string nombre, string direccion, string edad, string correo)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();
                
                cmd.Connection = ole;

                cmd.CommandText = "INSERT INTO ALUMNOS (NOMBRE,DIRECCION,EDAD,CORREOELECTRONICO) VALUES ('"+nombre+"','"+direccion+"',"+edad+",'"+correo+"')";
               con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Creado con exito");
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            
        }

        public static  void MostrarAlumno(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT Nombre,Direccion,Edad,CorreoElectronico FROM Alumnos WHERE Id="+id;
                con.Open();
                
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    nombre = reader.GetValue(0).ToString();
                    direccion = reader.GetValue(1).ToString();
                    edad = reader.GetValue(2).ToString();
                    correo = reader.GetValue(3).ToString();                  
                }
                      
             
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }

        }

        public static void EliminarAlumno(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                cmd.CommandText = "DELETE FROM ALUMNOS WHERE Id="+id;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alumno Eliminado con exito");
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }

        }

        public static void ActualizarAlumno(string id,string nombre, string direccion, string edad, string correo)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                // "UPDATE Records SET FirstName = @firstname, LastName = @lastname, Age = @age, Address = @address, Course = @course WHERE FirstName = @firstname";
                //cmd.CommandText = "UPDATE ALUMNOS SET NOMBRE = (NOMBRE,DIRECCION,EDAD,CORREOELECTRONICO) VALUES ('" + nombre + "','" + direccion + "'," + edad + ",'" + correo + "')";
                cmd.CommandText = "UPDATE ALUMNOS SET NOMBRE = '"+nombre+ "' ,DIRECCION = '" + direccion + "' ,EDAD = " + edad + " ,CORREOELECTRONICO = '" + correo + "' WHERE Id = "+id;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado con exito");
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }

        }


    }
}
