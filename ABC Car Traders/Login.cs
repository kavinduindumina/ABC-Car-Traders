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
            if (email == "admin@abc.com" && password == "Admin")
            {

                // Set session
                SessionManager.LoggedInEmail = email;
                SessionManager.IsAdmin = true;


                // Redirect to admin dashboard
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
                return;
            }

            // Check if customer
            try
            {
                Con.Open();
                string query = "SELECT PasswordHash FROM Customers WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Email", email);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedPasswordHash = reader["PasswordHash"].ToString();

                    if (BCrypt.Net.BCrypt.Verify(password, storedPasswordHash))
                    {

                        // Set session
                        SessionManager.LoggedInEmail = email;
                        SessionManager.IsAdmin = false;


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

                reader.Close();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
    }
}
