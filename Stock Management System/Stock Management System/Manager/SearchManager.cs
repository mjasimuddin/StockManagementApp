using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class SearchManager
    {
        private SearchGateway aSearchGateway = new SearchGateway();
        private CategoryGateway aProductGateway = new CategoryGateway();
        private CompanyGateway aCompanyGateway = new CompanyGateway();

        public List<CategoryAdd> GetAllProducts()
        {
            return aProductGateway.GetAllCategory();
        }
        public List<CompanyAdd> GetAllCompanies()
        {
            return aCompanyGateway.GetAllCompanies();
        }
        public List<ViewItemSummary> GetSearchAllItems(string company, string category)
        {
            return aSearchGateway.GetSearchAllItems(company, category);
        }
    }

}
