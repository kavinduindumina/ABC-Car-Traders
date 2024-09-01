using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CarReportForm : Form
    {
        private PrintDocument printDocument;

        public CarReportForm()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        SqlConnection Con = new SqlConnection(@"Data Source=KGK;Initial Catalog=ABC_Car_Traders;Integrated Security=True;Encrypt=False");

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from CarDetails", Con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);

                // Generate a string representation of the report
                string reportContent = GenerateReportContent(dt);

                // Set the print document content
                printDocument.DocumentName = "Car Report";
                printDocument.PrintController = new StandardPrintController();
                // Use a lambda to handle the print page
                printDocument.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString(reportContent, new Font("Arial", 20), Brushes.Black, ev.PageBounds);
                };

                // Display the print preview
                printPreviewControl1.Document = printDocument;
                printPreviewControl1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }

        private string GenerateReportContent(DataTable dt)
        {
            // Convert the DataTable into a string for demonstration purposes
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    sb.Append(item.ToString() + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        // Ensure this method is defined in the class
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // This method can be used to customize the printing logic further if needed
        }
    }
}
