using ProyectoIngenieriaSoftware.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIngenieriaSoftware
{
    public partial class Inscripcion : Form
    {
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void btnInscrip_Click(object sender, EventArgs e)
        {
            if (txtIDalumnoInsc.Text != "" && txtIDcursonsc.Text != "")
            {
                int cantidad = Convert.ToInt32(Metodos.cantidadInscritosCurso(txtIDcursonsc.Text));
                int bandera = 0;
                // 0 = No dejar incribir y si es 1 = Dejar inscribir

                if (cantidad >= 0 && cantidad < 9)
                {
                    //ESTADO = Pendiente
                    Metodos.ActualizarEstadoCurso(txtIDcursonsc.Text,"Pendiente");
                    bandera = 1;
                }
                else if (cantidad > 8 && cantidad < 19)
                {
                    //ESTADO = Disponible
                    Metodos.ActualizarEstadoCurso(txtIDcursonsc.Text, "Disponible");
                    bandera = 1;
                }
                else if (cantidad == 19)
                {
                    //ESTADO = CERRADO
                    Metodos.ActualizarEstadoCurso(txtIDcursonsc.Text, "Cerrado");
                    bandera = 1;
                }
                else {
                    MessageBox.Show("El curso deseado se encuentra Cerrado");
                    bandera = 0;
                    //No dejas inscribir

                }

                if (bandera == 1) {

                    int cuantos = Metodos.MaxAlumno(txtIDalumnoInsc.Text);

                    if (cuantos <= 4)
                    {
                        Metodos.CrearCalificacion(txtIDalumnoInsc.Text, txtIDcursonsc.Text, "0");
                        string nombreAl = Metodos.MostrarNombreAlumno(txtIDalumnoInsc.Text);
                        string nombreCur = Metodos.MostrarNombreCurso(txtIDcursonsc.Text);

                        string id = Metodos.MostrarUltimoCalificacion();

                        MessageBox.Show("Se ha realizado la siguiente Inscripcion: " + "\nID Calificacion: " + id + "\nID Alumno: " + txtIDalumnoInsc.Text + "\nNombre del Alumno: " + nombreAl + "\nID Curso: " + txtIDcursonsc.Text + "\nNombre del Curso: " + nombreCur);

                        txtIDalumnoInsc.Text = "";
                        txtIDcursonsc.Text = "";

                    }
                    else {
                        MessageBox.Show("El Alumno no puede estar inscrito en mas de 5 cursos al mismo tiempo");
                    }

                    
                }
                
            }
            else
            {
                MessageBox.Show("Rellena todos los campos");
            }
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            txtIDalumnoInsc.Text = "";
            txtIDcursonsc.Text = "";
                
        }
    }
}
