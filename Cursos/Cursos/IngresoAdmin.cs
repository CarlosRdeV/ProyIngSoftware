using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursos
{
    public partial class IngresoAdmin : Form
    {
        public IngresoAdmin()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            CrearAlumno crearAlumno = new CrearAlumno();
            crearAlumno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            MostrarUnAlumno mostrarUnAlumno = new MostrarUnAlumno();
            mostrarUnAlumno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            MostrarAlumnos mostrarAlumnos = new MostrarAlumnos();
            mostrarAlumnos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            BorrarAlumno borrarAlumno = new BorrarAlumno();
            borrarAlumno.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            ModificarAlumno modificarAlumno = new ModificarAlumno();
            modificarAlumno.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
            CrearProfesor crearProfesor = new CrearProfesor();
            crearProfesor.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
            MostrarUnProfesor mostrarUnProfesor = new MostrarUnProfesor();
            mostrarUnProfesor.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
            MostrarProfesores mostrarProfesores = new MostrarProfesores();
            mostrarProfesores.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
            BorrarProfesor borrarProfesor = new BorrarProfesor();
            borrarProfesor.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            ModificarProfesor modificarProfesor = new ModificarProfesor();
            modificarProfesor.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();
            CrearCurso crearCurso = new CrearCurso();
            crearCurso.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
            BorrarCurso borrarCurso = new BorrarCurso();
            borrarCurso.Show();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
            ModificarCurso modificarCurso = new ModificarCurso();
            modificarCurso.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
            MostrarUnCurso mostrarUnCurso = new MostrarUnCurso();
            mostrarUnCurso.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
            MostrarCursos mostrarCursos = new MostrarCursos();
            mostrarCursos.Show();
        }
    }
}
