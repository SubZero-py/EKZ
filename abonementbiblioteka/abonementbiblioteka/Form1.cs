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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
 

            if (IsValidUser(username, password))
            {
                MessageBox.Show("Успешно авторизовались!");
                this.Hide();
                Home frm1 = new Home();
                frm1.Show();

               

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
 


        private bool IsValidUser(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return (count == 1);


            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm2 = new Register();
            this.Hide();
            frm2.Show();
        }
    }
}
