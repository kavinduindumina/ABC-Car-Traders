using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ABC_Car_Traders
{
    public partial class ViewForm : Form
    {
        public ViewForm(int carID, string carName, string carModel, string quantity, decimal price, Image carImage)
        {
            InitializeComponent();


            // Set the form controls with the passed car details

            carIDLable.Text = carID.ToString();
            carNameLabel.Text = carName;
            modelLabel.Text = carModel;
            qtyLabel.Text = quantity;
            priceLabel.Text = price.ToString("N");  // Convert decimal to string with formatting
            carPictureBox.Image = carImage;

        }



        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            string carID = carIDLable.Text;
            string carName = carNameLabel.Text;
            string carModel = modelLabel.Text;
            Image carImage = carPictureBox.Image;

            // Convert the price text to decimal
            if (decimal.TryParse(priceLabel.Text, out decimal price))
            {
                // Pass these details to CreateOrderForm
                CreateOrderForm createOrderForm = new CreateOrderForm(carID, carName, carModel, price, carImage);
                createOrderForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid price format. Please check the price details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
