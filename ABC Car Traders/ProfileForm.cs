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

namespace ABC_Car_Traders
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            LoadProfileDetails();
        }

        private void LoadProfileDetails()
        {
            id.Text = SessionManager.CustomerID.ToString();
            firstname.Text = SessionManager.FirstName;
            lastname.Text = SessionManager.LastName;
            email.Text = SessionManager.Email;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            // Check if new password is empty
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("New password cannot be empty.");
                return;
            }

            // Check if new password and confirmation match
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirmation do not match.");
                return;
            }

            // Check if the current password is correct
            if (VerifyCurrentPassword(currentPassword))
            {
                // Hash the new password with bcrypt
                string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                // Update the password in the database
                if (UpdatePasswordInDatabase(hashedNewPassword))
                {
                    MessageBox.Show("Password changed successfully!");
                }
                else
                {
                    MessageBox.Show("Error updating password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Current password is incorrect.");
            }
        }

        // Method to verify if the current password matches the stored hash in the database
        private bool VerifyCurrentPassword(string currentPassword)
        {
            bool isPasswordCorrect = false;

            using (SqlConnection con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                string query = "SELECT PasswordHash FROM Customers WHERE Id = @CustomerId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", SessionManager.CustomerID);

                    string storedPasswordHash = (string)cmd.ExecuteScalar();

                    // Check if the stored password hash is null or empty
                    if (!string.IsNullOrEmpty(storedPasswordHash) && BCrypt.Net.BCrypt.Verify(currentPassword, storedPasswordHash))
                    {
                        isPasswordCorrect = true;
                    }
                }
                con.Close();
            }

            return isPasswordCorrect;
        }

        // Method to update the password in the database
        private bool UpdatePasswordInDatabase(string hashedNewPassword)
        {
            bool isUpdated = false;

            using (SqlConnection con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                string query = "UPDATE Customers SET PasswordHash = @NewPassword WHERE Id = @CustomerId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NewPassword", hashedNewPassword);
                    cmd.Parameters.AddWithValue("@CustomerId", SessionManager.CustomerID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isUpdated = true;
                    }
                }
                con.Close();
            }

            return isUpdated;
        }
    }
}
