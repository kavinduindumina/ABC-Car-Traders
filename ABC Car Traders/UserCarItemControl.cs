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
    public partial class UserCarItemControl : UserControl
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        // Declare the instance of ViewForm at the class level (only once)
        private ViewForm viewFormInstance;

        // Properties to hold car details
        public string CarID
        {
            get { return carIDLabel.Text; }
            set { carIDLabel.Text = value; }
        }

        public string CarName
        {
            get { return carNameLabel.Text; }
            set { carNameLabel.Text = value; }
        }

        public string CarModel
        {
            get { return modelLabel.Text; }
            set { modelLabel.Text = value; }
        }

        public string Quantity
        {
            get { return qtyLabel.Text; }
            set { qtyLabel.Text = value; }
        }

        public string Price
        {
            get { return priceLabel.Text; }
            set { priceLabel.Text = "Rs: " + value; }
        }

        public Image CarImage
        {
            get { return carPictureBox.Image; }
            set { carPictureBox.Image = value; }
        }

        public UserCarItemControl()
        {
            InitializeComponent();
            // Subscribe to the Click event if it is not done in the designer
            // orderButton.Click += orderButton_Click; // Uncomment if needed
        }

        private void UserCarItemControl_Load(object sender, EventArgs e)
        {
            // Load event logic if needed
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            // Check if the ViewForm instance already exists and is not disposed
            if (viewFormInstance == null || viewFormInstance.IsDisposed)
            {
                // Create a new instance of ViewForm with the necessary parameters
                viewFormInstance = new ViewForm(CarID, CarName, CarModel, Quantity, Price, CarImage);
                viewFormInstance.Show();
            }
            else
            {
                // If the instance already exists, bring it to the front
                viewFormInstance.BringToFront();
            }
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{CarModel} {CarName} added to cart successfully!");
        }
    }
}
