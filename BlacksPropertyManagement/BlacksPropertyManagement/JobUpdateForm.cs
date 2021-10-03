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
    public partial class JobUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmJob;

        public JobUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            LoadListJobs();
            frmMenu.Hide();
        }
        private void LoadListJobs()
        {
            cmJob = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Job"];

            string JobText = "";
            foreach (DataRow drJob in DC.dtJob.Rows)
            {
                if (drJob["Status"].ToString() == "Current")
                {
                    JobText = drJob["JobID"] + ", " + drJob["JobDescription"];
                    lstJobs.Items.Add(JobText);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void lstJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstJobs.SelectedItem != null)
            {
                string[] parts = lstJobs.SelectedItem.ToString().Split(',');
                int jobID = Convert.ToInt32(parts[0]);
                cmJob.Position = DC.jobView.Find(jobID);
                DataRow drJob = DC.dtJob.Rows[cmJob.Position];
                txtJobID.Text = drJob["JobID"].ToString();
                txtDescription.Text = drJob["JobDescription"].ToString();
                dtpDate.Text = drJob["JobDate"].ToString();
                nudJobFee.Value = Convert.ToInt32(drJob["JobFee"]);
                cboStatus.Text = drJob["Status"].ToString();
                DataRow drRelation = drJob.GetParentRow(DC.dtJob.ParentRelations["PROPERTY_JOB"]);
                DataRow drLandlordID = drRelation.GetParentRow(DC.dtPropery.ParentRelations["LANDLORD_PROPERTY"]);
                txtLastName.Text = drLandlordID["LastName"].ToString();
                txtFirstName.Text = drLandlordID["FirstName"].ToString();
            }
        }

        private void btnUpdateJob_Click(object sender, EventArgs e)
        {
            DataRow updateJobRow = DC.dtJob.Rows[cmJob.Position];
            if ((txtDescription.Text) == "" || (dtpDate.Text == "") || (nudJobFee.Text == "") || (cboStatus.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                updateJobRow["JobDescription"] = txtDescription.Text;
                updateJobRow["JobDate"] = dtpDate.Text;
                updateJobRow["JobFee"] = nudJobFee.Value;
                updateJobRow["Status"] = cboStatus.Text;
                cmJob.EndCurrentEdit();
                DC.UpdateJob();
                MessageBox.Show("Job updated successfully", "Success");
                ClearFields();
                lstJobs.Items.Clear();
                LoadListJobs();
            }
        }
        private void ClearFields()
        {
            txtDescription.Text = "";
            txtJobID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            cboStatus.Text = "";
            nudJobFee.Value = 100;
            dtpDate.Text = "";
        }
    }
}
