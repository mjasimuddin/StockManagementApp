using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class SearchViewItems : Form
    {
        private SearchManager aSearchManager = new SearchManager();
        private CategoryManager aCategoryManager = new CategoryManager();
        private CompanyManager aCompanyManager = new CompanyManager();
        public SearchViewItems()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void SearchViewItems_Load(object sender, EventArgs e)
        {
            //Product
            CategoryAdd defaultCategory = new CategoryAdd();
            defaultCategory.Id = -1;
            defaultCategory.Category = "--Select--";
            List<CategoryAdd> categories = aCategoryManager.GetAllCategory();
            categories.Insert(0, defaultCategory);
            categorySummaryComboBox.DataSource = categories;
            categorySummaryComboBox.DisplayMember = "Category";
            categorySummaryComboBox.ValueMember = "Id";

            // Company
            CompanyAdd defaultCompany = new CompanyAdd();
            defaultCompany.Id = -1;
            defaultCompany.CompanyName = "--Select--";
            List<CompanyAdd> companies = aCompanyManager.GetAllCompanies();

            companies.Insert(0, defaultCompany);
            companySummaryComboBox.DataSource = companies;
            companySummaryComboBox.DisplayMember = "CompanyName";
            companySummaryComboBox.ValueMember = "Id";
        }

        private int rowcount = 0;
        private void seachViewBtn_Click(object sender, EventArgs e)
        {
            summaryListView.Items.Clear();
            rowcount = 0;

            string category = categorySummaryComboBox.Text.Trim();
            string company = companySummaryComboBox.Text.Trim();

            if (categorySummaryComboBox.SelectedIndex.Equals(0))
            {
                category = "";
            }
            if (companySummaryComboBox.SelectedIndex.Equals(0))
            {
                company = "";
            }
            foreach (ViewItemSummary item in aSearchManager.GetSearchAllItems(company, category))
            {
                ListViewItem viewItem = new ListViewItem();
                viewItem.Text = (++rowcount).ToString();
                viewItem.SubItems.Add(item.ItemName.Trim());
                viewItem.SubItems.Add(item.CompanyName.Trim());
                viewItem.SubItems.Add(item.CategoryName.Trim());
                viewItem.SubItems.Add(item.AvailableQuantity.ToString());
                viewItem.SubItems.Add(item.ReorderLevel.ToString());
                viewItem.Tag = item;
                summaryListView.Items.Add(viewItem);
            }
                   
        }

        private void printSummaryButton_Click(object sender, EventArgs e)
        {
            if (summaryListView.Items.Count.Equals(0))
            {
                MessageBox.Show("There are no data to be generated");
            }
            else
            {
                string result = PdfSummaryManager.GenerateItemSummaryPdf(summaryListView);
                MessageBox.Show(result);
            }
        }
    }
}
