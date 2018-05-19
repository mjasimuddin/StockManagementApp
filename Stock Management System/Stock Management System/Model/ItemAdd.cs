using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model
{
    class ItemAdd : Stock
    {
        public new int Id { get; set; }
        public int CategoryId { set; get; }
        public int CompanyId { set; get; }
        public string ItemName { set; get; }
        public int ReorderLevel { set; get; }
    }
}
