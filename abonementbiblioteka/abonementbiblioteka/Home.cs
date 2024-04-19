using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abonementbiblioteka
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author ath = new Author();
            this.Close();
            ath.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Genres grs = new Genres();
            this.Close();
            grs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books bks = new Books();
            this.Close();
            bks.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Borrowers br = new Borrowers();
            this.Close();
            br.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Publisher pub = new Publisher();
            this.Close();
            pub.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
