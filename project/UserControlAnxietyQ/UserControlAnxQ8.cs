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
    public partial class UserControlAnxQ8 : UserControl
    {
        public UserControlAnxQ8()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx8.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx8.Text + '.');
                OneC.Close();
            }
            else if (raranx8.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx8.Text + '.');
                TwoQ.Close();
            }
            else if (someanx8.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx8.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx8.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx8.Text + '.');
                FourQ.Close();
            }
            if (nevanx8.Checked == false && raranx8.Checked == false && someanx8.Checked == false && oftanx8.Checked == false)
            {
                MessageBox.Show("Error at question 8. \nYou must answer all the questions");
            }
            if (nevanx8.Checked == true || raranx8.Checked == true || someanx8.Checked == true || oftanx8.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
