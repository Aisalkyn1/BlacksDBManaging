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
    public partial class MaterialsAssignFrom : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmJob;
        private CurrencyManager cmMaterials;
        private CurrencyManager cmJobMaterial;
        public MaterialsAssignFrom(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            LoadInfo();
            loadInfo();
            frmMenu.Hide();
        }
        public void LoadInfo()
        {
            cmJob = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Job"];
            cmMaterials = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Material"];
            cmJobMaterial = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Job.Job_JOBMATERIAL"];

            cboMaterialID.DataSource = DC.dsBlacks;
            cboMaterialID.DisplayMember = "Material.MaterialID";
            cboMaterialID.ValueMember = "Material.MaterialID";
            cboMaterialDescription.DataSource = DC.dsBlacks;
            cboMaterialDescription.DisplayMember = "Material.MaterialDescription";
            cboMaterialDescription.ValueMember = "Material.MaterialDescription";
        }
        public void loadInfo()
        { 
            string JobText = "";
            foreach (DataRow drJob in DC.dtJob.Rows)
            {
                if (drJob["Status"].ToString() == "Current")
                {
                    JobText = drJob["JobID"] + ", " + drJob["JobDescription"];
                    cboJOB.Items.Add(JobText);
                }
            }
        }
        private void MaterialsAssignFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
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
                txtJobID.Text = drJob["JobID"].ToString();
                txtDescription.Text = drJob["JobDescription"].ToString();
                txtJobDate.Text = drJob["JobDate"].ToString();
                txtPropertyID.Text = drJob["PropertyID"].ToString();
                DataRow drProperties = drJob.GetParentRow(DC.dtJob.ParentRelations["PROPERTY_JOB"]);
                txtStreetAddress.Text = drProperties["StreetAddress"].ToString();
                DataRow[] drJobMaterial = drJob.GetChildRows(DC.dtJob.ChildRelations["JOB_JOBMATERIAL"]);
                foreach (DataRow drJobMat in drJobMaterial)
                {                 
                    int Matid = Convert.ToInt32(drJobMat["MaterialID"]);
                    cmMaterials.Position = DC.materialView.Find(Matid);
                    DataRow drMat = DC.dtMaterial.Rows[cmMaterials.Position];
                    MaterialText = "Material ID:  " + drJobMat["MaterialID"] + "  " + drMat["MaterialDescription"] + ",  " + "Quantity:  " + drJobMat["Quantity"];
                    lstMaterials.Items.Add(MaterialText);
                }
            }
        }

        private void btnAssignMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newJobMaterialRow = DC.dtJobMaterial.NewRow();
                newJobMaterialRow["JobID"] = txtJobID.Text;
                newJobMaterialRow["Quantity"] = nudQuantity.Value;
                newJobMaterialRow["MaterialID"] = cboMaterialID.Text;
                DC.dsBlacks.Tables["JobMaterial"].Rows.Add(newJobMaterialRow);
                DC.UpdateJobMaterial();
                ClearField();
                cboJOB.Items.Clear();
                loadInfo();
                lstMaterials.Items.Clear();
                MessageBox.Show("Material assigned successfully", "Success");
            }
            catch(System.Data.ConstraintException)
            {
                MessageBox.Show("This material is already assigned to this job", "Error");
            }

        }
        public void ClearField()
        {
            txtJobID.Text = "";
            txtDescription.Text = "";
            txtJobDate.Text = "";
            txtPropertyID.Text = "";
            txtStreetAddress.Text = "";
        }
    }
}
