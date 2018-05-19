using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class SalesManager
    {
        private SalesGateway aSalesGateway = new SalesGateway();
        //private CategoryGateway aProductGateway = new CategoryGateway();
        //private CompanyGateway aCompanyGateway = new CompanyGateway();



        public List<ViewSalesReport> GetSalesAllItems(DateTime fromDate, DateTime toDate)
        {
            return aSalesGateway.GetSalesAllItems(fromDate, toDate);
        }
    }
}
