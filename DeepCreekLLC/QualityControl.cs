using System.Windows.Forms;
using System;

namespace DeepCreekLLC
{
    public partial class QualityControl : UserControl
    {
        public QualityControl()
        {
            InitializeComponent();
        }

        // Ported helpers and handlers from original Quality form
        public void ClearForm()
        {
            if (cboBatch != null && cboBatch.Items.Count > 0) cboBatch.SelectedIndex = 0;
            if (dtpInspDate != null) dtpInspDate.Value = DateTime.Today;
            txtUnit?.Clear();
            if (cboDefectCode != null && cboDefectCode.Items.Count > 0) cboDefectCode.SelectedIndex = 0;
            if (cboSeverity != null && cboSeverity.Items.Count > 0) cboSeverity.SelectedIndex = 0;
            if (cboZone != null && cboZone.Items.Count > 0) cboZone.SelectedIndex = 0;
            txtComments?.Clear();
        }

        public void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void btnClearRow_Click(object sender, EventArgs e) => ClearForm();

        // A simple helper property for identification or testing purposes.
        public string ControlName => "QualityControl";
    }
}
