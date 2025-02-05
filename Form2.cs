using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;

namespace Form_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string connectionString= ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

            
            



            

            string name = nametxt.Text;
            string email = emailtxt.Text;
            string password = passtxt.Text;
            string dob = datetxt.Value.ToString("yyyy-MM-dd"); // Format the DateTimePicker value
            string gender = mtxt.Checked ? "Male" : "Female";

         
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Insert query with parameters
                    string query = "INSERT INTO Hostel_signup (Name, Email, Password, DOB, Gender) VALUES (@Name, @Email, @Password, @DOB, @Gender)";

                    // Create SQL command and set parameters
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                        cmd.Parameters.AddWithValue("@Password", passtxt.Text);
                        cmd.Parameters.AddWithValue("@DOB", datetxt.Value.ToString("yyyy-MM-dd")); // Format the DateTimePicker value
                        cmd.Parameters.AddWithValue("@Gender", mtxt.Checked ? "Male" : "Female");

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Provide feedback
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 ff= new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
