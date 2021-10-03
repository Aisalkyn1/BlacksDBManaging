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
    public partial class JobAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmLandlord;
        private int PropertyID;
        private int TradesmanID;

        public JobAddForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            LoadListLandlords();
        }
        private void LoadListLandlords()
        {
            cmLandlord = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Landlord"];

            string LandlordText = "";
            foreach (DataRow drLandlord in DC.dtLandlord.Rows)
            {
                if (drLandlord["CreditStatus"].ToString() == "Valid")
                {
                    LandlordText = drLandlord["LandlordID"] + ", " + drLandlord["LastName"] + ", " + drLandlord["FirstName"];
                    cboLandlords.Items.Add(LandlordText);
                }
            }
            string tradesmanText = "";
            foreach (DataRow drTradesman in DC.dtTradesman.Rows)
            {
                tradesmanText = drTradesman["TradesmanID"] + ", " + drTradesman["LastName"] + ", " + drTradesman["FirstName"];
                cboTradesman.Items.Add(tradesmanText);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void cboLandlords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLandlords.SelectedItem != null)
            {
                string list, propertyText = "";
                lstProperties.Items.Clear();
                list = cboLandlords.SelectedItem.ToString();
                string[] parts = list.Split(',');
                txtLastName.Text = parts[1].ToString();
                txtFirstName.Text = parts[2].ToString();
                cmLandlord.Position = DC.landlordView.Find(parts[0]);
                DataRow drLandlord = DC.dtLandlord.Rows[cmLandlord.Position];
                cmLandlord.Position = DC.landlordView.Find(parts[0]);
                DataRow[] drProperties = drLandlord.GetChildRows(DC.dtLandlord.ChildRelations["LANDLORD_PROPERTY"]);
                foreach (DataRow drProperty in drProperties)
                {
                    propertyText = drProperty["StreetAddress"] + ", " + drProperty["Suburb"];
                    lstProperties.Items.Add(propertyText);
                    PropertyID = Convert.ToInt32(drProperty["PropertyID"]);
                }
            }
        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboTradesman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTradesman.SelectedItem != null)
            {
                string list = cboTradesman.SelectedItem.ToString();
                string[] parts = list.Split(',');
                txtlName.Text = parts[1].ToString();
                txtfName.Text = parts[2].ToString();
                TradesmanID = Convert.ToInt32(parts[0]);             
            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            if (dtpDate.Text == "" || txtDescription.Text == "" || nudJobFee.Text == "")
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DataRow newJobRow = DC.dtJob.NewRow();
                newJobRow["JobDescription"] = txtDescription.Text;
                newJobRow["JobDate"] = dtpDate.Value;
                newJobRow["Status"] = txtStatus.Text;
                newJobRow["JobFee"] = nudJobFee.Value;
                newJobRow["PropertyID"] = PropertyID;
                newJobRow["TradesmanID"] = TradesmanID;
                DC.dsBlacks.Tables["Job"].Rows.Add(newJobRow);
                DC.UpdateJob();
                ClearFields();
                MessageBox.Show("Job added successfully", "Acknowledgment", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void ClearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtlName.Text = "";
            txtfName.Text = "";
            txtDescription.Text = "";
            txtStatus.Text = "Current";
            dtpDate.Text = "";
            nudJobFee.Value = 100;
        }
    }
}
