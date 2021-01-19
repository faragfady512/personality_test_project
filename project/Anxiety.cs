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
    public partial class Anxiety : Form
    {
        public Anxiety()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Anxiety_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FirstForm().Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            new ResultForm().Show();
            this.Hide();

            //int Resno4 = 0;

            //if (radioButton1.Checked == true)
            //{
            //    Resno4 += 0;
            //}
            //if (radioButton4.Checked == true)
            //{
            //    Resno4 += 1;
            //}
            //if (radioButton3.Checked == true)
            //{
            //    Resno4 += 2;
            //}
            //if (radioButton2.Checked == true)
            //{
            //    Resno4 += 3;
            //}

            //int sum=  Resno4 + resno1

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void litanx4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            new FirstForm().Show();
            this.Hide();
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            userControlAnxQ101.BringToFront();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            userControlAnxQ11.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            userControlAnxQ21.BringToFront();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            userControlAnxQ31.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControlAnxQ41.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControlAnxQ51.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            userControlAnxQ61.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userControlAnxQ71.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControlAnxQ81.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            userControlAnxQ91.BringToFront();

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void userControlAnxQ11_Load(object sender, EventArgs e)
        {

        }
    }
}
