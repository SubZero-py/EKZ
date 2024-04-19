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
    public partial class deletebook : Form
    {
        public deletebook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                

                    if (booksCheckBox.Checked)
                    {
                        string deleteBooksQuery = "DELETE FROM Books WHERE Id = @Id";
                        using (SqlCommand command = new SqlCommand(deleteBooksQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", idTextBox.Text);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Строка удалена в таблице книги");
                    }
                

                if(genresCheckBox.Checked)
                {
                    string deleteGenresQuery = "DELETE FROM Genres WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(deleteGenresQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idTextBox.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Строка удалена в таблице жанры");
                }

                if (authorCheckBox.Checked)
                {
                    string deleteAuthorsQuery = "DELETE FROM Authors WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(deleteAuthorsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idTextBox.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Строка удалена в таблице авторы");
                }

                if (publishCheckBox.Checked)
                {
                    string deletePublishersQuery = "DELETE FROM Publishers WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(deletePublishersQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idTextBox.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Строка удалена в таблице издатели");
                }
                if (boreCheckBox.Checked)
                {
                    string deleteBorrowersQuery = "DELETE FROM Borrowers WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(deleteBorrowersQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idTextBox.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Строка удалена в таблице заёмщики");
                }
            }
        }

        private void deletebook_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
