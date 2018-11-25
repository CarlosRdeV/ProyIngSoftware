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
    public partial class ModificarCurso : Form
    {
        public ModificarCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;

            cmd.CommandText = "Select * from cursos WHERE IdCurso=" + textBox1.Text;
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader.GetValue(1).ToString();
                textBox3.Text = reader.GetValue(2).ToString();
                textBox4.Text = reader.GetValue(3).ToString();
                textBox5.Text = reader.GetValue(4).ToString();
                textBox6.Text = reader.GetValue(5).ToString();
                textBox7.Text = reader.GetValue(6).ToString();
            }
            else
            {
                MessageBox.Show("No existe un curso registrado con ese Id");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection nuevo = new OleDbConnection();
            nuevo = Metodos.Conectar();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = nuevo;
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas cambiar este curso?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd.CommandText = "Update cursos set Nombre=" + "'" + textBox2.Text + "'" + "," + "Duracion=" + "'" + textBox3.Text + "'" + "," + "FechaInicio=" + "'" + textBox4.Text + "'" +","+"FechaFinal="+"'"+textBox5.Text+"'"+","+"AlumnosInscritos="+"'"+textBox6.Text+"'"+","+"Horario="+"'"+textBox7.Text+"'"+ "Where IdCurso=" + textBox1.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Curso editado con exito");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
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
