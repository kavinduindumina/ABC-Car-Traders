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
using FluentValidation.Results;
using FluentValidation;

namespace ABC_Car_Traders
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            _validator = new CustomerValidator();
        }
        private readonly CustomerValidator _validator;
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

            // Create a Customer instance
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            // Validate the input
            ValidationResult results = _validator.Validate(customer);

            if (!results.IsValid)
            {
                // Display validation errors
                string errors = string.Join(Environment.NewLine, results.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(errors);
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
                MessageBox.Show("Customer Registration Successfully");
                Con.Close();


                // Clear the TextBox fields after successful registration
                FirstNametxt.Text = "";
                LastNametxt.Text = "";
                Emailtxt.Text = "";
                Passwordtxt.Text = "";

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
