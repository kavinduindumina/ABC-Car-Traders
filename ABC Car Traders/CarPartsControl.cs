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
    public partial class CarPartsControl : UserControl
    {
        public CarPartsControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(CarPartsControl_Load);
            PartsDataGridView.CellClick += new DataGridViewCellEventHandler(PartsDataGridView_CellContentClick);
            Pricetxt.Maximum = 10000000; 


        }

        SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        private void CarPartsControl_Load(object sender, EventArgs e)
        {
            LoadCarPartsData();
        }

        private void LoadPartImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PartImagePictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        //Clear function

        private void ClearFields()
        {
            PartIDtxt.Text = "";
            PartNametxt.Text = "";
            PartModeltxt.Text = "";
            Quantitytxt.Value = 0;
            Pricetxt.Value = 0;
            PartImagePictureBox.Image = null;
        }

        private void SavePartDetailsButton_Click(object sender, EventArgs e)
        {
            AddCarPart();
        }

        // Add New Car Part
        private void AddCarPart()
        {
            if (PartImagePictureBox.Image != null)
            {
                try
                {
                    Con.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO CarParts (PartName, PartModel, Quantity, Price, PartImage) VALUES (@PartName, @PartModel, @Quantity, @Price, @PartImage)", Con))
                    {
                        command.Parameters.AddWithValue("@PartName", PartNametxt.Text);
                        command.Parameters.AddWithValue("@PartModel", PartModeltxt.Text);
                        command.Parameters.AddWithValue("@Quantity", Quantitytxt.Value);
                        command.Parameters.AddWithValue("@Price", Pricetxt.Value);

                        MemoryStream ms = new MemoryStream();
                        PartImagePictureBox.Image.Save(ms, PartImagePictureBox.Image.RawFormat);
                        command.Parameters.AddWithValue("@PartImage", ms.ToArray());

                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Part Added Successfully");
                        Con.Close();

                        // Clear the TextBox fields after successful registration
                        ClearFields();

                        // Reload the data grid view
                        LoadCarPartsData();
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


        // Select Car Part

        private void PartsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PartsDataGridView.Rows[e.RowIndex];
                PartIDtxt.Text = row.Cells["PartID"].Value.ToString();
                PartNametxt.Text = row.Cells["PartName"].Value.ToString();
                PartModeltxt.Text = row.Cells["PartModel"].Value.ToString();
                Quantitytxt.Value = Convert.ToDecimal(row.Cells["Quantity"].Value);
                Pricetxt.Value = Convert.ToDecimal(row.Cells["Price"].Value);

                if (row.Cells["PartImage"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["PartImage"].Value;
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
        }
        private void LoadCarPartsData()
        {
            try
            {
                Con.Open();
                using (SqlCommand command = new SqlCommand("SELECT PartID, PartName, PartModel, Quantity, Price, PartImage FROM CarParts", Con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    PartsDataGridView.DataSource = dt;
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


        // clear text boxes
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            PartIDtxt.Text = "";
            PartNametxt.Text = "";
            PartModeltxt.Text = "";
            Quantitytxt.Value = 0;
            Pricetxt.Value = 0;
            PartImagePictureBox.Image = null;
        }



        // delete item
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeletePartDetails();
        }

        private void DeletePartDetails()
        {
            if (!string.IsNullOrEmpty(PartIDtxt.Text))
            {
                // Prompt the user with a confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Part?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Con.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM CarDetails WHERE CarParts = @PartID", Con))
                        {
                            command.Parameters.AddWithValue("@PartID", PartIDtxt.Text);

                            command.ExecuteNonQuery();
                            MessageBox.Show("This Part Deleted Successfully");
                            Con.Close();

                            // Clear the TextBox fields after successful deletion
                            ClearFields();

                            // Reload the data grid view
                            LoadCarPartsData();
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
                MessageBox.Show("Please select a Car Part to delete.");
            }
        }


        // Search Parts
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
    }
}
