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
    public partial class UserControlAnxQ3 : UserControl
    {
        public UserControlAnxQ3()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx3.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx3.Text + '.');
                OneC.Close();
            }
            else if (raranx3.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx3.Text + '.');
                TwoQ.Close();
            }
            else if (someanx3.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx3.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx3.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx3.Text + '.');
                FourQ.Close();
            }
            if (nevanx3.Checked == false && raranx3.Checked == false && someanx3.Checked == false && oftanx3.Checked == false)
            {
                MessageBox.Show("Error at question 3. \nYou must answer all the questions");
            }
            if (nevanx3.Checked == true || raranx3.Checked == true || someanx3.Checked == true || oftanx3.Checked == true)
            {
                btnNext.Hide();
            }

        }
    }
}
