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
    public partial class UserControlAnxQ9 : UserControl
    {
        public UserControlAnxQ9()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nevanx9.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("Anxiety-Answers.txt", true);
                OneC.Write(nevanx9.Text + '.');
                OneC.Close();
            }
            else if (raranx9.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("Anxiety-Answers.txt", true);
                TwoQ.Write(raranx9.Text + '.');
                TwoQ.Close();
            }
            else if (someanx9.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("Anxiety-Answers.txt", true);
                ThreeQ.Write(someanx9.Text + '.');
                ThreeQ.Close();
            }
            else if (oftanx9.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("Anxiety-Answers.txt", true);
                FourQ.Write(oftanx9.Text + '.');
                FourQ.Close();
            }
            if (nevanx9.Checked == false && raranx9.Checked == false && someanx9.Checked == false && oftanx9.Checked == false)
            {
                MessageBox.Show("Error at question 9. \nYou must answer all the questions");
            }
            if (nevanx9.Checked == true || raranx9.Checked == true || someanx9.Checked == true || oftanx9.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
