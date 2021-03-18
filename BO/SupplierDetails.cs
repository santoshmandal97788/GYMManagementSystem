using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SupplierDetails
    {
        public int S_ID { get; set; }
        public string SupplierNo { get; set; }
        public string S_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public byte[] Photo { get; set; }
    }
}
