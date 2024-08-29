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
    public partial class CreateOrderForm : Form
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        // Fields to store car or part details
        private string carID;
        private string carName;
        private string carModel;
        private decimal price;
        private Image carImage;
        private string customerID;
        private string firstName;
        private string lastName;
        public CreateOrderForm(string carID, string carName, string carModel, decimal price, Image carImage)
        {

            InitializeComponent();

            this.carID = carID;
            this.carName = carName;
            this.carModel = carModel;
            this.price = price;
            decimal totalPrice = decimal.Parse(totalLable.Text.Replace(",", ""));
            this.carImage = carImage;

            LoadDetails();
            LoadCustomerDetails();
        }

        private void LoadDetails()
        {
            // Set car or part details in controls
            carIDLable.Text = carID;
            carNameLabel.Text = carName;
            modelLabel.Text = carModel;
            priceLabel.Text = price.ToString("N0"); // formatted price
            carPictureBox.Image = carImage;
            totalLable.Text = price.ToString("N0");
        }

        private void LoadCustomerDetails()
        {


            customerIdtxt.Text = customerID;
            FirstNametxt.Text = firstName;
            LastNametxt.Text = lastName;
        }

        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        {
            // Calculate total price when quantity changes
            if (int.TryParse(Qtytxt.Text, out int quantity))
            {
                decimal totalPrice = price * quantity;
                totalLable.Text = totalPrice.ToString("N0"); // Display formatted total price
            }
            else
            {
                totalLable.Text = price.ToString("N0");
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            // Insert order into the database
            string address = Addresstxt.Text;
            string mobileNumber = Mobiletxt.Text;
            int quantity = int.Parse(Qtytxt.Text);

            // Corrected parsing from string to decimal
            decimal totalPrice = decimal.Parse(totalLable.Text.Replace(",", ""));

            string query = "INSERT INTO Orders (CarID, Id, Address, MobileNumber, CreatedAt, UpdatedAt, Status) VALUES (@CarID, @CustomerID, @Address, @MobileNumber, @CreatedAt, @UpdatedAt, @Status)";

            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@CarID", carID);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "Inprogress");

                try
                {
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order created successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating order: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
