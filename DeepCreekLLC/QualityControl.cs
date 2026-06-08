using System;
using System.Windows.Forms;
using DeepCreekLLC.Database;

namespace DeepCreekLLC
{
    public partial class QualityControl : UserControl
    {
        public QualityControl()
        {
            InitializeComponent();

            SetupGrid();
            LoadBatches();
            LoadGrid();

            if (cboDefectCode.Items.Count > 0) cboDefectCode.SelectedIndex = 0;
            if (cboSeverity.Items.Count > 0) cboSeverity.SelectedIndex = 0;
            if (cboZone.Items.Count > 0) cboZone.SelectedIndex = 0;
        }

        private void SetupGrid()
        {
            dgvDefects.Columns.Clear();

            dgvDefects.Columns.Add("DefectID", "Defect ID");
            dgvDefects.Columns.Add("BatchCode", "Batch");
            dgvDefects.Columns.Add("InspectionDate", "Inspection Date");
            dgvDefects.Columns.Add("UnitNumber", "Unit #");
            dgvDefects.Columns.Add("DefectCode", "Defect Code");
            dgvDefects.Columns.Add("SeverityCode", "Severity");
            dgvDefects.Columns.Add("ZoneCode", "Zone");
            dgvDefects.Columns.Add("Comments", "Comments");

            dgvDefects.Columns["DefectID"].Visible = false;
        }

        private void LoadBatches()
        {
            cboBatch.Items.Clear();

            try
            {
                foreach (var batch in QualityRepository.GetBatches())
                {
                    cboBatch.Items.Add(batch);
                }

                if (cboBatch.Items.Count > 0)
                    cboBatch.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading batches:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGrid()
        {
            dgvDefects.Rows.Clear();

            try
            {
                foreach (var d in QualityRepository.GetAllDefects())
                {
                    dgvDefects.Rows.Add(
                        d.DefectID,
                        d.BatchCode,
                        d.InspectionDate.ToString("MM/dd/yyyy"),
                        d.UnitNumber,
                        d.DefectCode,
                        d.SeverityCode,
                        d.ZoneCode,
                        d.Comments
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quality defects:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveInsp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inspection header selected. Add a defect row to save inspection details.");
        }

        private void btnAddDefect_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                BatchItem selectedBatch = (BatchItem)cboBatch.SelectedItem;

                QualityDefect defect = new QualityDefect
                {
                    BatchID = selectedBatch.BatchID,
                    InspectionDate = dtpInspDate.Value.Date,
                    UnitNumber = int.Parse(txtUnit.Text),
                    DefectCode = cboDefectCode.Text.Split(' ')[0],
                    SeverityCode = cboSeverity.Text.Split(' ')[0],
                    ZoneCode = cboZone.Text.Split(' ')[0],
                    Comments = txtComments.Text.Trim()
                };

                QualityRepository.InsertDefect(defect);

                ClearDefectFields();
                LoadGrid();

                MessageBox.Show("Defect added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding defect:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDefects.CurrentRow == null)
            {
                MessageBox.Show("Please select a defect to remove.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Remove the selected defect?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int defectID = Convert.ToInt32(dgvDefects.CurrentRow.Cells["DefectID"].Value);

                QualityRepository.DeleteDefect(defectID);

                LoadGrid();

                MessageBox.Show("Defect removed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing defect:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (cboBatch.SelectedItem is not BatchItem)
            {
                MessageBox.Show("Please select a batch.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtUnit.Text, out int unitNumber) || unitNumber <= 0)
            {
                MessageBox.Show("Unit number must be a positive whole number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboDefectCode.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a defect code.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboSeverity.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a severity.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearDefectFields()
        {
            txtUnit.Clear();

            if (cboDefectCode.Items.Count > 0)
                cboDefectCode.SelectedIndex = 0;

            if (cboSeverity.Items.Count > 0)
                cboSeverity.SelectedIndex = 0;

            if (cboZone.Items.Count > 0)
                cboZone.SelectedIndex = 0;

            txtComments.Clear();
        }

        public void ClearForm()
        {
            if (cboBatch.Items.Count > 0)
                cboBatch.SelectedIndex = 0;

            dtpInspDate.Value = DateTime.Today;

            ClearDefectFields();
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClearRow_Click(object sender, EventArgs e)
        {
            ClearDefectFields();
        }
    }
}