namespace ABC_Car_Traders
{
    partial class ViewForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            priceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            qtyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            modelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            carNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            carPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            buyButton = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            carIDLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Microsoft Sans Serif", 12F);
            priceLabel.Location = new Point(155, 336);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(90, 27);
            priceLabel.TabIndex = 19;
            priceLabel.Text = "3,000,000";
            // 
            // qtyLabel
            // 
            qtyLabel.BackColor = Color.Transparent;
            qtyLabel.Font = new Font("Microsoft Sans Serif", 12F);
            qtyLabel.Location = new Point(155, 297);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(25, 27);
            qtyLabel.TabIndex = 18;
            qtyLabel.Text = "10";
            // 
            // modelLabel
            // 
            modelLabel.BackColor = Color.Transparent;
            modelLabel.Font = new Font("Microsoft Sans Serif", 12F);
            modelLabel.Location = new Point(156, 260);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(63, 27);
            modelLabel.TabIndex = 17;
            modelLabel.Text = "Suzuki";
            // 
            // carNameLabel
            // 
            carNameLabel.BackColor = Color.Transparent;
            carNameLabel.Font = new Font("Microsoft Sans Serif", 12F);
            carNameLabel.Location = new Point(155, 223);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new Size(37, 27);
            carNameLabel.TabIndex = 16;
            carNameLabel.Text = "Alto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(59, 336);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 15;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(59, 297);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 14;
            label3.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(59, 260);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 13;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(59, 223);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // carPictureBox
            // 
            carPictureBox.CustomizableEdges = customizableEdges3;
            carPictureBox.Image = (Image)resources.GetObject("carPictureBox.Image");
            carPictureBox.ImageRotate = 0F;
            carPictureBox.Location = new Point(53, 21);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            carPictureBox.Size = new Size(225, 170);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 11;
            carPictureBox.TabStop = false;
            // 
            // buyButton
            // 
            buyButton.BorderRadius = 10;
            buyButton.Cursor = Cursors.Hand;
            buyButton.CustomizableEdges = customizableEdges1;
            buyButton.DisabledState.BorderColor = Color.DarkGray;
            buyButton.DisabledState.CustomBorderColor = Color.DarkGray;
            buyButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buyButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buyButton.FillColor = Color.Orange;
            buyButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            buyButton.ForeColor = Color.White;
            buyButton.Location = new Point(96, 379);
            buyButton.Name = "buyButton";
            buyButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buyButton.Size = new Size(139, 52);
            buyButton.TabIndex = 20;
            buyButton.Text = "Buy Now";
            buyButton.Click += buyButton_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(313, -1);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(15, 33);
            guna2HtmlLabel1.TabIndex = 21;
            guna2HtmlLabel1.Text = "x";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // carIDLable
            // 
            carIDLable.BackColor = Color.Transparent;
            carIDLable.Font = new Font("Microsoft Sans Serif", 12F);
            carIDLable.Location = new Point(155, 148);
            carIDLable.Name = "carIDLable";
            carIDLable.Size = new Size(22, 27);
            carIDLable.TabIndex = 22;
            carIDLable.Text = "ID";
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 454);
            Controls.Add(buyButton);
            Controls.Add(priceLabel);
            Controls.Add(qtyLabel);
            Controls.Add(modelLabel);
            Controls.Add(carNameLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(carPictureBox);
            Controls.Add(carIDLable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewForm";
            Text = "ViewForm";
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel priceLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel qtyLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel modelLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel carNameLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox carPictureBox;
        private Guna.UI2.WinForms.Guna2Button buyButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel carIDLable;
    }
}