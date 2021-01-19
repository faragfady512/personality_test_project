using project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FirstForm : Form
    {
        

            public FirstForm()
        {
                InitializeComponent();
        }


           
        // this code to make lampe image rounded
        

            private void pictureBox1_Click(object sender, EventArgs e)
            {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }
        
        //This method to show next form
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
     

        }

        //This method to show next form


        private void pictureBox6_Click(object sender, EventArgs e)
        {

            
        }
        // close app method 

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {


        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Depression().Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new BorderlinePersonalityDisorder().Show();
            this.Hide();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new Anxiety().Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new PreFirstForm().Show();
        }
    }
}
