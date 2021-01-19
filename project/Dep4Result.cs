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
    public partial class Dep4Result : Form
    {
        public Dep4Result()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            File.Create("answers.txt").Close();
            File.Create("Anxiety-Answers.txt").Close();
            File.Create("Borderline-Answers.txt").Close();
            new FirstForm().Show();
            this.Hide();
        }
    }
}
