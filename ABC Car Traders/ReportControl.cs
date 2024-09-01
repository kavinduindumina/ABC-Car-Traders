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
    public partial class ReportControl : UserControl
    {
        public ReportControl()
        {
            InitializeComponent();
        }

        private void carReportbtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the CarReportForm
            CarReportForm carReportForm = new CarReportForm();

            // Show the form
            carReportForm.Show();
        }
    }
}
