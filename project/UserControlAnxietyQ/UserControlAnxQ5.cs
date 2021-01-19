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
    public partial class UserControlAnxQ5 : UserControl
    {
        public UserControlAnxQ5()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx5.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx5.Text + '.');
                OneC.Close();
            }
            else if (raranx5.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx5.Text + '.');
                TwoQ.Close();
            }
            else if (someanx5.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx5.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx5.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx5.Text + '.');
                FourQ.Close();
            }
            if (nevanx5.Checked == false && raranx5.Checked == false && someanx5.Checked == false && oftanx5.Checked == false)
            {
                MessageBox.Show("Error at question 5. \nYou must answer all the questions");
            }
            if (nevanx5.Checked == true || raranx5.Checked == true || someanx5.Checked == true || oftanx5.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
