namespace ABC_Car_Traders
{
    partial class UserCarItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCarItemControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            carPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            CartButton = new Guna.UI2.WinForms.Guna2ImageButton();
            orderButton = new Guna.UI2.WinForms.Guna2Button();
            carNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            modelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            qtyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            priceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            carIDLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            SuspendLayout();
            // 
            // carPictureBox
            // 
            carPictureBox.CustomizableEdges = customizableEdges1;
            carPictureBox.Image = (Image)resources.GetObject("carPictureBox.Image");
            carPictureBox.ImageRotate = 0F;
            carPictureBox.Location = new Point(14, 16);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            carPictureBox.Size = new Size(182, 127);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 0;
            carPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(14, 146);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(14, 227);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 4;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(14, 200);
            label3.Name = "label3";
            label3.Size = new Size(38, 23);
            label3.TabIndex = 3;
            label3.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(14, 173);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 2;
            label2.Text = "Model";
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
            CartButton.Location = new Point(158, 16);
            CartButton.Name = "CartButton";
            CartButton.PressedState.ImageSize = new Size(64, 64);
            CartButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            CartButton.Size = new Size(38, 38);
            CartButton.TabIndex = 5;
            CartButton.Click += CartButton_Click;
            // 
            // orderButton
            // 
            orderButton.BorderRadius = 10;
            orderButton.Cursor = Cursors.Hand;
            orderButton.CustomizableEdges = customizableEdges4;
            orderButton.DisabledState.BorderColor = Color.DarkGray;
            orderButton.DisabledState.CustomBorderColor = Color.DarkGray;
            orderButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            orderButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            orderButton.FillColor = Color.Orange;
            orderButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderButton.ForeColor = Color.White;
            orderButton.Location = new Point(58, 253);
            orderButton.Name = "orderButton";
            orderButton.ShadowDecoration.CustomizableEdges = customizableEdges5;
            orderButton.Size = new Size(86, 28);
            orderButton.TabIndex = 6;
            orderButton.Text = "View";
            orderButton.Click += orderButton_Click;
            // 
            // carNameLabel
            // 
            carNameLabel.BackColor = Color.Transparent;
            carNameLabel.Location = new Point(90, 149);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new Size(31, 22);
            carNameLabel.TabIndex = 7;
            carNameLabel.Text = "Alto";
            // 
            // modelLabel
            // 
            modelLabel.BackColor = Color.Transparent;
            modelLabel.Location = new Point(90, 173);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(45, 22);
            modelLabel.TabIndex = 8;
            modelLabel.Text = "Suzuki";
            // 
            // qtyLabel
            // 
            qtyLabel.BackColor = Color.Transparent;
            qtyLabel.Location = new Point(90, 201);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(19, 22);
            qtyLabel.TabIndex = 9;
            qtyLabel.Text = "10";
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Location = new Point(90, 228);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(65, 22);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "3,000,000";
            // 
            // carIDLabel
            // 
            carIDLabel.BackColor = Color.Transparent;
            carIDLabel.Location = new Point(90, 109);
            carIDLabel.Name = "carIDLabel";
            carIDLabel.Size = new Size(31, 22);
            carIDLabel.TabIndex = 11;
            carIDLabel.Text = "Alto";
            // 
            // UserCarItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(priceLabel);
            Controls.Add(qtyLabel);
            Controls.Add(modelLabel);
            Controls.Add(carNameLabel);
            Controls.Add(orderButton);
            Controls.Add(CartButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carPictureBox);
            Controls.Add(carIDLabel);
            Name = "UserCarItemControl";
            Size = new Size(217, 291);
            Load += UserCarItemControl_Load;
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox carPictureBox;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton CartButton;
        private Guna.UI2.WinForms.Guna2Button orderButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel carNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel modelLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel qtyLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel priceLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel carIDLabel;
    }
}
