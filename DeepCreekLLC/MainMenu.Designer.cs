namespace DeepCreekLLC
{
    partial class MainMenu
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
            tabControlMain = new TabControl();
            tabInventory = new TabPage();
            grpFG = new GroupBox();
            lblFGBatch = new Label();
            cboFGBatch = new ComboBox();
            lblFGModel = new Label();
            cboFGModel = new ComboBox();
            lblFGQty = new Label();
            txtFGQty = new TextBox();
            lblFGStatus = new Label();
            cboFGStatus = new ComboBox();
            btnSaveFG = new Button();
            btnClearFG = new Button();
            grpAdj = new GroupBox();
            lblAdjMaterial = new Label();
            cboAdjMaterial = new ComboBox();
            lblAdjQty = new Label();
            txtAdjQty = new TextBox();
            lblAdjReason = new Label();
            cboAdjReason = new ComboBox();
            btnApplyAdj = new Button();
            btnClearAdj = new Button();
            lblFGGridTitle = new Label();
            dgvFinishedGoods = new DataGridView();
            lblRMGridTitle = new Label();
            dgvRawMaterials = new DataGridView();
            btnEdit = new Button();
            tabProduction = new TabPage();
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
            button1 = new Button();
            btnDelete = new Button();
            tabQuality = new TabPage();
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
            label1 = new Label();
            dgvDefects = new DataGridView();
            button2 = new Button();
            btnRemove = new Button();
            tabReturns = new TabPage();
            grpEntry = new GroupBox();
            lblAuthCode = new Label();
            txtAuthCode = new TextBox();
            lblCustomer = new Label();
            txtCustomer = new TextBox();
            lblDateRcvd = new Label();
            dtpDateRcvd = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            lblResolution = new Label();
            cboResolution = new ComboBox();
            lblReason = new Label();
            txtReason = new TextBox();
            btnSave = new Button();
            button3 = new Button();
            label4 = new Label();
            dgvReturns = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button5 = new Button();
            tabControlMain.SuspendLayout();
            tabInventory.SuspendLayout();
            grpFG.SuspendLayout();
            grpAdj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinishedGoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRawMaterials).BeginInit();
            tabProduction.SuspendLayout();
            grpBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            tabQuality.SuspendLayout();
            grpHeader.SuspendLayout();
            grpDefect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDefects).BeginInit();
            tabReturns.SuspendLayout();
            grpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturns).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabInventory);
            tabControlMain.Controls.Add(tabProduction);
            tabControlMain.Controls.Add(tabQuality);
            tabControlMain.Controls.Add(tabReturns);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(984, 549);
            tabControlMain.TabIndex = 0;
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(grpFG);
            tabInventory.Controls.Add(grpAdj);
            tabInventory.Controls.Add(lblFGGridTitle);
            tabInventory.Controls.Add(dgvFinishedGoods);
            tabInventory.Controls.Add(lblRMGridTitle);
            tabInventory.Controls.Add(dgvRawMaterials);
            tabInventory.Controls.Add(btnEdit);
            tabInventory.Location = new Point(4, 24);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(976, 521);
            tabInventory.TabIndex = 0;
            tabInventory.Text = "Inventory";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // grpFG
            // 
            grpFG.Controls.Add(lblFGBatch);
            grpFG.Controls.Add(cboFGBatch);
            grpFG.Controls.Add(lblFGModel);
            grpFG.Controls.Add(cboFGModel);
            grpFG.Controls.Add(lblFGQty);
            grpFG.Controls.Add(txtFGQty);
            grpFG.Controls.Add(lblFGStatus);
            grpFG.Controls.Add(cboFGStatus);
            grpFG.Controls.Add(btnSaveFG);
            grpFG.Controls.Add(btnClearFG);
            grpFG.Location = new Point(8, 15);
            grpFG.Name = "grpFG";
            grpFG.Size = new Size(460, 130);
            grpFG.TabIndex = 7;
            grpFG.TabStop = false;
            grpFG.Text = "Finished Goods Inventory";
            // 
            // lblFGBatch
            // 
            lblFGBatch.AutoSize = true;
            lblFGBatch.Location = new Point(8, 22);
            lblFGBatch.Name = "lblFGBatch";
            lblFGBatch.Size = new Size(45, 15);
            lblFGBatch.TabIndex = 0;
            lblFGBatch.Text = "Batch *";
            // 
            // cboFGBatch
            // 
            cboFGBatch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFGBatch.Items.AddRange(new object[] { "190416-2.1", "190415-1.1", "190414-2.2" });
            cboFGBatch.Location = new Point(8, 42);
            cboFGBatch.Name = "cboFGBatch";
            cboFGBatch.Size = new Size(120, 23);
            cboFGBatch.TabIndex = 1;
            // 
            // lblFGModel
            // 
            lblFGModel.AutoSize = true;
            lblFGModel.Location = new Point(138, 22);
            lblFGModel.Name = "lblFGModel";
            lblFGModel.Size = new Size(73, 15);
            lblFGModel.TabIndex = 2;
            lblFGModel.Text = "Rod Model *";
            // 
            // cboFGModel
            // 
            cboFGModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFGModel.Items.AddRange(new object[] { "BR0906E", "PR0906M", "GD0806F" });
            cboFGModel.Location = new Point(138, 42);
            cboFGModel.Name = "cboFGModel";
            cboFGModel.Size = new Size(120, 23);
            cboFGModel.TabIndex = 3;
            // 
            // lblFGQty
            // 
            lblFGQty.AutoSize = true;
            lblFGQty.Location = new Point(268, 22);
            lblFGQty.Name = "lblFGQty";
            lblFGQty.Size = new Size(61, 15);
            lblFGQty.TabIndex = 4;
            lblFGQty.Text = "Quantity *";
            // 
            // txtFGQty
            // 
            txtFGQty.Location = new Point(268, 42);
            txtFGQty.Name = "txtFGQty";
            txtFGQty.Size = new Size(70, 23);
            txtFGQty.TabIndex = 5;
            // 
            // lblFGStatus
            // 
            lblFGStatus.AutoSize = true;
            lblFGStatus.Location = new Point(348, 22);
            lblFGStatus.Name = "lblFGStatus";
            lblFGStatus.Size = new Size(96, 15);
            lblFGStatus.TabIndex = 6;
            lblFGStatus.Text = "Location Status *";
            // 
            // cboFGStatus
            // 
            cboFGStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFGStatus.Items.AddRange(new object[] { "Available", "Holding" });
            cboFGStatus.Location = new Point(348, 42);
            cboFGStatus.Name = "cboFGStatus";
            cboFGStatus.Size = new Size(100, 23);
            cboFGStatus.TabIndex = 7;
            // 
            // btnSaveFG
            // 
            btnSaveFG.Location = new Point(8, 80);
            btnSaveFG.Name = "btnSaveFG";
            btnSaveFG.Size = new Size(90, 23);
            btnSaveFG.TabIndex = 8;
            btnSaveFG.Text = "Save Record";
            // 
            // btnClearFG
            // 
            btnClearFG.Location = new Point(104, 80);
            btnClearFG.Name = "btnClearFG";
            btnClearFG.Size = new Size(60, 23);
            btnClearFG.TabIndex = 9;
            btnClearFG.Text = "Clear";
            // 
            // grpAdj
            // 
            grpAdj.Controls.Add(lblAdjMaterial);
            grpAdj.Controls.Add(cboAdjMaterial);
            grpAdj.Controls.Add(lblAdjQty);
            grpAdj.Controls.Add(txtAdjQty);
            grpAdj.Controls.Add(lblAdjReason);
            grpAdj.Controls.Add(cboAdjReason);
            grpAdj.Controls.Add(btnApplyAdj);
            grpAdj.Controls.Add(btnClearAdj);
            grpAdj.Location = new Point(8, 151);
            grpAdj.Name = "grpAdj";
            grpAdj.Size = new Size(460, 110);
            grpAdj.TabIndex = 8;
            grpAdj.TabStop = false;
            grpAdj.Text = "Manual Inventory Adjustment";
            // 
            // lblAdjMaterial
            // 
            lblAdjMaterial.AutoSize = true;
            lblAdjMaterial.Location = new Point(8, 22);
            lblAdjMaterial.Name = "lblAdjMaterial";
            lblAdjMaterial.Size = new Size(85, 15);
            lblAdjMaterial.TabIndex = 0;
            lblAdjMaterial.Text = "Material / Item";
            // 
            // cboAdjMaterial
            // 
            cboAdjMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAdjMaterial.Items.AddRange(new object[] { "Graphite Strip", "Fiberglass Strip", "Guide Set", "Rod Tip", "Handle" });
            cboAdjMaterial.Location = new Point(8, 42);
            cboAdjMaterial.Name = "cboAdjMaterial";
            cboAdjMaterial.Size = new Size(180, 23);
            cboAdjMaterial.TabIndex = 1;
            // 
            // lblAdjQty
            // 
            lblAdjQty.AutoSize = true;
            lblAdjQty.Location = new Point(198, 22);
            lblAdjQty.Name = "lblAdjQty";
            lblAdjQty.Size = new Size(63, 15);
            lblAdjQty.TabIndex = 2;
            lblAdjQty.Text = "Adjust Qty";
            // 
            // txtAdjQty
            // 
            txtAdjQty.Location = new Point(198, 42);
            txtAdjQty.Name = "txtAdjQty";
            txtAdjQty.Size = new Size(70, 23);
            txtAdjQty.TabIndex = 3;
            // 
            // lblAdjReason
            // 
            lblAdjReason.AutoSize = true;
            lblAdjReason.Location = new Point(278, 22);
            lblAdjReason.Name = "lblAdjReason";
            lblAdjReason.Size = new Size(45, 15);
            lblAdjReason.TabIndex = 4;
            lblAdjReason.Text = "Reason";
            // 
            // cboAdjReason
            // 
            cboAdjReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAdjReason.Items.AddRange(new object[] { "Damage", "Waste", "Loss", "Other" });
            cboAdjReason.Location = new Point(278, 42);
            cboAdjReason.Name = "cboAdjReason";
            cboAdjReason.Size = new Size(120, 23);
            cboAdjReason.TabIndex = 5;
            // 
            // btnApplyAdj
            // 
            btnApplyAdj.Location = new Point(8, 78);
            btnApplyAdj.Name = "btnApplyAdj";
            btnApplyAdj.Size = new Size(120, 23);
            btnApplyAdj.TabIndex = 6;
            btnApplyAdj.Text = "Apply Adjustment";
            // 
            // btnClearAdj
            // 
            btnClearAdj.Location = new Point(134, 78);
            btnClearAdj.Name = "btnClearAdj";
            btnClearAdj.Size = new Size(60, 23);
            btnClearAdj.TabIndex = 7;
            btnClearAdj.Text = "Clear";
            // 
            // lblFGGridTitle
            // 
            lblFGGridTitle.AutoSize = true;
            lblFGGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFGGridTitle.Location = new Point(476, 15);
            lblFGGridTitle.Name = "lblFGGridTitle";
            lblFGGridTitle.Size = new Size(117, 15);
            lblFGGridTitle.TabIndex = 9;
            lblFGGridTitle.Text = "Finished Goods Grid";
            // 
            // dgvFinishedGoods
            // 
            dgvFinishedGoods.AllowUserToAddRows = false;
            dgvFinishedGoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFinishedGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinishedGoods.Location = new Point(476, 35);
            dgvFinishedGoods.Name = "dgvFinishedGoods";
            dgvFinishedGoods.ReadOnly = true;
            dgvFinishedGoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFinishedGoods.Size = new Size(490, 160);
            dgvFinishedGoods.TabIndex = 10;
            // 
            // lblRMGridTitle
            // 
            lblRMGridTitle.AutoSize = true;
            lblRMGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRMGridTitle.Location = new Point(476, 203);
            lblRMGridTitle.Name = "lblRMGridTitle";
            lblRMGridTitle.Size = new Size(112, 15);
            lblRMGridTitle.TabIndex = 11;
            lblRMGridTitle.Text = "Raw Materials Grid";
            // 
            // dgvRawMaterials
            // 
            dgvRawMaterials.AllowUserToAddRows = false;
            dgvRawMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRawMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRawMaterials.Location = new Point(476, 223);
            dgvRawMaterials.Name = "dgvRawMaterials";
            dgvRawMaterials.ReadOnly = true;
            dgvRawMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRawMaterials.Size = new Size(490, 140);
            dgvRawMaterials.TabIndex = 12;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(476, 369);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 23);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit Selected";
            // 
            // tabProduction
            // 
            tabProduction.Controls.Add(grpBatch);
            tabProduction.Controls.Add(lblGridTitle);
            tabProduction.Controls.Add(dgvBatches);
            tabProduction.Controls.Add(button1);
            tabProduction.Controls.Add(btnDelete);
            tabProduction.Location = new Point(4, 24);
            tabProduction.Name = "tabProduction";
            tabProduction.Padding = new Padding(3);
            tabProduction.Size = new Size(976, 521);
            tabProduction.TabIndex = 1;
            tabProduction.Text = "Production";
            tabProduction.UseVisualStyleBackColor = true;
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
            grpBatch.Location = new Point(10, 15);
            grpBatch.Name = "grpBatch";
            grpBatch.Size = new Size(960, 129);
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
            btnSaveBatch.Location = new Point(6, 89);
            btnSaveBatch.Name = "btnSaveBatch";
            btnSaveBatch.Size = new Size(85, 23);
            btnSaveBatch.TabIndex = 18;
            btnSaveBatch.Text = "Save Batch";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(97, 89);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 23);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGridTitle.Location = new Point(10, 147);
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
            dgvBatches.Location = new Point(10, 167);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.ReadOnly = true;
            dgvBatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatches.Size = new Size(960, 200);
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
            // button1
            // 
            button1.Location = new Point(10, 375);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 8;
            button1.Text = "Edit Selected";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(106, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Selected";
            // 
            // tabQuality
            // 
            tabQuality.Controls.Add(grpHeader);
            tabQuality.Controls.Add(grpDefect);
            tabQuality.Controls.Add(label1);
            tabQuality.Controls.Add(dgvDefects);
            tabQuality.Controls.Add(button2);
            tabQuality.Controls.Add(btnRemove);
            tabQuality.Location = new Point(4, 24);
            tabQuality.Name = "tabQuality";
            tabQuality.Padding = new Padding(3);
            tabQuality.Size = new Size(976, 521);
            tabQuality.TabIndex = 2;
            tabQuality.Text = "Quality";
            tabQuality.UseVisualStyleBackColor = true;
            // 
            // grpHeader
            // 
            grpHeader.Controls.Add(lblBatch);
            grpHeader.Controls.Add(cboBatch);
            grpHeader.Controls.Add(lblInspDate);
            grpHeader.Controls.Add(dtpInspDate);
            grpHeader.Controls.Add(btnSaveInsp);
            grpHeader.Controls.Add(btnClearHeader);
            grpHeader.Location = new Point(6, 16);
            grpHeader.Name = "grpHeader";
            grpHeader.Size = new Size(460, 90);
            grpHeader.TabIndex = 6;
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
            // 
            // btnClearHeader
            // 
            btnClearHeader.Location = new Point(124, 65);
            btnClearHeader.Name = "btnClearHeader";
            btnClearHeader.Size = new Size(60, 23);
            btnClearHeader.TabIndex = 5;
            btnClearHeader.Text = "Clear";
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
            grpDefect.Location = new Point(6, 112);
            grpDefect.Name = "grpDefect";
            grpDefect.Size = new Size(460, 160);
            grpDefect.TabIndex = 7;
            grpDefect.TabStop = false;
            grpDefect.Text = "Defect Detail Entry";
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(474, 16);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 8;
            label1.Text = "Inspection Detail Grid";
            // 
            // dgvDefects
            // 
            dgvDefects.AllowUserToAddRows = false;
            dgvDefects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDefects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDefects.Location = new Point(474, 36);
            dgvDefects.Name = "dgvDefects";
            dgvDefects.ReadOnly = true;
            dgvDefects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDefects.Size = new Size(490, 280);
            dgvDefects.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(474, 323);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 10;
            button2.Text = "Edit Selected";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(570, 323);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 23);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove Defect";
            // 
            // tabReturns
            // 
            tabReturns.Controls.Add(grpEntry);
            tabReturns.Controls.Add(label4);
            tabReturns.Controls.Add(dgvReturns);
            tabReturns.Controls.Add(button4);
            tabReturns.Controls.Add(button5);
            tabReturns.Location = new Point(4, 24);
            tabReturns.Name = "tabReturns";
            tabReturns.Padding = new Padding(3);
            tabReturns.Size = new Size(976, 521);
            tabReturns.TabIndex = 3;
            tabReturns.Text = "Returns";
            tabReturns.UseVisualStyleBackColor = true;
            // 
            // grpEntry
            // 
            grpEntry.Controls.Add(lblAuthCode);
            grpEntry.Controls.Add(txtAuthCode);
            grpEntry.Controls.Add(lblCustomer);
            grpEntry.Controls.Add(txtCustomer);
            grpEntry.Controls.Add(lblDateRcvd);
            grpEntry.Controls.Add(dtpDateRcvd);
            grpEntry.Controls.Add(label2);
            grpEntry.Controls.Add(comboBox1);
            grpEntry.Controls.Add(label3);
            grpEntry.Controls.Add(textBox1);
            grpEntry.Controls.Add(lblResolution);
            grpEntry.Controls.Add(cboResolution);
            grpEntry.Controls.Add(lblReason);
            grpEntry.Controls.Add(txtReason);
            grpEntry.Controls.Add(btnSave);
            grpEntry.Controls.Add(button3);
            grpEntry.Location = new Point(6, 23);
            grpEntry.Name = "grpEntry";
            grpEntry.Size = new Size(964, 218);
            grpEntry.TabIndex = 6;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 78);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 6;
            label2.Text = "Rod Model *";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "PR0906M — Primo 9'6\" Moderate", "BR0906E — Better 9'6\" Extra Fast", "GD0806F — Good 8'6\" Fast" });
            comboBox1.Location = new Point(8, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 23);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 78);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 8;
            label3.Text = "Batch Code (from rod)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 9;
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
            // 
            // button3
            // 
            button3.Location = new Point(104, 185);
            button3.Name = "button3";
            button3.Size = new Size(80, 23);
            button3.TabIndex = 15;
            button3.Text = "Clear Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 252);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 7;
            label4.Text = "Customer Returns Grid";
            // 
            // dgvReturns
            // 
            dgvReturns.AllowUserToAddRows = false;
            dgvReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturns.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
            dgvReturns.Location = new Point(6, 272);
            dgvReturns.Name = "dgvReturns";
            dgvReturns.ReadOnly = true;
            dgvReturns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturns.Size = new Size(964, 200);
            dgvReturns.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Return ID";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Auth Code";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Customer";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Model";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Batch";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Date Received";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Reason";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Resolution";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 486);
            button4.Name = "button4";
            button4.Size = new Size(90, 23);
            button4.TabIndex = 9;
            button4.Text = "Edit Selected";
            // 
            // button5
            // 
            button5.Location = new Point(102, 486);
            button5.Name = "button5";
            button5.Size = new Size(105, 23);
            button5.TabIndex = 10;
            button5.Text = "Delete Selected";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 549);
            Controls.Add(tabControlMain);
            Name = "MainMenu";
            Text = "Deep Creek LLC Management";
            tabControlMain.ResumeLayout(false);
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            grpFG.ResumeLayout(false);
            grpFG.PerformLayout();
            grpAdj.ResumeLayout(false);
            grpAdj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinishedGoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRawMaterials).EndInit();
            tabProduction.ResumeLayout(false);
            tabProduction.PerformLayout();
            grpBatch.ResumeLayout(false);
            grpBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            tabQuality.ResumeLayout(false);
            tabQuality.PerformLayout();
            grpHeader.ResumeLayout(false);
            grpHeader.PerformLayout();
            grpDefect.ResumeLayout(false);
            grpDefect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDefects).EndInit();
            tabReturns.ResumeLayout(false);
            tabReturns.PerformLayout();
            grpEntry.ResumeLayout(false);
            grpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturns).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabInventory;
        private TabPage tabProduction;
        private TabPage tabQuality;
        private TabPage tabReturns;
        private GroupBox grpFG;
        private Label lblFGBatch;
        private ComboBox cboFGBatch;
        private Label lblFGModel;
        private ComboBox cboFGModel;
        private Label lblFGQty;
        private TextBox txtFGQty;
        private Label lblFGStatus;
        private ComboBox cboFGStatus;
        private Button btnSaveFG;
        private Button btnClearFG;
        private GroupBox grpAdj;
        private Label lblAdjMaterial;
        private ComboBox cboAdjMaterial;
        private Label lblAdjQty;
        private TextBox txtAdjQty;
        private Label lblAdjReason;
        private ComboBox cboAdjReason;
        private Button btnApplyAdj;
        private Button btnClearAdj;
        private Label lblFGGridTitle;
        private DataGridView dgvFinishedGoods;
        private Label lblRMGridTitle;
        private DataGridView dgvRawMaterials;
        private Button btnEdit;
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
        private Button button1;
        private Button btnDelete;
        private GroupBox grpHeader;
        private Label lblBatch;
        private ComboBox cboBatch;
        private Label lblInspDate;
        private DateTimePicker dtpInspDate;
        private Button btnSaveInsp;
        private Button btnClearHeader;
        private GroupBox grpDefect;
        private Label lblUnit;
        private TextBox txtUnit;
        private Label lblDefectCode;
        private ComboBox cboDefectCode;
        private Label lblSeverity;
        private ComboBox cboSeverity;
        private Label lblZone;
        private ComboBox cboZone;
        private Label lblComments;
        private TextBox txtComments;
        private Button btnAddDefect;
        private Button btnClearRow;
        private Label label1;
        private DataGridView dgvDefects;
        private Button button2;
        private Button btnRemove;
        private GroupBox grpEntry;
        private Label lblAuthCode;
        private TextBox txtAuthCode;
        private Label lblCustomer;
        private TextBox txtCustomer;
        private Label lblDateRcvd;
        private DateTimePicker dtpDateRcvd;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label lblResolution;
        private ComboBox cboResolution;
        private Label lblReason;
        private TextBox txtReason;
        private Button btnSave;
        private Button button3;
        private Label label4;
        private DataGridView dgvReturns;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private Button button4;
        private Button button5;
    }
}