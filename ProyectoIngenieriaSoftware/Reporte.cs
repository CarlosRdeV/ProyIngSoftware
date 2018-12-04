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

        private void btnRating_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRatingMayor_Click(object sender, EventArgs e)
        {
            Metodos.CursosMasSolicitados();
            lblIdCursoMayor1.Text = Metodos.curso1;
            lblIdCursoMayor2.Text = Metodos.curso2;
            lblIdCursoMayor3.Text = Metodos.curso3;
            lblIdCursoMayor4.Text = Metodos.curso4;
            lblIdCursoMayor5.Text = Metodos.curso5;
            lblCantidadCursoMayor1.Text = Metodos.num1Mayor;
            lblCantidadCursoMayor2.Text = Metodos.num2Mayor;
            lblCantidadCursoMayor3.Text = Metodos.num3Mayor;
            lblCantidadCursoMayor4.Text = Metodos.num4Mayor;
            lblCantidadCursoMayor5.Text = Metodos.num5Mayor;

            lblNombreCursoMayor1.Text = Metodos.MostrarNombreCurso(lblIdCursoMayor1.Text);
            lblNombreCursoMayor2.Text = Metodos.MostrarNombreCurso(lblIdCursoMayor2.Text);
            lblNombreCursoMayor3.Text = Metodos.MostrarNombreCurso(lblIdCursoMayor3.Text);
            lblNombreCursoMayor4.Text = Metodos.MostrarNombreCurso(lblIdCursoMayor4.Text);
            lblNombreCursoMayor5.Text = Metodos.MostrarNombreCurso(lblIdCursoMayor5.Text);

            Metodos.curso1 = "";
            Metodos.curso2 = "";
            Metodos.curso3 = "";
            Metodos.curso4 = "";
            Metodos.curso5 = "";
            Metodos.num1Mayor = "";
            Metodos.num2Mayor = "";
            Metodos.num3Mayor = "";
            Metodos.num4Mayor = "";
            Metodos.num5Mayor = "";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Metodos.CursosMenosSolicitados();
            lblIdCursoMenor1.Text = Metodos.curso1;
            lblIdCursoMenor2.Text = Metodos.curso2;
            lblIdCursoMenor3.Text = Metodos.curso3;
            lblIdCursoMenor4.Text = Metodos.curso4;
            lblIdCursoMenor5.Text = Metodos.curso5;
            lblCantidadCursoMenor1.Text = Metodos.num1Menor;
            lblCantidadCursoMenor2.Text = Metodos.num2Menor;
            lblCantidadCursoMenor3.Text = Metodos.num3Menor;
            lblCantidadCursoMenor4.Text = Metodos.num4Menor;
            lblCantidadCursoMenor5.Text = Metodos.num5Menor;

            lblNombreCursoMenor1.Text = Metodos.MostrarNombreCurso(lblIdCursoMenor1.Text);
            lblNombreCursoMenor2.Text = Metodos.MostrarNombreCurso(lblIdCursoMenor2.Text);
            lblNombreCursoMenor3.Text = Metodos.MostrarNombreCurso(lblIdCursoMenor3.Text);
            lblNombreCursoMenor4.Text = Metodos.MostrarNombreCurso(lblIdCursoMenor4.Text);
            lblNombreCursoMenor5.Text = Metodos.MostrarNombreCurso(lblIdCursoMenor5.Text);

            Metodos.curso1 = "";
            Metodos.curso2 = "";
            Metodos.curso3 = "";
            Metodos.curso4 = "";
            Metodos.curso5 = "";
            Metodos.num1Menor = "";
            Metodos.num2Menor = "";
            Metodos.num3Menor = "";
            Metodos.num4Menor = "";
            Metodos.num5Menor = "";
        }
    }
}
