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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Display logged-in user's email
            lblLoggedInEmail.Text = SessionManager.LoggedInEmail;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            SessionManager.LoggedInEmail = null;
            SessionManager.IsAdmin = false;

            // Redirect to login form
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
