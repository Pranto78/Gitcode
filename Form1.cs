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

namespace Form_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 signupForm = new Form2();
            signupForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-TD5FI3C\SQLEXPRESS;Initial Catalog=Hostel_Mange;Integrated Security=True";

            // Get user inputs
            string username = Usenametxt.Text; // Username or Email field
            string password = passtxt2.Text; // Password field

            // SQL query to validate user credentials
            string query = "SELECT COUNT(*) FROM Hostel_signup WHERE Email = @Email AND Password = @Password";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Email", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query and get the result
                        int userExists = (int)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            // Login successful
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open the next form (e.g., DashboardForm)
                            Form3 dashboard = new Form3();
                            dashboard.Show();

                            // Hide the current form
                            this.Hide();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Show Password checkbox
        private void checktxt_CheckedChanged(object sender, EventArgs e)
        {

            if (checktxt.Checked)
            {
                passtxt2.UseSystemPasswordChar = true;
            }
            else
            {
                passtxt2.UseSystemPasswordChar = false;
            }



        }

        


    }
}
