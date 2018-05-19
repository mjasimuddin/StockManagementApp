using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model
{
    class StockOutAdd
    {
        public string Item { set; get; }
        public int ItemId { get; set; }
        public string Company { set; get; }
        public int Quantity { set; get; }
    }
}
