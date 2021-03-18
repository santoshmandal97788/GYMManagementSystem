using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
   public  interface ICustomer
    {
        List<CustomerDetails> GetAllCustomer();
        int AddNewCustomer(CustomerDetails cd);
        int UpdateCustomer(CustomerDetails cd);
        int DeleteCustomer(int customerid);
        //bool CheckCustomer(string customerName);
        int GetCustomerById(int customerid);
    }
}
