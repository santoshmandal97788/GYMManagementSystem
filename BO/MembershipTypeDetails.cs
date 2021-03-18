using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class MembershipTypeDetails
    {
        public int MT_ID { get; set; }
        public string MembershipType { get; set; }
        public decimal ChargesPerMonth { get; set; }
        public decimal ServiceTAX { get; set; }
        public decimal VAT { get; set; }
    }
}
