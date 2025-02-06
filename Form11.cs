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
    public partial class Form11 : Form
    {

        function fn = new function();
        String query;

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Location = new Point(650, 280);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where emobile = " + txtMobile.Text + "";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmailId.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermanent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtUnique.Text = ds.Tables[0].Rows[0][7].ToString();
                txtDesignation.Text = ds.Tables[0].Rows[0][8].ToString();
                txtWorking.Text = ds.Tables[0].Rows[0][9].ToString();

            }
            else
            {
                MessageBox.Show("No Record Exist.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string name= txtName.Text;
            string fname = txtFather.Text;
            string mname= txtMother.Text;
            string email = txtEmailId.Text;
            string paddress = txtPermanent.Text;
            string id = txtUnique.Text;
            string designation = txtDesignation.Text;
            string working = txtWorking.Text;

            query = "update newEmployee set ename = '" + name + "',efname='" + fname + "',emname='" + mname + "',email='" + email + "',eaddress='" + paddress + "',eidproof='" + id + "',designation='" + designation + "',working ='" + working + "' where emobile =" + mobile + "";
            fn.setData(query, "Date Updation Successfully");

            clearAll();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newEmployee where emobile =" + txtMobile.Text + "";
                fn.setData(query, "Employee Record Deleted");
                clearAll();
            }
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailId.Clear();
            txtPermanent.Clear();
            txtUnique.Clear();
            txtDesignation.SelectedIndex = -1;
            txtWorking.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
