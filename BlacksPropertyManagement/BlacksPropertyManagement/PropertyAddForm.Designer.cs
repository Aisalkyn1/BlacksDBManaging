
namespace BlacksPropertyManagement
{
    partial class PropertyAddForm
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
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblLandlord = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.nudYearBuilt = new System.Windows.Forms.NumericUpDown();
            this.lstLandlords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(193, 414);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(304, 60);
            this.btnAddProperty.TabIndex = 0;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(645, 414);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(304, 60);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblLandlord
            // 
            this.lblLandlord.AutoSize = true;
            this.lblLandlord.Location = new System.Drawing.Point(474, 98);
            this.lblLandlord.Name = "lblLandlord";
            this.lblLandlord.Size = new System.Drawing.Size(116, 35);
            this.lblLandlord.TabIndex = 3;
            this.lblLandlord.Text = "Landlord";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Occupied",
            "Unoccupied"});
            this.cboStatus.Location = new System.Drawing.Point(546, 248);
            this.cboStatus.MaxLength = 10;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(138, 43);
            this.cboStatus.TabIndex = 5;
            this.cboStatus.Text = "Occupied";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(546, 95);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(210, 42);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(762, 95);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(256, 42);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(546, 148);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(547, 42);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(434, 148);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(182, 35);
            this.lblStreetAddress.TabIndex = 8;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(546, 196);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(185, 42);
            this.txtSuburb.TabIndex = 11;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(482, 199);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(98, 35);
            this.lblSuburb.TabIndex = 10;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(482, 251);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 35);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(469, 297);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(121, 35);
            this.lblYearBuilt.TabIndex = 13;
            this.lblYearBuilt.Text = "Year Built";
            // 
            // nudYearBuilt
            // 
            this.nudYearBuilt.Location = new System.Drawing.Point(546, 297);
            this.nudYearBuilt.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudYearBuilt.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYearBuilt.Name = "nudYearBuilt";
            this.nudYearBuilt.Size = new System.Drawing.Size(103, 42);
            this.nudYearBuilt.TabIndex = 14;
            this.nudYearBuilt.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // lstLandlords
            // 
            this.lstLandlords.FormattingEnabled = true;
            this.lstLandlords.ItemHeight = 35;
            this.lstLandlords.Location = new System.Drawing.Point(21, 95);
            this.lstLandlords.Name = "lstLandlords";
            this.lstLandlords.Size = new System.Drawing.Size(373, 284);
            this.lstLandlords.TabIndex = 15;
            this.lstLandlords.SelectedIndexChanged += new System.EventHandler(this.lstLandlords_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Please select a landlord";
            // 
            // PropertyAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLandlords);
            this.Controls.Add(this.nudYearBuilt);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblLandlord);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddProperty);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PropertyAddForm";
            this.Text = "Add Property";
            this.Load += new System.EventHandler(this.PropertyAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblLandlord;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.NumericUpDown nudYearBuilt;
        private System.Windows.Forms.ListBox lstLandlords;
        private System.Windows.Forms.Label label1;
    }
}