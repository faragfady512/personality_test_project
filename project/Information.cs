using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            new InfoDepression().Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InformationAnxiety().Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InfoBorderline().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PreFirstForm().Show();
        }
    }
}
