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

        // Properties to hold car details
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
        }


        private void UserCarItemControl_Load(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{CarModel} {CarName}  ordered successfully!");
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{CarModel} {CarName}  added to cart successfully!");
        }
    }
}
