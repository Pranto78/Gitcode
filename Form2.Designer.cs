namespace Form_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signbtn = new System.Windows.Forms.Button();
            this.ftxt = new System.Windows.Forms.RadioButton();
            this.mtxt = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.signbtn);
            this.panel1.Controls.Add(this.ftxt);
            this.panel1.Controls.Add(this.mtxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.passtxt);
            this.panel1.Controls.Add(this.emailtxt);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Controls.Add(this.datetxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 648);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // signbtn
            // 
            this.signbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.signbtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbtn.Image = ((System.Drawing.Image)(resources.GetObject("signbtn.Image")));
            this.signbtn.Location = new System.Drawing.Point(196, 540);
            this.signbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(219, 49);
            this.signbtn.TabIndex = 18;
            this.signbtn.UseVisualStyleBackColor = false;
            this.signbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ftxt
            // 
            this.ftxt.AutoSize = true;
            this.ftxt.Location = new System.Drawing.Point(243, 451);
            this.ftxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ftxt.Name = "ftxt";
            this.ftxt.Size = new System.Drawing.Size(87, 24);
            this.ftxt.TabIndex = 17;
            this.ftxt.TabStop = true;
            this.ftxt.Text = "Female";
            this.ftxt.UseVisualStyleBackColor = true;
            // 
            // mtxt
            // 
            this.mtxt.AutoSize = true;
            this.mtxt.Location = new System.Drawing.Point(136, 451);
            this.mtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxt.Name = "mtxt";
            this.mtxt.Size = new System.Drawing.Size(68, 24);
            this.mtxt.TabIndex = 16;
            this.mtxt.TabStop = true;
            this.mtxt.Text = "Male";
            this.mtxt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(52, 454);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender:";
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.Silver;
            this.passtxt.Location = new System.Drawing.Point(136, 291);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(337, 41);
            this.passtxt.TabIndex = 10;
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.Silver;
            this.emailtxt.Location = new System.Drawing.Point(136, 208);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtxt.Multiline = true;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(337, 41);
            this.emailtxt.TabIndex = 9;
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.Silver;
            this.nametxt.Location = new System.Drawing.Point(136, 126);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(337, 41);
            this.nametxt.TabIndex = 8;
            // 
            // datetxt
            // 
            this.datetxt.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.datetxt.Location = new System.Drawing.Point(136, 365);
            this.datetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(298, 26);
            this.datetxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DOB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 651);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.Button signbtn;
        private System.Windows.Forms.RadioButton ftxt;
        private System.Windows.Forms.RadioButton mtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}