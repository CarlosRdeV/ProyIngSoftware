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
    public partial class MostrarUsuarios : Form
    {
        public MostrarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection ole = new OleDbConnection();
            ole = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM usuarios";
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = textBox1.Text + reader.GetValue(0).ToString();
                textBox1.Text = textBox1.Text + "   " + reader.GetValue(1).ToString();
                textBox1.Text = textBox1.Text + "   " + reader.GetValue(2).ToString() + "\r\n\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            IngresoAdmin ingresoAdmin = new IngresoAdmin();
            ingresoAdmin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
