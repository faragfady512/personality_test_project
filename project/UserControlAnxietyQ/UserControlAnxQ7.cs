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
    public partial class UserControlAnxQ7 : UserControl
    {
        public UserControlAnxQ7()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx7.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx7.Text + '.');
                OneC.Close();
            }
            else if (raranx7.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx7.Text + '.');
                TwoQ.Close();
            }
            else if (someanx7.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx7.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx7.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx7.Text + '.');
                FourQ.Close();
            }
            if (nevanx7.Checked == false && raranx7.Checked == false && someanx7.Checked == false && oftanx7.Checked == false)
            {
                MessageBox.Show("Error at question 7. \nYou must answer all the questions");
            }
            if (nevanx7.Checked == true || raranx7.Checked == true || someanx7.Checked == true || oftanx7.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
