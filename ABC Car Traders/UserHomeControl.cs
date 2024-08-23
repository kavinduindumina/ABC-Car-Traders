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
    public partial class UserHomeControl : UserControl
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        public UserHomeControl()
        {
            InitializeComponent();
            LoadCarDetails(); // Call to load data when the control initializes
            LoadPartDetails();
        }

        private void LoadCarDetails()
        {
            try
            {
                Con.Open();
                string query = "SELECT CarID, CarName, CarModel, Quantity, Price, CarImage FROM CarDetails"; // Adjust the query as per your actual table and column names
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No car details found in the database.");
                    reader.Close();
                    Con.Close();
                    return; // Exit the method early
                }

                while (reader.Read())
                {
                    // Create an instance of the UserCarItemControl
                    UserCarItemControl carItemControl = new UserCarItemControl();

                    // Set properties with database data
                    carItemControl.CarName = reader["CarName"].ToString();
                    carItemControl.CarModel = reader["CarModel"].ToString();
                    carItemControl.Quantity = reader["Quantity"].ToString();
                    carItemControl.Price = Convert.ToDecimal(reader["Price"]).ToString();

                    // Debugging: Print or display the fetched data
                    Console.WriteLine($"Loaded Car: {carItemControl.CarName}, Model: {carItemControl.CarModel}, Price: {carItemControl.Price}");

                    // Load the image from the database
                    if (reader["CarImage"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["CarImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            carItemControl.CarImage = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        carItemControl.CarImage = null;
                    }

                    // Add the control to a parent container, like a Panel or FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(carItemControl); // 'flowLayoutPanel1' should be the container you use in your form
                }

                reader.Close();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading car details: " + ex.Message);
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void LoadPartDetails()
        {
            try
            {
                Con.Open();
                string query = "SELECT PartID, PartName, PartModel, Quantity, Price, PartImage FROM CarParts"; // Adjust the query as per your actual table and column names
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No car details found in the database.");
                    reader.Close();
                    Con.Close();
                    return; // Exit the method early
                }

                while (reader.Read())
                {
                    // Create an instance of the UserCarItemControl
                    UserCarItemControl carItemControl = new UserCarItemControl();

                    // Set properties with database data
                    carItemControl.CarName = reader["PartName"].ToString();
                    carItemControl.CarModel = reader["PartModel"].ToString();
                    carItemControl.Quantity = reader["Quantity"].ToString();
                    carItemControl.Price = Convert.ToDecimal(reader["Price"]).ToString();

                    // Debugging: Print or display the fetched data
                    Console.WriteLine($"Loaded Car: {carItemControl.CarName}, Model: {carItemControl.CarModel}, Price: {carItemControl.Price}");

                    // Load the image from the database
                    if (reader["PartImage"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["PartImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            carItemControl.CarImage = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        carItemControl.CarImage = null;
                    }

                    // Add the control to a parent container, like a Panel or FlowLayoutPanel
                    flowLayoutPanel2.Controls.Add(carItemControl); // 'flowLayoutPanel1' should be the container you use in your form
                }

                reader.Close();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading car details: " + ex.Message);
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
    }
}
