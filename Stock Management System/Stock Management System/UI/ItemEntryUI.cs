using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class ItemEntryUI : Form
    {
        private ItemManager aItemManager = new ItemManager();
        private CategoryManager aCategoryManager = new CategoryManager();
        private CompanyManager aCompanyManager = new CompanyManager();

        public ItemEntryUI()
        {
            InitializeComponent();
        }

        private void ItemClear()
        {
            itemCategoryComboBox.Text = "";
            itemCompanyNameComboBox.Text = "";
            itemNameTextBox.Clear();
            reorderTextBox.Clear();
        }
        private void itemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemEntryUI_Load(object sender, EventArgs e)
        {
            //Product
            CategoryAdd defaultCategory = new CategoryAdd();
            defaultCategory.Id = -1;
            defaultCategory.Category = "--Select--";
            List<CategoryAdd> categories = aCategoryManager.GetAllCategory();
            categories.Insert(0, defaultCategory);
            itemCategoryComboBox.DataSource = categories;
            itemCategoryComboBox.DisplayMember = "Category";
            itemCategoryComboBox.ValueMember = "Id";

            // Company
            CompanyAdd defaultCompany = new CompanyAdd();
            defaultCompany.Id = -1;
            defaultCompany.CompanyName = "--Select--";
            List<CompanyAdd> companies = aCompanyManager.GetAllCompanies();

            companies.Insert(0, defaultCompany);
            itemCompanyNameComboBox.DataSource = companies;
            itemCompanyNameComboBox.DisplayMember = "CompanyName";
            itemCompanyNameComboBox.ValueMember = "Id";
        }

        private void itemSaveBtn_Click(object sender, EventArgs e)
        {
            ItemAdd aItem = new ItemAdd();
            aItem.CategoryId = Convert.ToInt32(itemCategoryComboBox.SelectedValue);
            aItem.CompanyId = Convert.ToInt32(itemCompanyNameComboBox.SelectedValue);
            aItem.ItemName = itemNameTextBox.Text;
            aItem.ReorderLevel = Convert.ToInt32(reorderTextBox.Text);
            if (itemSaveBtn.Text == "Save")
            {
                string message = aItemManager.SaveItem(aItem);
                MessageBox.Show(message);
            }
            ItemClear();
        }
    }
}
