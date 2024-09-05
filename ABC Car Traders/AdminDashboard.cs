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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            customerControl1.BringToFront();
        }


        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Display logged-in user's email
            lblLoggedInEmail.Text = SessionManager.LoggedInEmail;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Clear session
            SessionManager.LoggedInEmail = null;
            SessionManager.IsAdmin = false;

            // Redirect to login form
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customerlbl_Click(object sender, EventArgs e)
        {
            customerControl1.BringToFront();
        }

        private void CustomerPnl_Paint(object sender, PaintEventArgs e)
        {
            customerControl1.BringToFront();



        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            carControl1.BringToFront();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            carControl1.BringToFront();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            carPartsControl1.BringToFront();
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {
            carPartsControl1.BringToFront();
        }

        private void carPartsControl1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            orderControl1.BringToFront();
        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            orderControl1.BringToFront();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            reportControl1.BringToFront();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            AddAdminForm addAdminForm = new AddAdminForm();
            addAdminForm.Show();
        }
    }
}
