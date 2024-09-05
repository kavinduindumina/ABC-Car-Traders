using Microsoft.Data.SqlClient;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string email = Emailtxt.Text;
            string password = Passwordtxt.Text;

            // Check if admin
            try
            {
                Con.Open();
                string adminQuery = "SELECT [AdminId], [Email], [PasswordHash] FROM [Admin] WHERE [Email] = @Email";
                using (SqlCommand cmdAdmin = new SqlCommand(adminQuery, Con))
                {
                    cmdAdmin.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader readerAdmin = cmdAdmin.ExecuteReader())
                    {
                        if (readerAdmin.Read())
                        {
                            string storedAdminPasswordHash = readerAdmin["PasswordHash"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(password, storedAdminPasswordHash))
                            {
                                // Set session for admin
                                int adminId = readerAdmin.GetInt32(readerAdmin.GetOrdinal("AdminId")); // Updated to use "AdminId"
                                SessionManager.SetCustomerDetails(adminId.ToString(), "Admin", "Admin", email, true);

                                // Redirect to admin dashboard
                                AdminDashboard adminDashboard = new AdminDashboard();
                                adminDashboard.Show();
                                this.Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                                return;
                            }
                        }
                    }
                }

                // If not admin, check if customer
                string customerQuery = "SELECT [Id], [FirstName], [LastName], [Email], [PasswordHash] FROM [Customers] WHERE [Email] = @Email";
                using (SqlCommand cmdCustomer = new SqlCommand(customerQuery, Con))
                {
                    cmdCustomer.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader readerCustomer = cmdCustomer.ExecuteReader())
                    {
                        if (readerCustomer.Read())
                        {
                            string storedCustomerPasswordHash = readerCustomer["PasswordHash"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, storedCustomerPasswordHash))
                            {
                                // Retrieve and set customer details
                                int customerId = readerCustomer.GetInt32(readerCustomer.GetOrdinal("Id"));
                                string firstName = readerCustomer["FirstName"].ToString();
                                string lastName = readerCustomer["LastName"].ToString();
                                string loggedInEmail = readerCustomer["Email"].ToString();

                                // Set session details
                                SessionManager.SetCustomerDetails(customerId.ToString(), firstName, lastName, loggedInEmail, false);

                                // Redirect to home page
                                Home home = new Home();
                                home.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


        private void Adminbtn_Click(object sender, EventArgs e)
        {
            AddAdminForm addAdminForm = new AddAdminForm();
            addAdminForm.Show();
        }
    }
}
