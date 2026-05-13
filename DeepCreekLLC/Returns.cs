using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace DeepCreekLLC
{
    public partial class CustomerReturns : Form
    {
        public CustomerReturns()
        {
            InitializeComponent();
            // If used as a form keep existing behavior; when hosted as a control the ReturnsControl will handle events
            LoadSampleData();
        }

        // Expose same handlers so ReturnsControl can call into this logic if desired
        public void BtnSave_Click(object? sender, EventArgs e) => BtnSave_ClickInternal();
        public void BtnClear_Click(object? sender, EventArgs e) => ClearForm();
        public void BtnDelete_Click(object? sender, EventArgs e)
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

        private void BtnSave_ClickInternal()
        {
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

        // ── Sample data ──────────────────────────────────────────────────
        private void LoadSampleData()
        {
            dgvReturns.Rows.Add("501", "RA-2019-00412", "John Chambers", "PR0906M", "190415-1.1", "04/18/19", "Guide loose after first use", "Replacement");
            dgvReturns.Rows.Add("500", "RA-2019-00408", "Linda Torres", "PR0906M", "190413-1.2", "04/17/19", "Rod tip broke on first cast", "Replacement");
            dgvReturns.Rows.Add("499", "RA-2019-00401", "Dave Kim", "BR0906E", "190414-2.2", "04/16/19", "Paint chipping at handle area", "Repair");
            dgvReturns.Rows.Add("498", "RA-2019-00395", "Susan Hart", "PR0906M", "190415-1.1", "04/15/19", "Wrong action — ordered moderate, got fast", "Replacement");
            dgvReturns.Rows.Add("497", "RA-2019-00388", "Ray Patel", "GD0806F", "190414-2.2", "04/14/19", "Reel seat does not hold reel", "Refund");
        }

        // ── Button handlers ──────────────────────────────────────────────
        /*private void BtnSave_Click(object sender, EventArgs e)
        {
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
        }*/

        /*private void BtnClear_Click(object sender, EventArgs e) => ClearForm();

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReturns.CurrentRow == null) return;

            var result = MessageBox.Show(
                "Delete the selected return record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                dgvReturns.Rows.Remove(dgvReturns.CurrentRow);
        }*/

        // ── Helpers ──────────────────────────────────────────────────────
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtAuthCode.Text) ||
                string.IsNullOrWhiteSpace(txtCustomer.Text))
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
    }
}
