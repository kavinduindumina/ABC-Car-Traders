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
    public partial class UserVehiclePartControl : UserControl
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        public UserVehiclePartControl()
        {
            InitializeComponent();
            LoadPartDetails();
        }


        private void LoadPartDetails()
        {
            try
            {
                Con.Open();
                string query = "SELECT PartID, PartName, PartModel, Quantity, Price, PartImage FROM CarParts"; 
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No car details found in the database.");
                    reader.Close();
                    Con.Close();
                    return; 
                }

                while (reader.Read())
                {
                    // Create an instance of the UserCarItemControl
                    UserCarPartControl carPartControl = new UserCarPartControl();

                    // Set properties with database data
                    carPartControl.PartName = reader["PartName"].ToString();
                    carPartControl.PartModel = reader["PartModel"].ToString();
                    carPartControl.Quantity = reader["Quantity"].ToString();
                    carPartControl.Price = Convert.ToDecimal(reader["Price"]).ToString();

                    // Debugging: Print or display the fetched data
                    Console.WriteLine($"Loaded Part: {carPartControl.PartName}, Model: {carPartControl.PartModel}, Price: {carPartControl.Price}");

                    // Load the image from the database
                    if (reader["PartImage"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["PartImage"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            carPartControl.CarImage = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        carPartControl.CarImage = null;
                    }

                    // Add the control to a parent container, like a Panel or FlowLayoutPanel
                    partsLayoutPanel.Controls.Add(carPartControl); // 'flowLayoutPanel1' should be the container you use in your form
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
