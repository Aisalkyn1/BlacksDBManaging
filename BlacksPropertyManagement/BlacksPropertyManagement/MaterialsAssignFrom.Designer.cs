
namespace BlacksPropertyManagement
{
    partial class MaterialsAssignFrom
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAssignMaterial = new System.Windows.Forms.Button();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.lblPropertyID = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboJOB = new System.Windows.Forms.ComboBox();
            this.lblassigntedMaterials = new System.Windows.Forms.Label();
            this.lstMaterials = new System.Windows.Forms.ListBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cboMaterialID = new System.Windows.Forms.ComboBox();
            this.cboMaterialDescription = new System.Windows.Forms.ComboBox();
            this.txtJobDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(608, 449);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(292, 62);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAssignMaterial
            // 
            this.btnAssignMaterial.Location = new System.Drawing.Point(183, 449);
            this.btnAssignMaterial.Name = "btnAssignMaterial";
            this.btnAssignMaterial.Size = new System.Drawing.Size(258, 62);
            this.btnAssignMaterial.TabIndex = 2;
            this.btnAssignMaterial.Text = "Assign Material";
            this.btnAssignMaterial.UseVisualStyleBackColor = true;
            this.btnAssignMaterial.Click += new System.EventHandler(this.btnAssignMaterial_Click);
            // 
            // txtJobID
            // 
            this.txtJobID.BackColor = System.Drawing.SystemColors.Control;
            this.txtJobID.Location = new System.Drawing.Point(662, 74);
            this.txtJobID.MaxLength = 8;
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(78, 42);
            this.txtJobID.TabIndex = 43;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(608, 81);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(84, 35);
            this.lblJobID.TabIndex = 42;
            this.lblJobID.Text = "Job ID";
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPropertyID.Location = new System.Drawing.Point(662, 215);
            this.txtPropertyID.MaxLength = 5;
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(68, 42);
            this.txtPropertyID.TabIndex = 41;
            // 
            // lblPropertyID
            // 
            this.lblPropertyID.AutoSize = true;
            this.lblPropertyID.Location = new System.Drawing.Point(578, 222);
            this.lblPropertyID.Name = "lblPropertyID";
            this.lblPropertyID.Size = new System.Drawing.Size(145, 35);
            this.lblPropertyID.TabIndex = 40;
            this.lblPropertyID.Text = "Property ID";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(662, 119);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(395, 42);
            this.txtDescription.TabIndex = 36;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(577, 126);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 35);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Description";
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Location = new System.Drawing.Point(594, 174);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(113, 35);
            this.lblJobDate.TabIndex = 34;
            this.lblJobDate.Text = "Job Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 35);
            this.label1.TabIndex = 33;
            this.label1.Text = "Select a material";
            // 
            // cboJOB
            // 
            this.cboJOB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboJOB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJOB.FormattingEnabled = true;
            this.cboJOB.Location = new System.Drawing.Point(12, 74);
            this.cboJOB.Name = "cboJOB";
            this.cboJOB.Size = new System.Drawing.Size(371, 43);
            this.cboJOB.TabIndex = 31;
            this.cboJOB.SelectedIndexChanged += new System.EventHandler(this.cboJOB_SelectedIndexChanged);
            // 
            // lblassigntedMaterials
            // 
            this.lblassigntedMaterials.AutoSize = true;
            this.lblassigntedMaterials.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassigntedMaterials.Location = new System.Drawing.Point(6, 144);
            this.lblassigntedMaterials.Name = "lblassigntedMaterials";
            this.lblassigntedMaterials.Size = new System.Drawing.Size(343, 35);
            this.lblassigntedMaterials.TabIndex = 30;
            this.lblassigntedMaterials.Text = "Assigned materials to the job";
            // 
            // lstMaterials
            // 
            this.lstMaterials.BackColor = System.Drawing.SystemColors.Control;
            this.lstMaterials.FormattingEnabled = true;
            this.lstMaterials.ItemHeight = 35;
            this.lstMaterials.Location = new System.Drawing.Point(12, 172);
            this.lstMaterials.Name = "lstMaterials";
            this.lstMaterials.Size = new System.Drawing.Size(492, 109);
            this.lstMaterials.TabIndex = 29;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(12, 47);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(221, 35);
            this.lblSelect.TabIndex = 28;
            this.lblSelect.Text = "Please select a job";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreetAddress.Location = new System.Drawing.Point(662, 263);
            this.txtStreetAddress.MaxLength = 60;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(246, 42);
            this.txtStreetAddress.TabIndex = 49;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(559, 270);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(182, 35);
            this.lblStreetAddress.TabIndex = 48;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 35);
            this.label2.TabIndex = 50;
            this.label2.Text = "Enter quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(662, 333);
            this.nudQuantity.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(50, 42);
            this.nudQuantity.TabIndex = 51;
            this.nudQuantity.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // cboMaterialID
            // 
            this.cboMaterialID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboMaterialID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterialID.FormattingEnabled = true;
            this.cboMaterialID.Location = new System.Drawing.Point(12, 337);
            this.cboMaterialID.Name = "cboMaterialID";
            this.cboMaterialID.Size = new System.Drawing.Size(121, 43);
            this.cboMaterialID.TabIndex = 52;
            // 
            // cboMaterialDescription
            // 
            this.cboMaterialDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboMaterialDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterialDescription.FormattingEnabled = true;
            this.cboMaterialDescription.Location = new System.Drawing.Point(136, 337);
            this.cboMaterialDescription.Name = "cboMaterialDescription";
            this.cboMaterialDescription.Size = new System.Drawing.Size(368, 43);
            this.cboMaterialDescription.TabIndex = 53;
            // 
            // txtJobDate
            // 
            this.txtJobDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtJobDate.Location = new System.Drawing.Point(662, 164);
            this.txtJobDate.MaxLength = 10;
            this.txtJobDate.Name = "txtJobDate";
            this.txtJobDate.ReadOnly = true;
            this.txtJobDate.Size = new System.Drawing.Size(128, 42);
            this.txtJobDate.TabIndex = 54;
            // 
            // MaterialsAssignFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 656);
            this.Controls.Add(this.txtJobDate);
            this.Controls.Add(this.cboMaterialDescription);
            this.Controls.Add(this.cboMaterialID);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.lblPropertyID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboJOB);
            this.Controls.Add(this.lblassigntedMaterials);
            this.Controls.Add(this.lstMaterials);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnAssignMaterial);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaterialsAssignFrom";
            this.Text = "Assign Materials";
            this.Load += new System.EventHandler(this.MaterialsAssignFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAssignMaterial;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.Label lblPropertyID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboJOB;
        private System.Windows.Forms.Label lblassigntedMaterials;
        private System.Windows.Forms.ListBox lstMaterials;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cboMaterialID;
        private System.Windows.Forms.ComboBox cboMaterialDescription;
        private System.Windows.Forms.TextBox txtJobDate;
    }
}