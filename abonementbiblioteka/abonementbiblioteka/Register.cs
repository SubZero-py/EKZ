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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;


            if (RegisterUser(username, password))
            {
                MessageBox.Show("Регистрация успешна!");
                // Do something here after successful registration
                Form1 frm1 = new Form1();
                this.Close();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Такое имя уже имеется!");
            }
        }

        private bool RegisterUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM users WHERE username = @username";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    return false;
                }
                else
                {
                    query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
