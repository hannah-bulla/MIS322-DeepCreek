using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DeepCreekLLC
{
    public partial class InventoryControl : UserControl
    {
        private readonly BindingList<FinishedGoodRecord> finishedGoods = new();
        private readonly BindingList<RawMaterialRecord> rawMaterials = new();

        private readonly BindingSource finishedGoodsSource = new();
        private readonly BindingSource rawMaterialsSource = new();

        private int nextFinishedGoodId = 1;
        private int? editingFinishedGoodId = null;
        private string? editingRawMaterialName = null;
        private string activeGrid = "FinishedGoods";

        private Button? btnDeleteSelected;

        public InventoryControl()
        {
            InitializeComponent();

            SetupInventoryTab();
            LoadSampleData();

            btnSaveFG.Click -= btnSaveFG_Click;
            btnSaveFG.Click += btnSaveFG_Click;

            btnClearFG.Click -= btnClear_Click;
            btnClearFG.Click += btnClear_Click;

            btnApplyAdj.Click -= btnApplyAdj_Click;
            btnApplyAdj.Click += btnApplyAdj_Click;

            btnClearAdj.Click -= btnClearAdj_Click;
            btnClearAdj.Click += btnClearAdj_Click;

            btnEdit.Click -= btnEdit_Click;
            btnEdit.Click += btnEdit_Click;
        }

        private void SetupInventoryTab()
        {
            finishedGoodsSource.DataSource = finishedGoods;
            rawMaterialsSource.DataSource = rawMaterials;

            dgvFinishedGoods.DataSource = finishedGoodsSource;
            dgvRawMaterials.DataSource = rawMaterialsSource;

            dgvFinishedGoods.AutoGenerateColumns = true;
            dgvRawMaterials.AutoGenerateColumns = true;

            dgvFinishedGoods.ReadOnly = true;
            dgvRawMaterials.ReadOnly = true;

            dgvFinishedGoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRawMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvFinishedGoods.MultiSelect = false;
            dgvRawMaterials.MultiSelect = false;

            dgvFinishedGoods.Enter += (sender, e) => activeGrid = "FinishedGoods";
            dgvFinishedGoods.CellClick += (sender, e) => activeGrid = "FinishedGoods";

            dgvRawMaterials.Enter += (sender, e) => activeGrid = "RawMaterials";
            dgvRawMaterials.CellClick += (sender, e) => activeGrid = "RawMaterials";

            // Allows users to type new batches, rod models, and raw materials.
            cboFGBatch.DropDownStyle = ComboBoxStyle.DropDown;
            cboFGModel.DropDownStyle = ComboBoxStyle.DropDown;
            cboAdjMaterial.DropDownStyle = ComboBoxStyle.DropDown;

            AddComboBoxItemIfMissing(cboFGStatus, "Available");
            AddComboBoxItemIfMissing(cboFGStatus, "Holding");

            AddComboBoxItemIfMissing(cboAdjReason, "New Inventory");
            AddComboBoxItemIfMissing(cboAdjReason, "Restock");
            AddComboBoxItemIfMissing(cboAdjReason, "Correction");
            AddComboBoxItemIfMissing(cboAdjReason, "Loss");
            AddComboBoxItemIfMissing(cboAdjReason, "Damage");
            AddComboBoxItemIfMissing(cboAdjReason, "Waste");
            AddComboBoxItemIfMissing(cboAdjReason, "Other");

            CreateDeleteButton();

            SetComboBoxesBlank();
        }

        private void CreateDeleteButton()
        {
            btnDeleteSelected = new Button
            {
                Name = "btnDeleteSelected",
                Text = "Delete Selected",
                Size = new Size(110, 23),
                Location = new Point(btnEdit.Right + 8, btnEdit.Top)
            };

            btnDeleteSelected.Click += btnDeleteSelected_Click;
            Controls.Add(btnDeleteSelected);
            btnDeleteSelected.BringToFront();
        }

        private void LoadSampleData()
        {
            finishedGoods.Add(new FinishedGoodRecord
            {
                InventoryId = nextFinishedGoodId++,
                Batch = "190416-2.1",
                RodModel = "BR0906E",
                Quantity = 25,
                LocationStatus = "Available"
            });

            finishedGoods.Add(new FinishedGoodRecord
            {
                InventoryId = nextFinishedGoodId++,
                Batch = "190415-1.1",
                RodModel = "PR0906M",
                Quantity = 12,
                LocationStatus = "Holding"
            });

            rawMaterials.Add(new RawMaterialRecord
            {
                MaterialItem = "Graphite Strip",
                QuantityOnHand = 150,
                LastAdjustment = 0,
                Reason = "Starting Inventory"
            });

            rawMaterials.Add(new RawMaterialRecord
            {
                MaterialItem = "Fiberglass Strip",
                QuantityOnHand = 100,
                LastAdjustment = 0,
                Reason = "Starting Inventory"
            });

            rawMaterials.Add(new RawMaterialRecord
            {
                MaterialItem = "Guide Set",
                QuantityOnHand = 80,
                LastAdjustment = 0,
                Reason = "Starting Inventory"
            });

            rawMaterials.Add(new RawMaterialRecord
            {
                MaterialItem = "Rod Tip",
                QuantityOnHand = 90,
                LastAdjustment = 0,
                Reason = "Starting Inventory"
            });

            rawMaterials.Add(new RawMaterialRecord
            {
                MaterialItem = "Handle",
                QuantityOnHand = 75,
                LastAdjustment = 0,
                Reason = "Starting Inventory"
            });

            RefreshFinishedGoodsComboBoxItems();
            RefreshRawMaterialComboBoxItems();
        }

        private void btnSaveFG_Click(object sender, EventArgs e)
        {
            if (!ValidateFinishedGoodsInput(out int quantity))
            {
                return;
            }

            string batch = cboFGBatch.Text.Trim();
            string rodModel = cboFGModel.Text.Trim();
            string status = cboFGStatus.Text.Trim();

            if (editingFinishedGoodId.HasValue)
            {
                FinishedGoodRecord? record = finishedGoods
                    .FirstOrDefault(item => item.InventoryId == editingFinishedGoodId.Value);

                if (record != null)
                {
                    record.Batch = batch;
                    record.RodModel = rodModel;
                    record.Quantity = quantity;
                    record.LocationStatus = status;

                    finishedGoodsSource.ResetBindings(false);
                    RefreshFinishedGoodsComboBoxItems();

                    MessageBox.Show("Finished goods record updated successfully.");
                }

                editingFinishedGoodId = null;
                btnSaveFG.Text = "Save Record";
            }
            else
            {
                finishedGoods.Add(new FinishedGoodRecord
                {
                    InventoryId = nextFinishedGoodId++,
                    Batch = batch,
                    RodModel = rodModel,
                    Quantity = quantity,
                    LocationStatus = status
                });

                AddComboBoxItemIfMissing(cboFGBatch, batch);
                AddComboBoxItemIfMissing(cboFGModel, rodModel);

                MessageBox.Show("New product added to finished goods inventory.");
            }

            ClearFinishedGoodsFields();
        }

        private bool ValidateFinishedGoodsInput(out int quantity)
        {
            quantity = 0;

            if (string.IsNullOrWhiteSpace(cboFGBatch.Text))
            {
                MessageBox.Show("Please enter or select a batch.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboFGModel.Text))
            {
                MessageBox.Show("Please enter or select a rod model.");
                return false;
            }

            if (!int.TryParse(txtFGQty.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboFGStatus.Text))
            {
                MessageBox.Show("Please select a location status.");
                return false;
            }

            return true;
        }

        private void btnApplyAdj_Click(object sender, EventArgs e)
        {
            string materialName = cboAdjMaterial.Text.Trim();

            if (string.IsNullOrWhiteSpace(materialName))
            {
                MessageBox.Show("Please enter or select a raw material.");
                return;
            }

            if (!int.TryParse(txtAdjQty.Text, out int enteredQty) || enteredQty < 0)
            {
                MessageBox.Show("Please enter a valid quantity of zero or greater.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cboAdjReason.Text))
            {
                MessageBox.Show("Please select a reason.");
                return;
            }

            if (editingRawMaterialName != null)
            {
                UpdateRawMaterialRecord(materialName, enteredQty);
                return;
            }

            ApplyRawMaterialAdjustment(materialName, enteredQty);
        }

        private void ApplyRawMaterialAdjustment(string materialName, int enteredQty)
        {
            RawMaterialRecord? material = rawMaterials
                .FirstOrDefault(item => item.MaterialItem.Equals(materialName, StringComparison.OrdinalIgnoreCase));

            bool isSubtractReason =
                cboAdjReason.Text == "Loss" ||
                cboAdjReason.Text == "Damage" ||
                cboAdjReason.Text == "Waste";

            int adjustmentQty = Math.Abs(enteredQty);

            if (isSubtractReason)
            {
                adjustmentQty *= -1;
            }

            if (material == null)
            {
                if (adjustmentQty < 0)
                {
                    MessageBox.Show("A new raw material cannot be added with Loss, Damage, or Waste.");
                    return;
                }

                rawMaterials.Add(new RawMaterialRecord
                {
                    MaterialItem = materialName,
                    QuantityOnHand = adjustmentQty,
                    LastAdjustment = adjustmentQty,
                    Reason = cboAdjReason.Text
                });

                RefreshRawMaterialComboBoxItems();
                rawMaterialsSource.ResetBindings(false);

                MessageBox.Show("New raw material added successfully.");
                ClearAdjustmentFields();
                return;
            }

            int newQuantity = material.QuantityOnHand + adjustmentQty;

            if (newQuantity < 0)
            {
                MessageBox.Show("Adjustment cannot reduce inventory below zero.");
                return;
            }

            material.QuantityOnHand = newQuantity;
            material.LastAdjustment = adjustmentQty;
            material.Reason = cboAdjReason.Text;

            rawMaterialsSource.ResetBindings(false);

            MessageBox.Show("Raw material inventory updated successfully.");
            ClearAdjustmentFields();
        }

        private void UpdateRawMaterialRecord(string newMaterialName, int newQuantityOnHand)
        {
            RawMaterialRecord? material = rawMaterials
                .FirstOrDefault(item => item.MaterialItem == editingRawMaterialName);

            if (material == null)
            {
                MessageBox.Show("Unable to update selected raw material.");
                ClearAdjustmentFields();
                return;
            }

            bool duplicateNameExists = rawMaterials.Any(item =>
                item.MaterialItem.Equals(newMaterialName, StringComparison.OrdinalIgnoreCase) &&
                item.MaterialItem != editingRawMaterialName);

            if (duplicateNameExists)
            {
                MessageBox.Show("A raw material with that name already exists.");
                return;
            }

            int difference = newQuantityOnHand - material.QuantityOnHand;

            material.MaterialItem = newMaterialName;
            material.QuantityOnHand = newQuantityOnHand;
            material.LastAdjustment = difference;
            material.Reason = string.IsNullOrWhiteSpace(cboAdjReason.Text) ? "Correction" : cboAdjReason.Text;

            rawMaterialsSource.ResetBindings(false);
            RefreshRawMaterialComboBoxItems();

            MessageBox.Show("Raw material record updated successfully.");
            ClearAdjustmentFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (activeGrid == "RawMaterials")
            {
                EditSelectedRawMaterial();
            }
            else
            {
                EditSelectedFinishedGood();
            }
        }

        private void EditSelectedFinishedGood()
        {
            if (dgvFinishedGoods.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a finished goods record to edit.");
                return;
            }

            FinishedGoodRecord? selectedRecord =
                dgvFinishedGoods.SelectedRows[0].DataBoundItem as FinishedGoodRecord;

            if (selectedRecord == null)
            {
                MessageBox.Show("Unable to load selected finished goods record.");
                return;
            }

            activeGrid = "FinishedGoods";
            editingFinishedGoodId = selectedRecord.InventoryId;
            editingRawMaterialName = null;

            cboFGBatch.Text = selectedRecord.Batch;
            cboFGModel.Text = selectedRecord.RodModel;
            txtFGQty.Text = selectedRecord.Quantity.ToString();
            cboFGStatus.Text = selectedRecord.LocationStatus;

            btnSaveFG.Text = "Update Record";
            btnApplyAdj.Text = "Apply Adjustment";
            lblAdjQty.Text = "Adjust Qty";
        }

        private void EditSelectedRawMaterial()
        {
            if (dgvRawMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a raw material record to edit.");
                return;
            }

            RawMaterialRecord? selectedRecord =
                dgvRawMaterials.SelectedRows[0].DataBoundItem as RawMaterialRecord;

            if (selectedRecord == null)
            {
                MessageBox.Show("Unable to load selected raw material record.");
                return;
            }

            activeGrid = "RawMaterials";
            editingRawMaterialName = selectedRecord.MaterialItem;
            editingFinishedGoodId = null;

            cboAdjMaterial.Text = selectedRecord.MaterialItem;
            txtAdjQty.Text = selectedRecord.QuantityOnHand.ToString();
            cboAdjReason.Text = selectedRecord.Reason;

            btnApplyAdj.Text = "Update Material";
            lblAdjQty.Text = "New Qty";
            btnSaveFG.Text = "Save Record";
        }

        private void btnDeleteSelected_Click(object? sender, EventArgs e)
        {
            if (activeGrid == "RawMaterials")
            {
                DeleteSelectedRawMaterial();
            }
            else
            {
                DeleteSelectedFinishedGood();
            }
        }

        private void DeleteSelectedFinishedGood()
        {
            if (dgvFinishedGoods.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a finished goods record to delete.");
                return;
            }

            FinishedGoodRecord? selectedRecord =
                dgvFinishedGoods.SelectedRows[0].DataBoundItem as FinishedGoodRecord;

            if (selectedRecord == null)
            {
                MessageBox.Show("Unable to delete selected finished goods record.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the selected finished goods record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            finishedGoods.Remove(selectedRecord);
            finishedGoodsSource.ResetBindings(false);
            RefreshFinishedGoodsComboBoxItems();
            ClearFinishedGoodsFields();

            MessageBox.Show("Finished goods record deleted successfully.");
        }

        private void DeleteSelectedRawMaterial()
        {
            if (dgvRawMaterials.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a raw material record to delete.");
                return;
            }

            RawMaterialRecord? selectedRecord =
                dgvRawMaterials.SelectedRows[0].DataBoundItem as RawMaterialRecord;

            if (selectedRecord == null)
            {
                MessageBox.Show("Unable to delete selected raw material record.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the selected raw material record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            rawMaterials.Remove(selectedRecord);
            rawMaterialsSource.ResetBindings(false);
            RefreshRawMaterialComboBoxItems();
            ClearAdjustmentFields();

            MessageBox.Show("Raw material record deleted successfully.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFinishedGoodsFields();
        }

        private void btnClearAdj_Click(object sender, EventArgs e)
        {
            ClearAdjustmentFields();
        }

        private void ClearFinishedGoodsFields()
        {
            cboFGBatch.SelectedIndex = -1;
            cboFGBatch.Text = string.Empty;
            cboFGModel.SelectedIndex = -1;
            cboFGModel.Text = string.Empty;
            txtFGQty.Clear();
            cboFGStatus.SelectedIndex = -1;

            editingFinishedGoodId = null;
            btnSaveFG.Text = "Save Record";
        }

        private void ClearAdjustmentFields()
        {
            cboAdjMaterial.SelectedIndex = -1;
            cboAdjMaterial.Text = string.Empty;
            txtAdjQty.Clear();
            cboAdjReason.SelectedIndex = -1;

            editingRawMaterialName = null;
            btnApplyAdj.Text = "Apply Adjustment";
            lblAdjQty.Text = "Adjust Qty";
        }

        private void SetComboBoxesBlank()
        {
            cboFGBatch.SelectedIndex = -1;
            cboFGBatch.Text = string.Empty;
            cboFGModel.SelectedIndex = -1;
            cboFGModel.Text = string.Empty;
            cboFGStatus.SelectedIndex = -1;
            cboAdjMaterial.SelectedIndex = -1;
            cboAdjMaterial.Text = string.Empty;
            cboAdjReason.SelectedIndex = -1;
        }

        private void RefreshFinishedGoodsComboBoxItems()
        {
            cboFGBatch.Items.Clear();
            cboFGModel.Items.Clear();

            foreach (string batch in finishedGoods.Select(item => item.Batch).Distinct().OrderBy(item => item))
            {
                cboFGBatch.Items.Add(batch);
            }

            foreach (string model in finishedGoods.Select(item => item.RodModel).Distinct().OrderBy(item => item))
            {
                cboFGModel.Items.Add(model);
            }
        }

        private void RefreshRawMaterialComboBoxItems()
        {
            string currentText = cboAdjMaterial.Text;

            cboAdjMaterial.Items.Clear();

            foreach (RawMaterialRecord material in rawMaterials.OrderBy(item => item.MaterialItem))
            {
                cboAdjMaterial.Items.Add(material.MaterialItem);
            }

            cboAdjMaterial.Text = currentText;
        }

        private void AddComboBoxItemIfMissing(ComboBox comboBox, string itemText)
        {
            bool exists = comboBox.Items
                .Cast<object>()
                .Any(item => item.ToString() == itemText);

            if (!exists)
            {
                comboBox.Items.Add(itemText);
            }
        }

        private class FinishedGoodRecord
        {
            public int InventoryId { get; set; }
            public string Batch { get; set; } = string.Empty;
            public string RodModel { get; set; } = string.Empty;
            public int Quantity { get; set; }
            public string LocationStatus { get; set; } = string.Empty;
        }

        private class RawMaterialRecord
        {
            public string MaterialItem { get; set; } = string.Empty;
            public int QuantityOnHand { get; set; }
            public int LastAdjustment { get; set; }
            public string Reason { get; set; } = string.Empty;
        }
    }
}