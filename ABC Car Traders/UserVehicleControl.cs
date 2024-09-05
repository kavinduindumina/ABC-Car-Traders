using Microsoft.Data.SqlClient;
using System.Data;

namespace ABC_Car_Traders
{
    public partial class UserVehicleControl : UserControl
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        public UserVehicleControl()
        {
            InitializeComponent();
            LoadCarDetails();
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
                    carItemControl.CarID = Convert.ToInt32(reader["CarID"]);
                    carItemControl.CarName = reader["CarName"].ToString();
                    carItemControl.CarModel = reader["CarModel"].ToString();
                    carItemControl.Quantity = reader["Quantity"].ToString();
                    carItemControl.Price = Convert.ToDecimal(reader["Price"]);


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
                    carLayoutPanel.Controls.Add(carItemControl); // 'flowLayoutPanel1' should be the container you use in your form
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

        private void UserVehicleControl_Load(object sender, EventArgs e)
        {

        }


        // Search Vehicle by name
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchCarByName(CarNametxt.Text);
        }

        private void SearchCarByName(string carName)
        {
            if (!string.IsNullOrEmpty(carName))
            {
                try
                {
                    Con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT CarID, CarName, CarModel, Quantity, Price, CarImage FROM CarDetails WHERE CarName = @CarName", Con))
                    {
                        command.Parameters.AddWithValue("@CarName", carName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CarIdtxt.Text = reader["CarID"].ToString();
                                CarNametxt.Text = reader["CarName"].ToString();
                                CarModeltxt.Text = reader["CarModel"].ToString();
                                Quantitytxt.Value = Convert.ToDecimal(reader["Quantity"]);
                                Pricetxt.Value = Convert.ToDecimal(reader["Price"]);

                                if (reader["CarImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["CarImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        PictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    PictureBox1.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No car found with the provided name.");
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
                MessageBox.Show("Please enter a car name to search.");
            }
        }

        // clear field method

        private void ClearFields()
        {

            CarNametxt.Text = "";

        }
    }
}
