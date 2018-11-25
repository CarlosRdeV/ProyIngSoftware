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
    public partial class BorrarCurso : Form
    {
        public BorrarCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            
                cmd.CommandText = "Select * from cursos WHERE IdCurso="+textBox1.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label7.Text = reader.GetValue(1).ToString();
                label8.Text = reader.GetValue(2).ToString();
                label9.Text = reader.GetValue(3).ToString();
                label10.Text = reader.GetValue(4).ToString();
                label11.Text = reader.GetValue(5).ToString();
                label12.Text = reader.GetValue(6).ToString();
            }
            else
            {
                MessageBox.Show("No existe un curso registrado con ese Id");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            IngresoAdmin ingresoAdmin = new IngresoAdmin();
            ingresoAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas borrar este curso?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "Delete FROM cursos WHERE IdCurso=" + textBox1.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Curso borrado con exito");
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label12.Text = "";
            }
        }
    }
}
