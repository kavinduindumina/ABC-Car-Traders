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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ABC_Car_Traders
{
    public partial class CarControl : UserControl
    {
        public CarControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(CarControl_Load);
            CarDataGridView.CellClick += new DataGridViewCellEventHandler(CarDataGridView_CellContentClick);
            SearchButton.Click += new EventHandler(SearchButton_Click);
            Pricetxt.Maximum = 10000000; 

        }

        SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }


        // Add New Car
        private void SaveCarDetailsButton_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {

                {
                    try
                    {
                        Con.Open();
                        using (SqlCommand command = new SqlCommand("INSERT INTO CarDetails (CarName, CarModel, Quantity, Price, CarImage) VALUES (@CarName, @CarModel, @Quantity, @Price, @CarImage)", Con))
                        {
                            command.Parameters.AddWithValue("@CarName", CarNametxt.Text);
                            command.Parameters.AddWithValue("@CarModel", CarModeltxt.Text);
                            command.Parameters.AddWithValue("@Quantity", Quantitytxt.Value);
                            command.Parameters.AddWithValue("@Price", Pricetxt.Value);

                            MemoryStream ms = new MemoryStream();
                            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
                            command.Parameters.AddWithValue("@CarImage", ms.ToArray());

                            command.ExecuteNonQuery();
                            MessageBox.Show("Car Added Successfully");
                            Con.Close();

                            // Clear the TextBox fields after successful added car
                            ClearFields();

                            // Reload the data grid view
                            LoadCarData();
                        }
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

        private void LoadCarData()
        {
            try
            {
                Con.Open();
                using (SqlCommand command = new SqlCommand("SELECT CarId, CarName, CarModel, Quantity, Price, CarImage FROM CarDetails", Con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CarDataGridView.DataSource = dt;
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

        private void CarControl_Load(object sender, EventArgs e)
        {
            LoadCarData();
        }

        private void CarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CarDataGridView.Rows[e.RowIndex];
                CarIdtxt.Text = row.Cells["CarID"].Value.ToString();
                CarNametxt.Text = row.Cells["CarName"].Value.ToString();
                CarModeltxt.Text = row.Cells["CarModel"].Value.ToString();
                Quantitytxt.Value = Convert.ToDecimal(row.Cells["Quantity"].Value);
                Pricetxt.Value = Convert.ToDecimal(row.Cells["Price"].Value);

                if (row.Cells["CarImage"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["CarImage"].Value;
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

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            CarIdtxt.Text = "";
            CarNametxt.Text = "";
            CarModeltxt.Text = "";
            Quantitytxt.Value = 0;
            Pricetxt.Value = 0;
            PictureBox1.Image = null;
        }

        //Update Car details

        private void UpdateCarDetails()
        {
            if (PictureBox1.Image != null && !string.IsNullOrEmpty(CarIdtxt.Text))
            {
                try
                {
                    Con.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE CarDetails SET CarName = @CarName, CarModel = @CarModel, Quantity = @Quantity, Price = @Price, CarImage = @CarImage WHERE CarID = @CarID", Con))
                    {
                        command.Parameters.AddWithValue("@CarID", CarIdtxt.Text);
                        command.Parameters.AddWithValue("@CarName", CarNametxt.Text);
                        command.Parameters.AddWithValue("@CarModel", CarModeltxt.Text);
                        command.Parameters.AddWithValue("@Quantity", Quantitytxt.Value);
                        command.Parameters.AddWithValue("@Price", Pricetxt.Value);

                        using (MemoryStream ms = new MemoryStream())
                        {
                            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
                            command.Parameters.AddWithValue("@CarImage", ms.ToArray());
                        }

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Updated Successfully");
                        Con.Close();

                        // Clear the TextBox fields after successful update
                        ClearFields();

                        // Reload the data grid view
                        LoadCarData();
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
        }


        // clear field method

        private void ClearFields()
        {
            CarIdtxt.Text = "";
            CarNametxt.Text = "";
            CarModeltxt.Text = "";
            Quantitytxt.Value = 0;
            Pricetxt.Value = 0;
            PictureBox1.Image = null;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateCarDetails();
        }


        // Delete Car details

        private void DeleteCarDetails()
        {
            if (!string.IsNullOrEmpty(CarIdtxt.Text))
            {
                // Prompt the user with a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Con.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM CarDetails WHERE CarID = @CarID", Con))
                        {
                            command.Parameters.AddWithValue("@CarID", CarIdtxt.Text);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Car Deleted Successfully");
                            Con.Close();

                            // Clear the TextBox fields after successful deletion
                            ClearFields();

                            // Reload the data grid view
                            LoadCarData();
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
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }


        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteCarDetails();
        }

        //Search Car details

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchCarByName(CarNametxt.Text);
        }



    }

}
