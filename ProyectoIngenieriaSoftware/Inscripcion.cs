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
                Metodos.CrearCalificacion(txtIDalumnoInsc.Text, txtIDcursonsc.Text, "0");
                string nombreAl=Metodos.MostrarNombreAlumno(txtIDalumnoInsc.Text);
                string nombreCur = Metodos.MostrarNombreCurso(txtIDcursonsc.Text);

                MessageBox.Show("Se ha creado el siguiente Curso: " + "\nID Alumno: " + txtIDalumnoInsc.Text + "\nNombre del Alumno: "+nombreAl+"\nID Curso: "+txtIDcursonsc.Text+"\nNombre del Curso: "+nombreCur);

                txtIDalumnoInsc.Text = "";
                txtIDcursonsc.Text = "";
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
