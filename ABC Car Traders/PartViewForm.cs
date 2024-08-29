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
    public partial class PartViewForm : Form
    {
        public PartViewForm(int partID, string partName, string partModel, string quantity, decimal price, Image partImage)
        {
            InitializeComponent();

            partIDLable.Text = partID.ToString();
            partNameLabel.Text = partName;
            modelLabel.Text = partModel;
            qtyLabel.Text = quantity;
            priceLabel.Text = price.ToString("N");
            carPictureBox.Image = partImage;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            string partID = partIDLable.Text;
            string partName = partNameLabel.Text;
            string partModel = modelLabel.Text;
            Image partImage = carPictureBox.Image;

            if (decimal.TryParse(priceLabel.Text, out decimal price))
            {
                //Pass this details create order from -- order ekat
                CreateOrderForm createOrderForm = new CreateOrderForm(partID, partName, partModel,price, partImage);
                createOrderForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Price Format","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
