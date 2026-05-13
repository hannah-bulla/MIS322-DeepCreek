namespace DeepCreekLLC
{
    partial class InventoryControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpFG = new GroupBox();
            lblFGBatch = new Label();
            cboFGBatch = new ComboBox();
            lblFGModel = new Label();
            cboFGModel = new ComboBox();
            lblFGQty = new Label();
            txtFGQty = new TextBox();
            lblFGStatus = new Label();
            cboFGStatus = new ComboBox();
            this.btnSaveFG = new Button();
            this.btnClearFG = new Button();
            grpAdj = new GroupBox();
            lblAdjMaterial = new Label();
            cboAdjMaterial = new ComboBox();
            lblAdjQty = new Label();
            txtAdjQty = new TextBox();
            lblAdjReason = new Label();
            cboAdjReason = new ComboBox();
            this.btnApplyAdj = new Button();
            this.btnClearAdj = new Button();
            lblFGGridTitle = new Label();
            dgvFinishedGoods = new DataGridView();
            lblRMGridTitle = new Label();
            dgvRawMaterials = new DataGridView();
            this.btnEdit = new Button();
            grpFG.SuspendLayout();
            grpAdj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinishedGoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRawMaterials).BeginInit();
            SuspendLayout();
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
            grpFG.Controls.Add(this.btnSaveFG);
            grpFG.Controls.Add(this.btnClearFG);
            grpFG.Location = new Point(8, 8);
            grpFG.Name = "grpFG";
            grpFG.Size = new Size(460, 130);
            grpFG.TabIndex = 0;
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
            this.btnSaveFG.Location = new Point(8, 80);
            this.btnSaveFG.Name = "btnSaveFG";
            this.btnSaveFG.Size = new Size(90, 23);
            this.btnSaveFG.TabIndex = 8;
            this.btnSaveFG.Text = "Save Record";
            // 
            // btnClearFG
            // 
            this.btnClearFG.Location = new Point(104, 80);
            this.btnClearFG.Name = "btnClearFG";
            this.btnClearFG.Size = new Size(60, 23);
            this.btnClearFG.TabIndex = 9;
            this.btnClearFG.Text = "Clear";
            this.btnClearFG.Click += this.btnClear_Click;
            // 
            // grpAdj
            // 
            grpAdj.Controls.Add(lblAdjMaterial);
            grpAdj.Controls.Add(cboAdjMaterial);
            grpAdj.Controls.Add(lblAdjQty);
            grpAdj.Controls.Add(txtAdjQty);
            grpAdj.Controls.Add(lblAdjReason);
            grpAdj.Controls.Add(cboAdjReason);
            grpAdj.Controls.Add(this.btnApplyAdj);
            grpAdj.Controls.Add(this.btnClearAdj);
            grpAdj.Location = new Point(8, 144);
            grpAdj.Name = "grpAdj";
            grpAdj.Size = new Size(460, 110);
            grpAdj.TabIndex = 1;
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
            this.btnApplyAdj.Location = new Point(8, 78);
            this.btnApplyAdj.Name = "btnApplyAdj";
            this.btnApplyAdj.Size = new Size(120, 23);
            this.btnApplyAdj.TabIndex = 6;
            this.btnApplyAdj.Text = "Apply Adjustment";
            // 
            // btnClearAdj
            // 
            this.btnClearAdj.Location = new Point(134, 78);
            this.btnClearAdj.Name = "btnClearAdj";
            this.btnClearAdj.Size = new Size(60, 23);
            this.btnClearAdj.TabIndex = 7;
            this.btnClearAdj.Text = "Clear";
            // 
            // lblFGGridTitle
            // 
            lblFGGridTitle.AutoSize = true;
            lblFGGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFGGridTitle.Location = new Point(476, 8);
            lblFGGridTitle.Name = "lblFGGridTitle";
            lblFGGridTitle.Size = new Size(117, 15);
            lblFGGridTitle.TabIndex = 2;
            lblFGGridTitle.Text = "Finished Goods Grid";
            // 
            // dgvFinishedGoods
            // 
            dgvFinishedGoods.AllowUserToAddRows = false;
            dgvFinishedGoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFinishedGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinishedGoods.Location = new Point(476, 28);
            dgvFinishedGoods.Name = "dgvFinishedGoods";
            dgvFinishedGoods.ReadOnly = true;
            dgvFinishedGoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFinishedGoods.Size = new Size(490, 160);
            dgvFinishedGoods.TabIndex = 3;
            // 
            // lblRMGridTitle
            // 
            lblRMGridTitle.AutoSize = true;
            lblRMGridTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRMGridTitle.Location = new Point(476, 196);
            lblRMGridTitle.Name = "lblRMGridTitle";
            lblRMGridTitle.Size = new Size(112, 15);
            lblRMGridTitle.TabIndex = 4;
            lblRMGridTitle.Text = "Raw Materials Grid";
            // 
            // dgvRawMaterials
            // 
            dgvRawMaterials.AllowUserToAddRows = false;
            dgvRawMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRawMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRawMaterials.Location = new Point(476, 216);
            dgvRawMaterials.Name = "dgvRawMaterials";
            dgvRawMaterials.ReadOnly = true;
            dgvRawMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRawMaterials.Size = new Size(490, 140);
            dgvRawMaterials.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new Point(476, 362);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new Size(90, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit Selected";
            // 
            // InventoryControl
            // 
            ClientSize = new Size(980, 395);
            Controls.Add(grpFG);
            Controls.Add(grpAdj);
            Controls.Add(lblFGGridTitle);
            Controls.Add(dgvFinishedGoods);
            Controls.Add(lblRMGridTitle);
            Controls.Add(dgvRawMaterials);
            Controls.Add(this.btnEdit);
            Name = "InventoryControl";
            Text = "Inventory";
            grpFG.ResumeLayout(false);
            grpFG.PerformLayout();
            grpAdj.ResumeLayout(false);
            grpAdj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinishedGoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRawMaterials).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox grpFG, grpAdj;
        private Label lblFGBatch, lblFGModel, lblFGQty, lblFGStatus;
        private Label lblAdjMaterial, lblAdjQty, lblAdjReason;
        private Label lblFGGridTitle, lblRMGridTitle;
        private ComboBox cboFGBatch, cboFGModel, cboFGStatus, cboAdjMaterial, cboAdjReason;
        private TextBox txtFGQty, txtAdjQty;
        private DataGridView dgvFinishedGoods, dgvRawMaterials;
        private Button btnSaveFG, btnClearFG, btnApplyAdj, btnClearAdj, btnEdit;
    }
}
