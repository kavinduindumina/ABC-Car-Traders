namespace ABC_Car_Traders
{
    partial class CarReportForm
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
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            printPreviewControl1 = new PrintPreviewControl();
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
            guna2HtmlLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(322, 21);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(356, 33);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Genarate Your Car Details Report";
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.BorderRadius = 10;
            guna2GradientButton1.CustomizableEdges = customizableEdges1;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.Orange;
            guna2GradientButton1.FillColor2 = Color.Gold;
            guna2GradientButton1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientButton1.ForeColor = Color.White;
            guna2GradientButton1.HoverState.FillColor = Color.Gold;
            guna2GradientButton1.HoverState.FillColor2 = Color.Orange;
            guna2GradientButton1.Location = new Point(405, 60);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientButton1.Size = new Size(158, 35);
            guna2GradientButton1.TabIndex = 1;
            guna2GradientButton1.Text = "Genarate";
            guna2GradientButton1.Click += guna2GradientButton1_Click;
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Location = new Point(112, 182);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(727, 394);
            printPreviewControl1.TabIndex = 2;
            // 
            // CarReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(953, 637);
            Controls.Add(printPreviewControl1);
            Controls.Add(guna2GradientButton1);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Stimulsoft.Report.Viewer.StiDotMatrixViewerControl stiDotMatrixViewerControl1;
        private PrintPreviewControl printPreviewControl1;
    }
}