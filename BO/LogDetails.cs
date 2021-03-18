using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LogDetails
    {
        public int LId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Operation { get; set; }

    }
}
