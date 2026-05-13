namespace DeepCreekLLC
{
    partial class ReturnsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpEntry = new GroupBox();
            lblAuthCode = new Label();
            txtAuthCode = new TextBox();
            lblCustomer = new Label();
            txtCustomer = new TextBox();
            lblDateRcvd = new Label();
            dtpDateRcvd = new DateTimePicker();
            lblRodModel = new Label();
            cboRodModel = new ComboBox();
            lblBatchCode = new Label();
            txtBatchCode = new TextBox();
            lblResolution = new Label();
            cboResolution = new ComboBox();
            lblReason = new Label();
            txtReason = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            lblGridTitle = new Label();
            dgvReturns = new DataGridView();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExport = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            grpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturns).BeginInit();
            SuspendLayout();
            // 
            // grpEntry
            // 
            grpEntry.Controls.Add(lblAuthCode);
            grpEntry.Controls.Add(txtAuthCode);
            grpEntry.Controls.Add(lblCustomer);
            grpEntry.Controls.Add(txtCustomer);
            grpEntry.Controls.Add(lblDateRcvd);
            grpEntry.Controls.Add(dtpDateRcvd);
            grpEntry.Controls.Add(lblRodModel);
            grpEntry.Controls.Add(cboRodModel);
            grpEntry.Controls.Add(lblBatchCode);
            grpEntry.Controls.Add(txtBatchCode);
            grpEntry.Controls.Add(lblResolution);
            grpEntry.Controls.Add(cboResolution);
            grpEntry.Controls.Add(lblReason);
            grpEntry.Controls.Add(txtReason);
            grpEntry.Controls.Add(btnSave);
            grpEntry.Controls.Add(btnClear);
            grpEntry.Location = new Point(8, 8);
            grpEntry.Name = "grpEntry";
            grpEntry.Size = new Size(964, 218);
            grpEntry.TabIndex = 0;
            grpEntry.TabStop = false;
            grpEntry.Text = "Customer Return Entry";
            // 
            // lblAuthCode
            // 
            lblAuthCode.AutoSize = true;
            lblAuthCode.Location = new Point(8, 22);
            lblAuthCode.Name = "lblAuthCode";
            lblAuthCode.Size = new Size(110, 15);
            lblAuthCode.TabIndex = 0;
            lblAuthCode.Text = "Return Auth Code *";
            // 
            // txtAuthCode
            // 
            txtAuthCode.Location = new Point(8, 44);
            txtAuthCode.Name = "txtAuthCode";
            txtAuthCode.Size = new Size(180, 23);
            txtAuthCode.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(200, 22);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(102, 15);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Customer Name *";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(200, 44);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(200, 23);
            txtCustomer.TabIndex = 3;
            // 
            // lblDateRcvd
            // 
            lblDateRcvd.AutoSize = true;
            lblDateRcvd.Location = new Point(412, 22);
            lblDateRcvd.Name = "lblDateRcvd";
            lblDateRcvd.Size = new Size(89, 15);
            lblDateRcvd.TabIndex = 4;
            lblDateRcvd.Text = "Date Received *";
            // 
            // dtpDateRcvd
            // 
            dtpDateRcvd.Format = DateTimePickerFormat.Short;
            dtpDateRcvd.Location = new Point(412, 44);
            dtpDateRcvd.Name = "dtpDateRcvd";
            dtpDateRcvd.Size = new Size(140, 23);
            dtpDateRcvd.TabIndex = 5;
            // 
            // lblRodModel
            // 
            lblRodModel.AutoSize = true;
            lblRodModel.Location = new Point(8, 78);
            lblRodModel.Name = "lblRodModel";
            lblRodModel.Size = new Size(73, 15);
            lblRodModel.TabIndex = 6;
            lblRodModel.Text = "Rod Model *";
            // 
            // cboRodModel
            // 
            cboRodModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRodModel.Items.AddRange(new object[] { "PR0906M — Primo 9'6\" Moderate", "BR0906E — Better 9'6\" Extra Fast", "GD0806F — Good 8'6\" Fast" });
            cboRodModel.Location = new Point(8, 100);
            cboRodModel.Name = "cboRodModel";
            cboRodModel.Size = new Size(280, 23);
            cboRodModel.TabIndex = 7;
            // 
            // lblBatchCode
            // 
            lblBatchCode.AutoSize = true;
            lblBatchCode.Location = new Point(300, 78);
            lblBatchCode.Name = "lblBatchCode";
            lblBatchCode.Size = new Size(126, 15);
            lblBatchCode.TabIndex = 8;
            lblBatchCode.Text = "Batch Code (from rod)";
            // 
            // txtBatchCode
            // 
            txtBatchCode.Location = new Point(300, 100);
            txtBatchCode.Name = "txtBatchCode";
            txtBatchCode.Size = new Size(130, 23);
            txtBatchCode.TabIndex = 9;
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = true;
            lblResolution.Location = new Point(442, 78);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(71, 15);
            lblResolution.TabIndex = 10;
            lblResolution.Text = "Resolution *";
            // 
            // cboResolution
            // 
            cboResolution.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResolution.Items.AddRange(new object[] { "Replacement", "Repair", "Refund" });
            cboResolution.Location = new Point(442, 100);
            cboResolution.Name = "cboResolution";
            cboResolution.Size = new Size(130, 23);
            cboResolution.TabIndex = 11;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Location = new Point(8, 134);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(83, 15);
            lblReason.TabIndex = 12;
            lblReason.Text = "Return Reason";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(8, 156);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(944, 23);
            txtReason.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(8, 185);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save Return";
            btnSave.Click += BtnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(104, 185);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear Form";
            btnClear.Click += BtnClear_Click;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGridTitle.Location = new Point(8, 237);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(135, 15);
            lblGridTitle.TabIndex = 1;
            lblGridTitle.Text = "Customer Returns Grid";
            // 
            // dgvReturns
            // 
            dgvReturns.AllowUserToAddRows = false;
            dgvReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturns.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvReturns.Location = new Point(8, 257);
            dgvReturns.Name = "dgvReturns";
            dgvReturns.ReadOnly = true;
            dgvReturns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturns.Size = new Size(964, 200);
            dgvReturns.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(8, 471);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Selected";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(104, 471);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Selected";
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(215, 471);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(85, 23);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export Grid";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Return ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Auth Code";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Customer";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Model";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Batch";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Date Received";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Reason";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Resolution";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ReturnsControl
            // 
            ClientSize = new Size(984, 506);
            Controls.Add(grpEntry);
            Controls.Add(lblGridTitle);
            Controls.Add(dgvReturns);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExport);
            Name = "ReturnsControl";
            Text = "Customer Returns";
            grpEntry.ResumeLayout(false);
            grpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox grpEntry;
        private Label lblAuthCode, lblCustomer, lblDateRcvd;
        private Label lblRodModel, lblBatchCode, lblResolution;
        private Label lblReason, lblGridTitle;
        private TextBox txtAuthCode, txtCustomer, txtBatchCode, txtReason;
        private DateTimePicker dtpDateRcvd;
        private ComboBox cboRodModel, cboResolution;
        private Button btnSave, btnClear, btnEdit, btnDelete, btnExport;
        private DataGridView dgvReturns;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
