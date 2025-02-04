using System;
using System.Collections;
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
    public partial class Form7 : Form
    {

        function fn = new function();
        string query;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            this.Location = new Point(350, 170);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != " ")
            {
                query = "select name ,email,Room_No from newStudent where mobile = " + txtMobile.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(Int64.Parse(txtMobile.Text));
                }
                else
                {
                    MessageBox.Show("No Record Exist ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        public void setDataGrid(Int64 mobile)
        {
            query = "select * from fees where mobileNo = " + mobile + "";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];


        }
        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "" && txtAmount.Text != "")
            {
                query ="select * from fees where mobileNo = "+Int64.Parse(txtMobile.Text)+" and fmonth ='"+dateTimePicker1.Text+"'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count== 0)
                {
                    Int64 mobile =Int64.Parse(txtMobile.Text);
                    string month = dateTimePicker1.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);
                    query = "insert into fees values(" + mobile + ",'"+month+"',"+amount+")";
                    fn.setData(query, "Fees paid.");

                }
                else
                {
                    MessageBox.Show("No dues off" + dateTimePicker1.Text + " Left ", "Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();

        }

        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtAmount.Clear();  
            txtRoomNo.Clear();
            txtEmailId.Clear();
            dataGridView1.DataSource = 0;
        }
    }
}
