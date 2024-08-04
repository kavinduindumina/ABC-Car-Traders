namespace ABC_Car_Traders
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            MyProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            timer1 = new System.Windows.Forms.Timer(components);
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(172, 65);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.BorderRadius = 10;
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Enabled = true;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.ShadowDecoration.Shadow = new Padding(0, 0, 0, 10);
            guna2CirclePictureBox1.Size = new Size(231, 192);
            guna2CirclePictureBox1.TabIndex = 1;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // MyProgress
            // 
            MyProgress.CustomizableEdges = customizableEdges2;
            MyProgress.FillColor = Color.Khaki;
            MyProgress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MyProgress.ForeColor = Color.White;
            MyProgress.Location = new Point(70, 288);
            MyProgress.Name = "MyProgress";
            MyProgress.ProgressColor = Color.Red;
            MyProgress.ProgressColor2 = Color.Red;
            MyProgress.ShadowDecoration.CustomizableEdges = customizableEdges3;
            MyProgress.ShowText = true;
            MyProgress.Size = new Size(443, 14);
            MyProgress.TabIndex = 2;
            MyProgress.Text = "ProgressBar1";
            MyProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            MyProgress.ValueChanged += guna2ProgressBar1_ValueChanged;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            guna2Elipse2.TargetControl = MyProgress;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel6.Location = new Point(165, 24);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(248, 35);
            guna2HtmlLabel6.TabIndex = 11;
            guna2HtmlLabel6.Text = "ABC Car Traders ";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(585, 339);
            Controls.Add(guna2HtmlLabel6);
            Controls.Add(MyProgress);
            Controls.Add(guna2CirclePictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar MyProgress;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}
