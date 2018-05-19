namespace StockManagementSystemApp.UI
{
    partial class SearchViewItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.companySummaryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categorySummaryComboBox = new System.Windows.Forms.ComboBox();
            this.seachViewBtn = new System.Windows.Forms.Button();
            this.summaryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printSummaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // companySummaryComboBox
            // 
            this.companySummaryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySummaryComboBox.FormattingEnabled = true;
            this.companySummaryComboBox.Location = new System.Drawing.Point(159, 10);
            this.companySummaryComboBox.Name = "companySummaryComboBox";
            this.companySummaryComboBox.Size = new System.Drawing.Size(461, 29);
            this.companySummaryComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // categorySummaryComboBox
            // 
            this.categorySummaryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySummaryComboBox.FormattingEnabled = true;
            this.categorySummaryComboBox.Location = new System.Drawing.Point(159, 55);
            this.categorySummaryComboBox.Name = "categorySummaryComboBox";
            this.categorySummaryComboBox.Size = new System.Drawing.Size(461, 29);
            this.categorySummaryComboBox.TabIndex = 1;
            // 
            // seachViewBtn
            // 
            this.seachViewBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seachViewBtn.Location = new System.Drawing.Point(533, 90);
            this.seachViewBtn.Name = "seachViewBtn";
            this.seachViewBtn.Size = new System.Drawing.Size(87, 35);
            this.seachViewBtn.TabIndex = 2;
            this.seachViewBtn.Text = "Search";
            this.seachViewBtn.UseVisualStyleBackColor = true;
            this.seachViewBtn.Click += new System.EventHandler(this.seachViewBtn_Click);
            // 
            // summaryListView
            // 
            this.summaryListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.summaryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.summaryListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryListView.ForeColor = System.Drawing.Color.Black;
            this.summaryListView.FullRowSelect = true;
            this.summaryListView.GridLines = true;
            this.summaryListView.Location = new System.Drawing.Point(99, 131);
            this.summaryListView.Name = "summaryListView";
            this.summaryListView.Size = new System.Drawing.Size(609, 237);
            this.summaryListView.TabIndex = 3;
            this.summaryListView.UseCompatibleStateImageBehavior = false;
            this.summaryListView.View = System.Windows.Forms.View.Details;
            this.summaryListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S.I";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Category";
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Av.Qty";
            this.columnHeader5.Width = 49;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Reorder L.";
            this.columnHeader6.Width = 74;
            // 
            // printSummaryButton
            // 
            this.printSummaryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSummaryButton.Location = new System.Drawing.Point(611, 374);
            this.printSummaryButton.Name = "printSummaryButton";
            this.printSummaryButton.Size = new System.Drawing.Size(97, 32);
            this.printSummaryButton.TabIndex = 4;
            this.printSummaryButton.Text = "Print";
            this.printSummaryButton.UseVisualStyleBackColor = true;
            this.printSummaryButton.Click += new System.EventHandler(this.printSummaryButton_Click);
            // 
            // SearchViewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 408);
            this.Controls.Add(this.printSummaryButton);
            this.Controls.Add(this.summaryListView);
            this.Controls.Add(this.seachViewBtn);
            this.Controls.Add(this.categorySummaryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companySummaryComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchViewItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchViewItems";
            this.Load += new System.EventHandler(this.SearchViewItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox companySummaryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorySummaryComboBox;
        private System.Windows.Forms.Button seachViewBtn;
        private System.Windows.Forms.ListView summaryListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button printSummaryButton;
    }
}