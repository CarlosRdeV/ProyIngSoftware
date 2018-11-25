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
    public partial class MostrarCursos : Form
    {
        public MostrarCursos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection ole = new OleDbConnection();
            ole = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM cursos";
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = textBox1.Text + reader.GetValue(0).ToString();
                textBox1.Text = textBox1.Text + "   "  +reader.GetValue(1).ToString() ;
                textBox1.Text = textBox1.Text + "   " + reader.GetValue(2).ToString() ;
                textBox1.Text = textBox1.Text + "   " + reader.GetValue(3).ToString() ;
                textBox1.Text = textBox1.Text + "   " + reader.GetValue(4).ToString() ;
                textBox1.Text = textBox1.Text + "   " + reader.GetValue(5).ToString() ;
                textBox1.Text = textBox1.Text + "   " + reader.GetValue(6).ToString()+ "\r\n\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            IngresoAdmin ingresoAdmin = new IngresoAdmin();
            ingresoAdmin.Show();
        }
    }
}
