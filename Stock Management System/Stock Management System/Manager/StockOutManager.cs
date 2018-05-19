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
    class StockOutManager
    {

        private StockOutGateway aStockOutGateway = new StockOutGateway();
        private CompanyGateway aCompanyGateway = new CompanyGateway();
        private ItemGateway aItemGateway = new ItemGateway();
        public List<CompanyAdd> GetAllCompanies()
        {
            return aCompanyGateway.GetAllCompanies();
        }
        public DataTable SearchReorderLevel(string itemName)
        {
            return aStockOutGateway.SearchReorderLevel(itemName);
        }
        public DataTable SearchAvailableQuantity(int ItemId)
        {
            return aStockOutGateway.SearchAvailableQuantity(ItemId);
        }

        public void SellStockOut(StockOut aStockOut)
        {
            aStockOutGateway.SellStockOut(aStockOut);
            //int rowAffected = aStockOutGateway.SellStockOut(aStockOut);
            //if (rowAffected > 0)
            //{
            //    return "Save Successfull.";
            //}
            //return "Save Failed.";
        }
    }
}
