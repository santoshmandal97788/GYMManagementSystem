using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class ProductDetails
    {
    
        public int PID { get; set; }
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public string Category { get; set; }
        public string Features { get; set; }
        public decimal VAT { get; set; }
        public decimal ServiceTAX { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; }
    }
}
