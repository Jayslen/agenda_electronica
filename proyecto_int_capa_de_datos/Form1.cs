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
using Microsoft.Win32.SafeHandles;

namespace proyecto_int_capa_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
            conn.Open();

            MessageBox.Show("Conexión exitosa");

            conn.Close();
        }
    }
}
