
namespace BlacksPropertyManagement
{
    partial class JobUpdateForm
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
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateJob = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblJobID = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.nudJobFee = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLandlord = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobFee)).BeginInit();
            this.SuspendLayout();
            // 
            // lstJobs
            // 
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.ItemHeight = 35;
            this.lstJobs.Location = new System.Drawing.Point(49, 91);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(285, 319);
            this.lstJobs.TabIndex = 0;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.lstJobs_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Paid"});
            this.cboStatus.Location = new System.Drawing.Point(472, 264);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(93, 43);
            this.cboStatus.TabIndex = 1;
            // 
            // btnUpdateJob
            // 
            this.btnUpdateJob.Location = new System.Drawing.Point(215, 445);
            this.btnUpdateJob.Name = "btnUpdateJob";
            this.btnUpdateJob.Size = new System.Drawing.Size(269, 68);
            this.btnUpdateJob.TabIndex = 2;
            this.btnUpdateJob.Text = "Update Job";
            this.btnUpdateJob.UseVisualStyleBackColor = true;
            this.btnUpdateJob.Click += new System.EventHandler(this.btnUpdateJob_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(473, 168);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 42);
            this.dtpDate.TabIndex = 3;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(400, 81);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(84, 35);
            this.lblJobID.TabIndex = 4;
            this.lblJobID.Text = "Job ID";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(473, 74);
            this.txtJobID.MaxLength = 8;
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(83, 42);
            this.txtJobID.TabIndex = 5;
            // 
            // nudJobFee
            // 
            this.nudJobFee.DecimalPlaces = 2;
            this.nudJobFee.Location = new System.Drawing.Point(473, 216);
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
            this.nudJobFee.Size = new System.Drawing.Size(65, 42);
            this.nudJobFee.TabIndex = 6;
            this.nudJobFee.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(473, 122);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(476, 42);
            this.txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(369, 129);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 35);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(386, 175);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(113, 35);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Job Date";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(392, 218);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(101, 35);
            this.lblFee.TabIndex = 10;
            this.lblFee.Text = "Job Fee";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(400, 267);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 35);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(473, 313);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(204, 42);
            this.txtLastName.TabIndex = 13;
            // 
            // lblLandlord
            // 
            this.lblLandlord.AutoSize = true;
            this.lblLandlord.Location = new System.Drawing.Point(384, 320);
            this.lblLandlord.Name = "lblLandlord";
            this.lblLandlord.Size = new System.Drawing.Size(116, 35);
            this.lblLandlord.TabIndex = 12;
            this.lblLandlord.Text = "Landlord";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(683, 313);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(211, 42);
            this.txtFirstName.TabIndex = 14;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(523, 445);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(254, 68);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Please select a job";
            // 
            // JobUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLandlord);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.nudJobFee);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnUpdateJob);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lstJobs);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobUpdateForm";
            this.Text = "Update Job";
            ((System.ComponentModel.ISupportInitialize)(this.nudJobFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnUpdateJob;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.NumericUpDown nudJobFee;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLandlord;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
    }
}