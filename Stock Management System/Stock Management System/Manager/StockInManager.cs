using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class StockInManager
    {
        private StockInGateway aStockInGateway = new StockInGateway();
        private CompanyGateway aCompanyGateway = new CompanyGateway();
        private ItemGateway aItemGateway = new ItemGateway();

        public List<CompanyAdd> GetAllCompanies()
        {
            return aCompanyGateway.GetAllCompanies();
        }
        public DataTable SearchReorderLevel(string itemName)
        {
            return aStockInGateway.SearchReorderLevel(itemName);
        }
        public DataTable SearchAvailableQuantity(int ItemId)
        {
            return aStockInGateway.SearchAvailableQuantity(ItemId);
        }

        public string SaveStockIn(StockIn aStockIn)
        {
            int rowAffected = aStockInGateway.SaveStockIn(aStockIn);
            if (rowAffected > 0)
            {
                return "Save Successfull.";
            }
            return "Save Failed.";
        }
    }
}
