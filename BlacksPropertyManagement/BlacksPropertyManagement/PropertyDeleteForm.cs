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
    public partial class PropertyDeleteForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmProperty;
        private int PropertyID;
        public PropertyDeleteForm(DataController dc, MainForm mnu)
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
        private void clearFields()
        {
            txtPropertyID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            txtYearBuilt.Text = "";
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
                txtYearBuilt.Text = drProperty["YearBuilt"].ToString();
                DataRow drLandlord = drProperty.GetParentRow(DC.dtPropery.ParentRelations["LANDLORD_PROPERTY"]);
                txtLastName.Text = drLandlord["LastName"].ToString();
                txtFirstName.Text = drLandlord["FirstName"].ToString();
            }
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            DataRow deletePropertyRow = DC.dtPropery.Rows[cmProperty.Position];
            DataRow[] drJobs = deletePropertyRow.GetChildRows(DC.dtPropery.ChildRelations["PROPERTY_JOB"]);
            if (drJobs.Length == 0)
            {
                deletePropertyRow.Delete();
                DC.UpdateProperty();
                clearFields();
                MessageBox.Show("Property deleted successfully.", "Acknowledgement", MessageBoxButtons.OK);
                lstProperties.Items.Clear();
                DisplayProperty();
            }
            else
            {
                MessageBox.Show("Property’s with jobs cannot be deleted", "Error");
            }
        }
    }
}
