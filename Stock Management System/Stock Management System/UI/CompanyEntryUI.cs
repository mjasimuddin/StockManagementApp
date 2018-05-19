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


namespace StockManagementSystemApp
{
    public partial class CompanyEntryUI : Form
    {
        private CompanyManager aCompanyManager = new CompanyManager();
        public CompanyEntryUI()
        {
            InitializeComponent();
        }
        private void companySaveBtn_Click(object sender, EventArgs e)
        {
            count = 0;
            CompanyAdd aCompany = new CompanyAdd();
            aCompany.CompanyName = companyTextBox.Text;

            companyTextBox.Text = "";
            companyTextBox.Clear();
            companyTextBox.Focus();


            if(companySaveBtn.Text == "Save")
            {
                string message = aCompanyManager.SaveCompany(aCompany);
                MessageBox.Show(message);
            }
            else
            {
                aCompany.Id = Convert.ToInt32(hiddenIdLevel.Text);
                string message = aCompanyManager.UpdateCompany(aCompany);
                MessageBox.Show(message);
            }

            PopulateCompanyListView();
        }
        private int count = 0;
        private void CompanyEntryUI_Load(object sender, EventArgs e)
        {
            PopulateCompanyListView();
        }
        private void PopulateCompanyListView()
        {
            companyListView.Items.Clear();
            List<CompanyAdd> companies = aCompanyManager.GetAllCompanies();

            foreach (CompanyAdd company in companies)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (++count).ToString();
                item.SubItems.Add(company.CompanyName);
                item.Tag = company;

                companyListView.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void companyListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void companyListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = companyListView.SelectedItems[0];
            CompanyAdd company = selectedItem.Tag as CompanyAdd;
            if (company != null)
            {
                companyTextBox.Text = company.CompanyName;
                hiddenIdLevel.Text = company.Id.ToString();

                companySaveBtn.Text = "Update";
            }
        }

        private void hiddenIdLevel_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            companyTextBox.Clear();

            companySaveBtn.Text = "Save";
        }
    }
}
