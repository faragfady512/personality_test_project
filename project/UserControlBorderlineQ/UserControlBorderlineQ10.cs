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
    public partial class UserControlBorderlineQ10 : UserControl
    {
        public UserControlBorderlineQ10()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (nevbor10.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor10.Text + '.');
                oneC.Close();

            }
            else if (rarebor10.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor10.Text + '.');
                threeQ.Close();
            }
            else if (somebor10.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor10.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor10.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor10.Text + '.');
                fourQ.Close();
            }

            if (nevbor10.Checked == false && rarebor10.Checked == false && somebor10.Checked == false && alwbor10.Checked == false)
            {
                MessageBox.Show("Error at question 10. \nYou must answer all the questions");
            }
            if (nevbor10.Checked == true || rarebor10.Checked == true || somebor10.Checked == true || alwbor10.Checked == true)
            {
                pictureBox1.Hide();
            }

            StreamReader ThreeR = new StreamReader("Borderline-Answers.txt");
            string z = ThreeR.ReadToEnd();
            ThreeR.Close();


            int borcount = 0;

            string[] bordata = z.Split('.');

            foreach (string boritem in bordata)
            {
                if (boritem == "Never")
                {
                    borcount += 0;
                }
                else if (boritem == "Rarely")
                {
                    borcount += 1;
                }
                else if (boritem == "Sometimes")
                {
                    borcount += 2;
                }
                else if (boritem == "Always")
                {
                    borcount += 3;
                }
            }


            int sum = borcount;

            if (sum >= 0 && sum <= 8)
            {
                this.Hide();
                new bord1Result().Show();
            }

            else if (sum >= 9 && sum <= 15)
            {
                this.Hide();
                new bord2Result().Show();
            }

            else if (sum >= 16 && sum <= 23)
            {
                this.Hide();
                new bord3Result().Show();
            }
            else if (sum >= 24 && sum <= 30)
            {
                this.Hide();
                new bord4Result().Show();
            }

            File.Create("Borderline-Answers.txt").Close();
        }
    }
}
