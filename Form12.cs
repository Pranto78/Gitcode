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
    public partial class Form12 : Form
    {
        function fn = new function();
        String query;
        public Form12()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            this.Location = new Point(650, 280);
            MonthDateTime.Format = DateTimePickerFormat.Custom;
            MonthDateTime.CustomFormat = "MMMM yyyy";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMNum.Text != "")
            {
                query = "select ename,email,designation from newEmployee where emobile = " + txtMNum.Text + "";
                fn.getData(query);
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDesignation.Text = ds.Tables[0].Rows[0][2].ToString();

                    setDataGrid(Convert.ToInt64(txtMNum.Text));
                }
                else
                {
                    MessageBox.Show("No Record Exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Enter Some Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void setDataGrid(Int64 mobile)
        {
            query = "select * from employeeSalary where mobileNo = " + mobile + "";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            if (txtMNum.Text != "" && txtPayment.Text != "")
            {
                query = "select * from employeeSalary where mobileNo = " + txtMNum.Text + " and fmonth = '" + MonthDateTime.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMNum.Text);
                    String month = MonthDateTime.Text;
                    Int64 amount = Int64.Parse(txtPayment.Text);

                    query = "insert into employeeSalary values(" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Salary for month " + MonthDateTime.Text + " Paid ");
                    setDataGrid(mobile);
                }
                else
                {
                    MessageBox.Show("Payment of " + MonthDateTime.Text + " Done. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
         clearAll();
        }

        public void clearAll()
        {
            txtMNum.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtDesignation.Clear();
            txtPayment.Clear();
            dataGridView1.DataSource = 0;
            MonthDateTime.ResetText();
        }
    }
    
}
