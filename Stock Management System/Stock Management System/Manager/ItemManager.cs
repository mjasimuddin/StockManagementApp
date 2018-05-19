using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class ItemManager
    {
        private ItemGateway aItemGateway = new ItemGateway();
        private CategoryGateway aProductGateway = new CategoryGateway();
        private CompanyGateway aCompanyGateway = new CompanyGateway();


        public List<ItemWithCompany> GetAllItems(string company)
        {
            return aItemGateway.GetAllItems(company);
        }
        public List<CategoryAdd> GetAllProducts()
        {
            return aProductGateway.GetAllCategory();
        }
        public List<CompanyAdd> GetAllCompanies()
        {
            return aCompanyGateway.GetAllCompanies();
        }

        public string SaveItem(ItemAdd aItem)
        {
            if (aItemGateway.IsItemNameExist(aItem.ItemName))
            {
                return "Product Name Already Exists.";
            }
            int rowaffected = aItemGateway.SaveItem(aItem);
            if (rowaffected > 0)
            {
                return "Save Successfully.";
            }
            return "Save Failed.";
        }
    }
}
