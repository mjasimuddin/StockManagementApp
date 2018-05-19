using System;
using System.Windows.Forms;

namespace StockManagementSystemApp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryEntryUi categoryList = new CategoryEntryUi();
            categoryList.Show();
        }

        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyEntryUI CompanyList = new CompanyEntryUI();
            CompanyList.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemEntryUI item = new ItemEntryUI();
            item.Show();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInUI stockInList = new StockInUI();
            stockInList.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutUI stockOutList = new StockOutUI();
            stockOutList.Show();
        }

        private void itemSammeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchViewItems itemSammary = new SearchViewItems();
            itemSammary.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSales salesReport = new ViewSales();
            salesReport.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
