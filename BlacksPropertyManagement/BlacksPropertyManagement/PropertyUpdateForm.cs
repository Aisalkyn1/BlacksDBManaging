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
    public partial class PropertyUpdateForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmProperty;
        private int PropertyID;
        public PropertyUpdateForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            DisplayProperty();
            frmMenu.Hide();
        }

        public void DisplayProperty()
        {
            cmProperty = (CurrencyManager)this.BindingContext[DC.dsBlacks, "Property"];

            string PropertyText = "";
            foreach (DataRow drProperty in DC.dtPropery.Rows)
            {
                PropertyText = drProperty["PropertyID"] + ", " + drProperty["StreetAddress"];
                lstProperties.Items.Add(PropertyText);
             
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {           
            DataRow updatePropertyRow = DC.dtPropery.Rows[cmProperty.Position];
            if ((txtStreetAddress.Text == "") || (txtSuburb.Text == "") || (cbStatus.Text == "") || (nudYearBuilt.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Error");
            }
            else
            {
                updatePropertyRow["StreetAddress"] = txtStreetAddress.Text;
                updatePropertyRow["Suburb"] = txtSuburb.Text;
                updatePropertyRow["Status"] = cbStatus.Text;
                updatePropertyRow["YearBuilt"] = nudYearBuilt.Value;
                DC.UpdateProperty();
                clearFields();
                MessageBox.Show("Property updated successfully.", "Success");
                lstProperties.Items.Clear();
                DisplayProperty();

            }
        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProperties.SelectedItem != null)
            {
                string property = lstProperties.SelectedItem.ToString();
                string[] parts = property.Split(',');
                PropertyID = Convert.ToInt32(parts[0]);
                cmProperty.Position = DC.propertyView.Find(PropertyID);
                DataRow drProperty = DC.dtPropery.Rows[cmProperty.Position];
                txtPropertyID.Text = drProperty["PropertyID"].ToString();
                txtStreetAddress.Text = drProperty["StreetAddress"].ToString();
                txtSuburb.Text = drProperty["Suburb"].ToString();
                cbStatus.Text = drProperty["Status"].ToString();
                nudYearBuilt.Value = Convert.ToInt32(drProperty["YearBuilt"]);
                DataRow drLandlord = drProperty.GetParentRow(DC.dtPropery.ParentRelations["LANDLORD_PROPERTY"]);
                txtLastName.Text = drLandlord["LastName"].ToString();
                txtFirstName.Text = drLandlord["FirstName"].ToString();
            }

        }
        private void clearFields()
        {
            txtPropertyID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            cbStatus.Text = "";
            nudYearBuilt.Value = 1900;
        }
    }
}
