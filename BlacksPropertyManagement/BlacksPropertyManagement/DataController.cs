using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BlacksPropertyManagement
{
    public partial class DataController : Form
    {
        public DataTable dtJob;
        public DataTable dtJobMaterial;
        public DataTable dtLandlord;
        public DataTable dtMaterial;
        public DataTable dtPropery;
        public DataTable dtTradesman;
        public DataView jobView;
        public DataView jobMaterialView;
        public DataView landlordView;
        public DataView materialView;
        public DataView propertyView;
        public DataView tradesmanView;
        public DataController()
        {
            InitializeComponent();
            dsBlacks.EnforceConstraints = false;
            daJob.Fill(dsBlacks);
            daJobMaterial.Fill(dsBlacks);
            daLandlord.Fill(dsBlacks);
            daMaterial.Fill(dsBlacks);
            daProperty.Fill(dsBlacks);
            daTradesman.Fill(dsBlacks);
            dtJob = dsBlacks.Tables["Job"];
            dtJobMaterial = dsBlacks.Tables["Jobmaterial"];
            dtLandlord = dsBlacks.Tables["Landlord"];
            dtMaterial = dsBlacks.Tables["Material"];
            dtPropery = dsBlacks.Tables["Property"];
            dtTradesman = dsBlacks.Tables["Tradesman"];
            jobView = new DataView(dtJob);
            jobView.Sort = "JobID";
            jobMaterialView = new DataView(dtJobMaterial);
            jobMaterialView.Sort = "JobID, MaterialID";
            landlordView = new DataView(dtLandlord);
            landlordView.Sort = "LandlordID";
            materialView = new DataView(dtMaterial);
            materialView.Sort = "MaterialID";
            propertyView = new DataView(dtPropery);
            propertyView.Sort = "PropertyID";
            tradesmanView = new DataView(dtTradesman);
            tradesmanView.Sort = "TradesmanID";
            dsBlacks.EnforceConstraints = true;
        }
        public void UpdateProperty()
        {
            daProperty.Update(dsBlacks, "Property");
        }
        private void daProperty_RowUpdate(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBlacks);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["PropertyID"] = newID;
            }
        }
        public void UpdateJob()
        {
            daJob.Update(dsBlacks, "Job");
        }
        private void daJob_RowUpdate(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnBlacks);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["JobID"] = newID;
            }
        }
        public void UpdateJobMaterial()
        {
            daJobMaterial.Update(dsBlacks, "JobMaterial");
        }
    }
}
