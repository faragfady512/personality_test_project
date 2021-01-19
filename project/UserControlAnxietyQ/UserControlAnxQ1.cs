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

namespace project.UserControlDepQ
{
    public partial class UserControlAnxQ1 : UserControl
    {
        public UserControlAnxQ1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx1.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx1.Text + '.');
                OneC.Close();
                
            }
            else if (raranx1.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx1.Text + '.');
                TwoQ.Close();
            }
            else if (someanx1.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx1.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx1.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx1.Text + '.');
                FourQ.Close();
            }
            if (nevanx1.Checked == false && raranx1.Checked == false && someanx1.Checked == false && oftanx1.Checked == false)
            {
                MessageBox.Show("Error at question 1. \nYou must answer all the questions");
            }
            if (nevanx1.Checked == true || raranx1.Checked == true || someanx1.Checked == true || oftanx1.Checked == true)
            {
                btnNext.Hide();
            }

        }
    }
}
