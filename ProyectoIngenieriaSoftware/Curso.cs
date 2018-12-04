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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtProfesor.Text != "")
            {

                string duracion = cmbDuracion.Items[cmbDuracion.SelectedIndex].ToString();
                string horario = cmbHorario.Items[cmbHorario.SelectedIndex].ToString();

                Metodos.CrearCurso(txtNombre.Text, duracion, horario, txtProfesor.Text);


                string id = Metodos.MostrarUltimoCurso();

                MessageBox.Show("Se ha creado el siguiente Curso: \nId: " + id + "\nNombre: " + txtNombre.Text + "\nDuracion: " + duracion + " semanas\nHorario: " + horario + "\nProfesor: " + txtProfesor.Text);

                txtNombre.Text = "";
                txtProfesor.Text = "";

            }
            else {
                MessageBox.Show("Rellena todos los campos");
            }


            

            
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

        private void btnBuscarUpdate_Click(object sender, EventArgs e)
        {
            Metodos.MostrarCurso(txtUpdateId.Text);

            txtUpdateNombre.Text = Metodos.NombreCurso;
            txtUpdateDuracion.Text = Metodos.DuracionCurso;
            txtUpdateHorario.Text = Metodos.HorarioCurso;
            txtUpdateProfesor.Text = Metodos.ProfesorCurso;

            Metodos.NombreCurso = "";
            Metodos.DuracionCurso = "";
            Metodos.HorarioCurso= "";
            Metodos.ProfesorCurso= "";

            if (txtUpdateNombre.Text != "")
            {
                txtUpdateNombre.Enabled = true;
                txtUpdateDuracion.Enabled = true;
                txtUpdateHorario.Enabled = true;
                txtUpdateProfesor.Enabled = true;

            }
            else
            {

                txtUpdateNombre.Enabled = false;
                txtUpdateDuracion.Enabled = false;
                txtUpdateHorario.Enabled = false;
                txtUpdateProfesor.Enabled = false;

            }
        }

        private void btnModificarUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Los registros seran modificados, esta de acuerdo?",
                      "ALERTA", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    Metodos.ActualizarCursos(txtUpdateId.Text, txtUpdateNombre.Text, txtUpdateDuracion.Text, txtUpdateHorario.Text, txtUpdateProfesor.Text);
                    MessageBox.Show("El registro con id " + txtUpdateId.Text + " fue actualizado correctamente");

                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("El registros sera eliminado, esta de acuerdo?",
                      "ALERTA", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    Metodos.EliminarCurso(txtDeleteId.Text);
                    
                    MessageBox.Show("El registro con id " + txtDeleteId.Text + " fue eliminado correctamente");
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            cmbDuracion.SelectedIndex = 0;
            cmbHorario.SelectedIndex = 0;
            txtUpdateNombre.Enabled = false;
            txtUpdateDuracion.Enabled = false;
            txtUpdateHorario.Enabled = false;
            txtUpdateProfesor.Enabled = false;
            txtNombre.Text = "";
            txtProfesor.Text = "";
               
        }
    }
}
