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

        public Form1()
        {
            InitializeComponent();
            DataGrid.CellClick += DataGrid_CellClick;
            DisplayData("SELECT * FROM diary");
        }

        private void DisplayData(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
            try
            {

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
                        results["email"].ToString(),
                        results["birthdate"].ToString(),
                        results["genre"].ToString(),
                        results["direction"].ToString(),
                        results["marital_status"].ToString(),
                        results["phone_number"].ToString(),
                        results["number"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar los registros");
            }
            finally
            {
                conn.Close();
            }
        }
        private void ClearFields()
        {
            nameField.Text = "";
            lastNameField.Text = "";
            emailField.Text = "";
            dateField.Value = DateTime.Now;
            directionField.Text = "";
            genreField.Text = "";
            maritalStatusField.Text = "";
            phoneField.Text = "";
            phone2Field.Text = "";

            for (int i = 0; i < DataGrid.Rows.Count; i++)
            {
                DataGrid.Rows[i].Selected = false;
            }

            idSelected = 0;

        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGrid.Rows[e.RowIndex];
                string id = row.Cells["Id"].Value.ToString();
                nameField.Text = row.Cells["Name"].Value.ToString();
                lastNameField.Text = row.Cells["lastName"].Value.ToString();
                emailField.Text = row.Cells["email"].Value.ToString();
                dateField.Value = DateTime.Parse(row.Cells["birthdate"].Value.ToString());
                directionField.Text = row.Cells["direction"].Value.ToString();
                genreField.Text = row.Cells["genre"].Value.ToString();
                maritalStatusField.Text = row.Cells["maritalStatus"].Value.ToString();
                phoneField.Text = row.Cells["phoneNumber"].Value.ToString();
                phone2Field.Text = row.Cells["number"].Value.ToString();
                idSelected = int.Parse(id);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (idSelected == 0)
            {
                MessageBox.Show("Seleccione un fila antes de eliminar un registro");
                return;
            }
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
            conn.Open();
            SqlCommand query = new SqlCommand("DELETE FROM diary WHERE id = @id", conn);
            query.Parameters.AddWithValue("@id", idSelected);
            query.ExecuteNonQuery();
            ClearFields();
            DisplayData("SELECT * FROM diary");
            MessageBox.Show("Registro eliminado correctamente");

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
            ClearFields();
            search_field.Text = "";
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            search_field.Text = "";
            DisplayData("SELECT * FROM diary");
            ClearFields();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");
           
            try
            {

            conn.Open();
            string name = nameField.Text.Trim();
            string lastName = lastNameField.Text.Trim();
            string email = emailField.Text.Trim();
            DateTime date = dateField.Value;
            string direction = directionField.Text.Trim();
            string genre = genreField.Text.Trim();
            string maritalStatus = maritalStatusField.Text.Trim();
            string phoneNumber = phoneField.Text.Trim();
            string phone = phone2Field.Text.Trim();

            SqlCommand query = new SqlCommand("INSERT INTO diary (name,last_name,birthdate,direction,genre,marital_status,phone_number,email) " +
                "VALUES (@name,@lastName,@date,@direction,@genre,@maritalStatus,@phoneNumber,@email)", conn);

            query.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("@name", name),
                new SqlParameter("@lastName", lastName),
                new SqlParameter("@date", date),
                new SqlParameter("@direction", direction),
                new SqlParameter("@genre", genre),
                new SqlParameter("@maritalStatus", maritalStatus),
                new SqlParameter("@phoneNumber", phoneNumber),
                new SqlParameter("@email", email)
            });
            query.ExecuteNonQuery();
            DisplayData("SELECT * FROM diary");
            MessageBox.Show("Registro agregado correctamente");
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro");

            }
            finally
            {
                ClearFields();
                conn.Close();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {

            if(idSelected == 0)
            {
                MessageBox.Show("Seleccione un registro antes de editar");
                return;
            }
            SqlConnection conn = new SqlConnection("Server=JAYSLEN\\MSSQLSERVER01;Database=registers;Trusted_Connection=True;");

            try
            {

                conn.Open();
                SqlCommand query = new SqlCommand("UPDATE diary SET name = @name, last_name = @lastName, email = @email, birthdate = @date, direction = @direction, genre = @genre, marital_status = @maritalStatus, phone_number = @phoneNumber, number = @number WHERE id = @id", conn);
                query.Parameters.AddRange(new SqlParameter[]
                    {
                    new SqlParameter("@name", nameField.Text.Trim()),
                    new SqlParameter("@lastName", lastNameField.Text.Trim()),
                    new SqlParameter("@email", emailField.Text.Trim()),
                    new SqlParameter("@date", dateField.Value),
                    new SqlParameter("@direction", directionField.Text.Trim()),
                    new SqlParameter("@genre", genreField.Text.Trim()),
                    new SqlParameter("@maritalStatus", maritalStatusField.Text.Trim()),
                    new SqlParameter("@phoneNumber", phoneField.Text.Trim()),
                    new SqlParameter("@number", phone2Field.Text.Trim()),
                    new SqlParameter("@id", idSelected)
                    }
                );

                query.ExecuteNonQuery();
                DisplayData("SELECT * FROM diary");
                MessageBox.Show("Registro actualizado correctamente");
            }
            catch
            {
                MessageBox.Show("Error al actualizar el registro");
            }

            finally
            {
               conn.Close();
                ClearFields();

            }



        }
    }
}
