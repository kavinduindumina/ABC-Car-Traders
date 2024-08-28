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
        public ViewForm(string carID, string carName, string carModel, string quantity, string price, Image carImage)
        {
            InitializeComponent();


            // Set the form controls with the passed car details
      
            carIDLable.Text = carID;
            carNameLabel.Text = carName;
            modelLabel.Text = carModel;
            qtyLabel.Text = quantity;
            priceLabel.Text = price;
            carPictureBox.Image = carImage;

        }



        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
