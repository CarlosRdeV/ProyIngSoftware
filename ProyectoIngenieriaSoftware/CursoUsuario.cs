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
    public partial class CursoUsuario : Form
    {
        public CursoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TRae los valores pero no los muestra en los label
            Metodos.MostrarCurso(txtIdMostrar.Text);
            lblNombre.Text = Metodos.NombreCurso;
            lblDuracion.Text = Metodos.DuracionCurso;
            lblHorario.Text = Metodos.HorarioCurso;
            lblProfesor.Text = Metodos.ProfesorCurso;

            Metodos.NombreCurso = "";
            Metodos.DuracionCurso = "";
            Metodos.HorarioCurso = "";
            Metodos.ProfesorCurso = "";
        }
    }
}
