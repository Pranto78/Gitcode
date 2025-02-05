using System;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text != " ")
            {

            }
            else
            {
                MessageBox.Show("Fill all Required Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
