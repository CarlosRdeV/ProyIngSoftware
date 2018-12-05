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
    public partial class ProfesorUsuario : Form
    {
        public ProfesorUsuario()
        {
            InitializeComponent();
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
    }
}
