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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas agregar este usuario?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "insert into usuarios(usuario,password,tipo) values ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "')";
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Se agrego el usuario con exito");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            IngresoAdmin ingresoAdmin = new IngresoAdmin();
            ingresoAdmin.Show();
        }
    }
}
