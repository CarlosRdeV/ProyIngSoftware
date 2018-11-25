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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;

            cmd.CommandText = "Select * from usuarios WHERE usuario=" + textBox1.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader.GetValue(0).ToString();
                textBox3.Text = reader.GetValue(1).ToString();
                textBox4.Text = reader.GetValue(2).ToString();
                

            }
            else
            {
                MessageBox.Show("No existe un usuario registrado con ese nombre");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas cambiar este usuario?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "update usuarios set usuario='" + textBox2.Text + "', password='" + textBox3.Text + "',tipo=" + textBox4.Text +  "' where matricula=" + textBox1.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Usuario editado con exito");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                

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
