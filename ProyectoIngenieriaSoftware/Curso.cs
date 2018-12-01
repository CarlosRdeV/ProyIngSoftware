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
            try
            {
                string duracion = cmbDuracion.Items[cmbDuracion.SelectedIndex].ToString();
                string horario = cmbHorario.Items[cmbHorario.SelectedIndex].ToString();

                Metodos.CrearCurso(txtNombre.Text, duracion, horario, txtProfesor.Text);

                MessageBox.Show("Se ha creado el siguiente curso: \nId: " + Metodos.idCursoUltimo + "\nNombre: " + txtNombre.Text + " \nDuracion: " + duracion + " semanas \nHorario: " + horario + " \nId del Profesor: " + txtProfesor.Text);

                txtNombre.Text = "";
                txtProfesor.Text = "";

                Metodos.idCursoUltimo = "";
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }

            //
           

            
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
                txtUpdateHorario.Enabled = true;
                txtUpdateDuracion.Enabled = true;
                txtUpdateProfesor.Enabled = true;

                btnModificarUpdate.Enabled = false;

            }
            else
            {

                txtUpdateNombre.Enabled = false;
                txtUpdateHorario.Enabled = false;
                txtUpdateDuracion.Enabled = false;
                txtUpdateProfesor.Enabled = false;

                btnModificarUpdate.Enabled = false;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            cmbHorario.SelectedIndex = 0;
            cmbDuracion.SelectedIndex = 0;

            txtUpdateNombre.Enabled = false;
            txtUpdateHorario.Enabled = false;
            txtUpdateDuracion.Enabled = false;
            txtUpdateProfesor.Enabled = false;

            btnModificarUpdate.Enabled = false;

        }
    }
}
