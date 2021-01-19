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
    public partial class UserControlBorderlineQ2 : UserControl
    {
        public UserControlBorderlineQ2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor2.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor2.Text + '.');
                oneC.Close();

            }
            else if (rarebor2.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor2.Text + '.');
                threeQ.Close();
            }
            else if (somebor2.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor2.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor2.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor2.Text + '.');
                fourQ.Close();
            }

            if (nevbor2.Checked == false && rarebor2.Checked == false && somebor2.Checked == false && alwbor2.Checked == false)
            {
                MessageBox.Show("Error at question 2. \nYou must answer all the questions");
            }
            if (nevbor2.Checked == true || rarebor2.Checked == true || somebor2.Checked == true || alwbor2.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
