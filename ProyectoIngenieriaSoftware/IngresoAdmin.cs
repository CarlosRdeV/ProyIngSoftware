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
    public partial class IngresoAdmin : Form
    {
        public IngresoAdmin()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearAlumno_Click(object sender, EventArgs e)
        {
            Alumno al = new Alumno();
            al.Show();
        }
    }
}
