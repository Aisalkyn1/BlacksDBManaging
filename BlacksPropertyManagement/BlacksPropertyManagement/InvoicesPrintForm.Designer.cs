
namespace BlacksPropertyManagement
{
    partial class InvoicesPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesPrintForm));
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.prvReport = new System.Windows.Forms.PrintPreviewDialog();
            this.printInvoice = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(144, 178);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(254, 78);
            this.btnPrintInvoice.TabIndex = 0;
            this.btnPrintInvoice.Text = "Print Invoices";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(561, 178);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(254, 78);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // prvReport
            // 
            this.prvReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvReport.ClientSize = new System.Drawing.Size(400, 300);
            this.prvReport.Document = this.printInvoice;
            this.prvReport.Enabled = true;
            this.prvReport.Icon = ((System.Drawing.Icon)(resources.GetObject("prvReport.Icon")));
            this.prvReport.Name = "prvReport";
            this.prvReport.Visible = false;
            // 
            // printInvoice
            // 
            this.printInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReports_PrintPage);
            // 
            // InvoicesPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 656);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintInvoice);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoicesPrintForm";
            this.Text = "Print Invoices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PrintPreviewDialog prvReport;
        private System.Drawing.Printing.PrintDocument printInvoice;
    }
}