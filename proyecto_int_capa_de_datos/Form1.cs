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
            DataGrid.CellClick += DataGrid_CellClick;
            DisplayData();
        }
        private int idSelected;
        private void DisplayData() {
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
            conn.Open();
            SqlCommand query = new SqlCommand("SELECT * FROM diary", conn);
            SqlDataReader results = query.ExecuteReader();
            while (results.Read())
            {
                DataGrid.Rows.Add(results["id"].ToString(), results["name"].ToString(), results["birthdate"].ToString(), results["genre"].ToString(), results["direction"].ToString(), results["marital_status"].ToString(), results["phone_number"].ToString());
            }
            conn.Close();
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGrid.Rows[e.RowIndex];
                string id = row.Cells["Id"].Value.ToString();
                idSelected = int.Parse(id);
                
            }
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
            conn.Open();
            SqlCommand query = new SqlCommand("DELETE FROM diary WHERE id = @id", conn);
            query.Parameters.AddWithValue("@id", idSelected);
            query.ExecuteNonQuery();

            DataGrid.Rows.Clear();

            DisplayData();
        }
    }
}
