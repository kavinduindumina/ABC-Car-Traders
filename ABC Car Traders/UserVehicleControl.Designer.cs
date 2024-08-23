namespace ABC_Car_Traders
{
    partial class UserVehicleControl
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
            carLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(48, 123);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(36, 25);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Cars";
            // 
            // carLayoutPanel
            // 
            carLayoutPanel.AutoScroll = true;
            carLayoutPanel.Location = new Point(48, 154);
            carLayoutPanel.Name = "carLayoutPanel";
            carLayoutPanel.Size = new Size(859, 399);
            carLayoutPanel.TabIndex = 4;
            // 
            // UserVehicleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(carLayoutPanel);
            Controls.Add(guna2HtmlLabel1);
            Name = "UserVehicleControl";
            Size = new Size(951, 556);
            Load += UserVehicleControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private FlowLayoutPanel carLayoutPanel;
    }
}
