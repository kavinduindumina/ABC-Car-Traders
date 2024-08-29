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
                    carPartControl.PartID = Convert.ToInt32(reader["PartID"]);
                    carPartControl.PartName = reader["PartName"].ToString();
                    carPartControl.PartModel = reader["PartModel"].ToString();
                    carPartControl.Quantity = reader["Quantity"].ToString();
                    carPartControl.Price = Convert.ToDecimal(reader["Price"]);

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


        // Serach parts
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchPartByName(PartNametxt.Text);
        }

        private void SearchPartByName(string PartName)
        {
            if (!string.IsNullOrEmpty(PartName))
            {
                try
                {
                    Con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT PartID, PartName, PartModel, Quantity, Price, PartImage FROM CarParts WHERE PartName = @PartName", Con))
                    {
                        command.Parameters.AddWithValue("@PartName", PartName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PartIDtxt.Text = reader["PartID"].ToString();

                                PartNametxt.Text = reader["PartName"].ToString();
                                PartModeltxt.Text = reader["PartModel"].ToString();
                                Quantitytxt.Value = Convert.ToDecimal(reader["Quantity"]);
                                Pricetxt.Value = Convert.ToDecimal(reader["Price"]);

                                if (reader["PartImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["PartImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        PartImagePictureBox.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    PartImagePictureBox.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No part found with the provided name.");
                                ClearFields();
                            }
                        }
                    }
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
            else
            {
                MessageBox.Show("Please enter a car part name to search.");
            }
        }

        // clear field method

        private void ClearFields()
        {

            PartNametxt.Text = "";

        }
    }
}
