namespace DeepCreekLLC
{
    public partial class ReturnsControl : UserControl
    {
        public ReturnsControl()
        {
            InitializeComponent();

            // Ensure columns exist
            if (dgvReturns != null && dgvReturns.Columns.Count == 0)
            {
                dgvReturns.Columns.Add("ReturnID", "Return ID");
                dgvReturns.Columns.Add("AuthCode", "Auth Code");
                dgvReturns.Columns.Add("Customer", "Customer");
                dgvReturns.Columns.Add("Model", "Model");
                dgvReturns.Columns.Add("Batch", "Batch");
                dgvReturns.Columns.Add("DateReceived", "Date Received");
                dgvReturns.Columns.Add("Reason", "Reason");
                dgvReturns.Columns.Add("Resolution", "Resolution");
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Local save logic (mirrors CustomerReturns.BtnSave_ClickInternal)
            if (!ValidateForm()) return;

            dgvReturns.Rows.Insert(0,
                (dgvReturns.Rows.Count + 501).ToString(),
                txtAuthCode.Text,
                txtCustomer.Text,
                cboRodModel.Text.Split(' ')[0],
                txtBatchCode.Text,
                dtpDateRcvd.Value.ToString("MM/dd/yy"),
                txtReason.Text,
                cboResolution.Text);

            ClearForm();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtAuthCode.Text) || string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                MessageBox.Show("Return Auth Code and Customer Name are required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            txtAuthCode.Clear();
            txtCustomer.Clear();
            dtpDateRcvd.Value = DateTime.Today;
            cboRodModel.SelectedIndex = 0;
            txtBatchCode.Clear();
            cboResolution.SelectedIndex = 0;
            txtReason.Clear();
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtAuthCode.Clear();
            txtCustomer.Clear();
            dtpDateRcvd.Value = DateTime.Today;
            cboRodModel.SelectedIndex = 0;
            txtBatchCode.Clear();
            cboResolution.SelectedIndex = 0;
            txtReason.Clear();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvReturns.CurrentRow == null) return;
            var result = MessageBox.Show(
                "Delete the selected return record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                dgvReturns.Rows.Remove(dgvReturns.CurrentRow);
        }
    }
}

