
namespace BlacksPropertyManagement
{
    partial class TradesmenReportPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradesmenReportPrintForm));
            this.btnReportPrint = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.PrintTradesmen = new System.Drawing.Printing.PrintDocument();
            this.prvTradesmen = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.Location = new System.Drawing.Point(179, 187);
            this.btnReportPrint.Name = "btnReportPrint";
            this.btnReportPrint.Size = new System.Drawing.Size(275, 69);
            this.btnReportPrint.TabIndex = 0;
            this.btnReportPrint.Text = "Print Tradesmen";
            this.btnReportPrint.UseVisualStyleBackColor = true;
            this.btnReportPrint.Click += new System.EventHandler(this.btnReportPrint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(568, 187);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(275, 69);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // PrintTradesmen
            // 
            this.PrintTradesmen.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReports_PrintPage);
            // 
            // prvTradesmen
            // 
            this.prvTradesmen.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvTradesmen.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvTradesmen.ClientSize = new System.Drawing.Size(400, 300);
            this.prvTradesmen.Document = this.PrintTradesmen;
            this.prvTradesmen.Enabled = true;
            this.prvTradesmen.Icon = ((System.Drawing.Icon)(resources.GetObject("prvTradesmen.Icon")));
            this.prvTradesmen.Name = "prvTradesmen";
            this.prvTradesmen.Visible = false;
            // 
            // TradesmenReportPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 656);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReportPrint);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TradesmenReportPrintForm";
            this.Text = "Print Tradesmen Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportPrint;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument PrintTradesmen;
        private System.Windows.Forms.PrintPreviewDialog prvTradesmen;
    }
}