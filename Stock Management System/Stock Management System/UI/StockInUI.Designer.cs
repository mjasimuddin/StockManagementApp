namespace StockManagementSystemApp.UI
{
    partial class StockInUI
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
            this.companyLabel = new System.Windows.Forms.Label();
            this.companyInComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemInComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stockInTextBox = new System.Windows.Forms.TextBox();
            this.stockInSaveBtn = new System.Windows.Forms.Button();
            this.reorderInTextBox = new System.Windows.Forms.TextBox();
            this.availableQtyInTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(117, 30);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(77, 21);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Company";
            // 
            // companyInComboBox
            // 
            this.companyInComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyInComboBox.FormattingEnabled = true;
            this.companyInComboBox.Location = new System.Drawing.Point(247, 30);
            this.companyInComboBox.Name = "companyInComboBox";
            this.companyInComboBox.Size = new System.Drawing.Size(410, 29);
            this.companyInComboBox.TabIndex = 0;
            this.companyInComboBox.SelectedIndexChanged += new System.EventHandler(this.companyInComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item";
            // 
            // itemInComboBox
            // 
            this.itemInComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemInComboBox.FormattingEnabled = true;
            this.itemInComboBox.Location = new System.Drawing.Point(247, 70);
            this.itemInComboBox.Name = "itemInComboBox";
            this.itemInComboBox.Size = new System.Drawing.Size(410, 29);
            this.itemInComboBox.TabIndex = 1;
            this.itemInComboBox.SelectedIndexChanged += new System.EventHandler(this.itemInComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reorder Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Available Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stock-In Quantity";
            // 
            // stockInTextBox
            // 
            this.stockInTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.stockInTextBox.Location = new System.Drawing.Point(247, 214);
            this.stockInTextBox.Multiline = true;
            this.stockInTextBox.Name = "stockInTextBox";
            this.stockInTextBox.Size = new System.Drawing.Size(410, 33);
            this.stockInTextBox.TabIndex = 4;
            this.stockInTextBox.Text = "0";
            // 
            // stockInSaveBtn
            // 
            this.stockInSaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInSaveBtn.Location = new System.Drawing.Point(550, 272);
            this.stockInSaveBtn.Name = "stockInSaveBtn";
            this.stockInSaveBtn.Size = new System.Drawing.Size(107, 40);
            this.stockInSaveBtn.TabIndex = 5;
            this.stockInSaveBtn.Text = "Save";
            this.stockInSaveBtn.UseVisualStyleBackColor = true;
            this.stockInSaveBtn.Click += new System.EventHandler(this.stockInSaveBtn_Click);
            // 
            // reorderInTextBox
            // 
            this.reorderInTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderInTextBox.Location = new System.Drawing.Point(247, 112);
            this.reorderInTextBox.Multiline = true;
            this.reorderInTextBox.Name = "reorderInTextBox";
            this.reorderInTextBox.ReadOnly = true;
            this.reorderInTextBox.Size = new System.Drawing.Size(410, 32);
            this.reorderInTextBox.TabIndex = 6;
            this.reorderInTextBox.TextChanged += new System.EventHandler(this.reorderInComboBox_TextChanged);
            // 
            // availableQtyInTextBox
            // 
            this.availableQtyInTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQtyInTextBox.Location = new System.Drawing.Point(247, 161);
            this.availableQtyInTextBox.Multiline = true;
            this.availableQtyInTextBox.Name = "availableQtyInTextBox";
            this.availableQtyInTextBox.ReadOnly = true;
            this.availableQtyInTextBox.Size = new System.Drawing.Size(410, 30);
            this.availableQtyInTextBox.TabIndex = 6;
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 408);
            this.Controls.Add(this.availableQtyInTextBox);
            this.Controls.Add(this.reorderInTextBox);
            this.Controls.Add(this.stockInSaveBtn);
            this.Controls.Add(this.stockInTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemInComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyInComboBox);
            this.Controls.Add(this.companyLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StockInUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockInUI";
            this.Load += new System.EventHandler(this.StockInUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.ComboBox companyInComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemInComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stockInTextBox;
        private System.Windows.Forms.Button stockInSaveBtn;
        private System.Windows.Forms.TextBox reorderInTextBox;
        private System.Windows.Forms.TextBox availableQtyInTextBox;
    }
}