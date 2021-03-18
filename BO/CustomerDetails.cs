using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class CustomerDetails
    {
        public int C_ID { get; set; }
        public string CustomerNo { get; set; }
        public string C_Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public byte[] Photo { get; set; }
    }
}
