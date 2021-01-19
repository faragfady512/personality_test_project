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
namespace project.UserControlDepQ
{
    public partial class UserControlAnxQ10 : UserControl
    {
        public UserControlAnxQ10()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             if (nevanx10.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx10.Text + '.');
                OneC.Close();
            }
            else if (raranx10.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx10.Text + '.');
                TwoQ.Close();
            }
            else if (someanx10.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx10.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx10.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx10.Text + '.');
                FourQ.Close();
            }
            if (nevanx10.Checked == false && raranx10.Checked == false && someanx10.Checked == false && oftanx10.Checked == false)
            {
                MessageBox.Show("Error at question 10. \nYou must answer all the questions");
            }
            if (nevanx10.Checked == true || raranx10.Checked == true || someanx10.Checked == true || oftanx10.Checked == true)
            {
                pictureBox1.Hide();
            }

            StreamReader TwoR = new StreamReader("Anxiety-Answers.txt");
            string y = TwoR.ReadToEnd();
            TwoR.Close();


            int anxcount = 0;

            string[] Anxdata = y.Split('.');

            foreach (string anxitem in Anxdata)
            {
                if (anxitem == "Never")
                {
                    anxcount += 0;
                }
                else if (anxitem == "Rarely")
                {
                    anxcount += 1;
                }
                else if (anxitem == "Sometimes")
                {
                    anxcount += 2;
                }
                else if (anxitem == "Often")
                {
                    anxcount += 3;
                }
            }


            int sum = anxcount;

            if (sum >= 0 && sum <= 10)
            {
                this.Hide();
                new anx1Result().Show();
            }

            else if (sum >= 11 && sum <= 20)
            {
                this.Hide();
                new anx2Result().Show();
            }

            else if (sum >= 21 && sum <= 30)
            {
                this.Hide();
                new anx3Result().Show();
            }

            File.Create("Anxiety-Answers.txt").Close();

        }

        private void nevanx10_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
