﻿using System;
using System.Data.OleDb;
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

        //CALIFICACIONES

        public static string IDALUMNO = "";
        public static string IDCURSO = "";
        public static string CALIFICACION = "";

        //Metodos

        public static string curso1 = "";
        public static string curso2 = "";
        public static string curso3 = "";
        public static string curso4 = "";
        public static string curso5 = "";
        public static string cal1 = "";
        public static string cal2 = "";
        public static string cal3 = "";
        public static string cal4 = "";
        public static string cal5 = "";

        public static string num1Mayor = "";
        public static string num2Mayor = "";
        public static string num3Mayor = "";
        public static string num4Mayor = "";
        public static string num5Mayor = "";

        public static string num1Menor = "";
        public static string num2Menor = "";
        public static string num3Menor = "";
        public static string num4Menor = "";
        public static string num5Menor = "";

        //Unidad
        public static string unidad ;
        
         
        public static OleDbConnection con;

        //Metodo de Conexion
        public static OleDbConnection Conectar()
        {
             string cad_con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + unidad + ":/ProyectoIngenieriaSoftware/Resources/escuela.mdb";
        
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

                cmd.CommandText = "INSERT INTO CURSOS (NOMBRE,DURACION,HORARIO,PROFESOR,ESTADO) VALUES ('" + nombre + "','" + duracion + "','"+horario+"',"+profesor+",'Pendiente')";
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

        public static void ActualizarEstadoCurso(string id, string estado)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                // "UPDATE Records SET FirstName = @firstname, LastName = @lastname, Age = @age, Address = @address, Course = @course WHERE FirstName = @firstname";
                //cmd.CommandText = "UPDATE ALUMNOS SET NOMBRE = (NOMBRE,DIRECCION,EDAD,CORREOELECTRONICO) VALUES ('" + nombre + "','" + direccion + "'," + edad + ",'" + correo + "')";
                cmd.CommandText = "UPDATE CURSOS SET ESTADO = '" + estado + "' WHERE Id = " + id;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Actualizo el estado del curso");
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }

        }


        //Calificaiones
        public static void CrearCalificacion (string idAlumno, string idCurso, string calificacion)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                //cmd.CommandText = "INSERT INTO CURSOS (NOMBRE,DURACION,HORARIO,PROFESOR) VALUES ('" + nombre + "','" + duracion + "','" + horario + "'," + profesor + ")";

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

        public static void MostrarCalificacion(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT IDALUMNO, IDCURSO, CALIFICACION FROM CALIFICACIONES WHERE Id=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //To do
                    //Crear nuevas variables, solo para profesor
                    //Cambiar
                    IDALUMNO = reader.GetValue(0).ToString();
                    IDCURSO = reader.GetValue(1).ToString();
                    CALIFICACION = reader.GetValue(2).ToString();
                    
                }


                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }

        }

        public static void EliminarCalificacion(string id)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;

                cmd.CommandText = "DELETE FROM CALIFICACIONES WHERE Id=" + id;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Calificacion Eliminada con exito");
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }

        }

        public static void ActualizarCalificacion(string id, string idalumno, string idcurso, string calificacion)
        {
            try
            {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                // "UPDATE Records SET FirstName = @firstname, LastName = @lastname, Age = @age, Address = @address, Course = @course WHERE FirstName = @firstname";
                //cmd.CommandText = "UPDATE ALUMNOS SET NOMBRE = (NOMBRE,DIRECCION,EDAD,CORREOELECTRONICO) VALUES ('" + nombre + "','" + direccion + "'," + edad + ",'" + correo + "')";
                cmd.CommandText = "UPDATE CALIFICACIONES SET IDALUMNO = " + idalumno + " , idcurso = " + idcurso+ " , calificacion = " + calificacion + " WHERE Id = " + id;
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

        //Reportes

        public static string cantidadInscritosCurso(string id)
        {
            try
            {
                int cuantos = 0;

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT * FROM CALIFICACIONES WHERE IdCurso=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //To do
                    //Crear nuevas variables, solo para profesor
                    //Cambiar
                    //IDALUMNO = reader.GetValue(0).ToString();
                    //IDCURSO = reader.GetValue(1).ToString();
                    //CALIFICACION = reader.GetValue(2).ToString();
                    cuantos++;
                }

                con.Close();

                return Convert.ToString(cuantos);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return "0";

            }

        }

        public static string PromedioCurso(string id)
        {
            try
            {
                int cuantos = 0;
                int sumaCal = 0;
                int promedio = 0;

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT calificacion FROM CALIFICACIONES WHERE IdCurso=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    if (Convert.ToInt32(reader.GetValue(0).ToString()) > 0)
                    {
                        cuantos++;
                        sumaCal = sumaCal + Convert.ToInt32(reader.GetValue(0).ToString());
                    }

                }
                con.Close();
                if (cuantos > 0)
                {
                    promedio = sumaCal / cuantos;
                }
                else
                {
                    promedio = 0;
                }

                return Convert.ToString(promedio);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return "0";

            }

        }

        public static void CalificacionesAlumno(string id)
        {
            try
            {
                int cuantos = 0;

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT IdCurso, calificacion FROM CALIFICACIONES WHERE IdAlumno=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cuantos++;

                    switch (cuantos)
                    {
                        case 1:

                            curso1 = reader.GetValue(0).ToString();
                            cal1 = reader.GetValue(1).ToString();

                            break;

                        case 2:

                            curso2 = reader.GetValue(0).ToString();
                            cal2 = reader.GetValue(1).ToString();

                            break;

                        case 3:

                            curso3 = reader.GetValue(0).ToString();
                            cal3 = reader.GetValue(1).ToString();

                            break;

                        case 4:

                            curso4 = reader.GetValue(0).ToString();
                            cal4 = reader.GetValue(1).ToString();

                            break;

                        case 5:

                            curso5 = reader.GetValue(0).ToString();
                            cal5 = reader.GetValue(1).ToString();

                            break;
                    }

                }
                con.Close();



            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }

        }

        public static void CursosMasSolicitados()
        {
            try
            {
                int cuantos = 0;

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT TOP 5 IdCurso, COUNT(*) FROM CALIFICACIONES GROUP BY IdCurso ORDER BY COUNT(*) DESC";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cuantos++;
                  //  MessageBox.Show(reader.GetValue(0).ToString()+" "+ reader.GetValue(1).ToString()) ;
                    switch (cuantos)
                    {
                        
                        case 1:

                            curso1 = reader.GetValue(0).ToString();
                            num1Mayor = reader.GetValue(1).ToString();

                            break;

                        case 2:

                            curso2 = reader.GetValue(0).ToString();
                            num2Mayor = reader.GetValue(1).ToString();

                            break;

                        case 3:

                            curso3 = reader.GetValue(0).ToString();
                            num3Mayor = reader.GetValue(1).ToString();

                            break;

                        case 4:

                            curso4 = reader.GetValue(0).ToString();
                            num4Mayor = reader.GetValue(1).ToString();

                            break;

                        case 5:

                            curso5 = reader.GetValue(0).ToString();
                            num5Mayor = reader.GetValue(1).ToString();

                            break;
                    }

                }
                con.Close();



            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }

        }

        public static void CursosMenosSolicitados()
        {
            try
            {
                int cuantos = 0;

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT TOP 5 IdCurso, COUNT(*) FROM CALIFICACIONES GROUP BY IdCurso ORDER BY COUNT(*) ASC";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cuantos++;
                    //MessageBox.Show(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
                    switch (cuantos)
                    {

                        case 1:

                            curso1 = reader.GetValue(0).ToString();
                            num1Menor = reader.GetValue(1).ToString();

                            break;

                        case 2:

                            curso2 = reader.GetValue(0).ToString();
                            num2Menor = reader.GetValue(1).ToString();

                            break;

                        case 3:

                            curso3 = reader.GetValue(0).ToString();
                            num3Menor = reader.GetValue(1).ToString();

                            break;

                        case 4:

                            curso4 = reader.GetValue(0).ToString();
                            num4Menor = reader.GetValue(1).ToString();

                            break;

                        case 5:

                            curso5 = reader.GetValue(0).ToString();
                            num5Menor = reader.GetValue(1).ToString();

                            break;
                    }

                }
                con.Close();



            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);


            }

        }

        public static string MostrarNombreCurso(string id)
        {
            try
            {
                string nombre="";

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT NOMBRE from CURSOS WHERE Id=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {                   
                    nombre = reader.GetValue(0).ToString();                   
                }
              
                con.Close();
                return nombre;
            }
            catch (System.Exception ex)
            {
               // MessageBox.Show("Error:" + ex.Message);
                return "" ;

            }

        }

        public static string MostrarNombreAlumno(string id)
        {
            try
            {
                string nombre = "";

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT NOMBRE from ALUMNOS WHERE Id=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombre = reader.GetValue(0).ToString();
                }

                con.Close();
                return nombre;
            }
            catch (System.Exception ex)
            {
                // MessageBox.Show("Error:" + ex.Message);
                return "";

            }

        }

        public static string MostrarNombreProfesor(string id)
        {
            try
            {
                string nombre = "";

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT NOMBRE from PROFESORES WHERE Id=" + id;
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombre = reader.GetValue(0).ToString();
                }

                con.Close();
                return nombre;
            }
            catch (System.Exception ex)
            {
                // MessageBox.Show("Error:" + ex.Message);
                return "";

            }

        }

        public static string MostrarUltimoAlumno()
        {
            try
            {
                string id ="";

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT TOP 1 ID FROM ALUMNOS ORDER BY ID DESC";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {                 
                 id = reader.GetValue(0).ToString();
                }
                con.Close();
                return id;


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return "";

            }

        }

        public static string MostrarUltimoProfesor()
        {
            try
            {
                string id = "";

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT TOP 1 ID FROM Profesores ORDER BY ID DESC";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                }
                con.Close();
                return id;


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return "";

            }

        }

        public static string MostrarUltimoCurso()
        {
            try
            {
                string id = "";

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT TOP 1 ID FROM CURSOS ORDER BY ID DESC";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                }
                con.Close();
                return id;


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return "";

            }

        }

        public static string MostrarUltimoCalificacion()
        {
            try
            {
                string id = "";

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT TOP 1 ID FROM CALIFICACIONES ORDER BY ID DESC";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetValue(0).ToString();
                }
                con.Close();
                return id;


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return "";

            }

        }

        public static int MaxProfesor(string id)
        {
            try
            {
                string numero = "";
                int cuantos = 0;
                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT Profesor FROM cursos";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //To do
                    //Crear nuevas variables, solo para profesor
                    //Cambiar
                    numero = reader.GetValue(0).ToString();
                    if (numero == id) {
                        cuantos++;
                    }
                }
                con.Close();
                return cuantos;
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return 0;

            }
        }

        public static int MaxAlumno(string id)
        {
            try
            {
                string numero = "";
                int cuantos = 0;
                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = ole;
                cmd.CommandText = "SELECT IDALUMNO FROM calificaciones";
                con.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //To do
                    //Crear nuevas variables, solo para profesor
                    //Cambiar
                    numero = reader.GetValue(0).ToString();
                    if (numero == id)
                    {
                        cuantos++;
                    }
                }
                con.Close();
                return cuantos;
            }

            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return 0;

            }
        }

    }


}

