using Microsoft.Data.SqlClient;
using Stimulsoft.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AddAdminForm : Form
    {
        private readonly string connectionString = @"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False";

        public AddAdminForm()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                InsertAdmin();
            }
        }

        // Validate input fields
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(Emailtxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text))
            {
                MessageBox.Show("Email and password are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidEmail(Emailtxt.Text))
            {
                MessageBox.Show("Invalid email format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        // Email validation logic
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Insert new admin into the database
        private void InsertAdmin()
        {
            string email = Emailtxt.Text;
            string password = Passwordtxt.Text;

            try
            {
                // Hash the password using BCrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // SQL query to insert a new admin record with hashed password
                string query = "INSERT INTO [Admin] ([Email], [PasswordHash]) VALUES (@Email, @PasswordHash)";

                using (SqlConnection Con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                    Con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin account created successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create admin account.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
