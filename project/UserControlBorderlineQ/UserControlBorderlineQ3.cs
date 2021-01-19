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
    public partial class UserControlBorderlineQ3 : UserControl
    {
        public UserControlBorderlineQ3()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor3.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor3.Text + '.');
                oneC.Close();

            }
            else if (rarebor3.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor3.Text + '.');
                threeQ.Close();
            }
            else if (somebor3.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor3.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor3.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor3.Text + '.');
                fourQ.Close();
            }

            if (nevbor3.Checked == false && rarebor3.Checked == false && somebor3.Checked == false && alwbor3.Checked == false)
            {
                MessageBox.Show("Error at question 3. \nYou must answer all the questions");
            }
            if (nevbor3.Checked == true || rarebor3.Checked == true || somebor3.Checked == true || alwbor3.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
