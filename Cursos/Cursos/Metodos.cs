using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Cursos
{
    class Metodos
    {
        public static string cad_con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/escuela.mdb";
        public static OleDbConnection con;

        public static OleDbConnection Conectar()
        {
            try
            {

                con = new OleDbConnection(cad_con);
                con.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
            return con;
        }
    }
}
