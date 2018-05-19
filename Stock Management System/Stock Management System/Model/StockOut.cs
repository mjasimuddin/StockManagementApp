using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model
{
    public class StockOut
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Item { set; get; }
        public string Company { set; get; }
        public int Quantity { get; set; }
        public string Type { get; set; }

    }
}
