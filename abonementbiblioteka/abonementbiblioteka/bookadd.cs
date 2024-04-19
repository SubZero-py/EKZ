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
    public partial class bookadd : Form
    {
        public bookadd()
        {
            InitializeComponent();
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {



            if (booksCheckBox.Checked)
            {


                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Books (ID, Title, AuthorID, PublisherID, GenreID, ISBN, PublishDate) VALUES (@ID, @Title, @AuthorID,@PublisherID,@GenreID, @ISBN, @PublishDate)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", textBox1.Text);
                    command.Parameters.AddWithValue("@Title", textBox2.Text);
                    command.Parameters.AddWithValue("@AuthorID", textBox3.Text);
                    command.Parameters.AddWithValue("@PublisherID", textBox4.Text);
                    command.Parameters.AddWithValue("@GenreID", textBox5.Text);
                    command.Parameters.AddWithValue("@ISBN", textBox6.Text);
                    command.Parameters.AddWithValue("@PublishDate", textBox7.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " строка добавлена.");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
            }
            if (authorCheckBox.Checked)
            {


                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Authors (ID, FirstName, LastName, BirthDate, Email) VALUES (@ID, @Name, @Family,@Birthday,@Email)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", textBox1.Text);
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@Family", textBox3.Text);
                    command.Parameters.AddWithValue("@Birthday", textBox4.Text);
                    command.Parameters.AddWithValue("@Email", textBox5.Text);


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " строка добавлена.");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
            }
            if (genresCheckBox.Checked)
            {


                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Genres (ID, Name) VALUES (@ID, @Name)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", textBox1.Text);
                    command.Parameters.AddWithValue("@Name", textBox2.Text);


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " строка добавлена.");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
            }
            if (borrowersCheckBox.Checked)
            {


                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Borrowers (ID, Name, Family, Date, Adress, Phone) VALUES (@ID, @Name, @Family,@Date,@Adress, @Phone)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", textBox1.Text);
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@Family", textBox3.Text);
                    command.Parameters.AddWithValue("@Date", textBox4.Text);
                    command.Parameters.AddWithValue("@Adress", textBox5.Text);
                    command.Parameters.AddWithValue("@Phone", textBox6.Text);


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " строка добавлена.");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
            }
            if (publishersCheckBox.Checked)
            {


                using (SqlConnection connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Publishers (ID, Name, Adress, Phone) VALUES (@ID, @Title, @Adress,@Phone)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ID", textBox1.Text);
                    command.Parameters.AddWithValue("@Title", textBox2.Text);
                    command.Parameters.AddWithValue("@Adress", textBox3.Text);
                    command.Parameters.AddWithValue("@Phone", textBox4.Text);


                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " строка добавлена.");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Выберите таблицу");
                return;
            }


        }

        private void bookadd_Load(object sender, EventArgs e)
        {
            booksCheckBox.Checked = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void booksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (booksCheckBox.Checked)
            {
                label1.Text = "Id";
                label2.Text = "Название";
                label3.Text = "Id-автора";
                label4.Text = "Id-издателя";
                label5.Text = "Id-жанра";
                label6.Text = "Шифр книги";
                label7.Text = "Дата публикации";

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;

                authorCheckBox.Checked = false;
                genresCheckBox.Checked = false;
                borrowersCheckBox.Checked = false;
                publishersCheckBox.Checked = false;

                this.Size = new Size(650, 600);

                saveButton.Left = 270;
                saveButton.Top = 500;

            }

        }

        private void authorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (authorCheckBox.Checked)
            {
                label1.Text = "Id";
                label2.Text = "Имя";
                label3.Text = "Фамилия";
                label4.Text = "Дата рождения";
                label5.Text = "E-mail";

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = false;
                label7.Visible = false;

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;

                booksCheckBox.Checked = false;
                genresCheckBox.Checked = false;
                borrowersCheckBox.Checked = false;
                publishersCheckBox.Checked = false;

                this.Size = new Size(650, 480);
                saveButton.Left = 270;
                saveButton.Top = 380;


            }

        }

        private void genresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genresCheckBox.Checked)
            {
                label1.Text = "Id";
                label2.Text = "Имя";

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;

                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;

                booksCheckBox.Checked = false;
                authorCheckBox.Checked = false;
                borrowersCheckBox.Checked = false;
                publishersCheckBox.Checked = false;


                this.Size = new Size(650, 300);

                saveButton.Left = 270;
                saveButton.Top = 200;
            }
        }

        private void borrowersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (borrowersCheckBox.Checked)
            {
                label1.Text = "Id";
                label2.Text = "Имя";
                label3.Text = "Фамилия";
                label4.Text = "Дата рождения";
                label5.Text = "Адрес";
                label6.Text = "Телефон";

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = false;

                booksCheckBox.Checked = false;
                genresCheckBox.Checked = false;
                authorCheckBox.Checked = false;
                publishersCheckBox.Checked = false;

                this.Size = new Size(650, 540);
                saveButton.Left = 270;
                saveButton.Top = 440;
            }
        }

        private void publishersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (publishersCheckBox.Checked)
            {
                label1.Text = "Id";
                label2.Text = "Наименование";
                label3.Text = "Адрес";
                label4.Text = "Телефон";

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;

                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;

                booksCheckBox.Checked = false;
                genresCheckBox.Checked = false;
                borrowersCheckBox.Checked = false;

                this.Size = new Size(650, 420);
                saveButton.Left = 270;
                saveButton.Top = 320;


            }
        }
    }
}
