namespace ABC_Car_Traders
{
    partial class UserCarPartControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCarPartControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            partPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            priceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            qtyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            modelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            partNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            orderButton = new Guna.UI2.WinForms.Guna2Button();
            CartButton = new Guna.UI2.WinForms.Guna2ImageButton();
            partIDLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)partPictureBox).BeginInit();
            SuspendLayout();
            // 
            // partPictureBox
            // 
            partPictureBox.BackgroundImageLayout = ImageLayout.None;
            partPictureBox.CustomizableEdges = customizableEdges1;
            partPictureBox.Image = (Image)resources.GetObject("partPictureBox.Image");
            partPictureBox.ImageRotate = 0F;
            partPictureBox.Location = new Point(16, 14);
            partPictureBox.Name = "partPictureBox";
            partPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            partPictureBox.Size = new Size(182, 127);
            partPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            partPictureBox.TabIndex = 0;
            partPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(16, 151);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Location = new Point(92, 229);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(65, 22);
            priceLabel.TabIndex = 17;
            priceLabel.Text = "3,000,000";
            // 
            // qtyLabel
            // 
            qtyLabel.BackColor = Color.Transparent;
            qtyLabel.Location = new Point(92, 202);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(19, 22);
            qtyLabel.TabIndex = 16;
            qtyLabel.Text = "10";
            // 
            // modelLabel
            // 
            modelLabel.BackColor = Color.Transparent;
            modelLabel.Location = new Point(92, 174);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(45, 22);
            modelLabel.TabIndex = 15;
            modelLabel.Text = "Suzuki";
            // 
            // partNameLabel
            // 
            partNameLabel.BackColor = Color.Transparent;
            partNameLabel.Location = new Point(92, 150);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(31, 22);
            partNameLabel.TabIndex = 14;
            partNameLabel.Text = "Alto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(16, 228);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 13;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(16, 201);
            label3.Name = "label3";
            label3.Size = new Size(38, 23);
            label3.TabIndex = 12;
            label3.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(16, 174);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 11;
            label2.Text = "Model";
            // 
            // orderButton
            // 
            orderButton.BorderRadius = 10;
            orderButton.Cursor = Cursors.Hand;
            orderButton.CustomizableEdges = customizableEdges3;
            orderButton.DisabledState.BorderColor = Color.DarkGray;
            orderButton.DisabledState.CustomBorderColor = Color.DarkGray;
            orderButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            orderButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            orderButton.FillColor = Color.Orange;
            orderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderButton.ForeColor = Color.White;
            orderButton.Location = new Point(57, 254);
            orderButton.Name = "orderButton";
            orderButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            orderButton.Size = new Size(86, 28);
            orderButton.TabIndex = 18;
            orderButton.Text = "View";
            orderButton.Click += orderButton_Click_1;
            // 
            // CartButton
            // 
            CartButton.CheckedState.ImageSize = new Size(64, 64);
            CartButton.Cursor = Cursors.Hand;
            CartButton.HoverState.ImageSize = new Size(64, 64);
            CartButton.Image = (Image)resources.GetObject("CartButton.Image");
            CartButton.ImageOffset = new Point(0, 0);
            CartButton.ImageRotate = 0F;
            CartButton.ImageSize = new Size(30, 30);
            CartButton.Location = new Point(160, 14);
            CartButton.Name = "CartButton";
            CartButton.PressedState.ImageSize = new Size(64, 64);
            CartButton.ShadowDecoration.CustomizableEdges = customizableEdges5;
            CartButton.Size = new Size(38, 38);
            CartButton.TabIndex = 19;
            CartButton.Click += CartButton_Click;
            // 
            // partIDLabel
            // 
            partIDLabel.BackColor = Color.Transparent;
            partIDLabel.Location = new Point(93, 109);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new Size(18, 22);
            partIDLabel.TabIndex = 20;
            partIDLabel.Text = "ID";
            // 
            // UserCarPartControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartButton);
            Controls.Add(orderButton);
            Controls.Add(priceLabel);
            Controls.Add(qtyLabel);
            Controls.Add(modelLabel);
            Controls.Add(partNameLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(partPictureBox);
            Controls.Add(partIDLabel);
            Name = "UserCarPartControl";
            Size = new Size(217, 291);
            ((System.ComponentModel.ISupportInitialize)partPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox partPictureBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel priceLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel qtyLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel modelLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel partNameLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button orderButton;
        private Guna.UI2.WinForms.Guna2ImageButton CartButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel partIDLabel;
    }
}
