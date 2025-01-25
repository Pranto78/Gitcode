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
            Labelroomexist.Visible = false;
            Labelroom.Visible = false;

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
    }
}
