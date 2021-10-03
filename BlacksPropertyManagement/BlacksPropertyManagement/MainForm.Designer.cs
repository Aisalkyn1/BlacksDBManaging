
namespace BlacksPropertyManagement
{
    partial class MainForm
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
            this.btnAddProperties = new System.Windows.Forms.Button();
            this.btnUpdateProperties = new System.Windows.Forms.Button();
            this.btnDeleteProperties = new System.Windows.Forms.Button();
            this.btnAddJobs = new System.Windows.Forms.Button();
            this.btnUpdateJobs = new System.Windows.Forms.Button();
            this.btnDeleteJobs = new System.Windows.Forms.Button();
            this.btnAssignMaterials = new System.Windows.Forms.Button();
            this.btnRemoveMaterials = new System.Windows.Forms.Button();
            this.btnPrintInvoices = new System.Windows.Forms.Button();
            this.btnPrintTradesmenReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProperties
            // 
            this.btnAddProperties.Location = new System.Drawing.Point(131, 25);
            this.btnAddProperties.Name = "btnAddProperties";
            this.btnAddProperties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddProperties.Size = new System.Drawing.Size(324, 70);
            this.btnAddProperties.TabIndex = 0;
            this.btnAddProperties.Text = "Add Property";
            this.btnAddProperties.UseVisualStyleBackColor = true;
            this.btnAddProperties.Click += new System.EventHandler(this.btnAddProperties_Click);
            // 
            // btnUpdateProperties
            // 
            this.btnUpdateProperties.Location = new System.Drawing.Point(131, 112);
            this.btnUpdateProperties.Name = "btnUpdateProperties";
            this.btnUpdateProperties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateProperties.Size = new System.Drawing.Size(324, 66);
            this.btnUpdateProperties.TabIndex = 1;
            this.btnUpdateProperties.Text = "Update Property";
            this.btnUpdateProperties.UseVisualStyleBackColor = true;
            this.btnUpdateProperties.Click += new System.EventHandler(this.btnUpdateProperties_Click);
            // 
            // btnDeleteProperties
            // 
            this.btnDeleteProperties.Location = new System.Drawing.Point(131, 200);
            this.btnDeleteProperties.Name = "btnDeleteProperties";
            this.btnDeleteProperties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteProperties.Size = new System.Drawing.Size(324, 66);
            this.btnDeleteProperties.TabIndex = 2;
            this.btnDeleteProperties.Text = "Delete Property";
            this.btnDeleteProperties.UseVisualStyleBackColor = true;
            this.btnDeleteProperties.Click += new System.EventHandler(this.btnDeleteProperties_Click);
            // 
            // btnAddJobs
            // 
            this.btnAddJobs.Location = new System.Drawing.Point(131, 290);
            this.btnAddJobs.Name = "btnAddJobs";
            this.btnAddJobs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddJobs.Size = new System.Drawing.Size(324, 70);
            this.btnAddJobs.TabIndex = 3;
            this.btnAddJobs.Text = "Add Job";
            this.btnAddJobs.UseVisualStyleBackColor = true;
            this.btnAddJobs.Click += new System.EventHandler(this.btnAddJobs_Click);
            // 
            // btnUpdateJobs
            // 
            this.btnUpdateJobs.Location = new System.Drawing.Point(131, 379);
            this.btnUpdateJobs.Name = "btnUpdateJobs";
            this.btnUpdateJobs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateJobs.Size = new System.Drawing.Size(324, 66);
            this.btnUpdateJobs.TabIndex = 4;
            this.btnUpdateJobs.Text = "Update Job";
            this.btnUpdateJobs.UseVisualStyleBackColor = true;
            this.btnUpdateJobs.Click += new System.EventHandler(this.btnUpdateJobs_Click);
            // 
            // btnDeleteJobs
            // 
            this.btnDeleteJobs.Location = new System.Drawing.Point(131, 461);
            this.btnDeleteJobs.Name = "btnDeleteJobs";
            this.btnDeleteJobs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteJobs.Size = new System.Drawing.Size(324, 70);
            this.btnDeleteJobs.TabIndex = 5;
            this.btnDeleteJobs.Text = "Delete Job";
            this.btnDeleteJobs.UseVisualStyleBackColor = true;
            this.btnDeleteJobs.Click += new System.EventHandler(this.btnDeleteJobs_Click);
            // 
            // btnAssignMaterials
            // 
            this.btnAssignMaterials.Location = new System.Drawing.Point(479, 25);
            this.btnAssignMaterials.Name = "btnAssignMaterials";
            this.btnAssignMaterials.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAssignMaterials.Size = new System.Drawing.Size(324, 70);
            this.btnAssignMaterials.TabIndex = 6;
            this.btnAssignMaterials.Text = "Assign Material";
            this.btnAssignMaterials.UseVisualStyleBackColor = true;
            this.btnAssignMaterials.Click += new System.EventHandler(this.btnAssignMaterials_Click);
            // 
            // btnRemoveMaterials
            // 
            this.btnRemoveMaterials.Location = new System.Drawing.Point(479, 112);
            this.btnRemoveMaterials.Name = "btnRemoveMaterials";
            this.btnRemoveMaterials.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemoveMaterials.Size = new System.Drawing.Size(324, 66);
            this.btnRemoveMaterials.TabIndex = 7;
            this.btnRemoveMaterials.Text = "Remove Material";
            this.btnRemoveMaterials.UseVisualStyleBackColor = true;
            this.btnRemoveMaterials.Click += new System.EventHandler(this.btnRemoveMaterials_Click);
            // 
            // btnPrintInvoices
            // 
            this.btnPrintInvoices.Location = new System.Drawing.Point(479, 200);
            this.btnPrintInvoices.Name = "btnPrintInvoices";
            this.btnPrintInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrintInvoices.Size = new System.Drawing.Size(324, 66);
            this.btnPrintInvoices.TabIndex = 8;
            this.btnPrintInvoices.Text = "Print Invoices";
            this.btnPrintInvoices.UseVisualStyleBackColor = true;
            this.btnPrintInvoices.Click += new System.EventHandler(this.btnPrintInvoices_Click);
            // 
            // btnPrintTradesmenReports
            // 
            this.btnPrintTradesmenReports.Location = new System.Drawing.Point(479, 290);
            this.btnPrintTradesmenReports.Name = "btnPrintTradesmenReports";
            this.btnPrintTradesmenReports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrintTradesmenReports.Size = new System.Drawing.Size(324, 70);
            this.btnPrintTradesmenReports.TabIndex = 9;
            this.btnPrintTradesmenReports.Text = "Print Tradesmen Report";
            this.btnPrintTradesmenReports.UseVisualStyleBackColor = true;
            this.btnPrintTradesmenReports.Click += new System.EventHandler(this.btnPrintTradesmenReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(479, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(324, 152);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 656);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintInvoices);
            this.Controls.Add(this.btnPrintTradesmenReports);
            this.Controls.Add(this.btnAssignMaterials);
            this.Controls.Add(this.btnRemoveMaterials);
            this.Controls.Add(this.btnUpdateJobs);
            this.Controls.Add(this.btnDeleteJobs);
            this.Controls.Add(this.btnDeleteProperties);
            this.Controls.Add(this.btnAddJobs);
            this.Controls.Add(this.btnUpdateProperties);
            this.Controls.Add(this.btnAddProperties);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProperties;
        private System.Windows.Forms.Button btnUpdateProperties;
        private System.Windows.Forms.Button btnDeleteProperties;
        private System.Windows.Forms.Button btnAddJobs;
        private System.Windows.Forms.Button btnUpdateJobs;
        private System.Windows.Forms.Button btnDeleteJobs;
        private System.Windows.Forms.Button btnAssignMaterials;
        private System.Windows.Forms.Button btnRemoveMaterials;
        private System.Windows.Forms.Button btnPrintInvoices;
        private System.Windows.Forms.Button btnPrintTradesmenReports;
        private System.Windows.Forms.Button btnExit;
    }
}

