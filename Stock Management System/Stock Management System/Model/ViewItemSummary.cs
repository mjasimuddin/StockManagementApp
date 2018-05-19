using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model
{
    class ViewItemSummary
    {
        public int SI { set; get; }
        public string ItemName { set; get; }
        public string CompanyName { set; get; }
        public string CategoryName { set; get; }
        public int AvailableQuantity { set; get; }
        public int ReorderLevel { set; get; }
    }
}
