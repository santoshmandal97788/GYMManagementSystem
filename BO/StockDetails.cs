using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class StockDetails
    {
        public int StockID { get; set; }
        public string StockNo { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int Quantity { get; set; }
        public System.DateTime Date { get; set; }
    }
}
