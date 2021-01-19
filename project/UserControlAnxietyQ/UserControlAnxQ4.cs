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
    public partial class UserControlAnxQ4 : UserControl
    {
        public UserControlAnxQ4()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx4.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx4.Text + '.');
                OneC.Close();
            }
            else if (raranx4.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx4.Text + '.');
                TwoQ.Close();
            }
            else if (someanx4.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx4.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx4.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx4.Text + '.');
                FourQ.Close();
            }
            if (nevanx4.Checked == false && raranx4.Checked == false && someanx4.Checked == false && oftanx4.Checked == false)
            {
                MessageBox.Show("Error at question 4. \nYou must answer all the questions");
            }
            if (nevanx4.Checked == true || raranx4.Checked == true || someanx4.Checked == true || oftanx4.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
