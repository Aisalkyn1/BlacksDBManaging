using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksPropertyManagement
{
    public partial class InvoicesPrintForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private int count, countID;
        private DataRow[] JobInfo;

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            count = 0;
            string strSort = "JobID";
            string strFilter = "Status = 'Current'";
            JobInfo = DC.dsBlacks.Tables["Job"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            countID = JobInfo.Length;
            prvReport.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        public InvoicesPrintForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
        private void printReports_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 12, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 12, FontStyle.Bold);
            Font headingFont = new Font("Arial", 12, FontStyle.Bold);
            DataRow drJob = JobInfo[count];
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 10;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            double JobTotal = 0; 
            g.DrawString("\t\t" + "Black’s Property Management Invoice", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar++;            
            linesSoFar++;
            g.DrawString("\r\nJob ID: " + drJob["JobID"] + "\t\t" + "Description: " + drJob["JobDescription"] +
                        "\r\n" + "\t\t\t" + "Job Date: " + ((DateTime)drJob["JobDate"]).ToShortDateString() + "\t\t\t" + "Fee: " + drJob["JobFee"],
                        headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar++;
            string PropertyText = "";
            DataRow drProperty = drJob.GetParentRow(DC.dtJob.ParentRelations["Property_Job"]);
            DataRow drLandlord = drProperty.GetParentRow(DC.dtPropery.ParentRelations["Landlord_Property"]);
            PropertyText = "\r\nProperty ID: " + drProperty["PropertyID"] + "\r\n" +
                "StreetAddress: " + drProperty["StreetAddress"] + ", " + drProperty["Suburb"] + "\r\n" +
                "Landlord ID: " + drLandlord["LandlordID"] + "    " + "Landlord Name: " + drLandlord["LastName"] + " " + drLandlord["FirstName"] + "\r\n" +
                "StreetAddress: " + drLandlord["StreetAddress"] + ", " + drLandlord["Suburb"];
            linesSoFar++;
            linesSoFar++;
            g.DrawString(PropertyText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 3;
            double TotalMaterial = 0;
            DataRow TradesmanRows = drJob.GetParentRow(DC.dtJob.ParentRelations["Tradesman_Job"]);
            PropertyText = "Tradesman ID: " + TradesmanRows["TradesmanID"].ToString() + "\r\n" + "Tradesman Name: " + TradesmanRows["LastName"] + "  " + TradesmanRows["FirstName"]
                + "\r\n\t\t\t\t\t\t\t\t" + "Fee: " + TradesmanRows["Fee"];
            linesSoFar = linesSoFar + 3;
            g.DrawString(PropertyText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar++;
            CurrencyManager cmMaterial;
            cmMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Material"];
            DataRow[] drMaterial = drJob.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
            foreach (DataRow eachRow in drMaterial)
            {
                double costMaterial = 0;
                int Matid = Convert.ToInt32(eachRow["MaterialID"].ToString());
                cmMaterial.Position = DC.materialView.Find(Matid);
                DataRow drMat = DC.dtMaterial.Rows[cmMaterial.Position];
                costMaterial += Convert.ToDouble(drMat["Cost"]) * Convert.ToInt32(eachRow["Quantity"]);
                PropertyText = "\r\nMaterial ID: " + drMat["MaterialID"] + "\t\t\t\t\t\t\t" + "Quantity: " + eachRow["Quantity"] + " " +
                    "\r\nDescription: " + drMat["MaterialDescription"] + "\r\n\t\t\t\t\t\t\t\t" + "Cost: " + drMat["Cost"] + 
                    "\r\n" + "Price: " + "\t\t\t\t\t\t\t" + costMaterial;
                linesSoFar = linesSoFar + 3;
                g.DrawString(PropertyText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                linesSoFar++;
                TotalMaterial += costMaterial;                
            }
            linesSoFar = linesSoFar + 5;
            g.DrawString("Total Material: " + "\t\t\t\t\t\t" + string.Format("{0:#,##0,00}", TotalMaterial), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 3;
            JobTotal += Convert.ToDouble(drJob["JobFee"]) + Convert.ToDouble(TradesmanRows["Fee"]) + TotalMaterial;
            g.DrawString("\t\t\t\t\t\t" + "Job Total: " + string.Format("{0:#,##0,00}",JobTotal), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar++;
            count++;
            if (!(count == countID))
            {
                e.HasMorePages = true;
            }
        }
    }
}


