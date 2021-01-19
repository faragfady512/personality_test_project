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
    public partial class UserControlBorderlineQ8 : UserControl
    {
        public UserControlBorderlineQ8()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor8.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor8.Text + '.');
                oneC.Close();

            }
            else if (rarebor8.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor8.Text + '.');
                threeQ.Close();
            }
            else if (somebor8.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor8.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor8.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor8.Text + '.');
                fourQ.Close();
            }

            if (nevbor8.Checked == false && rarebor8.Checked == false && somebor8.Checked == false && alwbor8.Checked == false)
            {
                MessageBox.Show("Error at question 8. \nYou must answer all the questions");
            }
            if (nevbor8.Checked == true || rarebor8.Checked == true || somebor8.Checked == true || alwbor8.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
