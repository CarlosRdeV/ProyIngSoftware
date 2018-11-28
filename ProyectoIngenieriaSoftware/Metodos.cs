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
        //Alumno
        public static string nombre = "";
        public static string edad = "";
        public static string direccion = "";
        public static string correo = "";

        //Profesor

        public static string IdProfesor = "";
        public static string NombreProfesor = "";
        public static string CorreoProfesor = "";
        public static string TipoIdProfesor = "";

        //Curso

        public static string NombreCurso = "";
        public static string DuracionCurso = "";
        public static string HorarioCurso = "";
        public static string ProfesorCurso = "";


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

        //Alumno

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

        //Profesor
        public static void CrearProfesor(string nombre, string correo, string tipo)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                cmd.CommandText = "INSERT INTO PROFESORES (NOMBRE,CorreoElectronico,Tipo) VALUES ('" + nombre + "','" + correo + "','" + tipo + "')";
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

        public static void MostrarProfesor(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT Nombre,CorreoElectronico,Tipo FROM profesores WHERE Id=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //To do
                    //Crear nuevas variables, solo para profesor
                    //Cambiar

                    NombreProfesor = reader.GetValue(0).ToString();
                    CorreoProfesor = reader.GetValue(1).ToString();
                    TipoIdProfesor = reader.GetValue(2).ToString();
                }


                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }

        }

        public static void EliminarProfesor(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                cmd.CommandText = "DELETE FROM PROFESORES WHERE Id=" + id;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profesor Eliminado con exito");
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }

        }

        public static void ActualizarProfesor(string id, string nombre, string correo, string tipo)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                // "UPDATE Records SET FirstName = @firstname, LastName = @lastname, Age = @age, Address = @address, Course = @course WHERE FirstName = @firstname";
                //cmd.CommandText = "UPDATE ALUMNOS SET NOMBRE = (NOMBRE,DIRECCION,EDAD,CORREOELECTRONICO) VALUES ('" + nombre + "','" + direccion + "'," + edad + ",'" + correo + "')";
                cmd.CommandText = "UPDATE PROFESORES SET NOMBRE = '" + nombre + "' ,CORREOELECTRONICO = '" + correo + "' ,TIPO = '" + tipo + "' WHERE Id = " + id;
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

        //Curso
        public static void CrearCurso(string nombre, string duracion, string horario, string profesor)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                cmd.CommandText = "INSERT INTO CURSOS (NOMBRE,DURACION,HORARIO,PROFESOR) VALUES ('" + nombre + "','" + duracion + "','"+horario+"',"+profesor+")";
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

        public static void MostrarCurso(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT Nombre,Duracion,Horario,Profesor FROM cursos WHERE Id=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //To do
                    //Crear nuevas variables, solo para profesor
                    //Cambiar
                    NombreCurso = reader.GetValue(0).ToString();
                    DuracionCurso = reader.GetValue(1).ToString();
                    HorarioCurso = reader.GetValue(2).ToString();
                    ProfesorCurso = reader.GetValue(3).ToString();
                }


                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }

        }

        public static void EliminarCurso(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                cmd.CommandText = "DELETE FROM cursos WHERE Id=" + id;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso Eliminado con exito");
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }

        }

        public static void ActualizarCursos(string id, string nombre, string duracion, string horario, string profesor)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                // "UPDATE Records SET FirstName = @firstname, LastName = @lastname, Age = @age, Address = @address, Course = @course WHERE FirstName = @firstname";
                //cmd.CommandText = "UPDATE ALUMNOS SET NOMBRE = (NOMBRE,DIRECCION,EDAD,CORREOELECTRONICO) VALUES ('" + nombre + "','" + direccion + "'," + edad + ",'" + correo + "')";
                cmd.CommandText = "UPDATE CURSOS SET NOMBRE = '" + nombre + "' , DURACION = '" + duracion + "' , HORARIO = '" + horario + "' , PROFESOR = "+profesor+" WHERE Id = " + id;
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


        //Califiaciones
        public static void CrearCalificacion (string idAlumno, string idCurso, string calificacion)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                //              cmd.CommandText = "INSERT INTO CURSOS (NOMBRE,DURACION,HORARIO,PROFESOR) VALUES ('" + nombre + "','" + duracion + "','" + horario + "'," + profesor + ")";

                cmd.CommandText = "INSERT INTO CALIFICACIONES (IDALUMNO, IDCURSO, CALIFICACION) VALUES (" + idAlumno + "," + idCurso + "," + calificacion + ")";
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


    }
}
