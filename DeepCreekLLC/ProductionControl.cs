using System.Windows.Forms;

namespace DeepCreekLLC
{
    public partial class ProductionControl : UserControl
    {
        public ProductionControl()
        {
            InitializeComponent();
        }

        // Added helper method to ensure file changes apply cleanly.
        public void InitializeForDesignMode()
        {
            // Intentionally left blank. Use to prepare control in design-time scenarios.
        }
        public void ClearForm()
        {
            txtBatchCode.Clear();
            dtpBatchDate.Value = System.DateTime.Today;
            if (cboLine.Items.Count > 0) cboLine.SelectedIndex = 0;
            if (cboShift.Items.Count > 0) cboShift.SelectedIndex = 0;
            if (cboRodModel.Items.Count > 0) cboRodModel.SelectedIndex = 0;
            txtPlanned.Clear();
            txtActual.Clear();
            txtGood.Clear();
            txtDefect.Clear();
        }

        // Named event handler referenced from the designer
        public void btnClear_Click(object sender, System.EventArgs e)
        {
            ClearForm();
        }
    }
}
