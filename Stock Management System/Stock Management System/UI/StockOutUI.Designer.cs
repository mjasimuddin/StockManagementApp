namespace StockManagementSystemApp.UI
{
    partial class StockOutUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemOutComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyOutComboBox = new System.Windows.Forms.ComboBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.stockOutQtyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stockOutAddBtn = new System.Windows.Forms.Button();
            this.stockOutListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reorderOutTextBox = new System.Windows.Forms.TextBox();
            this.stockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.sellBtn = new System.Windows.Forms.Button();
            this.demageBtn = new System.Windows.Forms.Button();
            this.lostBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reorder Level";
            // 
            // itemOutComboBox
            // 
            this.itemOutComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOutComboBox.FormattingEnabled = true;
            this.itemOutComboBox.Location = new System.Drawing.Point(209, 52);
            this.itemOutComboBox.Name = "itemOutComboBox";
            this.itemOutComboBox.Size = new System.Drawing.Size(467, 29);
            this.itemOutComboBox.TabIndex = 1;
            this.itemOutComboBox.SelectedIndexChanged += new System.EventHandler(this.itemOutComboBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // companyOutComboBox
            // 
            this.companyOutComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyOutComboBox.FormattingEnabled = true;
            this.companyOutComboBox.Location = new System.Drawing.Point(209, 17);
            this.companyOutComboBox.Name = "companyOutComboBox";
            this.companyOutComboBox.Size = new System.Drawing.Size(467, 29);
            this.companyOutComboBox.TabIndex = 0;
            this.companyOutComboBox.SelectedIndexChanged += new System.EventHandler(this.companyOutComboBox_SelectedIndexChanged_1);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(35, 20);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(123, 21);
            this.companyLabel.TabIndex = 5;
            this.companyLabel.Text = "Company Name";
            // 
            // stockOutQtyTextBox
            // 
            this.stockOutQtyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutQtyTextBox.Location = new System.Drawing.Point(209, 123);
            this.stockOutQtyTextBox.Name = "stockOutQtyTextBox";
            this.stockOutQtyTextBox.ReadOnly = true;
            this.stockOutQtyTextBox.Size = new System.Drawing.Size(467, 29);
            this.stockOutQtyTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // stockOutAddBtn
            // 
            this.stockOutAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutAddBtn.Location = new System.Drawing.Point(573, 193);
            this.stockOutAddBtn.Name = "stockOutAddBtn";
            this.stockOutAddBtn.Size = new System.Drawing.Size(103, 30);
            this.stockOutAddBtn.TabIndex = 5;
            this.stockOutAddBtn.Text = "Add";
            this.stockOutAddBtn.UseVisualStyleBackColor = true;
            this.stockOutAddBtn.Click += new System.EventHandler(this.stockOutAddBtn_Click);
            // 
            // stockOutListView
            // 
            this.stockOutListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stockOutListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.stockOutListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutListView.FullRowSelect = true;
            this.stockOutListView.GridLines = true;
            this.stockOutListView.Location = new System.Drawing.Point(144, 239);
            this.stockOutListView.Name = "stockOutListView";
            this.stockOutListView.Size = new System.Drawing.Size(563, 226);
            this.stockOutListView.TabIndex = 6;
            this.stockOutListView.UseCompatibleStateImageBehavior = false;
            this.stockOutListView.View = System.Windows.Forms.View.Details;
            this.stockOutListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.stockOutListView.Click += new System.EventHandler(this.stockOutListView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S.I";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item ID";
            this.columnHeader5.Width = 90;
            // 
            // reorderOutTextBox
            // 
            this.reorderOutTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderOutTextBox.Location = new System.Drawing.Point(209, 87);
            this.reorderOutTextBox.Name = "reorderOutTextBox";
            this.reorderOutTextBox.ReadOnly = true;
            this.reorderOutTextBox.Size = new System.Drawing.Size(467, 29);
            this.reorderOutTextBox.TabIndex = 4;
            // 
            // stockOutQuantityTextBox
            // 
            this.stockOutQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutQuantityTextBox.Location = new System.Drawing.Point(209, 158);
            this.stockOutQuantityTextBox.Name = "stockOutQuantityTextBox";
            this.stockOutQuantityTextBox.Size = new System.Drawing.Size(467, 29);
            this.stockOutQuantityTextBox.TabIndex = 4;
            // 
            // sellBtn
            // 
            this.sellBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBtn.Location = new System.Drawing.Point(273, 461);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(103, 30);
            this.sellBtn.TabIndex = 5;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // demageBtn
            // 
            this.demageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demageBtn.Location = new System.Drawing.Point(392, 461);
            this.demageBtn.Name = "demageBtn";
            this.demageBtn.Size = new System.Drawing.Size(103, 30);
            this.demageBtn.TabIndex = 5;
            this.demageBtn.Text = "Demage";
            this.demageBtn.UseVisualStyleBackColor = true;
            this.demageBtn.Click += new System.EventHandler(this.demageBtn_Click);
            // 
            // lostBtn
            // 
            this.lostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostBtn.Location = new System.Drawing.Point(513, 461);
            this.lostBtn.Name = "lostBtn";
            this.lostBtn.Size = new System.Drawing.Size(103, 30);
            this.lostBtn.TabIndex = 5;
            this.lostBtn.Text = "Lost";
            this.lostBtn.UseVisualStyleBackColor = true;
            this.lostBtn.Click += new System.EventHandler(this.lostBtn_Click);
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 491);
            this.Controls.Add(this.stockOutListView);
            this.Controls.Add(this.lostBtn);
            this.Controls.Add(this.demageBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.stockOutAddBtn);
            this.Controls.Add(this.reorderOutTextBox);
            this.Controls.Add(this.stockOutQuantityTextBox);
            this.Controls.Add(this.stockOutQtyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemOutComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyOutComboBox);
            this.Controls.Add(this.companyLabel);
            this.Name = "StockOutUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox itemOutComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companyOutComboBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.TextBox stockOutQtyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button stockOutAddBtn;
        private System.Windows.Forms.ListView stockOutListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox reorderOutTextBox;
        private System.Windows.Forms.TextBox stockOutQuantityTextBox;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button demageBtn;
        private System.Windows.Forms.Button lostBtn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}