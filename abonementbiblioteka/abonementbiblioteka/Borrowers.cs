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

namespace abonementbiblioteka
{
    public partial class Borrowers : Form
    {
        public Borrowers()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Close();
            hm.Show();
        }

        private void Borrowers_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Borrowers";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deletebook db = new deletebook();
            db.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bookadd ba = new bookadd();
            ba.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Подключение к базе данных
            SqlConnection connection = DatabaseHelper.GetConnection();
            connection.Open();

            string searchQuery = "SELECT * FROM Borrowers WHERE FirstName LIKE @searchText OR LastName LIKE @searchText OR BirthDate LIKE @searchText";
            SqlCommand command = new SqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@searchText", "%" + searchTextbox.Text + "%");


            // Выполнение запроса и вывод результатов на экран
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            // Закрытие соединения с базой данных
            connection.Close();
        }
    }
}
