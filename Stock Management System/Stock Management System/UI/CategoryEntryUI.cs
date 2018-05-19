using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class CategoryEntryUi : Form
    {
        private CategoryManager aCategoryManager = new CategoryManager();
        public CategoryEntryUi()
        {
            InitializeComponent();
        }

        private void productSaveBtn_Click(object sender, EventArgs e)
        {
            rowcount = 0;
            CategoryAdd aCategory = new CategoryAdd();
            aCategory.Category = categoryTextBox.Text;

            categoryTextBox.Text = "";
            categoryTextBox.Clear();
            categoryTextBox.Focus();

            if (categorySaveBtn.Text == "Save")
            {
                string message = aCategoryManager.SaveCategory(aCategory);
                MessageBox.Show(message);
            }
            else
            {
                aCategory.Id = Convert.ToInt32(hiddenIdLevel.Text);
                string message = aCategoryManager.UpdateCategory(aCategory);
                MessageBox.Show(message);
            }

            PopulateCategoryListView();
        }

        private void ProductEntryUI_Load(object sender, EventArgs e)
        {
            PopulateCategoryListView();
        }

        private int rowcount = 0;
        private void PopulateCategoryListView()
        {
            categoryListView.Items.Clear();
            List<CategoryAdd> categories = aCategoryManager.GetAllCategory();
            foreach (CategoryAdd category in categories)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (++rowcount).ToString();
                item.SubItems.Add(category.Category);
                item.Tag = category;

                categoryListView.Items.Add(item);
            }
        }
        private void categoryListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = categoryListView.SelectedItems[0];
            CategoryAdd category = selectedItem.Tag as CategoryAdd;
            if (category != null)
            {
                categoryTextBox.Text = category.Category;
                hiddenIdLevel.Text = category.Id.ToString();

                categorySaveBtn.Text = "Update";
            }
        }

        private void hiddenIdLevel_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            categoryTextBox.Clear();

            categorySaveBtn.Text = "Save";
        }
    }
}
