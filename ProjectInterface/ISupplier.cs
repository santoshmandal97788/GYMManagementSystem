using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
    public interface ISupplier
    {
        List<SupplierDetails> GetAllSupplier();
        int AddNewSupplier(SupplierDetails sd);
        int UpdateSupplier(SupplierDetails sd);
        int DeleteSupplier(int supplierid);
        bool CheckSuppliername(string suppliername);

    }
}
