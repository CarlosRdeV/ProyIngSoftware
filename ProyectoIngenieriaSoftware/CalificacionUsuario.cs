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
    public partial class CalificacionUsuario : Form
    {
        public CalificacionUsuario()
        {
            InitializeComponent();
        }

        private void CalificacionUsuario_Load(object sender, EventArgs e)
        {
            cmbUpdateCal.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metodos.MostrarCalificacion(txtIdMostrar.Text);
            lblIDalumno.Text = Metodos.IDALUMNO;
            lblIDcurso.Text = Metodos.IDCURSO;
            lblCalificacion.Text = Metodos.CALIFICACION;
        }

        private void btnBuscarUpdate_Click(object sender, EventArgs e)
        {
            Metodos.MostrarCalificacion(txtUpdateId.Text);
            txtUpdateIDalumno.Text = Metodos.IDALUMNO;
            txtUpdateIDcurso.Text = Metodos.IDCURSO;
            string cal = Metodos.CALIFICACION;
            lblCalAsig.Text = "Calificación asignada: " + cal;

            Metodos.IDALUMNO = "";
            Metodos.IDCURSO = "";
            Metodos.CALIFICACION = "";
        }

        private void btnModificarUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Los registros seran modificados, esta de acuerdo?",
                      "ALERTA", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:

                    string nuevaCal = cmbUpdateCal.Items[cmbUpdateCal.SelectedIndex].ToString();
                    Metodos.ActualizarCalificacion(txtUpdateId.Text, txtUpdateIDalumno.Text, txtUpdateIDcurso.Text, nuevaCal);
                    MessageBox.Show("El registro con id " + txtUpdateId.Text + " fue actualizado correctamente");

                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
