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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCantidadAlumnos.Text = Metodos.cantidadInscritosCurso(txtIdCantidad.Text);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblPromedioCurso.Text = Metodos.PromedioCurso(txtIdPromedio.Text);
        }

        private void btnBuscarUpdate_Click(object sender, EventArgs e)
        {
            Metodos.CalificacionesAlumno(txtCalificacionMostrar.Text);
            lblcurso1.Text = Metodos.curso1;
            lblcurso2.Text = Metodos.curso2;
            lblcurso3.Text = Metodos.curso3;
            lblcurso4.Text = Metodos.curso4;
            lblcurso5.Text = Metodos.curso5;
            lblCal1.Text = Metodos.cal1;
            lblCal2.Text = Metodos.cal2;
            lblCal3.Text = Metodos.cal3;
            lblCal4.Text = Metodos.cal4;
            lblCal5.Text = Metodos.cal5;
            Metodos.curso1 = "--------";
            Metodos.curso2 = "--------";
            Metodos.curso3 = "--------";
            Metodos.curso4 = "--------";
            Metodos.curso5 = "--------";
            Metodos.cal1= "--------";
            Metodos.cal2 = "--------";
            Metodos.cal3 = "--------";
            Metodos.cal4 = "--------";
            Metodos.cal5 = "--------";
        }
    }
}
