using System;
using System.Windows.Forms;

namespace DeepCreekLLC
{
    public partial class Quality : Form
    {
        public Quality()
        {
            InitializeComponent();

            // Initialize defect grid columns at runtime so designer can parse the generated code
            if (dgvDefects != null && dgvDefects.Columns.Count == 0)
            {
                dgvDefects.Columns.Add("UnitNum", "Unit #");
                dgvDefects.Columns.Add("Defect", "Defect");
                dgvDefects.Columns.Add("Severity", "Severity");
                dgvDefects.Columns.Add("Zone", "Zone");
                dgvDefects.Columns.Add("Comments", "Comments");
            }

                LoadSampleData();
            }

        private void LoadSampleData()
        {
            dgvDefects.Rows.Add("1", "B3", "L", "B", "Slight scratches near bottom");
            dgvDefects.Rows.Add("2", "B3", "L", "M", "");
            dgvDefects.Rows.Add("2", "G5", "M", "B", "1st Guide out of alignment");
            dgvDefects.Rows.Add("3", "B3", "H", "M", "Gash across middle, graphite cut through");
            dgvDefects.Rows.Add("4", "P1", "S", "—", "Wrong spec, fits MH — move to correct FG");
            dgvDefects.Rows.Add("5", "B2", "M", "T,M,B", "Paint blotches, needs sanding");
            dgvDefects.Rows.Add("5", "R3", "L", "—", "Buffed out scratch");
        }

        public void ClearForm()
        {
            cboBatch.SelectedIndex = 0;
            dtpInspDate.Value = DateTime.Today;
            txtUnit.Clear();
            cboDefectCode.SelectedIndex = 0;
            cboSeverity.SelectedIndex = 0;
            cboZone.SelectedIndex = 0;
            txtComments.Clear();
        }

        // Named event handler referenced from the designer
        public void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClearRow_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

