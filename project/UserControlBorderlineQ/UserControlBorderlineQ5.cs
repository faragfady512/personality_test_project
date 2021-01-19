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
    public partial class UserControlBorderlineQ5 : UserControl
    {
        public UserControlBorderlineQ5()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevbor5.Checked == true)
            {
                StreamWriter oneC = new StreamWriter("Borderline-Answers.txt", true);
                oneC.Write(nevbor5.Text + '.');
                oneC.Close();

            }
            else if (rarebor5.Checked == true)
            {
                StreamWriter threeQ = new StreamWriter("Borderline-Answers.txt", true);
                threeQ.Write(rarebor5.Text + '.');
                threeQ.Close();
            }
            else if (somebor5.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Borderline-Answers.txt", true);
                TwoQ.Write(somebor5.Text + '.');
                TwoQ.Close();
            }

            else if (alwbor5.Checked == true)
            {
                StreamWriter fourQ = new StreamWriter("Borderline-Answers.txt", true);
                fourQ.Write(alwbor5.Text + '.');
                fourQ.Close();
            }

            if (nevbor5.Checked == false && rarebor5.Checked == false && somebor5.Checked == false && alwbor5.Checked == false)
            {
                MessageBox.Show("Error at question 5. \nYou must answer all the questions");
            }
            if (nevbor5.Checked == true || rarebor5.Checked == true || somebor5.Checked == true || alwbor5.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
