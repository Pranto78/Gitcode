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
    public partial class Form5 : Form
    {
        function fn = new function();
        String query;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 200);
            query = "select Room_No from New_Room where Room_Status = 'Yes' and Room_Booked = 'No'";
            DataSet ds = fn.getData(query);

             for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                cmbBoxRoomNumber.Items.Add(room);
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
            txtFather.Clear();
            txtEmail.Clear();
            txtMother.Clear();
            txtPermanent.Clear();
            txtCollege.Clear();
            txtId.Clear();
            cmbBoxRoomNumber.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermanent.Text != "" && txtCollege.Text != "" && cmbBoxRoomNumber.SelectedIndex != -1)

            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String father = txtFather.Text;
                String mother = txtMother.Text;
                String email = txtEmail.Text;
                String permanent = txtPermanent.Text;
                String college = txtCollege.Text;
                String id = txtId.Text;
                Int64 room = Int64.Parse(cmbBoxRoomNumber.Text);

                query = "insert into newStudent  (mobile,name,fname,mname,email,paddress,college,idproof,Room_No) values (" + mobile + ",'" + name + "','" + father + "', '" + mother + "', '" + email + "', '" + permanent + "', '" + college + "', '" + id + "', " + room + ")  update New_Room set Room_Booked = 'Yes' where Room_No = " + room + "";
                fn.setData(query, "Student Registration Successful");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all empty space ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbBoxRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
