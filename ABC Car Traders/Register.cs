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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

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

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNametxt.Text;
            string lastName = LastNametxt.Text;
            string email = Emailtxt.Text;
            string password = Passwordtxt.Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Hash the password
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            try
            {
                Con.Open();
                string query = "INSERT INTO Customers (FirstName, LastName, Email, PasswordHash) VALUES (@FirstName, @LastName, @Email, @PasswordHash)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully");
                Con.Close();
            } catch (Exception ex)
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
