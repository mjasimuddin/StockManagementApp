using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class StockInUI : Form
    {
        private StockInManager aStockInManager = new StockInManager();
        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();

        public StockInUI()
        {
            InitializeComponent();
        }
        private void StockInClear()
        {
            companyInComboBox.Text = "";
            itemInComboBox.Text = "";
            reorderInTextBox.Clear();
            availableQtyInTextBox.Clear();
            stockInTextBox.Clear();
        }

        private void StockInUI_Load(object sender, EventArgs e)
        {
            // Company
            CompanyAdd defaultCompany = new CompanyAdd();
            defaultCompany.Id = -1;
            defaultCompany.CompanyName = "--Select--";
            List<CompanyAdd> companies = aCompanyManager.GetAllCompanies();
            companies.Insert(0, defaultCompany);
            companyInComboBox.DataSource = companies;
            companyInComboBox.DisplayMember = "CompanyName";
        }

        private void companyInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemWithCompany defaultItem = new ItemWithCompany();
            defaultItem.Id = -1;
            defaultItem.ItemName = "--Select--";
            List<ItemWithCompany> items = aItemManager.GetAllItems(companyInComboBox.Text);
            items.Insert(0, defaultItem);
            itemInComboBox.DataSource = items;
            itemInComboBox.DisplayMember = "ItemName";
            itemInComboBox.ValueMember = "Id";
        }


        private void stockInSaveBtn_Click(object sender, EventArgs e)
        {
            StockIn aStockIn = new StockIn();
            aStockIn.ItemId = Convert.ToInt32(itemInComboBox.SelectedValue);
            aStockIn.StokInQuantity = Convert.ToInt32(stockInTextBox.Text);


            if (stockInSaveBtn.Text == "Save")
            {
                string message = aStockInManager.SaveStockIn(aStockIn);
                MessageBox.Show(message);
            }
            StockInClear();

        }

        private void itemInComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(itemInComboBox.SelectedValue is int)
            {
                if (aStockInManager.SearchAvailableQuantity((int)itemInComboBox.SelectedValue).Rows.Count > 0)
                {
                    availableQtyInTextBox.Text = aStockInManager.SearchAvailableQuantity((int)itemInComboBox.SelectedValue).Rows[0]["result"].ToString();
                }
            }
            if (aStockInManager.SearchReorderLevel(itemInComboBox.Text).Rows.Count > 0)
            {
                reorderInTextBox.Text = aStockInManager.SearchReorderLevel(itemInComboBox.Text).Rows[0]["ReorderLevel"]
                    .ToString();
            }
            //if (aStockInManager.SearchAvailableQuantity(Convert.ToInt32(itemInComboBox.SelectedValue)).Rows.Count > 0)
            //{
            //    availableQtyInTextBox.Text = aStockInManager.SearchAvailableQuantity(Convert.ToInt32(itemInComboBox.SelectedValue)).Rows[0]["AvaiableQuantity"].ToString();
            //}
        }

        private void reorderInComboBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
