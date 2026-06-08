namespace DeepCreekLLC
{
    partial class QualityControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpHeader = new GroupBox();
            lblBatch = new Label();
            cboBatch = new ComboBox();
            lblInspDate = new Label();
            dtpInspDate = new DateTimePicker();
            btnSaveInsp = new Button();
            btnClearHeader = new Button();
            grpDefect = new GroupBox();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblDefectCode = new Label();
            cboDefectCode = new ComboBox();
            lblSeverity = new Label();
            cboSeverity = new ComboBox();
            lblZone = new Label();
            cboZone = new ComboBox();
            lblComments = new Label();
            txtComments = new TextBox();
            btnAddDefect = new Button();
            btnClearRow = new Button();
            lblGridTitle = new Label();
            dgvDefects = new DataGridView();
            btnEdit = new Button();
            btnRemove = new Button();
            grpHeader.SuspendLayout();
            grpDefect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDefects).BeginInit();
            SuspendLayout();
            // 
            // grpHeader
            // 
            grpHeader.Controls.Add(lblBatch);
            grpHeader.Controls.Add(cboBatch);
            grpHeader.Controls.Add(lblInspDate);
            grpHeader.Controls.Add(dtpInspDate);
            grpHeader.Controls.Add(btnSaveInsp);
            grpHeader.Controls.Add(btnClearHeader);
            grpHeader.Location = new Point(8, 8);
            grpHeader.Name = "grpHeader";
            grpHeader.Size = new Size(460, 90);
            grpHeader.TabIndex = 0;
            grpHeader.TabStop = false;
            grpHeader.Text = "QA Inspection Header";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Location = new Point(8, 22);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(45, 15);
            lblBatch.TabIndex = 0;
            lblBatch.Text = "Batch *";
            // 
            // cboBatch
            // 
            cboBatch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBatch.Items.AddRange(new object[] { "190416-2.1 — BR0906E", "190415-1.1 — PR0906M" });
            cboBatch.Location = new Point(8, 42);
            cboBatch.Name = "cboBatch";
            cboBatch.Size = new Size(220, 23);
            cboBatch.TabIndex = 1;
            // 
            // lblInspDate
            // 
            lblInspDate.AutoSize = true;
            lblInspDate.Location = new Point(238, 22);
            lblInspDate.Name = "lblInspDate";
            lblInspDate.Size = new Size(97, 15);
            lblInspDate.TabIndex = 2;
            lblInspDate.Text = "Inspection Date *";
            // 
            // dtpInspDate
            // 
            dtpInspDate.Format = DateTimePickerFormat.Short;
            dtpInspDate.Location = new Point(238, 42);
            dtpInspDate.Name = "dtpInspDate";
            dtpInspDate.Size = new Size(130, 23);
            dtpInspDate.TabIndex = 3;
            // 
            // btnSaveInsp
            // 
            btnSaveInsp.Location = new Point(8, 65);
            btnSaveInsp.Name = "btnSaveInsp";
            btnSaveInsp.Size = new Size(110, 23);
            btnSaveInsp.TabIndex = 4;
            btnSaveInsp.Text = "Save Inspection";
            btnSaveInsp.Click += btnSaveInsp_Click;
            // 
            // btnClearHeader
            // 
            btnClearHeader.Location = new Point(124, 65);
            btnClearHeader.Name = "btnClearHeader";
            btnClearHeader.Size = new Size(60, 23);
            btnClearHeader.TabIndex = 5;
            btnClearHeader.Text = "Clear";
            btnClearHeader.Click += btnClear_Click;
            // 
            // grpDefect
            // 
            grpDefect.Controls.Add(lblUnit);
            grpDefect.Controls.Add(txtUnit);
            grpDefect.Controls.Add(lblDefectCode);
            grpDefect.Controls.Add(cboDefectCode);
            grpDefect.Controls.Add(lblSeverity);
            grpDefect.Controls.Add(cboSeverity);
            grpDefect.Controls.Add(lblZone);
            grpDefect.Controls.Add(cboZone);
            grpDefect.Controls.Add(lblComments);
            grpDefect.Controls.Add(txtComments);
            grpDefect.Controls.Add(btnAddDefect);
            grpDefect.Controls.Add(btnClearRow);
            grpDefect.Location = new Point(8, 104);
            grpDefect.Name = "grpDefect";
            grpDefect.Size = new Size(460, 160);
            grpDefect.TabIndex = 1;
            grpDefect.TabStop = false;
            grpDefect.Text = "Defect Detail Entry";
            btnAddDefect.Click += btnAddDefect_Click;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(8, 22);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(47, 15);
            lblUnit.TabIndex = 0;
            lblUnit.Text = "Unit # *";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(8, 42);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(55, 23);
            txtUnit.TabIndex = 1;
            // 
            // lblDefectCode
            // 
            lblDefectCode.AutoSize = true;
            lblDefectCode.Location = new Point(73, 22);
            lblDefectCode.Name = "lblDefectCode";
            lblDefectCode.Size = new Size(80, 15);
            lblDefectCode.TabIndex = 2;
            lblDefectCode.Text = "Defect Code *";
            // 
            // cboDefectCode
            // 
            cboDefectCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDefectCode.Items.AddRange(new object[] { "B1 — Wrong Length", "B2 — Bad Paint", "B3 — Scratched/Chipped Blank", "B4 — Epoxy overage", "P1 — Out of Spec for Action", "G5 — Guide not aligned", "R3 — Chipped/Scratched Reel" });
            cboDefectCode.Location = new Point(73, 42);
            cboDefectCode.Name = "cboDefectCode";
            cboDefectCode.Size = new Size(220, 23);
            cboDefectCode.TabIndex = 3;
            // 
            // lblSeverity
            // 
            lblSeverity.AutoSize = true;
            lblSeverity.Location = new Point(303, 22);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(56, 15);
            lblSeverity.TabIndex = 4;
            lblSeverity.Text = "Severity *";
            // 
            // cboSeverity
            // 
            cboSeverity.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeverity.Items.AddRange(new object[] { "L — Minor", "M — Moderate", "H — Severe", "S — Special" });
            cboSeverity.Location = new Point(303, 42);
            cboSeverity.Name = "cboSeverity";
            cboSeverity.Size = new Size(110, 23);
            cboSeverity.TabIndex = 5;
            // 
            // lblZone
            // 
            lblZone.AutoSize = true;
            lblZone.Location = new Point(8, 74);
            lblZone.Name = "lblZone";
            lblZone.Size = new Size(34, 15);
            lblZone.TabIndex = 6;
            lblZone.Text = "Zone";
            // 
            // cboZone
            // 
            cboZone.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZone.Items.AddRange(new object[] { "T — Top", "M — Middle", "B — Bottom", "T,M", "T,M,B" });
            cboZone.Location = new Point(8, 94);
            cboZone.Name = "cboZone";
            cboZone.Size = new Size(90, 23);
            cboZone.TabIndex = 7;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Location = new Point(108, 74);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(66, 15);
            lblComments.TabIndex = 8;
            lblComments.Text = "Comments";
            // 
            // txtComments
            // 
            txtComments.Location = new Point(108, 94);
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(305, 23);
            txtComments.TabIndex = 9;
            // 
            // btnAddDefect
            // 
            btnAddDefect.Location = new Point(8, 130);
            btnAddDefect.Name = "btnAddDefect";
            btnAddDefect.Size = new Size(85, 23);
            btnAddDefect.TabIndex = 10;
            btnAddDefect.Text = "Add Defect";
            // 
            // btnClearRow
            // 
            btnClearRow.Location = new Point(99, 130);
            btnClearRow.Name = "btnClearRow";
            btnClearRow.Size = new Size(75, 23);
            btnClearRow.TabIndex = 11;
            btnClearRow.Text = "Clear Row";
            btnClearRow.Click += btnClearRow_Click;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGridTitle.Location = new Point(476, 8);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(128, 15);
            lblGridTitle.TabIndex = 2;
            lblGridTitle.Text = "Inspection Detail Grid";
            // 
            // dgvDefects
            // 
            dgvDefects.AllowUserToAddRows = false;
            dgvDefects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDefects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDefects.Location = new Point(476, 28);
            dgvDefects.Name = "dgvDefects";
            dgvDefects.ReadOnly = true;
            dgvDefects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDefects.Size = new Size(490, 280);
            dgvDefects.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(476, 315);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Selected";
            btnEdit.Enabled = false;
            btnEdit.Text = "Edit Later";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(572, 315);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove Defect";
            btnRemove.Click += btnRemove_Click;
            // 
            // QualityControl
            // 
            ClientSize = new Size(980, 350);
            Controls.Add(grpHeader);
            Controls.Add(grpDefect);
            Controls.Add(lblGridTitle);
            Controls.Add(dgvDefects);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Name = "QualityControl";
            Text = "Quality";
            grpHeader.ResumeLayout(false);
            grpHeader.PerformLayout();
            grpDefect.ResumeLayout(false);
            grpDefect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDefects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox grpHeader, grpDefect;
        private Label lblBatch, lblInspDate, lblUnit, lblDefectCode, lblSeverity, lblZone, lblComments, lblGridTitle;
        private ComboBox cboBatch, cboDefectCode, cboSeverity, cboZone;
        private TextBox txtUnit, txtComments;
        private DateTimePicker dtpInspDate;
        private DataGridView dgvDefects;
        private Button btnSaveInsp, btnClearHeader, btnAddDefect, btnClearRow, btnEdit, btnRemove;
    }
}