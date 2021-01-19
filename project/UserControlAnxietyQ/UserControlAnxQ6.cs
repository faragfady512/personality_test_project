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
    public partial class UserControlAnxQ6 : UserControl
    {
        public UserControlAnxQ6()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx6.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx6.Text + '.');
                OneC.Close();
            }
            else if (raranx6.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx6.Text + '.');
                TwoQ.Close();
            }
            else if (someanx6.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx6.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx6.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx6.Text + '.');
                FourQ.Close();
            }
            if (nevanx6.Checked == false && raranx6.Checked == false && someanx6.Checked == false && oftanx6.Checked == false)
            {
                MessageBox.Show("Error at question 6. \nYou must answer all the questions");
            }
            if (nevanx6.Checked == true || raranx6.Checked == true || someanx6.Checked == true || oftanx6.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
