using System;
using System.Windows.Forms;
using DeepCreekLLC.Database;

namespace DeepCreekLLC
{
    public partial class ProductionControl : UserControl
    {
        private int _editingBatchID = -1;   // -1 means "new record" mode

        public ProductionControl()
        {
            InitializeComponent();
            LoadRodModels();
            LoadGrid();
        }

        // LOAD

        private void LoadRodModels()
        {
            cboRodModel.Items.Clear();
            try
            {
                foreach (var m in ProductionRepository.GetRodModels())
                {
                    // Store the whole object so we can get the ID on save
                    cboRodModel.Items.Add(m);
                }
                cboRodModel.DisplayMember = "DisplayText";
                if (cboRodModel.Items.Count > 0)
                    cboRodModel.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rod models:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGrid()
        {
            dgvBatches.Rows.Clear();
            try
            {
                foreach (var b in ProductionRepository.GetAllBatches())
                {
                    double defectPct = b.ActualQty > 0
                        ? Math.Round((double)b.DefectUnits / b.ActualQty * 100, 1)
                        : 0;

                    dgvBatches.Rows.Add(
                        b.BatchCode,
                        b.BatchDate.ToString("MM/dd/yyyy"),
                        b.ProductionLineNumber,
                        b.ShiftNumber,
                        b.ModelCode,
                        b.PlannedQty,
                        b.ActualQty,
                        b.GoodUnits,
                        b.DefectUnits,
                        $"{defectPct}%"
                    );

                    // Store BatchID in the rows tag for edit/delete
                    dgvBatches.Rows[dgvBatches.Rows.Count - 1].Tag = b.BatchID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading batches:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SAVE (Insert or Update)

        private void btnSaveBatch_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                var batch = BuildBatchFromForm();

                if (_editingBatchID == -1)
                    ProductionRepository.InsertBatch(batch);
                else
                {
                    batch.BatchID = _editingBatchID;
                    ProductionRepository.UpdateBatch(batch);
                    _editingBatchID = -1;
                    btnSaveBatch.Text = "Save Batch";
                }

                ClearForm();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving batch:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EDIT

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentRow == null) return;

            var row = dgvBatches.CurrentRow;
            _editingBatchID = (int)row.Tag;

            txtBatchCode.Text = row.Cells[0].Value?.ToString() ?? "";
            dtpBatchDate.Value = DateTime.TryParse(
                row.Cells[1].Value?.ToString(), out var d) ? d : DateTime.Today;

            SetComboByText(cboLine, "Line " + row.Cells[2].Value);
            SetComboByText(cboShift, row.Cells[3].Value?.ToString() ?? "");

            // Match rod model combo by model code
            var modelCode = row.Cells[4].Value?.ToString() ?? "";
            for (int i = 0; i < cboRodModel.Items.Count; i++)
            {
                if (((RodModelItem)cboRodModel.Items[i]).DisplayText.StartsWith(modelCode))
                { cboRodModel.SelectedIndex = i; break; }
            }

            txtPlanned.Text = row.Cells[5].Value?.ToString() ?? "";
            txtActual.Text = row.Cells[6].Value?.ToString() ?? "";
            txtGood.Text = row.Cells[7].Value?.ToString() ?? "";
            txtDefect.Text = row.Cells[8].Value?.ToString() ?? "";

            btnSaveBatch.Text = "Update Batch";
        }

        // DELETE

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBatches.CurrentRow == null) return;

            var confirm = MessageBox.Show(
                "Delete this production batch? This cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                int batchID = (int)dgvBatches.CurrentRow.Tag;
                ProductionRepository.DeleteBatch(batchID);
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting batch:\n{ex.Message}\n\n" +
                    "The batch may have linked QA inspections or inventory records.",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // HELPERS

        private ProductionBatch BuildBatchFromForm()
        {
            var selectedModel = (RodModelItem)cboRodModel.SelectedItem;
            return new ProductionBatch
            {
                BatchCode = txtBatchCode.Text.Trim(),
                BatchDate = dtpBatchDate.Value.Date,
                ProductionLineNumber = cboLine.SelectedIndex + 1,  // "Line 1" → 1
                ShiftNumber = int.Parse(cboShift.Text),
                RodModelID = selectedModel.RodModelID,
                PlannedQty = int.Parse(txtPlanned.Text),
                ActualQty = int.Parse(txtActual.Text),
                GoodUnits = int.Parse(txtGood.Text),
                DefectUnits = int.Parse(txtDefect.Text)
            };
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtBatchCode.Text))
            {
                MessageBox.Show("Batch Code is required.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }

            if (!int.TryParse(txtPlanned.Text, out _) ||
                !int.TryParse(txtActual.Text, out _) ||
                !int.TryParse(txtGood.Text, out _) ||
                !int.TryParse(txtDefect.Text, out _))
            {
                MessageBox.Show("Planned, Actual, Good, and Defect must be whole numbers.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }

            if (cboRodModel.SelectedItem is not RodModelItem)
            {
                MessageBox.Show("Please select a Rod Model.", "Validation",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }

            return true;
        }

        private static void SetComboByText(ComboBox cbo, string text)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
                if (cbo.Items[i].ToString() == text) { cbo.SelectedIndex = i; return; }
            if (cbo.Items.Count > 0) cbo.SelectedIndex = 0;
        }

        public void ClearForm()
        {
            txtBatchCode.Clear();
            dtpBatchDate.Value = DateTime.Today;
            if (cboLine.Items.Count > 0) cboLine.SelectedIndex = 0;
            if (cboShift.Items.Count > 0) cboShift.SelectedIndex = 0;
            if (cboRodModel.Items.Count > 0) cboRodModel.SelectedIndex = 0;
            txtPlanned.Clear(); txtActual.Clear();
            txtGood.Clear(); txtDefect.Clear();
            _editingBatchID = -1;
            btnSaveBatch.Text = "Save Batch";
        }

        public void btnClear_Click(object sender, EventArgs e) => ClearForm();

        public void InitializeForDesignMode() { }
    }
}