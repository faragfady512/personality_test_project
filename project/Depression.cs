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
    public partial class Depression : Form
    {
        public Depression()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userControlDepQ11.BringToFront();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            userControlDepQ21.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            userControlDepQ31.BringToFront();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            userControlDepQ41.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            userControlDepQ51.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            userControlDepQ61.BringToFront();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            userControlDepQ71.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControlDepQ81.BringToFront();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            userControlDepQ91.BringToFront();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            userControlDepQ101.BringToFront();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            Application.Exit();
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            new FirstForm().Show();
            this.Hide();
        }

        private void userControlDepQ11_Load(object sender, EventArgs e)
        {

        }
    }
}
