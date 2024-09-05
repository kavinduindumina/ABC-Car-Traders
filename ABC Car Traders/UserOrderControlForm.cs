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
    public partial class UserOrderControlForm : Form
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        public UserOrderControlForm()
        {
            InitializeComponent();
            LoadCustomerOrders();
        }

        private void LoadCustomerOrders()
        {
            int customerID = int.Parse(SessionManager.CustomerID); // Make sure SessionManager.CustomerID is an integer

            string query = "SELECT Orders.OrderID, CarDetails.CarName, CarDetails.CarModel, CarDetails.Price, Orders.Quantity, Orders.Total, Orders.Status " +
                           "FROM Orders " +
                           "INNER JOIN CarDetails ON Orders.ItemID = CarDetails.CarID " +
                           "WHERE Orders.Id = @CustomerID";

            using (SqlCommand cmd = new SqlCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    Con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable ordersTable = new DataTable();
                    adapter.Fill(ordersTable);

                    guna2DataGridView1.DataSource = ordersTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }


            }
        }

        public void RefreshOrders()
        {
            LoadCustomerOrders();
        }
    }
}
