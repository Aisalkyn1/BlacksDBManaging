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
    public partial class MaterialsRemoveFrom : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmJob;
        private CurrencyManager cmJobMaterial;
        private CurrencyManager cmMaterials;
        private CurrencyManager cmMaterialJob;
        private int MaterialID;
        private int JobID;

        public MaterialsRemoveFrom(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            LoadInfo();
        }
        public void LoadInfo()
        {
            cmJob = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Job"];
            cmJobMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Job.JOB_JOBMATERIAL"];
            cmMaterialJob = (CurrencyManager)this.BindingContext[DC.dsBlacks, "JOBMATERIAL"];
            cmMaterials = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Material"];

            string JobText = "";
            foreach (DataRow drJob in DC.dtJob.Rows)
            {
                DataRow[] jobMaterial = drJob.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
                if (jobMaterial.Length != 0)
                {
                    JobText = drJob["JobID"] + ", " + drJob["JobDescription"] + ",  " + drJob["JobDate"];
                    cboJOB.Items.Add(JobText);
                }
            }
        }

        private void cboJOB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJOB.SelectedItem != null)
            {
                string list, MaterialText = "";
                lstMaterials.Items.Clear();
                list = cboJOB.SelectedItem.ToString();
                string[] parts = list.Split(',');
                int jobID = Convert.ToInt32(parts[0]);
                cmJob.Position = DC.jobView.Find(jobID);
                DataRow drJob = DC.dtJob.Rows[cmJob.Position];
                JobID = Convert.ToInt32(drJob["JobID"]);
                txtJobID.Text = drJob["JobID"].ToString();
                txtDescription.Text = drJob["JobDescription"].ToString();
                txtJobDate.Text = drJob["JobDate"].ToString();
                DataRow drProperties = drJob.GetParentRow(DC.dtJob.ParentRelations["PROPERTY_JOB"]);
                txtStreetAddress.Text = drProperties["StreetAddress"].ToString();
                DataRow landlord = drProperties.GetParentRow(DC.dtPropery.ParentRelations["Landlord_Property"]);
                txtLastName.Text = landlord["LastName"].ToString();
                txtFirstName.Text = landlord["FirstName"].ToString();
                DataRow[] drJobMaterial = drJob.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
                foreach (DataRow drJobMat in drJobMaterial)
                {
                    int Matid = Convert.ToInt32(drJobMat["MaterialID"]);
                    cmJobMaterial.Position = DC.materialView.Find(Matid);
                    DataRow drMat = DC.dtMaterial.Rows[cmJobMaterial.Position];
                    MaterialText = drJobMat["MaterialID"] + ", " + drMat["MaterialDescription"] + ",  " + "Quantity:  " + drJobMat["Quantity"];
                    lstMaterials.Items.Add(MaterialText);
                }
            }
        }

        private void lstMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] parts = lstMaterials.SelectedItem.ToString().Split(',');
            int key = Convert.ToInt32(parts[0]);
            cmMaterials.Position = DC.materialView.Find(key);
            DataRow drKey = DC.dtMaterial.Rows[cmMaterials.Position];
            MaterialID = Convert.ToInt32(drKey["MaterialID"]);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            object[] Keys = new object[2];
            Keys[0] = JobID;
            Keys[1] = MaterialID;
            cmMaterialJob.Position = DC.jobMaterialView.Find(Keys);
            DataRow deleteRow = DC.dtJobMaterial.Rows[cmMaterialJob.Position];
            deleteRow.Delete();
            DC.UpdateJobMaterial();
            ClearField();
            cboJOB.Items.Clear();
            LoadInfo();
            lstMaterials.Items.Clear();
            MessageBox.Show("Material removed successfully");
        }
        public void ClearField()
        {
            txtDescription.Text = "";
            txtFirstName.Text = "";
            txtJobDate.Text = "";
            txtJobID.Text = "";
            txtStreetAddress.Text = "";
            txtLastName.Text = "";
        }
    }
}
