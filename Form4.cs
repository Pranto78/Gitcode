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
            this.Location = new Point(350,200);

            Query = "select * from New_Room ";

            DataSet ds = fn.getData(Query);
            dataGridView1.DataSource = ds.Tables[0];



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query = "select * from New_Room where Room_No =" + textBox1.Text + "";
            DataSet ds = fn.getData(Query);

            if (ds.Tables[0].Rows.Count==0)
            {

                String status;

                if(checkBox1.Checked)
                {
                    status = "Yes";

                }
                else
                {
                    status = "No";
                }

                //String book;
                //if()

                Labelroomexist.Visible = false;

                Query = "insert into New_Room (Room_No,Room_Status,Room_Booked) values (" + textBox1.Text + ",'"+status+ "', 'NO')";
                fn.setData(Query,"Room Added ");
                Form4_Load(this, null);



            }
            else
            {

                Labelroomexist.Text = "Room Already Exist ";
                Labelroomexist.Visible = true;



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query = "select * from New_Room where Room_No =" + textBox2.Text + "";
            DataSet ds = fn.getData(Query);

            if (ds.Tables[0].Rows.Count==0)
            {

                Labelroom.Text = "No Room Exist";
                Labelroom.Visible = true;
                checkBox2.Checked = false;

            }
            else
            {

                Labelroom.Text = "Room Found";
                Labelroom.Visible = true;

                if (ds.Tables[0].Rows[0][1].ToString()=="Yes")
                {
                    checkBox2.Checked = true;


                }
                else
                {
                    checkBox2.Checked = false;
                }


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String status;

            if(checkBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";

            }
            Query = "update New_Room set Room_Status='" + status + "' where Room_No="+ textBox2.Text+ " ";
            fn.setData(Query,"Details Updated");
            Form4_Load(this, null);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Labelroom.Text=="Room Found")
            {
                Query = "delete from New_Room where Room_No= " + textBox2.Text + "";
                fn.setData(Query, "Room Details Deleted");
                Form4_Load(this, null);



            }
            else
            {
                MessageBox.Show("Trying to Delete which dosen't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
