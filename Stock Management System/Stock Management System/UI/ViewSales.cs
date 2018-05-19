using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;
using Font = System.Drawing.Font;
using Rectangle = System.Drawing.Rectangle;

namespace StockManagementSystemApp.UI
{
    public partial class ViewSales : Form
    {
        private PdfDateRange PdfRange = new PdfDateRange();
        private SalesManager aSalesManager = new SalesManager();

        private DateTime fromDateGlobal = DateTime.Now.Date;
        private DateTime toDateGlobal = DateTime.Now.Date;
        public ViewSales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {

        }

        private void viewSalesSearchBtn_Click(object sender, EventArgs e)
        {

        }
        private int rowcount = 0;
        private void salesViewBtn_Click(object sender, EventArgs e)
        {
            salesListView.Items.Clear();

            DateTime fromDate = fromDateTimePicker.Value;
            DateTime toDate = toDateTimePicker.Value;
            foreach (ViewSalesReport item in aSalesManager.GetSalesAllItems(fromDate, toDate))
            {
                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = (++rowcount).ToString();
                viewItem.SubItems.Add(item.ItemName.Trim());
                viewItem.SubItems.Add(item.Quantity.ToString());
                viewItem.Tag = item;
                salesListView.Items.Add(viewItem);
            }
            PdfRange.FromDate = fromDate;
            PdfRange.ToDate = toDate;
        }
        
        private void salesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void printSalesButton_Click(object sender, EventArgs e)
        {
            if (salesListView.Items.Count.Equals(0))
            {
                MessageBox.Show("There are no data to be generated");
            }
            else
            {
                string result = PdfSalesManager.GenerateItemSalesPdf(salesListView);
                MessageBox.Show(result);
            }
        }
    }
}
