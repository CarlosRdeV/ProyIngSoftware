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
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void Profesor_Load(object sender, EventArgs e)
        {
            cmbCorreo.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.Items[cmbTipo.SelectedIndex].ToString();

            string seleccion = cmbCorreo.Items[cmbCorreo.SelectedIndex].ToString();

            string correo = txtCorreo.Text + seleccion;

            Metodos.CrearProfesor(txtNombre.Text,correo, tipo);

            txtNombre.Text = "";
            txtCorreo.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TRae los valores pero no los muestra en los label
            Metodos.MostrarProfesor(txtIdMostrar.Text);

            lblNombre.Text = Metodos.NombreProfesor;
            lblCorreo.Text = Metodos.CorreoProfesor;
            lblTipo.Text = Metodos.TipoIdProfesor;
        }

        private void btnBuscarUpdate_Click(object sender, EventArgs e)
        {
            //TRae los valores pero no los muestra en los label
            Metodos.MostrarProfesor(txtUpdateId.Text);

            txtUpdateNombre.Text = Metodos.NombreProfesor;
            txtUpdateCorreo.Text = Metodos.CorreoProfesor;
            txtUpdateTipo.Text = Metodos.TipoIdProfesor;
        }

        private void btnModificarUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Los registros seran modificados, esta de acuerdo?",
                      "ALERTA", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:

  
                    Metodos.ActualizarProfesor(txtUpdateId.Text, txtUpdateNombre.Text, txtUpdateCorreo.Text, txtUpdateTipo.Text);
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
                    Metodos.EliminarProfesor(txtDeleteId.Text);
                    
                    MessageBox.Show("El registro con id " + txtDeleteId.Text + " fue eliminado correctamente");
                    break;

                case DialogResult.No:
                    break;
            }
        }
    }
}
