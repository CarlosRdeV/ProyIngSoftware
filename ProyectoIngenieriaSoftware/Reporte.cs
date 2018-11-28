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

        private void btnCuantos_Click(object sender, EventArgs e)
        {
            lblCuantos.Text=Metodos.cantidadInscritosCurso(txtIdCurso.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCuantos.Text = Metodos.cantidadInscritosCurso(txtIdCurso.Text);
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            lblPromedio.Text=Metodos.PromedioCurso(txtIdPromedio.Text);                
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Metodos.CalificacionesAlumno(txtCalificacionesId.Text);
            lblCurso1.Text=Metodos.curso1;
            lblCurso2.Text = Metodos.curso2;
            lblCurso3.Text = Metodos.curso3;
            lblCurso4.Text = Metodos.curso4;
            lblCurso5.Text = Metodos.curso5;

            lblCal1.Text = Metodos.cal1;
            lblCal2.Text = Metodos.cal2;
            lblCal3.Text = Metodos.cal3;
            lblCal4.Text = Metodos.cal4;
            lblCal5.Text = Metodos.cal5;

            Metodos.curso1 = "";
            Metodos.curso2 = "";
            Metodos.curso3 = "";
            Metodos.curso4 = "";
            Metodos.curso5 = "";

            Metodos.cal1 = "";
            Metodos.cal2 = "";
            Metodos.cal3 = "";
            Metodos.cal4 = "";
            Metodos.cal5 = "";


        }

        private void btnBuscarUpdate_Click(object sender, EventArgs e)
        {

        }

        private void lblCurso3_Click(object sender, EventArgs e)
        {

        }
    }
}
