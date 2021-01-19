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
    public partial class UserControlDepQ4 : UserControl
    {
        public UserControlDepQ4()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                StreamWriter OneC = new StreamWriter("answers.txt", true);
                OneC.Write(radioButton1.Text + '.');
                OneC.Close();
            }
            else if (radioButton2.Checked == true)
            {
                StreamWriter TwoQ = new StreamWriter("answers.txt", true);
                TwoQ.Write(radioButton2.Text + '.');
                TwoQ.Close();
            }
            else if (radioButton3.Checked == true)
            {
                StreamWriter ThreeQ = new StreamWriter("answers.txt", true);
                ThreeQ.Write(radioButton3.Text + '.');
                ThreeQ.Close();
            }
            else if (radioButton4.Checked == true)
            {
                StreamWriter FourQ = new StreamWriter("answers.txt", true);
                FourQ.Write(radioButton4.Text + '.');
                FourQ.Close();
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Error at question 4. \nyou must answer all the questions");
            }
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
            {
                btnNext.Hide();
            }
        }
    }
}
