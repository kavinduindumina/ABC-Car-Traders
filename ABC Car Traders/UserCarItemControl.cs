using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class UserCarItemControl : UserControl
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        // Declare the instance of ViewForm at the class level (only once)
        private ViewForm viewFormInstance;

        public int CarID
        {
            get
            {
                if (int.TryParse(carIDLabel.Text, out int result))
                {
                    return result;
                }
                else
                {
                    MessageBox.Show("Invalid Car ID");
                    return 0; // Default value or handle appropriately
                }
            }
            set
            {
                carIDLabel.Text = value.ToString();
            }
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

        public decimal Price
        {
            get
            {
                if (decimal.TryParse(priceLabel.Text.Replace("Rs: ", "").Trim(), out decimal result))
                {
                    return result;
                }
                else
                {
                    return 0m;
                }
            }
            set
            {
                priceLabel.Text = "Rs: " + value.ToString("N");
            }
        }

        public Image CarImage
        {
            get { return carPictureBox.Image; }
            set { carPictureBox.Image = value; }
        }

        public UserCarItemControl()
        {
            InitializeComponent();
        }

        private void UserCarItemControl_Load(object sender, EventArgs e)
        {
            // Load event logic if needed
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (viewFormInstance == null || viewFormInstance.IsDisposed)
            {
                viewFormInstance = new ViewForm(CarID, CarName, CarModel, Quantity, Price, CarImage);
                viewFormInstance.Show();
            }
            else
            {
                viewFormInstance.BringToFront();
            }
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{CarModel} {CarName} added to cart successfully!");
        }
    }
}
