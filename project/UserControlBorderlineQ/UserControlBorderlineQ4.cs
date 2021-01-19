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
    public partial class UserControlBorderlineQ4 : UserControl
    {
        public UserControlBorderlineQ4()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor4.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor4.Text + '.');
                oneC.Close();

            }
            else if (rarebor4.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor4.Text + '.');
                threeQ.Close();
            }
            else if (somebor4.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor4.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor4.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor4.Text + '.');
                fourQ.Close();
            }

            if (nevbor4.Checked == false && rarebor4.Checked == false && somebor4.Checked == false && alwbor4.Checked == false)
            {
                MessageBox.Show("Error at question 4. \nYou must answer all the questions");
            }
            if (nevbor4.Checked == true || rarebor4.Checked == true || somebor4.Checked == true || alwbor4.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
