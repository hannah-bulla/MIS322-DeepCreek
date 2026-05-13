using System;
using System.Windows.Forms;

namespace DeepCreekLLC
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();

            // Configure DataGridView columns at runtime to avoid designer parse issues
            if (dgvFinishedGoods != null && dgvFinishedGoods.Columns.Count == 0)
            {
                dgvFinishedGoods.Columns.Add("InvID", "Inventory ID");
                dgvFinishedGoods.Columns.Add("Batch", "Batch");
                dgvFinishedGoods.Columns.Add("Model", "Model");
                dgvFinishedGoods.Columns.Add("Qty", "Qty");
                dgvFinishedGoods.Columns.Add("Status", "Status");
            }

            if (dgvRawMaterials != null && dgvRawMaterials.Columns.Count == 0)
            {
                dgvRawMaterials.Columns.Add("Material", "Material");
                dgvRawMaterials.Columns.Add("Unit", "Unit");
                dgvRawMaterials.Columns.Add("OnHand", "On Hand");
                dgvRawMaterials.Columns.Add("LastAdjusted", "Last Adjusted");
            }
        }

        private void ClearFGForm()
        {
            if (txtFGQty != null)
                txtFGQty.Clear();

            if (cboFGBatch != null && cboFGBatch.Items.Count > 0)
                cboFGBatch.SelectedIndex = 0;

            if (cboFGModel != null && cboFGModel.Items.Count > 0)
                cboFGModel.SelectedIndex = 0;

            if (cboFGStatus != null && cboFGStatus.Items.Count > 0)
                cboFGStatus.SelectedIndex = 0;

            if (dgvFinishedGoods != null)
                dgvFinishedGoods.ClearSelection();
        }

        public void ClearForm()
        {
            ClearFGForm();

            if (txtAdjQty != null)
                txtAdjQty.Clear();

            if (cboAdjMaterial != null && cboAdjMaterial.Items.Count > 0)
                cboAdjMaterial.SelectedIndex = 0;

            if (cboAdjReason != null && cboAdjReason.Items.Count > 0)
                cboAdjReason.SelectedIndex = 0;
        }

        // Named event handler referenced from the designer
        public void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
