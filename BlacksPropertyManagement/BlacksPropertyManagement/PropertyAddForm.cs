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
    public partial class PropertyAddForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmLandlord;
        private int LandlordID;

        public PropertyAddForm(DataController dc, MainForm mnu)
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
                    lstLandlords.Items.Add(LandlordText);
                }
            }
        }

        private void clearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            cboStatus.Text = "";
            nudYearBuilt.Value = 1900;
        }

        private void PropertyAddForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || txtStreetAddress.Text == "" ||
                txtSuburb.Text == "" || cboStatus.Text == "" || nudYearBuilt.Text == "")
            {
                MessageBox.Show("Some fields are blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow newPropertyRow = DC.dtPropery.NewRow();
                newPropertyRow["StreetAddress"] = txtStreetAddress.Text;
                newPropertyRow["Suburb"] = txtSuburb.Text;
                newPropertyRow["Status"] = cboStatus.Text;
                newPropertyRow["YearBuilt"] = nudYearBuilt.Value;
                newPropertyRow["LandlordID"] = LandlordID;
                DC.dtPropery.Rows.Add(newPropertyRow);
                DC.UpdateProperty();
                MessageBox.Show("Property Added Successfully", "Success");
                clearFields();
            }
        }

        private void lstLandlords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLandlords.SelectedItem != null)
            {
                string LD = lstLandlords.SelectedItem.ToString();
                string[] parts = LD.Split(',');
                LandlordID = Convert.ToInt32(parts[0]);
                txtLastName.Text = parts[1].ToString();
                txtFirstName.Text = parts[2].ToString();
            }
        }
    }
}
