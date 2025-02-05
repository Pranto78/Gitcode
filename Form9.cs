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
    public partial class Form9 : Form
    {
        function fn = new function();
        String query;


        public Form9()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Location = new Point(650, 280);
            query = "select * from newStudent where living ='No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource= ds .Tables[0];
        }
    }
}
