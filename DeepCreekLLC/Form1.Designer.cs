namespace DeepCreekLLC
{
    partial class Edit_Production
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            grpBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            SuspendLayout();
            // 
            // grpBatch
            // 
            grpBatch.Controls.Add(lblBatchCode);
            grpBatch.Controls.Add(txtBatchCode);
            grpBatch.Controls.Add(lblBatchDate);
            grpBatch.Controls.Add(dtpBatchDate);
            grpBatch.Controls.Add(lblLine);
            grpBatch.Controls.Add(cboLine);
            grpBatch.Controls.Add(lblShift);
            grpBatch.Controls.Add(cboShift);
            grpBatch.Controls.Add(lblRodModel);
            grpBatch.Controls.Add(cboRodModel);
            grpBatch.Controls.Add(lblPlanned);
            grpBatch.Controls.Add(txtPlanned);
            grpBatch.Controls.Add(lblActual);
            grpBatch.Controls.Add(txtActual);
            grpBatch.Controls.Add(lblGood);
            grpBatch.Controls.Add(txtGood);
            grpBatch.Controls.Add(lblDefect);
            grpBatch.Controls.Add(txtDefect);
            grpBatch.Controls.Add(btnSaveBatch);
            grpBatch.Controls.Add(btnClear);
            grpBatch.Location = new Point(14, 4);
            grpBatch.Name = "grpBatch";
            grpBatch.Size = new Size(693, 36);
            grpBatch.TabIndex = 5;
            grpBatch.TabStop = false;
            grpBatch.Text = "Batch Entry";
            // 
            // lblBatchCode
            // 
            lblBatchCode.AutoSize = true;
            lblBatchCode.Location = new Point(8, 20);
            lblBatchCode.Name = "lblBatchCode";
            lblBatchCode.Size = new Size(76, 15);
            lblBatchCode.TabIndex = 0;
            lblBatchCode.Text = "Batch Code *";
            // 
            // txtBatchCode
            // 
            txtBatchCode.Location = new Point(8, 60);
            txtBatchCode.Name = "txtBatchCode";
            txtBatchCode.Size = new Size(110, 23);
            txtBatchCode.TabIndex = 1;
            // 
            // lblBatchDate
            // 
            lblBatchDate.AutoSize = true;
            lblBatchDate.Location = new Point(128, 20);
            lblBatchDate.Name = "lblBatchDate";
            lblBatchDate.Size = new Size(72, 15);
            lblBatchDate.TabIndex = 2;
            lblBatchDate.Text = "Batch Date *";
            // 
            // dtpBatchDate
            // 
            dtpBatchDate.Format = DateTimePickerFormat.Short;
            dtpBatchDate.Location = new Point(128, 60);
            dtpBatchDate.Name = "dtpBatchDate";
            dtpBatchDate.Size = new Size(120, 23);
            dtpBatchDate.TabIndex = 3;
            // 
            // lblLine
            // 
            lblLine.AutoSize = true;
            lblLine.Location = new Point(258, 20);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(99, 15);
            lblLine.TabIndex = 4;
            lblLine.Text = "Production Line *";
            // 
            // cboLine
            // 
            cboLine.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLine.Items.AddRange(new object[] { "Line 1", "Line 2" });
            cboLine.Location = new Point(258, 60);
            cboLine.Name = "cboLine";
            cboLine.Size = new Size(90, 23);
            cboLine.TabIndex = 5;
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Location = new Point(358, 20);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(39, 15);
            lblShift.TabIndex = 6;
            lblShift.Text = "Shift *";
            // 
            // cboShift
            // 
            cboShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cboShift.Items.AddRange(new object[] { "1", "2" });
            cboShift.Location = new Point(358, 60);
            cboShift.Name = "cboShift";
            cboShift.Size = new Size(60, 23);
            cboShift.TabIndex = 7;
            // 
            // lblRodModel
            // 
            lblRodModel.AutoSize = true;
            lblRodModel.Location = new Point(428, 20);
            lblRodModel.Name = "lblRodModel";
            lblRodModel.Size = new Size(73, 15);
            lblRodModel.TabIndex = 8;
            lblRodModel.Text = "Rod Model *";
            // 
            // cboRodModel
            // 
            cboRodModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRodModel.Items.AddRange(new object[] { "BR0906E — Better 9'6\" Extra Fast", "PR0906M — Primo 9'6\" Moderate", "GD0806F — Good 8'6\" Fast" });
            cboRodModel.Location = new Point(428, 60);
            cboRodModel.Name = "cboRodModel";
            cboRodModel.Size = new Size(250, 23);
            cboRodModel.TabIndex = 9;
            // 
            // lblPlanned
            // 
            lblPlanned.AutoSize = true;
            lblPlanned.Location = new Point(688, 20);
            lblPlanned.Name = "lblPlanned";
            lblPlanned.Size = new Size(72, 15);
            lblPlanned.TabIndex = 10;
            lblPlanned.Text = "Planned Qty";
            // 
            // txtPlanned
            // 
            txtPlanned.Location = new Point(688, 60);
            txtPlanned.Name = "txtPlanned";
            txtPlanned.Size = new Size(60, 23);
            txtPlanned.TabIndex = 11;
            // 
            // lblActual
            // 
            lblActual.AutoSize = true;
            lblActual.Location = new Point(758, 20);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(63, 15);
            lblActual.TabIndex = 12;
            lblActual.Text = "Actual Qty";
            // 
            // txtActual
            // 
            txtActual.Location = new Point(758, 60);
            txtActual.Name = "txtActual";
            txtActual.Size = new Size(60, 23);
            txtActual.TabIndex = 13;
            // 
            // lblGood
            // 
            lblGood.AutoSize = true;
            lblGood.Location = new Point(828, 20);
            lblGood.Name = "lblGood";
            lblGood.Size = new Size(66, 15);
            lblGood.TabIndex = 14;
            lblGood.Text = "Good Units";
            // 
            // txtGood
            // 
            txtGood.Location = new Point(828, 60);
            txtGood.Name = "txtGood";
            txtGood.Size = new Size(55, 23);
            txtGood.TabIndex = 15;
            // 
            // lblDefect
            // 
            lblDefect.AutoSize = true;
            lblDefect.Location = new Point(893, 20);
            lblDefect.Name = "lblDefect";
            lblDefect.Size = new Size(71, 15);
            lblDefect.TabIndex = 16;
            lblDefect.Text = "Defect Units";
            // 
            // txtDefect
            // 
            txtDefect.Location = new Point(893, 60);
            txtDefect.Name = "txtDefect";
            txtDefect.Size = new Size(55, 23);
            txtDefect.TabIndex = 17;
            // 
            // btnSaveBatch
            // 
            btnSaveBatch.Location = new Point(8, 85);
            btnSaveBatch.Name = "btnSaveBatch";
            btnSaveBatch.Size = new Size(85, 23);
            btnSaveBatch.TabIndex = 18;
            btnSaveBatch.Text = "Save Batch";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(99, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 23);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGridTitle.Location = new Point(12, 73);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(130, 15);
            lblGridTitle.TabIndex = 6;
            lblGridTitle.Text = "Production Batch Grid";
            // 
            // dgvBatches
            // 
            dgvBatches.AllowUserToAddRows = false;
            dgvBatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgvBatches.Location = new Point(12, 93);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.ReadOnly = true;
            dgvBatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatches.Size = new Size(693, 126);
            dgvBatches.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Batch Code";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Date";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Line";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Shift";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Model";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Planned";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Actual";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Good";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Defects";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Defect %";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(14, 348);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(10, 10);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit Selected";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(110, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(10, 10);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Selected";
            // 
            // Edit_Production
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 278);
            Controls.Add(grpBatch);
            Controls.Add(lblGridTitle);
            Controls.Add(dgvBatches);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "Edit_Production";
            Text = "Edit Production Batch";
            Load += Edit_Production_Load;
            grpBatch.ResumeLayout(false);
            grpBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBatch;
        private Label lblBatchCode;
        private TextBox txtBatchCode;
        private Label lblBatchDate;
        private DateTimePicker dtpBatchDate;
        private Label lblLine;
        private ComboBox cboLine;
        private Label lblShift;
        private ComboBox cboShift;
        private Label lblRodModel;
        private ComboBox cboRodModel;
        private Label lblPlanned;
        private TextBox txtPlanned;
        private Label lblActual;
        private TextBox txtActual;
        private Label lblGood;
        private TextBox txtGood;
        private Label lblDefect;
        private TextBox txtDefect;
        private Button btnSaveBatch;
        private Button btnClear;
        private Label lblGridTitle;
        private DataGridView dgvBatches;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button btnEdit;
        private Button btnDelete;
    }
}