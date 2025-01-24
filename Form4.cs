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
    public partial class Form4 : Form
    {


        function fn = new function();

        String Query;


        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);

            Query = "select * from New_Room ";

            DataSet ds = fn.getData(Query);
            dataGridView1.DataSource = ds.Tables[0];



        }
    }
}
