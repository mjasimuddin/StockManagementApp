using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class CompanyManager
    {
        private CompanyGateway aCompanyGateway = new CompanyGateway();
        public string SaveCompany(CompanyAdd aCompany)
        {
            if (aCompanyGateway.IsNameExist(aCompany.CompanyName))
            {
                return "Company Name Already Exists.";
            }
            int rowaffected = aCompanyGateway.SaveCompany(aCompany);
            if (rowaffected > 0)
            {
                return "Save Successfully.";
            }
            return "Save Failed.";
        }
        public List<CompanyAdd> GetAllCompanies()
        {
            return aCompanyGateway.GetAllCompanies();
        }

        public string UpdateCompany(CompanyAdd company)
        {
            int rowaffected = aCompanyGateway.UpdateCompany(company);
            if (rowaffected > 0)
            {
                return "Update successfully.";
            }
            return "Update failed.";
        }
    }
}
