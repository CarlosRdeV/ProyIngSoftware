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
    public partial class IngresoUsuario : Form
    {
        public IngresoUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            AlumnoUsuario au = new AlumnoUsuario();
            au.Show();
        }

        private void btnCrearProfe_Click(object sender, EventArgs e)
        {
            ProfesorUsuario profesorUsuario = new ProfesorUsuario();
            profesorUsuario.Show();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            CursoUsuario cursoUsuario = new CursoUsuario();
            cursoUsuario.Show();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            CalificacionUsuario calificacionUsuario = new CalificacionUsuario();
            calificacionUsuario.Show();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
