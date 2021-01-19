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
    public partial class UserControlBorderlineQ1 : UserControl
    {
        public UserControlBorderlineQ1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor1.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor1.Text + '.');
                oneC.Close();

            }
            else if (rarebor1.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor1.Text + '.');
                threeQ.Close();
            }
            else if (somebor1.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor1.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor1.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor1.Text + '.');
                fourQ.Close();
            }

            if (nevbor1.Checked == false && rarebor1.Checked == false && somebor1.Checked == false && alwbor1.Checked == false)
            {
                MessageBox.Show("Error at question 1. \nYou must answer all the questions");
            }
            if (nevbor1.Checked == true || rarebor1.Checked == true || somebor1.Checked == true || alwbor1.Checked == true)
            {
                btnNext.Hide();
            }
        }

        private void UserControlBorderlineQ1_Load(object sender, EventArgs e)
        {

        }
    }
}
