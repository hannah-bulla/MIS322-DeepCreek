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
            this.btnInventory = new Button();
            this.btnProduction = new Button();
            this.btnQuality = new Button();
            this.btnReturns = new Button();
            SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new Point(12, 12);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new Size(128, 74);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += this.btnInventory_Click;
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new Point(146, 12);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new Size(128, 74);
            this.btnProduction.TabIndex = 1;
            this.btnProduction.Text = "Production";
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += this.btnProduction_Click;
            // 
            // btnQuality
            // 
            this.btnQuality.Location = new Point(280, 12);
            this.btnQuality.Name = "btnQuality";
            this.btnQuality.Size = new Size(128, 74);
            this.btnQuality.TabIndex = 2;
            this.btnQuality.Text = "Quality";
            this.btnQuality.UseVisualStyleBackColor = true;
            this.btnQuality.Click += this.btnQuality_Click;
            // 
            // btnReturns
            // 
            this.btnReturns.Location = new Point(414, 12);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new Size(128, 74);
            this.btnReturns.TabIndex = 3;
            this.btnReturns.Text = "Returns";
            this.btnReturns.UseVisualStyleBackColor = true;
            this.btnReturns.Click += this.btnReturns_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 104);
            Controls.Add(this.btnReturns);
            Controls.Add(this.btnQuality);
            Controls.Add(this.btnProduction);
            Controls.Add(this.btnInventory);
            Name = "MainMenu";
            Text = "Deep Creek LLC Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnQuality;
        private System.Windows.Forms.Button btnReturns;
    }
}