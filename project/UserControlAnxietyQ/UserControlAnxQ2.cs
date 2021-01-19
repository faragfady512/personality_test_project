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
    public partial class UserControlAnxQ2 : UserControl
    {
        public UserControlAnxQ2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx2.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx2.Text + '.');
                OneC.Close();
            }
            else if (raranx2.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx2.Text + '.');
                TwoQ.Close();
            }
            else if (someanx2.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx2.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx2.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx2.Text + '.');
                FourQ.Close();
            }
            if (nevanx2.Checked == false && raranx2.Checked == false && someanx2.Checked == false && oftanx2.Checked == false)
            {
                MessageBox.Show("Error at question 2. \nYou must answer all the questions");
            }
            if (nevanx2.Checked == true || raranx2.Checked == true || someanx2.Checked == true || oftanx2.Checked == true)
            {
                btnNext.Hide();
            }

        }
    }
}
