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
    public partial class CustomerControl : UserControl
    {
        private DataTable customerTable;
        private int selectedCustomerId;
        public CustomerControl()
        {
            InitializeComponent();
            InitializeCustomerTable();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");


        private void InitializeCustomerTable()
        {
            customerTable = new DataTable();
            customerTable.Columns.Add("Id", typeof(int));
            customerTable.Columns.Add("FirstName", typeof(string));
            customerTable.Columns.Add("LastName", typeof(string));
            customerTable.Columns.Add("Email", typeof(string));

            guna2DataGridView1.DataSource = customerTable;
        }

        // Add New customers 
        private void Addbtn_Click(object sender, EventArgs e)
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
                string query = "INSERT INTO Customers (FirstName, LastName, Email, PasswordHash) OUTPUT INSERTED.Id VALUES (@FirstName, @LastName, @Email, @PasswordHash)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                // Execute the query and get the inserted CustomerId
                int Id = (int)cmd.ExecuteScalar();

                MessageBox.Show("Customer Added Successfully");
                Con.Close();

                // Clear the TextBox fields after successful registration
                FirstNametxt.Text = "";
                LastNametxt.Text = "";
                Emailtxt.Text = "";
                Passwordtxt.Text = "";

                // Add the new customer to the DataTable
                customerTable.Rows.Add(Id, firstName, lastName, email);
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                selectedCustomerId = Convert.ToInt32(row.Cells["Id"].Value);
                FirstNametxt.Text = row.Cells["FirstName"].Value.ToString();
                LastNametxt.Text = row.Cells["LastName"].Value.ToString();
                Emailtxt.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }



        // Update Customer details

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNametxt.Text;
            string lastName = LastNametxt.Text;
            string email = Emailtxt.Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            try
            {
                Con.Open();
                string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Id", selectedCustomerId);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Customer Updated Successfully");

                // Update the DataTable
                DataRow row = customerTable.Select($"Id = {selectedCustomerId}").FirstOrDefault();
                if (row != null)
                {
                    row["FirstName"] = firstName;
                    row["LastName"] = lastName;
                    row["Email"] = email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        // Show customers in data table
        private void LoadCustomerData()
        {
            try
            {
                Con.Open();
                string query = "SELECT Id, FirstName, LastName, Email FROM Customers";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.Fill(customerTable);
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            FirstNametxt.Text = "";
            LastNametxt.Text = "";
            Emailtxt.Text = "";
            Passwordtxt.Text = "";
        }


        //Delete Customer data
        private void Deletebtn_Click(object sender, EventArgs e)
        {
                if (selectedCustomerId == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            try
            {
                Con.Open();
                string query = "DELETE FROM Customers WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Id", selectedCustomerId);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Customer Deleted Successfully");

                // Remove the deleted customer from the DataTable
                DataRow row = customerTable.Select($"Id = {selectedCustomerId}").FirstOrDefault();
                if (row != null)
                {
                    customerTable.Rows.Remove(row);
                }

                // Clear the TextBox fields
                FirstNametxt.Text = "";
                LastNametxt.Text = "";
                Emailtxt.Text = "";
                Passwordtxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
    }
}
    