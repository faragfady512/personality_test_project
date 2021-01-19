using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class PreFirstForm : Form
    {
        public PreFirstForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new FirstForm().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TakeTesttxt_Click(object sender, EventArgs e)
        {
            new FirstForm().Show();
            this.Hide();
        }

        private void btnRich_Click(object sender, EventArgs e)
        {
            new Information().Show();
            this.Hide();
        }
    }
}
