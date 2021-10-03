using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksPropertyManagement
{
    public partial class JobDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmJob;
        private CurrencyManager cmJobMaterial;
        private CurrencyManager cmTableJobMaterial;

        public JobDeleteForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            LoadJobInfo();
            frmMenu.Hide();
        }
        public void LoadJobInfo()
        {
            dgvJobs.DataSource = DC.dsBlacks;
            dgvJobs.DataMember = "Job";
            txtJobID.DataBindings.Add("Text", DC.dsBlacks, "Job.JobID");
            txtDescription.DataBindings.Add("Text", DC.dsBlacks, "Job.JobDescription");
            txtJobDate.DataBindings.Add("Text", DC.dsBlacks, "Job.JobDate");
            txtJobFee.DataBindings.Add("Text", DC.dsBlacks, "Job.JobFee");
            txtStatus.DataBindings.Add("Text", DC.dsBlacks, "Job.Status");
            cmJob = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Job"];
            cmJobMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Job.JOB_JOBMATERIAL"];
            cmTableJobMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacks, "JOBMATERIAL"];
            dgvJobs.Columns["JobDate"].Visible = false;
            dgvJobs.Columns["Status"].Visible = false;
            dgvJobs.Columns["JobFee"].Visible = false;
            dgvJobs.Columns["PropertyID"].Visible = false;
            dgvJobs.Columns["TradesmanID"].Visible = false;
        }

        private void btnJobDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteJobRow = DC.dtJob.Rows[cmJob.Position];
            if(deleteJobRow["Status"].ToString() == "Paid")
            {
                DataRow[] dRow = deleteJobRow.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
                foreach (DataRow Row in dRow)
                {
                    Row.Delete();
                    DC.UpdateJobMaterial();
                }
                deleteJobRow.Delete();
                DC.UpdateJob();
                MessageBox.Show("Job deleted successfully", "Success");
            }            
            else
            {
                MessageBox.Show("Current jobs cannot be deleted", "Error");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}

