using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Cursos
{
    public partial class BorrarProfesor : Form
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-9G9FEER\\SQLEXPRESS ; database=escuela ; integrated security = true");
        public BorrarProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;

            cmd.CommandText = "Select * from profesores WHERE matricula=" + textBox1.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label7.Text = reader.GetValue(1).ToString();
                label8.Text = reader.GetValue(2).ToString();
                label9.Text = reader.GetValue(3).ToString();
                label10.Text = reader.GetValue(4).ToString();
            
            }
            else
            {
                MessageBox.Show("No existe un profesor registrado con esa matricula");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas borrar este profesor?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "Delete FROM profesores WHERE matricula=" + textBox1.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Profesor borrado con exito");
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                
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
