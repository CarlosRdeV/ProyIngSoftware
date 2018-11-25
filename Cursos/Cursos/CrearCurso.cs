using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cursos
{
    public partial class CrearCurso : Form
    {
        public static string cad_con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/escuela.mdb";
        public static OleDbConnection con;
        public CrearCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int alumnos = 0;
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas agregar este curso?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "Insert into cursos (Nombre, Duracion, FechaInicio, FechaFinal, AlumnosInscritos, Horario) VALUES(" +"'"+textBox1.Text+"'" + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + "," + "'" + textBox4.Text + "'" + ","+alumnos+","+"'"+textBox5.Text+"'"+ ")";
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se agrego el curso con exito");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            IngresoAdmin ingresoAdmin = new IngresoAdmin();
            ingresoAdmin.Show();
        }
    }
}
