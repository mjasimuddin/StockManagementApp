namespace StockManagementSystemApp.UI
{
    partial class ItemEntryUI
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
            this.itemCategory = new System.Windows.Forms.Label();
            this.itemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.companyName = new System.Windows.Forms.Label();
            this.itemCompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.itemName = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemSaveBtn = new System.Windows.Forms.Button();
            this.reorderLevel = new System.Windows.Forms.Label();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemCategory
            // 
            this.itemCategory.AutoSize = true;
            this.itemCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCategory.Location = new System.Drawing.Point(92, 33);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(73, 21);
            this.itemCategory.TabIndex = 0;
            this.itemCategory.Text = "Category";
            // 
            // itemCategoryComboBox
            // 
            this.itemCategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCategoryComboBox.FormattingEnabled = true;
            this.itemCategoryComboBox.ItemHeight = 21;
            this.itemCategoryComboBox.Location = new System.Drawing.Point(239, 33);
            this.itemCategoryComboBox.Name = "itemCategoryComboBox";
            this.itemCategoryComboBox.Size = new System.Drawing.Size(339, 29);
            this.itemCategoryComboBox.TabIndex = 0;
            this.itemCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.itemCategoryComboBox_SelectedIndexChanged);
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(42, 88);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(123, 21);
            this.companyName.TabIndex = 0;
            this.companyName.Text = "Company Name";
            // 
            // itemCompanyNameComboBox
            // 
            this.itemCompanyNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCompanyNameComboBox.FormattingEnabled = true;
            this.itemCompanyNameComboBox.Location = new System.Drawing.Point(239, 88);
            this.itemCompanyNameComboBox.Name = "itemCompanyNameComboBox";
            this.itemCompanyNameComboBox.Size = new System.Drawing.Size(339, 29);
            this.itemCompanyNameComboBox.TabIndex = 1;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(78, 137);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(87, 21);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "Item Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(239, 137);
            this.itemNameTextBox.Multiline = true;
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(339, 31);
            this.itemNameTextBox.TabIndex = 2;
            // 
            // itemSaveBtn
            // 
            this.itemSaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSaveBtn.Location = new System.Drawing.Point(485, 250);
            this.itemSaveBtn.Name = "itemSaveBtn";
            this.itemSaveBtn.Size = new System.Drawing.Size(93, 37);
            this.itemSaveBtn.TabIndex = 4;
            this.itemSaveBtn.Text = "Save";
            this.itemSaveBtn.UseVisualStyleBackColor = true;
            this.itemSaveBtn.Click += new System.EventHandler(this.itemSaveBtn_Click);
            // 
            // reorderLevel
            // 
            this.reorderLevel.AutoSize = true;
            this.reorderLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevel.Location = new System.Drawing.Point(59, 193);
            this.reorderLevel.Name = "reorderLevel";
            this.reorderLevel.Size = new System.Drawing.Size(106, 21);
            this.reorderLevel.TabIndex = 0;
            this.reorderLevel.Text = "Reorder Level";
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.reorderTextBox.Location = new System.Drawing.Point(239, 193);
            this.reorderTextBox.Multiline = true;
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(339, 28);
            this.reorderTextBox.TabIndex = 3;
            this.reorderTextBox.Text = "0";
            // 
            // ItemEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 408);
            this.Controls.Add(this.itemSaveBtn);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemCompanyNameComboBox);
            this.Controls.Add(this.reorderLevel);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.itemCategoryComboBox);
            this.Controls.Add(this.itemCategory);
            this.Name = "ItemEntryUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemEntryUI";
            this.Load += new System.EventHandler(this.ItemEntryUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemCategory;
        private System.Windows.Forms.ComboBox itemCategoryComboBox;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.ComboBox itemCompanyNameComboBox;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Button itemSaveBtn;
        private System.Windows.Forms.Label reorderLevel;
        private System.Windows.Forms.TextBox reorderTextBox;
    }
}