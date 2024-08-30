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
    public partial class OrderControl : UserControl
    {


        SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        public OrderControl()
        {
            InitializeComponent();
            InitializeStatusBox();


        }

        private void InitializeStatusBox()
        {
            Statusbox.Items.Clear();
            Statusbox.Items.Add("Inprogress");
            Statusbox.Items.Add("Completed");

        }



        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                // Set the OrderID to the OrderIdtxt TextBox
                OrderIdtxt.Text = selectedRow.Cells["OrderID"].Value.ToString();

                // Set the Status to the Statusbox ComboBox
                string status = selectedRow.Cells["Status"].Value.ToString();
                if (Statusbox.Items.Contains(status))
                {
                    Statusbox.SelectedItem = status;
                }
                else
                {
                    Statusbox.SelectedIndex = -1; // Clear selection if status not found
                }
            }
        }


        // Show Order Details in the table
        private void OrderControl_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            try
            {
                // Ensure the connection is closed before opening
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                // Open the SQL connection
                Con.Open();

                // Define the query to fetch all orders
                string query = "SELECT [OrderID], [ItemID], [Id], [Address], [MobileNumber], [CreatedAt], [UpdatedAt], [Status], [Total], [Quantity] FROM [ABC_Car_Traders].[dbo].[Orders]";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, Con))
                {
                    // DataTable to hold the data temporarily
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Set the DataSource of the DataGridView to the DataTable
                    guna2DataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Show any errors that occur during data retrieval
                MessageBox.Show("An error occurred while loading orders: " + ex.Message);
            }
            finally
            {
                // Ensure the SQL connection is closed after data retrieval
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OrderIdtxt.Text) || Statusbox.SelectedItem == null)
            {
                MessageBox.Show("Please select an order and a status to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int orderId = int.Parse(OrderIdtxt.Text);
            string newStatus = Statusbox.SelectedItem.ToString();

            try
            {
                // Ensure the connection is closed before opening
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }

                // Open the SQL connection
                Con.Open();

                // Define the update query with parameters
                string query = "UPDATE [ABC_Car_Traders].[dbo].[Orders] SET [Status] = @Status, [UpdatedAt] = @UpdatedAt WHERE [OrderID] = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);

                    // Execute the update command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadOrderData(); // Reload the updated data
                    }
                    else
                    {
                        MessageBox.Show("Order update failed. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors that occur during the update
                MessageBox.Show("An error occurred while updating the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the SQL connection is closed after the update
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            OrderIdtxt.Text = "";
            Statusbox.SelectedIndex = -1;
        }
    }
}
