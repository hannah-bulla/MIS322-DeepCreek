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
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            dgvBatches.Rows.Add("190416-2.1", "04/16/19", "1", "2", "BR0906E", 100, 25, 20, 5, "20.0%");
            dgvBatches.Rows.Add("190415-1.1", "04/15/19", "1", "1", "PR0906M", 100, 98, 71, 27, "27.6%");
            dgvBatches.Rows.Add("190414-2.2", "04/14/19", "2", "2", "GD0806F", 100, 100, 82, 18, "18.0%");
            dgvBatches.Rows.Add("190413-1.2", "04/13/19", "2", "1", "BR0906E", 100, 95, 68, 27, "28.4%");
        }

        private void ClearForm()
        {
            txtBatchCode.Clear();
            dtpBatchDate.Value = DateTime.Today;
            cboLine.SelectedIndex = 0;
            cboShift.SelectedIndex = 0;
            cboRodModel.SelectedIndex = 0;
            txtPlanned.Clear();
            txtActual.Clear();
            txtGood.Clear();
            txtDefect.Clear();
        }

        // Named event handler referenced from the designer
        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
