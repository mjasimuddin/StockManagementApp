using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Model;
using StockManagementSystemApp.Manager;


namespace StockManagementSystemApp.UI
{
    public partial class StockOutUI : Form
    {
        private StockOutManager aStockOutManager = new StockOutManager();
        private CompanyManager aCompanyManager = new CompanyManager();
        private ItemManager aItemManager = new ItemManager();

        public StockOutUI()
        {
            InitializeComponent();
        }
       
        private void StockOutClear()
        {
            companyOutComboBox.Text = "";
            itemOutComboBox.Text = "";
            reorderOutTextBox.Clear();
            stockOutQtyTextBox.Clear();
            stockOutQuantityTextBox.Clear();
        }
        int count = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            CompanyAdd defaultCompany = new CompanyAdd();
            defaultCompany.Id = -1;
            defaultCompany.CompanyName = "--Select--";
            List<CompanyAdd> companies = aItemManager.GetAllCompanies();
            companies.Insert(0, defaultCompany);
            companyOutComboBox.DataSource = companies;
            companyOutComboBox.DisplayMember = "CompanyName";

        }
        private void companyOutComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ItemWithCompany defaultItem = new ItemWithCompany();
            defaultItem.Id = -1;
            defaultItem.ItemName = "--Select--";
            List<ItemWithCompany> items = aItemManager.GetAllItems(companyOutComboBox.Text);
            items.Insert(0, defaultItem);
            itemOutComboBox.DataSource = items;
            itemOutComboBox.DisplayMember = "ItemName";
            itemOutComboBox.ValueMember = "Id";
        }

        
        private void stockOutAddBtn_Click(object sender, EventArgs e)
        {
            StockOut aStockOut = new StockOut();
            aStockOut.Company = companyOutComboBox.Text;
            aStockOut.Item = itemOutComboBox.Text;
            aStockOut.ItemId = Convert.ToInt32(itemOutComboBox.SelectedValue);
            aStockOut.Quantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
          
            ListViewItem item = new ListViewItem();
            item.Text = (++count).ToString();
            item.SubItems.Add(aStockOut.Item);
            item.SubItems.Add(aStockOut.Company);
            item.SubItems.Add(aStockOut.Quantity.ToString());
            item.SubItems.Add(aStockOut.ItemId.ToString());
            stockOutListView.Items.Add(item);
            
            StockOutClear();
        }
        private void itemOutComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (itemOutComboBox.SelectedValue is int)
            {
                if (aStockOutManager.SearchAvailableQuantity((int)itemOutComboBox.SelectedValue).Rows.Count > 0)
                {
                    stockOutQtyTextBox.Text = aStockOutManager.SearchAvailableQuantity((int)itemOutComboBox.SelectedValue).Rows[0]["result"].ToString();
                }
            }
            
            if (aStockOutManager.SearchReorderLevel(itemOutComboBox.Text).Rows.Count > 0)
            {
                reorderOutTextBox.Text = aStockOutManager.SearchReorderLevel(itemOutComboBox.Text).Rows[0]["ReorderLevel"]
                    .ToString();
            }
        }

        private void PopulateCompanyListView()
        {
            //stockOutListView.Items.Clear();
            //List<StockOutWithItems> stockOutWithItems = aStockOutManager.GetAllStockOutItems();
           // List<StockOutAdd> stockOutAddItems = aStockOutManager.GetAllStockOutAdd();


            //foreach (StockOutAdd company in stockOutAddItems)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.Text = (++count).ToString();
            //    item.SubItems.Add(company.Company);
            //    item.SubItems.Add(company.Item);
            //    item.SubItems.Add(company.Quantity.ToString());

            //    stockOutListView.Items.Add(item);
            //}
        }

        private void companyOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void itemOutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            int i;
            //count = 0;
            for (i = 0; i < stockOutListView.Items.Count; i++)
            {

                StockOut aStockOut = new StockOut();
                aStockOut.Id = Convert.ToInt32(stockOutListView.Items[i].SubItems[0].Text);
                aStockOut.ItemId = Convert.ToInt32(stockOutListView.Items[i].SubItems[4].Text);
                aStockOut.Quantity = Convert.ToInt32(stockOutListView.Items[i].SubItems[3].Text);
                aStockOut.Type = "S";
                aStockOutManager.SellStockOut(aStockOut);
            }
            if (i == stockOutListView.Items.Count)
            {
                MessageBox.Show("Sell");
            }
            stockOutListView.Items.Clear();
        }

        private void demageBtn_Click(object sender, EventArgs e)
        {
            int i;
            //count = 0;
            for (i = 0; i < stockOutListView.Items.Count; i++)
            {

                StockOut aStockOut = new StockOut();
                aStockOut.Id = Convert.ToInt32(stockOutListView.Items[i].SubItems[0].Text);
                aStockOut.ItemId = Convert.ToInt32(stockOutListView.Items[i].SubItems[4].Text);
                aStockOut.Quantity = Convert.ToInt32(stockOutListView.Items[i].SubItems[3].Text);
                aStockOut.Type = "D";
                aStockOutManager.SellStockOut(aStockOut);
            }
            if (i == stockOutListView.Items.Count)
            {
                MessageBox.Show("Demage");
            }
            stockOutListView.Items.Clear();
        }

        private void lostBtn_Click(object sender, EventArgs e)
        {
            int i;
            //count = 0;
            for (i = 0; i < stockOutListView.Items.Count; i++)
            {

                StockOut aStockOut = new StockOut();
                aStockOut.Id = Convert.ToInt32(stockOutListView.Items[i].SubItems[0].Text);
                aStockOut.ItemId = Convert.ToInt32(stockOutListView.Items[i].SubItems[4].Text);
                aStockOut.Quantity = Convert.ToInt32(stockOutListView.Items[i].SubItems[3].Text);
                aStockOut.Type = "L";
                aStockOutManager.SellStockOut(aStockOut);
            }
            if (i == stockOutListView.Items.Count)
            {
                MessageBox.Show("Lost");
            }
            stockOutListView.Items.Clear();
        }

        private void stockOutListView_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
