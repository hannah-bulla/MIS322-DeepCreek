using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeepCreekLLC
{
    public partial class MainMenu : Form
    {
        private readonly Dictionary<int, Control> _tabControls = new Dictionary<int, Control>();

        public MainMenu()
        {
            InitializeComponent();

            // Create tab pages for each screen
            tabControlMain.TabPages.Clear();
            tabControlMain.TabPages.Add(new TabPage("Inventory"));
            tabControlMain.TabPages.Add(new TabPage("Quality"));
            tabControlMain.TabPages.Add(new TabPage("Production"));
            tabControlMain.TabPages.Add(new TabPage("Returns"));

            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;

            // Optionally load first tab
            LoadControlIntoTab(0);
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadControlIntoTab(tabControlMain.SelectedIndex);
        }

        private void LoadControlIntoTab(int index)
        {
            var tp = tabControlMain.TabPages[index];
            if (tp.Controls.Count > 0) return;

            Control ctrl = index switch
            {
                0 => new InventoryControl(),
                1 => new QualityControl(),
                2 => new ProductionControl(),
                3 => new ReturnsControl(),
                _ => null
            };

            if (ctrl == null) return;

            ctrl.Dock = DockStyle.Fill;
            tp.Controls.Add(ctrl);
            _tabControls[index] = ctrl;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (var c in _tabControls.Values) c?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
