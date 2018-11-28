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
    public partial class IngresoAdmin : Form
    {
        public IngresoAdmin()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            al.Show();
        }

        private void btnCrearProfe_Click(object sender, EventArgs e)
        {
            Profesor pr = new Profesor();
            pr.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Show();
                   
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            Calificacion cal = new Calificacion();
            cal.Show();
        }
    }
}
