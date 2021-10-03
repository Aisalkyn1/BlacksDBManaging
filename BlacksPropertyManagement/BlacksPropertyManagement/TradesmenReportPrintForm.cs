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
    public partial class TradesmenReportPrintForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private int count, countID;
        private DataRow[] TradesmanTable;

        public TradesmenReportPrintForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReportPrint_Click(object sender, EventArgs e)
        {
            
            count = 0;
            string strSort = "TradesmanID";
            string strFilter = null;
            TradesmanTable = DC.dsBlacks.Tables["Tradesman"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            countID = TradesmanTable.Length;
            prvTradesmen.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
        private void printReports_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 12, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 12, FontStyle.Bold);
            Font headingFont = new Font("Arial", 12, FontStyle.Bold);
            DataRow drTradesman = TradesmanTable[count];
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 10;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            g.DrawString("\t\t" + "Black’s Property Management Tradesmen Report", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            linesSoFar = linesSoFar + 3;
            g.DrawString("\r\n\r\n\r\n" + "Tradesman ID: " + drTradesman["TradesmanID"].ToString() + "\r\n" + "Tradesman Name: " + drTradesman["LastName"] + "  "  + drTradesman["FirstName"]
                + "                                                     " + "Fee: " + drTradesman["Fee"] + "\r\n" + "Phone Number: " + drTradesman["PhoneNumber"] +
                "\r\n" + "________________________",
            headingFont, brush, leftMargin + headingLeftMargin, topMargin);
            linesSoFar = linesSoFar + 5;
            DataRow[] drJobs = drTradesman.GetChildRows(DC.dtTradesman.ChildRelations["TRADESMAN_JOB"]);
            if (drJobs.Length == 0)
            {
                g.DrawString("\r\nNo jobs yet", headingFont, brush,
                    leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            }
            else
            {
                foreach (DataRow drJob in drJobs)
                {
                    string JobText = "";
                    JobText = "\r\nJob ID: " + drJob["JobID"] + "                   " + "Description: " + drJob["JobDescription"] +
                        "\r\n" + "Job Date: " + ((DateTime)drJob["JobDate"]).ToShortDateString()
                        + "\r\n" + "Status: " + drJob["Status"] + "                                                                               Job Fee: " + drJob["JobFee"];
                    g.DrawString(JobText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                    string PropertyText = "";
                    DataRow drProperty = drJob.GetParentRow(DC.dtJob.ParentRelations["Property_Job"]);
                    DataRow drLandlord = drProperty.GetParentRow(DC.dtPropery.ParentRelations["Landlord_Property"]);
                    PropertyText = "\r\nProperty ID: " + drProperty["PropertyID"] +
                        "           StreetAddress: " + drProperty["StreetAddress"] + ", " + drProperty["Suburb"] + "\r\n" + "Year Built: " + drProperty["YearBuilt"] + "\r\n" +
                        "Landlord ID: " + drLandlord["LandlordID"] + "    " + "Landlord Name: " + drLandlord["LastName"] + " " + drLandlord["FirstName"];
                    g.DrawString(PropertyText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                    string Material = "";
                    CurrencyManager cmMaterial;
                    cmMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Material"];
                    DataRow[] drMaterial = drJob.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
                    foreach (DataRow eachRow in drMaterial)
                    {
                        int Matid = Convert.ToInt32(eachRow["MaterialID"].ToString());
                        cmMaterial.Position = DC.materialView.Find(Matid);
                        DataRow drMat = DC.dtMaterial.Rows[cmMaterial.Position];
                        Material = "\r\nMaterial ID: " + drMat["MaterialID"] + "                                                        " + "Quantity: " + eachRow["Quantity"] + " " +
                            "\r\nDescription: " + drMat["MaterialDescription"] + "                       " + "Cost: " + drMat["Cost"];
                        linesSoFar++;
                        linesSoFar++;
                        g.DrawString(Material, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                    }
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                }
            }
            count++;
            if (!(count == countID))
            {
                e.HasMorePages = true;
            }

        }
    }
}
