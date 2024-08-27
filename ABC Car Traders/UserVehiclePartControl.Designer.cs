namespace ABC_Car_Traders
{
    partial class UserVehiclePartControl
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            partsLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(50, 137);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(41, 25);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Parts";
            // 
            // partsLayoutPanel
            // 
            partsLayoutPanel.AutoScroll = true;
            partsLayoutPanel.Location = new Point(50, 168);
            partsLayoutPanel.Name = "partsLayoutPanel";
            partsLayoutPanel.Size = new Size(859, 385);
            partsLayoutPanel.TabIndex = 5;
            // 
            // UserVehiclePartControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(partsLayoutPanel);
            Controls.Add(guna2HtmlLabel1);
            Name = "UserVehiclePartControl";
            Size = new Size(951, 556);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FlowLayoutPanel partsLayoutPanel;
    }
}
