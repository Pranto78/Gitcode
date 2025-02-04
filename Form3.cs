﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_1
{
    public partial class Form3 : Form
    {

        public Point mouseLocation;

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 room = new Form4();
            room.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 room2 = new Form5();
            room2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 room3= new Form6();
            room3.Show();
        }
    }
}
