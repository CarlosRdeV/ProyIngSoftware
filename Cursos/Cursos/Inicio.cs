using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Cursos
{
    public partial class Inicio : Form
    {
        
        public static string usuario;
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Inicio inicio = new Inicio();
            OleDbConnection ole = new OleDbConnection();
            ole = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd.Connection = ole;
            cmd.CommandText = "SELECT * FROM usuarios WHERE Usuario='" + textBox1.Text + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string var = reader.GetValue(0).ToString();
                string var2 = reader.GetValue(1).ToString();
                string var3 = reader.GetValue(2).ToString();
                if (textBox1.Text == var && textBox2.Text == var2 && "A" == var3)
                {

                    IngresoAdmin ingresoAdmin = new IngresoAdmin();
                    ingresoAdmin.Show();
                }
                else if (textBox1.Text == var && textBox2.Text == var2 && "U" == var3)
                {
                    /*
                    IngresoUsuario ingresoUsuario = new IngresoUsuario();
                    ingresoUsuario.Show();*/
                }
                else
                {
                    MessageBox.Show("No Existe el usuario");
                }


            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }
        }
    }
}
