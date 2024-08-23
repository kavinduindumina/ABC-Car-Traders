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
    public partial class UserCarPartControl : UserControl
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");


        // Properties to hold car details
        public string PartName
        {
            get { return partNameLabel.Text; }
            set { partNameLabel.Text = value; }
        }

        public string PartModel
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
            get { return partPictureBox.Image; }
            set { partPictureBox.Image = value; }
        }
        public UserCarPartControl()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{PartModel} {PartName}  ordered successfully!");
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{PartModel} {PartName}  added to cart successfully!");
        }
    }
}
