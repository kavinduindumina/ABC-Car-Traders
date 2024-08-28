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
        public PartViewForm(string partID, string partName, string partModel, string quantity, string price, Image partImage)
        {
            InitializeComponent();

            partIDLable.Text = partID;
            partNameLabel.Text = partName;
            modelLabel.Text = partModel;
            qtyLabel.Text = quantity;
            priceLabel.Text = price;
            carPictureBox.Image = partImage;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
