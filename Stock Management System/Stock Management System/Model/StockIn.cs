using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApp.Model
{
    public class StockIn
    {
        public int Id { get; set; }
        public int ItemId { set; get; }
        public int ReorderLevel { get; set; }
        public int AvaiableQuantity { get; set; }
        public int StokInQuantity { set; get; }
    }
}
