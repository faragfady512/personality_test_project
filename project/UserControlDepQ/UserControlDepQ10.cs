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
    public partial class UserControlDepQ10 : UserControl
    {
        public UserControlDepQ10()
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
            if (radioButton1.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("answers.txt", true);
                OneC.Write(radioButton1.Text + '.');
                OneC.Close();
            }
            else if (radioButton2.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("answers.txt", true);
                TwoQ.Write(radioButton2.Text + '.');
                TwoQ.Close();
            }
            else if (radioButton3.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("answers.txt", true);
                ThreeQ.Write(radioButton3.Text + '.');
                ThreeQ.Close();
            }
            else if (radioButton4.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("answers.txt", true);
                FourQ.Write(radioButton4.Text + '.');
                FourQ.Close();
            }

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Error at question 10. \nyou must answer all the questions");
            }
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
            {
                pictureBox1.Hide();
            }

            StreamReader OneR = new StreamReader("answers.txt");
            string x = OneR.ReadToEnd();
            OneR.Close();


            int count = 0;

            string[] data = x.Split('.');

            foreach (string item in data)
            {
                if (item == "Never")
                {
                    count += 0;
                }
                else if (item == "Little")
                {
                    count += 1;
                }
                else if (item == "Sometimes")
                {
                    count += 2;
                }
                else if (item == "Frequently")
                {
                    count += 3;
                }
            }


            int sum = count;

            if (sum >= 0 && sum <= 4)
            {
                this.Hide();
                new ResultForm().Show();
            }

            else if (sum >= 5 && sum <= 9)
            {
                this.Hide();
                new Dep2Result().Show();
            }

            else if (sum >= 10 && sum <= 14)
            {
                this.Hide();
                new Dep3Result().Show();
            }
            else if (sum >= 15 && sum <= 20)
            {
                this.Hide();
                new Dep4Result().Show();
            }
            else if (sum >= 21 && sum <= 30)
            {
                this.Hide();
                new Dep5Result().Show();
            }

            File.Create("answers.txt").Close();
        }
    }
}
