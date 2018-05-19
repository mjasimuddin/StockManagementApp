using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Gateway;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.Manager
{
    class CategoryManager
    {
        private CategoryGateway aCategoryGateway = new CategoryGateway();
        public string SaveCategory(CategoryAdd aCategory)
        {
            if (aCategoryGateway.IsNameExist(aCategory.Category))
            {
                return "Category Name Already Exists.";
            }
            int rowaffected = aCategoryGateway.SaveProduct(aCategory);
            if (rowaffected > 0)
            {
                return "Save Successfully.";
            }
            return "Save Failed.";
        }
        public List<CategoryAdd> GetAllCategory()
        {
            return aCategoryGateway.GetAllCategory();
        }

        public string UpdateCategory(CategoryAdd category)
        {
            int rowaffected = aCategoryGateway.UpdateCategory(category);
            if (rowaffected > 0)
            {
                return "Update successfully.";
            }
            return "Update failed.";
        }
    }
}
