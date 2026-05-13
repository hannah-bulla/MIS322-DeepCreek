namespace DeepCreekLLC
{
    partial class Production
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpBatch = new GroupBox();
            lblBatchCode = new Label();
            txtBatchCode = new TextBox();
            lblBatchDate = new Label();
            dtpBatchDate = new DateTimePicker();
            lblLine = new Label();
            cboLine = new ComboBox();
            lblShift = new Label();
            cboShift = new ComboBox();
            lblRodModel = new Label();
            cboRodModel = new ComboBox();
            lblPlanned = new Label();
            txtPlanned = new TextBox();
            lblActual = new Label();
            txtActual = new TextBox();
            lblGood = new Label();
            txtGood = new TextBox();
            lblDefect = new Label();
            txtDefect = new TextBox();
            btnSaveBatch = new Button();
            btnClear = new Button();
            lblGridTitle = new Label();
            dgvBatches = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExport = new Button();

            grpBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            SuspendLayout();

            // grpBatch
            grpBatch.Text = "Batch Entry";
            grpBatch.Location = new Point(8, 8);
            grpBatch.Size = new Size(960, 110);
            grpBatch.Controls.AddRange(new Control[] {
                lblBatchCode, txtBatchCode, lblBatchDate, dtpBatchDate,
                lblLine, cboLine, lblShift, cboShift, lblRodModel, cboRodModel,
                lblPlanned, txtPlanned, lblActual, txtActual,
                lblGood, txtGood, lblDefect, txtDefect,
                btnSaveBatch, btnClear
            });

            int y1 = 20, y2 = 60;

            lblBatchCode.Text = "Batch Code *"; lblBatchCode.Location = new Point(8, y1); lblBatchCode.AutoSize = true;
            txtBatchCode.Location = new Point(8, y2); txtBatchCode.Size = new Size(110, 23);

            lblBatchDate.Text = "Batch Date *"; lblBatchDate.Location = new Point(128, y1); lblBatchDate.AutoSize = true;
            dtpBatchDate.Location = new Point(128, y2); dtpBatchDate.Size = new Size(120, 23); dtpBatchDate.Format = DateTimePickerFormat.Short;

            lblLine.Text = "Production Line *"; lblLine.Location = new Point(258, y1); lblLine.AutoSize = true;
            cboLine.Location = new Point(258, y2); cboLine.Size = new Size(90, 23); cboLine.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLine.Items.AddRange(new object[] { "Line 1", "Line 2" }); cboLine.SelectedIndex = 0;

            lblShift.Text = "Shift *"; lblShift.Location = new Point(358, y1); lblShift.AutoSize = true;
            cboShift.Location = new Point(358, y2); cboShift.Size = new Size(60, 23); cboShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShift.Items.AddRange(new object[] { "1", "2" }); cboShift.SelectedIndex = 0;

            lblRodModel.Text = "Rod Model *"; lblRodModel.Location = new Point(428, y1); lblRodModel.AutoSize = true;
            cboRodModel.Location = new Point(428, y2); cboRodModel.Size = new Size(250, 23); cboRodModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRodModel.Items.AddRange(new object[] { "BR0906E — Better 9'6\" Extra Fast", "PR0906M — Primo 9'6\" Moderate", "GD0806F — Good 8'6\" Fast" });
            cboRodModel.SelectedIndex = 0;

            lblPlanned.Text = "Planned Qty"; lblPlanned.Location = new Point(688, y1); lblPlanned.AutoSize = true;
            txtPlanned.Location = new Point(688, y2); txtPlanned.Size = new Size(60, 23);

            lblActual.Text = "Actual Qty"; lblActual.Location = new Point(758, y1); lblActual.AutoSize = true;
            txtActual.Location = new Point(758, y2); txtActual.Size = new Size(60, 23);

            lblGood.Text = "Good Units"; lblGood.Location = new Point(828, y1); lblGood.AutoSize = true;
            txtGood.Location = new Point(828, y2); txtGood.Size = new Size(55, 23);

            lblDefect.Text = "Defect Units"; lblDefect.Location = new Point(893, y1); lblDefect.AutoSize = true;
            txtDefect.Location = new Point(893, y2); txtDefect.Size = new Size(55, 23);

            btnSaveBatch.Text = "Save Batch"; btnSaveBatch.Location = new Point(8, 85); btnSaveBatch.Size = new Size(85, 23);
            btnClear.Text = "Clear"; btnClear.Location = new Point(99, 85); btnClear.Size = new Size(60, 23);
            btnClear.Click += new EventHandler(this.btnClear_Click);

            // Grid title
            lblGridTitle.Text = "Production Batch Grid";
            lblGridTitle.Location = new Point(8, 124);
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font(Font, FontStyle.Bold);

            // dgvBatches
            dgvBatches.Location = new Point(8, 144);
            dgvBatches.Size = new Size(960, 200);
            dgvBatches.ReadOnly = true;
            dgvBatches.AllowUserToAddRows = false;
            dgvBatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Columns.Add("BatchCode", "Batch Code");
            dgvBatches.Columns.Add("Date", "Date");
            dgvBatches.Columns.Add("Line", "Line");
            dgvBatches.Columns.Add("Shift", "Shift");
            dgvBatches.Columns.Add("Model", "Model");
            dgvBatches.Columns.Add("Planned", "Planned");
            dgvBatches.Columns.Add("Actual", "Actual");
            dgvBatches.Columns.Add("Good", "Good");
            dgvBatches.Columns.Add("Defects", "Defects");
            dgvBatches.Columns.Add("DefectPercent", "Defect %");

            btnEdit.Text = "Edit Selected"; btnEdit.Location = new Point(8, 352); btnEdit.Size = new Size(90, 23);
            btnDelete.Text = "Delete Selected"; btnDelete.Location = new Point(104, 352); btnDelete.Size = new Size(100, 23);
            btnExport.Text = "Export Grid"; btnExport.Location = new Point(210, 352); btnExport.Size = new Size(85, 23);

            // Form
            ClientSize = new Size(980, 390);
            Text = "Production";
            Controls.AddRange(new Control[] { grpBatch, lblGridTitle, dgvBatches, btnEdit, btnDelete, btnExport });

            grpBatch.ResumeLayout(false);
            grpBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            ResumeLayout(false);
        }

        private GroupBox grpBatch;
        private Label lblBatchCode, lblBatchDate, lblLine, lblShift, lblRodModel;
        private Label lblPlanned, lblActual, lblGood, lblDefect, lblGridTitle;
        private TextBox txtBatchCode, txtPlanned, txtActual, txtGood, txtDefect;
        private DateTimePicker dtpBatchDate;
        private ComboBox cboLine, cboShift, cboRodModel;
        private Button btnSaveBatch, btnClear, btnEdit, btnDelete, btnExport;
        private DataGridView dgvBatches;
    }
}
