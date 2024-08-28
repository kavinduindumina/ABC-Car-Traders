namespace ABC_Car_Traders
{
    partial class PartViewForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartViewForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            buyButton = new Guna.UI2.WinForms.Guna2Button();
            priceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            qtyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            modelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            partNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            carPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            partIDLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(313, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(15, 33);
            guna2HtmlLabel1.TabIndex = 22;
            guna2HtmlLabel1.Text = "x";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
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
            buyButton.Location = new Point(98, 386);
            buyButton.Name = "buyButton";
            buyButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buyButton.Size = new Size(139, 52);
            buyButton.TabIndex = 32;
            buyButton.Text = "Buy Now";
            // 
            // priceLabel
            // 
            priceLabel.BackColor = Color.Transparent;
            priceLabel.Font = new Font("Microsoft Sans Serif", 12F);
            priceLabel.Location = new Point(157, 343);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(90, 27);
            priceLabel.TabIndex = 31;
            priceLabel.Text = "3,000,000";
            // 
            // qtyLabel
            // 
            qtyLabel.BackColor = Color.Transparent;
            qtyLabel.Font = new Font("Microsoft Sans Serif", 12F);
            qtyLabel.Location = new Point(157, 304);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(25, 27);
            qtyLabel.TabIndex = 30;
            qtyLabel.Text = "10";
            // 
            // modelLabel
            // 
            modelLabel.BackColor = Color.Transparent;
            modelLabel.Font = new Font("Microsoft Sans Serif", 12F);
            modelLabel.Location = new Point(158, 267);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(63, 27);
            modelLabel.TabIndex = 29;
            modelLabel.Text = "Suzuki";
            // 
            // partNameLabel
            // 
            partNameLabel.BackColor = Color.Transparent;
            partNameLabel.Font = new Font("Microsoft Sans Serif", 12F);
            partNameLabel.Location = new Point(157, 230);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(37, 27);
            partNameLabel.TabIndex = 28;
            partNameLabel.Text = "Alto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(61, 343);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 27;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(61, 304);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 26;
            label3.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(61, 267);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 25;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(61, 230);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 24;
            label1.Text = "Name";
            // 
            // carPictureBox
            // 
            carPictureBox.CustomizableEdges = customizableEdges3;
            carPictureBox.Image = (Image)resources.GetObject("carPictureBox.Image");
            carPictureBox.ImageRotate = 0F;
            carPictureBox.Location = new Point(55, 28);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            carPictureBox.Size = new Size(225, 170);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 23;
            carPictureBox.TabStop = false;
            // 
            // partIDLable
            // 
            partIDLable.BackColor = Color.Transparent;
            partIDLable.Font = new Font("Microsoft Sans Serif", 12F);
            partIDLable.Location = new Point(157, 155);
            partIDLable.Name = "partIDLable";
            partIDLable.Size = new Size(37, 27);
            partIDLable.TabIndex = 33;
            partIDLable.Text = "Alto";
            // 
            // PartViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 454);
            Controls.Add(buyButton);
            Controls.Add(priceLabel);
            Controls.Add(qtyLabel);
            Controls.Add(modelLabel);
            Controls.Add(partNameLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(carPictureBox);
            Controls.Add(partIDLable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PartViewForm";
            Text = "PartViewForm";
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button buyButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel priceLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel qtyLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel modelLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel partNameLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox carPictureBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel partIDLable;
    }
}