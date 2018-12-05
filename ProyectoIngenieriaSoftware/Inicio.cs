using ProyectoIngenieriaSoftware.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProyectoIngenieriaSoftware
{
    public partial class Inicio : Form
    {
        //Declaracion de variables para almacenar los las columnas de la base de datos
        static string var="";
        static string var2 = "";
        static string var3 = "";

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializacion del check button para mostrar la contrasena oculta
            string text = txtContrasena.Text;
            if (chkBMostrar.Checked)
            {
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.Text = text;

            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.Text = text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Acciones del check box 
            string text = txtContrasena.Text;
            if (chkBMostrar.Checked)
            {
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.Text = text;

            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
                txtContrasena.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Metodo de Conexion a la base de datos
            try {

                OleDbConnection ole = new OleDbConnection();
                ole = Metodos.Conectar();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = ole;
                cmd.CommandText = "SELECT * FROM usuarios WHERE usuario='" + txtUsuario.Text + "'";
                ole.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                     var = reader.GetValue(0).ToString();
                     var2 = reader.GetValue(1).ToString();
                     var3 = reader.GetValue(2).ToString();

                }

                    if (txtUsuario.Text == var && txtContrasena.Text == var2 && "A" == var3)
                    {
                        IngresoAdmin ingresoAdmin = new IngresoAdmin();
                        ingresoAdmin.Show();
                        Hide();
                    
                    }
                    else if (txtUsuario.Text == var && txtContrasena.Text == var2 && "U" == var3)
                    {
                        
                        IngresoUsuario ingresoUsuario = new IngresoUsuario();
                        ingresoUsuario.Show();
                        Hide();
                    }
                    else {
                        MessageBox.Show("El usuario no Existe");
                    }

                ole.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el proceso");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar nuestro software");
            Close();
        }
    }
}
