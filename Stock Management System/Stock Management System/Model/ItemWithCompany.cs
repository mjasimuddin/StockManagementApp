using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model
{
    class ItemWithCompany
    {
        public int Id { get; set; }
        public int CompanyId { set; get; }
        public string CompanyName { set; get; }
        public string ItemName { set; get; }
        public int ReorderLevel { set; get; }
    }
}
