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
    public partial class MainForm : Form
    {
        private DataController DC;
        private PropertyAddForm frmPropertyAdd;
        private PropertyUpdateForm frmPropertyUpdate;
        private PropertyDeleteForm frmPropertyDelete;
        private JobAddForm frmJobAdd;
        private JobUpdateForm frmJobUpdate;
        private JobDeleteForm frmJobDelete;
        private MaterialsAssignFrom frmMaterialsAssign;
        private MaterialsRemoveFrom frmMaterialsRemove;
        private InvoicesPrintForm frmInvoicesPrint;
        private TradesmenReportPrintForm frmTradesmenReportPrint;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnAddProperties_Click(object sender, EventArgs e)
        {
            if (frmPropertyAdd == null)
            {
                frmPropertyAdd = new PropertyAddForm(DC, this);
            }
            frmPropertyAdd.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateProperties_Click(object sender, EventArgs e)
        {
            if (frmPropertyUpdate == null);
            {
                frmPropertyUpdate = new PropertyUpdateForm(DC, this);
            }
            frmPropertyUpdate.ShowDialog();
        }

        private void btnDeleteProperties_Click(object sender, EventArgs e)
        {
            if (frmPropertyDelete == null)
            {
                frmPropertyDelete = new PropertyDeleteForm(DC, this);
            }
            frmPropertyDelete.ShowDialog();
        }

        private void btnAddJobs_Click(object sender, EventArgs e)
        {
            if (frmJobAdd == null)
            {
                frmJobAdd = new JobAddForm(DC, this);
            }
            frmJobAdd.ShowDialog();
        }

        private void btnUpdateJobs_Click(object sender, EventArgs e)
        {
            if (frmJobUpdate == null)
            {
                frmJobUpdate = new JobUpdateForm(DC, this);
            }
            frmJobUpdate.ShowDialog();
        }

        private void btnDeleteJobs_Click(object sender, EventArgs e)
        {
            if (frmJobDelete == null)
            {
                frmJobDelete = new JobDeleteForm(DC, this);
            }
            frmJobDelete.ShowDialog();
        }

        private void btnAssignMaterials_Click(object sender, EventArgs e)
        {
            if (frmMaterialsAssign == null)
            {
                frmMaterialsAssign = new MaterialsAssignFrom(DC, this);
            }
            frmMaterialsAssign.ShowDialog();
        }

        private void btnRemoveMaterials_Click(object sender, EventArgs e)
        {
            if (frmMaterialsRemove == null)
            {
                frmMaterialsRemove = new MaterialsRemoveFrom(DC, this);
            }
            frmMaterialsRemove.ShowDialog();
        }

        private void btnPrintTradesmenReports_Click(object sender, EventArgs e)
        {
           if (frmTradesmenReportPrint == null)
           {
                frmTradesmenReportPrint = new TradesmenReportPrintForm(DC, this);
           }
           frmTradesmenReportPrint.ShowDialog();
        }

        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoicesPrint == null)
            {
                frmInvoicesPrint = new InvoicesPrintForm(DC, this);
            }
            frmInvoicesPrint.ShowDialog();
        }
    }
}
