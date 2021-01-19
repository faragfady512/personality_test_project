
namespace project
{
    partial class PreFirstForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreFirstForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRich = new Guna.UI2.WinForms.Guna2Button();
            this.btnTakeText = new Guna.UI2.WinForms.Guna2Button();
            this.lblOR = new System.Windows.Forms.Label();
            this.Helptxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "About your personality ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(705, 55);
            this.panel5.TabIndex = 34;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(675, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnRich
            // 
            this.btnRich.BorderRadius = 20;
            this.btnRich.CheckedState.Parent = this.btnRich;
            this.btnRich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRich.CustomImages.Parent = this.btnRich;
            this.btnRich.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRich.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F);
            this.btnRich.ForeColor = System.Drawing.Color.White;
            this.btnRich.HoverState.Parent = this.btnRich;
            this.btnRich.Location = new System.Drawing.Point(14, 324);
            this.btnRich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRich.Name = "btnRich";
            this.btnRich.ShadowDecoration.Parent = this.btnRich;
            this.btnRich.Size = new System.Drawing.Size(296, 52);
            this.btnRich.TabIndex = 39;
            this.btnRich.Text = "Rich your knowledge";
            this.btnRich.Click += new System.EventHandler(this.btnRich_Click);
            // 
            // btnTakeText
            // 
            this.btnTakeText.BorderRadius = 20;
            this.btnTakeText.CheckedState.Parent = this.btnTakeText;
            this.btnTakeText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeText.CustomImages.Parent = this.btnTakeText;
            this.btnTakeText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnTakeText.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeText.ForeColor = System.Drawing.Color.White;
            this.btnTakeText.HoverState.Parent = this.btnTakeText;
            this.btnTakeText.Location = new System.Drawing.Point(384, 385);
            this.btnTakeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTakeText.Name = "btnTakeText";
            this.btnTakeText.ShadowDecoration.Parent = this.btnTakeText;
            this.btnTakeText.Size = new System.Drawing.Size(296, 52);
            this.btnTakeText.TabIndex = 39;
            this.btnTakeText.Text = "Take the test";
            this.btnTakeText.Click += new System.EventHandler(this.TakeTesttxt_Click);
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblOR.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOR.Location = new System.Drawing.Point(316, 364);
            this.lblOR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(60, 36);
            this.lblOR.TabIndex = 3;
            this.lblOR.Text = "OR";
            this.lblOR.Click += new System.EventHandler(this.label1_Click);
            // 
            // Helptxt
            // 
            this.Helptxt.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Helptxt.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Helptxt.BorderRadius = 20;
            this.Helptxt.BorderThickness = 3;
            this.Helptxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Helptxt.DefaultText = resources.GetString("Helptxt.DefaultText");
            this.Helptxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Helptxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Helptxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Helptxt.DisabledState.Parent = this.Helptxt;
            this.Helptxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Helptxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Helptxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Helptxt.FocusedState.Parent = this.Helptxt;
            this.Helptxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helptxt.ForeColor = System.Drawing.Color.White;
            this.Helptxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Helptxt.HoverState.Parent = this.Helptxt;
            this.Helptxt.Location = new System.Drawing.Point(23, 65);
            this.Helptxt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Helptxt.Multiline = true;
            this.Helptxt.Name = "Helptxt";
            this.Helptxt.PasswordChar = '\0';
            this.Helptxt.PlaceholderText = "";
            this.Helptxt.ReadOnly = true;
            this.Helptxt.SelectedText = "";
            this.Helptxt.SelectionStart = 263;
            this.Helptxt.ShadowDecoration.Parent = this.Helptxt;
            this.Helptxt.Size = new System.Drawing.Size(640, 234);
            this.Helptxt.TabIndex = 36;
            // 
            // PreFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnRich);
            this.Controls.Add(this.btnTakeText);
            this.Controls.Add(this.Helptxt);
            this.Controls.Add(this.lblOR);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PreFirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreFirstForm";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnRich;
        private Guna.UI2.WinForms.Guna2Button btnTakeText;
        private System.Windows.Forms.Label lblOR;
        private Guna.UI2.WinForms.Guna2TextBox Helptxt;
    }
}