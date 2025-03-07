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
        private int idSelected;
        private void DisplayData(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
            conn.Open();
            SqlCommand queryToExecute = new SqlCommand(query, conn);

            if (parameters != null)
            {
                queryToExecute.Parameters.AddRange(parameters);
            }

            SqlDataReader results = queryToExecute.ExecuteReader();
            DataGrid.Rows.Clear();


            //insert values
            while (results.Read())
            {
                DataGrid.Rows.Add(results["id"].ToString(),
                    results["name"].ToString(),
                    results["last_name"].ToString(),
                    results["birthdate"].ToString(),
                    results["genre"].ToString(),
                    results["direction"].ToString(),
                    results["marital_status"].ToString(),
                    results["phone_number"].ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
            DataGrid.CellClick += DataGrid_CellClick;
            DisplayData("SELECT * FROM diary");
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

            if(idSelected == 0)
            {
                MessageBox.Show("Seleccione un fila antes de eliminar un registro");
                return;
            }
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
            conn.Open();
            SqlCommand query = new SqlCommand("DELETE FROM diary WHERE id = @id", conn);
            query.Parameters.AddWithValue("@id", idSelected);
            query.ExecuteNonQuery();
            DataGrid.Rows.Clear();
            DisplayData("SELECT * FROM diary");
            idSelected = 0;
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string userInput = search_field.Text;
            if (userInput.Length <= 0)
            {
                MessageBox.Show("Escriba un nombre para ejecutar la busqueda");
                return;
            }
            DisplayData("SELECT * FROM diary WHERE name LIKE @name", new SqlParameter("@name", "%" + userInput + "%"));
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            search_field.Text = "";
            DisplayData("SELECT * FROM diary");
        }
    }
}
