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
        function fn = new function();
        String query;
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         clearAll();
        }

        private void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmailId.Clear();
            txtPermanent.Clear();
            txtUniqueId.Clear();
            txtDesignation.SelectedIndex = -1;

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "" &&  txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmailId.Text != "" && txtPermanent.Text != "" && txtUniqueId.Text != "" && txtDesignation.SelectedIndex != -1)
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string name = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string email = txtEmailId.Text;
                string address = txtPermanent.Text;
                string id = txtUniqueId.Text;
                string designation = txtDesignation.Text;

                query = "insert into newEmployee(emobile,ename,efname,emname,email,eaddress,eidproof,designation) values ("+mobile+",'"+name+ "','"+fname+ "','"+mname+ "','"+email+" ','" +address+ "','" + id + "' ,'" + designation + "')";
                fn.setData(query ,"Employee Registration Successful");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all Required Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPermanent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
