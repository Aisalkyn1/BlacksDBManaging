
namespace BlacksPropertyManagement
{
    partial class PropertyDeleteForm
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
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtYearBuilt = new System.Windows.Forms.TextBox();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLandlord = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 35;
            this.lstProperties.Location = new System.Drawing.Point(45, 79);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(361, 284);
            this.lstProperties.TabIndex = 0;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Location = new System.Drawing.Point(469, 95);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(145, 35);
            this.lblPropertyID.TabIndex = 1;
            this.lblPropertyID.Text = "Property ID";
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Location = new System.Drawing.Point(559, 100);
            this.txtPropertyID.MaxLength = 5;
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(68, 42);
            this.txtPropertyID.TabIndex = 2;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(559, 165);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(442, 42);
            this.txtStreetAddress.TabIndex = 4;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(445, 165);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(182, 35);
            this.lblStreetAddress.TabIndex = 3;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // txtYearBuilt
            // 
            this.txtYearBuilt.Location = new System.Drawing.Point(559, 227);
            this.txtYearBuilt.MaxLength = 4;
            this.txtYearBuilt.Name = "txtYearBuilt";
            this.txtYearBuilt.ReadOnly = true;
            this.txtYearBuilt.Size = new System.Drawing.Size(100, 42);
            this.txtYearBuilt.TabIndex = 6;
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(469, 222);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(121, 35);
            this.lblYearBuilt.TabIndex = 5;
            this.lblYearBuilt.Text = "Year Built";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(559, 284);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(203, 42);
            this.txtLastName.TabIndex = 8;
            // 
            // lblLandlord
            // 
            this.lblLandlord.AutoSize = true;
            this.lblLandlord.Location = new System.Drawing.Point(469, 279);
            this.lblLandlord.Name = "lblLandlord";
            this.lblLandlord.Size = new System.Drawing.Size(116, 35);
            this.lblLandlord.TabIndex = 7;
            this.lblLandlord.Text = "Landlord";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(768, 284);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(209, 42);
            this.txtFirstName.TabIndex = 9;
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(206, 396);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(242, 70);
            this.btnDeleteProperty.TabIndex = 10;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(559, 396);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(242, 70);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Please select a property";
            // 
            // PropertyDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLandlord);
            this.Controls.Add(this.txtYearBuilt);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.lstProperties);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PropertyDeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtYearBuilt;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLandlord;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
    }
}