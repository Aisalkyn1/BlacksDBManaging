
namespace BlacksPropertyManagement
{
    partial class JobDeleteForm
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
            this.lblJobFee = new System.Windows.Forms.Label();
            this.txtJobFee = new System.Windows.Forms.TextBox();
            this.txtJobDate = new System.Windows.Forms.TextBox();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnJobDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJobFee
            // 
            this.lblJobFee.AutoSize = true;
            this.lblJobFee.Location = new System.Drawing.Point(481, 197);
            this.lblJobFee.Name = "lblJobFee";
            this.lblJobFee.Size = new System.Drawing.Size(101, 35);
            this.lblJobFee.TabIndex = 2;
            this.lblJobFee.Text = "Job Fee";
            // 
            // txtJobFee
            // 
            this.txtJobFee.BackColor = System.Drawing.SystemColors.Control;
            this.txtJobFee.Location = new System.Drawing.Point(562, 194);
            this.txtJobFee.MaxLength = 6;
            this.txtJobFee.Name = "txtJobFee";
            this.txtJobFee.ReadOnly = true;
            this.txtJobFee.Size = new System.Drawing.Size(72, 42);
            this.txtJobFee.TabIndex = 3;
            // 
            // txtJobDate
            // 
            this.txtJobDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtJobDate.Location = new System.Drawing.Point(562, 242);
            this.txtJobDate.MaxLength = 10;
            this.txtJobDate.Name = "txtJobDate";
            this.txtJobDate.ReadOnly = true;
            this.txtJobDate.Size = new System.Drawing.Size(128, 42);
            this.txtJobDate.TabIndex = 5;
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Location = new System.Drawing.Point(475, 245);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(113, 35);
            this.lblJobDate.TabIndex = 4;
            this.lblJobDate.Text = "Job Date";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Location = new System.Drawing.Point(562, 290);
            this.txtStatus.MaxLength = 7;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(96, 42);
            this.txtStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(489, 293);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 35);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // btnJobDelete
            // 
            this.btnJobDelete.Location = new System.Drawing.Point(181, 415);
            this.btnJobDelete.Name = "btnJobDelete";
            this.btnJobDelete.Size = new System.Drawing.Size(268, 65);
            this.btnJobDelete.TabIndex = 8;
            this.btnJobDelete.Text = "Delete Job";
            this.btnJobDelete.UseVisualStyleBackColor = true;
            this.btnJobDelete.Click += new System.EventHandler(this.btnJobDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(577, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(268, 65);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(562, 143);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(476, 42);
            this.txtDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(458, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 35);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // txtJobID
            // 
            this.txtJobID.BackColor = System.Drawing.SystemColors.Control;
            this.txtJobID.Location = new System.Drawing.Point(562, 95);
            this.txtJobID.MaxLength = 8;
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(83, 42);
            this.txtJobID.TabIndex = 13;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(489, 102);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(84, 35);
            this.lblJobID.TabIndex = 12;
            this.lblJobID.Text = "Job ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Please select a job";
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AllowUserToOrderColumns = true;
            this.dgvJobs.AllowUserToResizeColumns = false;
            this.dgvJobs.AllowUserToResizeRows = false;
            this.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvJobs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvJobs.Location = new System.Drawing.Point(40, 75);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowHeadersVisible = false;
            this.dgvJobs.RowHeadersWidth = 72;
            this.dgvJobs.RowTemplate.Height = 31;
            this.dgvJobs.Size = new System.Drawing.Size(377, 253);
            this.dgvJobs.TabIndex = 18;
            // 
            // JobDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 656);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnJobDelete);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtJobDate);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.txtJobFee);
            this.Controls.Add(this.lblJobFee);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobDeleteForm";
            this.Text = "Delete Job";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobFee;
        private System.Windows.Forms.TextBox txtJobFee;
        private System.Windows.Forms.TextBox txtJobDate;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnJobDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJobs;
    }
}