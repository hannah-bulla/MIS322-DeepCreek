using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepCreekLLC
{
    public partial class MainMenu : Form
    {
        private Inventory? inventoryForm;
        private Production? productionForm;
        private Quality? qualityForm;
        private Returns? returnsForm;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (inventoryForm == null || inventoryForm.IsDisposed)
            {
                inventoryForm = new Inventory();
                inventoryForm.FormClosed += (s, ev) => inventoryForm = null;
                inventoryForm.Show(this);
            }
            else
            {
                inventoryForm.BringToFront();
            }
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            if (productionForm == null || productionForm.IsDisposed)
            {
                productionForm = new Production();
                productionForm.FormClosed += (s, ev) => productionForm = null;
                productionForm.Show(this);
            }
            else
            {
                productionForm.BringToFront();
            }
        }

        private void btnQuality_Click(object sender, EventArgs e)
        {
            if (qualityForm == null || qualityForm.IsDisposed)
            {
                qualityForm = new Quality();
                qualityForm.FormClosed += (s, ev) => qualityForm = null;
                qualityForm.Show(this);
            }
            else
            {
                qualityForm.BringToFront();
            }
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            if (returnsForm == null || returnsForm.IsDisposed)
            {
                returnsForm = new Returns();
                returnsForm.FormClosed += (s, ev) => returnsForm = null;
                returnsForm.Show(this);
            }
            else
            {
                returnsForm.BringToFront();
            }
        }
    }
}
