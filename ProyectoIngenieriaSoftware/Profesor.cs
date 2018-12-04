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
            txtUpdateNombre.Enabled = false;
            txtUpdateTipo.Enabled = false;
            txtUpdateCorreo.Enabled = false;
            btnModificarUpdate.Enabled = false;

            txtNombre.Text = "";
            txtCorreo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtCorreo.Text != "")
            {
                string tipo = cmbTipo.Items[cmbTipo.SelectedIndex].ToString();

                string seleccion = cmbCorreo.Items[cmbCorreo.SelectedIndex].ToString();

                string correo = txtCorreo.Text + seleccion;

                Metodos.CrearProfesor(txtNombre.Text, correo, tipo);

                string id = Metodos.MostrarUltimoProfesor();

                MessageBox.Show("Se ha creado el siguiente Profesor: \nId: " + id + "\nNombre: " + txtNombre.Text + "\nCorreo Electronico: " + correo + "\nTipo: " + tipo);

                txtNombre.Text = "";
                txtCorreo.Text = "";
            }
            else {
                
                MessageBox.Show("Rellena todos los campos");
            }

            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Metodos.MostrarProfesor(txtIdMostrar.Text);

            lblNombre.Text = Metodos.NombreProfesor;
            lblCorreo.Text = Metodos.CorreoProfesor;
            lblTipo.Text = Metodos.TipoIdProfesor;

            Metodos.NombreProfesor = "";
            Metodos.CorreoProfesor = "";
            Metodos.TipoIdProfesor = "";
        }

        private void btnBuscarUpdate_Click(object sender, EventArgs e)
        {
            
            Metodos.MostrarProfesor(txtUpdateId.Text);

            txtUpdateNombre.Text = Metodos.NombreProfesor;
            txtUpdateCorreo.Text = Metodos.CorreoProfesor;
            txtUpdateTipo.Text = Metodos.TipoIdProfesor;

            Metodos.NombreProfesor = "";
            Metodos.CorreoProfesor = "";
            Metodos.TipoIdProfesor = "";

            if (txtUpdateNombre.Text != "")
            {
                txtUpdateNombre.Enabled = true;
                txtUpdateCorreo.Enabled = true;
                txtUpdateTipo.Enabled = true;
                btnModificarUpdate.Enabled = true;

            }
            else
            {

                txtUpdateNombre.Enabled = false;
                txtUpdateCorreo.Enabled = false;
                txtUpdateTipo.Enabled = false;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
