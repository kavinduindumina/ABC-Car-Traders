﻿using System;
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

        private void Homebtn_Click(object sender, EventArgs e)
        {
            userHomeControl1.BringToFront();
        }

        private void Vehiclebtn_Click(object sender, EventArgs e)
        {
            userVehicleControl2.BringToFront();
        }

        private void partsbtn_Click(object sender, EventArgs e)
        {
            userVehiclePartControl1.BringToFront();
        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            UserOrderControlForm userOrderControlForm = new UserOrderControlForm();
            userOrderControlForm.Show();
        }

        private void userImg_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }
    }
}
