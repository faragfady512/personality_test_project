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
    public partial class UserControlBorderlineQ6 : UserControl
    {
        public UserControlBorderlineQ6()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor6.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor6.Text + '.');
                oneC.Close();

            }
            else if (rarebor6.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor6.Text + '.');
                threeQ.Close();
            }
            else if (somebor6.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor6.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor6.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor6.Text + '.');
                fourQ.Close();
            }

            if (nevbor6.Checked == false && rarebor6.Checked == false && somebor6.Checked == false && alwbor6.Checked == false)
            {
                MessageBox.Show("Error at question 6. \nYou must answer all the questions");
            }
            if (nevbor6.Checked == true || rarebor6.Checked == true || somebor6.Checked == true || alwbor6.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
