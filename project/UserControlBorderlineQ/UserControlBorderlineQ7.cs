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
    public partial class UserControlBorderlineQ7 : UserControl
    {
        public UserControlBorderlineQ7()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor7.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor7.Text + '.');
                oneC.Close();

            }
            else if (rarebor7.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor7.Text + '.');
                threeQ.Close();
            }
            else if (somebor7.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor7.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor7.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor7.Text + '.');
                fourQ.Close();
            }

            if (nevbor7.Checked == false && rarebor7.Checked == false && somebor7.Checked == false && alwbor7.Checked == false)
            {
                MessageBox.Show("Error at question 7. \nYou must answer all the questions");
            }
            if (nevbor7.Checked == true || rarebor7.Checked == true || somebor7.Checked == true || alwbor7.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
