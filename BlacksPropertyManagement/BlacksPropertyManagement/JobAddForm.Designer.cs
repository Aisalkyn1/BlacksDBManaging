
namespace BlacksPropertyManagement
{
    partial class JobAddForm
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblOwnedProperties = new System.Windows.Forms.Label();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.cboLandlords = new System.Windows.Forms.ComboBox();
            this.cboTradesman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblJobFee = new System.Windows.Forms.Label();
            this.nudJobFee = new System.Windows.Forms.NumericUpDown();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTradesman = new System.Windows.Forms.Label();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLandlord = new System.Windows.Forms.Label();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobFee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(12, 32);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(279, 35);
            this.lblSelect.TabIndex = 4;
            this.lblSelect.Text = "Please select a landlord";
            this.lblSelect.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOwnedProperties
            // 
            this.lblOwnedProperties.AutoSize = true;
            this.lblOwnedProperties.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedProperties.Location = new System.Drawing.Point(6, 129);
            this.lblOwnedProperties.Name = "lblOwnedProperties";
            this.lblOwnedProperties.Size = new System.Drawing.Size(209, 35);
            this.lblOwnedProperties.TabIndex = 6;
            this.lblOwnedProperties.Text = "Select a property";
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 35;
            this.lstProperties.Location = new System.Drawing.Point(12, 157);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(492, 109);
            this.lstProperties.TabIndex = 5;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // cboLandlords
            // 
            this.cboLandlords.FormattingEnabled = true;
            this.cboLandlords.Location = new System.Drawing.Point(12, 59);
            this.cboLandlords.Name = "cboLandlords";
            this.cboLandlords.Size = new System.Drawing.Size(371, 43);
            this.cboLandlords.TabIndex = 8;
            this.cboLandlords.SelectedIndexChanged += new System.EventHandler(this.cboLandlords_SelectedIndexChanged);
            // 
            // cboTradesman
            // 
            this.cboTradesman.FormattingEnabled = true;
            this.cboTradesman.Location = new System.Drawing.Point(12, 321);
            this.cboTradesman.Name = "cboTradesman";
            this.cboTradesman.Size = new System.Drawing.Size(492, 43);
            this.cboTradesman.TabIndex = 9;
            this.cboTradesman.SelectedIndexChanged += new System.EventHandler(this.cboTradesman_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select a tradesman";
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Location = new System.Drawing.Point(554, 160);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(113, 35);
            this.lblJobDate.TabIndex = 11;
            this.lblJobDate.Text = "Job Date";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(641, 201);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(406, 42);
            this.txtDescription.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(537, 208);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 35);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "DD/MM/YYYY";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(641, 153);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(156, 42);
            this.dtpDate.TabIndex = 15;
            // 
            // lblJobFee
            // 
            this.lblJobFee.AutoEllipsis = true;
            this.lblJobFee.AutoSize = true;
            this.lblJobFee.Location = new System.Drawing.Point(560, 257);
            this.lblJobFee.Name = "lblJobFee";
            this.lblJobFee.Size = new System.Drawing.Size(101, 35);
            this.lblJobFee.TabIndex = 16;
            this.lblJobFee.Text = "Job Fee";
            // 
            // nudJobFee
            // 
            this.nudJobFee.DecimalPlaces = 2;
            this.nudJobFee.Location = new System.Drawing.Point(641, 250);
            this.nudJobFee.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudJobFee.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudJobFee.Name = "nudJobFee";
            this.nudJobFee.Size = new System.Drawing.Size(101, 42);
            this.nudJobFee.TabIndex = 17;
            this.nudJobFee.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(251, 460);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(269, 71);
            this.btnAddJob.TabIndex = 18;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(591, 460);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(269, 71);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTradesman
            // 
            this.lblTradesman.AutoSize = true;
            this.lblTradesman.Location = new System.Drawing.Point(541, 112);
            this.lblTradesman.Name = "lblTradesman";
            this.lblTradesman.Size = new System.Drawing.Size(139, 35);
            this.lblTradesman.TabIndex = 20;
            this.lblTradesman.Text = "Tradesman";
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(642, 105);
            this.txtlName.MaxLength = 30;
            this.txtlName.Name = "txtlName";
            this.txtlName.ReadOnly = true;
            this.txtlName.Size = new System.Drawing.Size(200, 42);
            this.txtlName.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(642, 60);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(179, 42);
            this.txtLastName.TabIndex = 23;
            // 
            // lblLandlord
            // 
            this.lblLandlord.AutoSize = true;
            this.lblLandlord.Location = new System.Drawing.Point(552, 67);
            this.lblLandlord.Name = "lblLandlord";
            this.lblLandlord.Size = new System.Drawing.Size(116, 35);
            this.lblLandlord.TabIndex = 22;
            this.lblLandlord.Text = "Landlord";
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(848, 105);
            this.txtfName.MaxLength = 30;
            this.txtfName.Name = "txtfName";
            this.txtfName.ReadOnly = true;
            this.txtfName.Size = new System.Drawing.Size(178, 42);
            this.txtfName.TabIndex = 24;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(827, 60);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(178, 42);
            this.txtFirstName.TabIndex = 25;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(641, 295);
            this.txtStatus.MaxLength = 7;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(117, 42);
            this.txtStatus.TabIndex = 27;
            this.txtStatus.Text = "Current";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(568, 298);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 35);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // JobAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 681);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLandlord);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(this.lblTradesman);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.nudJobFee);
            this.Controls.Add(this.lblJobFee);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTradesman);
            this.Controls.Add(this.cboLandlords);
            this.Controls.Add(this.lblOwnedProperties);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lblSelect);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobAddForm";
            this.Text = "Add Job";
            ((System.ComponentModel.ISupportInitialize)(this.nudJobFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblOwnedProperties;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.ComboBox cboLandlords;
        private System.Windows.Forms.ComboBox cboTradesman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblJobFee;
        public System.Windows.Forms.NumericUpDown nudJobFee;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTradesman;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLandlord;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}