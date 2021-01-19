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
    public partial class UserControlBorderlineQ9 : UserControl
    {
        public UserControlBorderlineQ9()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor9.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor9.Text + '.');
                oneC.Close();

            }
            else if (rarebor9.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor9.Text + '.');
                threeQ.Close();
            }
            else if (somebor9.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor9.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor9.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor9.Text + '.');
                fourQ.Close();
            }

            if (nevbor9.Checked == false && rarebor9.Checked == false && somebor9.Checked == false && alwbor9.Checked == false)
            {
                MessageBox.Show("Error at question 9. \nYou must answer all the questions");
            }
            if (nevbor9.Checked == true || rarebor9.Checked == true || somebor9.Checked == true || alwbor9.Checked == true)
            {
                btnNext.Hide();
            }
        }

        private void lblOR_Click(object sender, EventArgs e)
        {

        }
    }
}
