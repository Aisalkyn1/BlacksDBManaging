
namespace BlacksPropertyManagement
{
    partial class PropertyUpdateForm
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
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLandlord = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nudYearBuilt = new System.Windows.Forms.NumericUpDown();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Location = new System.Drawing.Point(515, 93);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(145, 35);
            this.lblPropertyID.TabIndex = 1;
            this.lblPropertyID.Text = "Property ID";
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(619, 90);
            this.txtPropertyID.MaxLength = 5;
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(84, 42);
            this.txtPropertyID.TabIndex = 2;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(619, 138);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(460, 42);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(619, 186);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(162, 42);
            this.txtSuburb.TabIndex = 6;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(538, 189);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(98, 35);
            this.lblSuburb.TabIndex = 5;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(527, 285);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(121, 35);
            this.lblYearBuilt.TabIndex = 7;
            this.lblYearBuilt.Text = "Year Built";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(619, 330);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(201, 42);
            this.txtLastName.TabIndex = 10;
            // 
            // lblLandlord
            // 
            this.lblLandlord.AutoSize = true;
            this.lblLandlord.Location = new System.Drawing.Point(529, 333);
            this.lblLandlord.Name = "lblLandlord";
            this.lblLandlord.Size = new System.Drawing.Size(116, 35);
            this.lblLandlord.TabIndex = 9;
            this.lblLandlord.Text = "Landlord";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(826, 330);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(191, 42);
            this.txtFirstName.TabIndex = 12;
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(196, 402);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(307, 80);
            this.btnUpdateProperty.TabIndex = 13;
            this.btnUpdateProperty.Text = "Update Property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(579, 402);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(305, 80);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(545, 237);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 35);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Occupied",
            "Unoccupied"});
            this.cbStatus.Location = new System.Drawing.Point(619, 234);
            this.cbStatus.MaxLength = 10;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(110, 43);
            this.cbStatus.TabIndex = 16;
            // 
            // nudYearBuilt
            // 
            this.nudYearBuilt.Location = new System.Drawing.Point(620, 283);
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
            this.nudYearBuilt.Size = new System.Drawing.Size(92, 42);
            this.nudYearBuilt.TabIndex = 17;
            this.nudYearBuilt.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(496, 141);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(182, 35);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 35;
            this.lstProperties.Location = new System.Drawing.Point(73, 90);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(376, 284);
            this.lstProperties.TabIndex = 18;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Please select a property";
            // 
            // PropertyUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.nudYearBuilt);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLandlord);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.lblPropertyID);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PropertyUpdateForm";
            this.Text = "Update Property";
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBuilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLandlord;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown nudYearBuilt;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label label1;
    }
}