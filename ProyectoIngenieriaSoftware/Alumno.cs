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
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDireccion.Text != "" && txtEdad.Text != "" && txtCorreo.Text != "")
            {
                string seleccion = cmbCorreo.Items[cmbCorreo.SelectedIndex].ToString();

                string correo = txtCorreo.Text + seleccion;

                Metodos.CrearAlumno(txtNombre.Text, txtDireccion.Text, txtEdad.Text, correo);

                string id = Metodos.MostrarUltimoAlumno();

                MessageBox.Show("Se ha creado el siguiente Alumno: \nId: " + id + "\nNombre: " + txtNombre.Text + "\nDireccion: " +txtDireccion.Text+ "\nEdad: "+txtEdad.Text+ "\nCorreo Electronico: "+correo);

                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtEdad.Text = "";
                txtCorreo.Text = "";

            }
            else {
                MessageBox.Show("Rellena todos los campos");
            }
            


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            
            cmbCorreo.SelectedIndex = 0;
            txtUpdateNombre.Enabled = false;
            txtUpdateDireccion.Enabled = false;
            txtUpdateEdad.Enabled = false;
            txtUpdateCorreo.Enabled = false;
            btnModificarUpdate.Enabled = false;
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            txtCorreo.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Metodos.MostrarAlumno(txtIdMostrar.Text);
            lblNombre.Text = Metodos.nombre;
            lbDireccion.Text = Metodos.direccion;
            lbEdad.Text = Metodos.edad;
            lbCorreo.Text = Metodos.correo;

            Metodos.nombre = "";
            Metodos.direccion = "";
            Metodos.edad = "";
            Metodos.correo = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Metodos.MostrarAlumno(txtUpdateId.Text);
            txtUpdateNombre.Text = Metodos.nombre;
            txtUpdateDireccion.Text = Metodos.direccion;
            txtUpdateEdad.Text = Metodos.edad;
            txtUpdateCorreo.Text = Metodos.correo;

            Metodos.nombre = "";
            Metodos.direccion = "";
            Metodos.edad = "";
            Metodos.correo = "";

            if (txtUpdateNombre.Text != "")
            {
                txtUpdateNombre.Enabled = true;
                txtUpdateDireccion.Enabled = true;
                txtUpdateEdad.Enabled = true;
                txtUpdateCorreo.Enabled = true;
                btnModificarUpdate.Enabled = true;

            }
            else {

                txtUpdateNombre.Enabled = false;
                txtUpdateDireccion.Enabled = false;
                txtUpdateEdad.Enabled = false;
                txtUpdateCorreo.Enabled = false;
                btnModificarUpdate.Enabled = false;

            }

            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Los registros seran modificados, esta de acuerdo?",
                      "ALERTA", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:

                    Metodos.ActualizarAlumno(txtUpdateId.Text, txtUpdateNombre.Text, txtUpdateDireccion.Text, txtUpdateEdad.Text, txtUpdateCorreo.Text);
                    MessageBox.Show("El registro con id "+txtUpdateId.Text+" fue actualizado correctamente");
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("El registros sera eliminado, esta de acuerdo?",
                      "ALERTA", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:

                    Metodos.EliminarAlumno(txtDeleteId.Text);
                    MessageBox.Show("El registro con id " + txtDeleteId.Text + " fue eliminado correctamente");
                    break;

                case DialogResult.No:
                    break;
            }



        }
    }
}
