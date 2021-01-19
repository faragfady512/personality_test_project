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
    public partial class BorderlinePersonalityDisorder : Form
    {
        public BorderlinePersonalityDisorder()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            new FirstForm().Show();
            this.Hide();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ21.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ31.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ11.BringToFront();

        }

        private void BorderlinePersonalityDisorder_Load(object sender, EventArgs e)
        {
        }

        private void usercontrol551_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ41.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ51.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ61.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ71.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ81.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ91.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            userControlBorderlineQ101.BringToFront();
        }

        private void userControlBorderlineQ11_Load(object sender, EventArgs e)
        {

        }
    }
}
