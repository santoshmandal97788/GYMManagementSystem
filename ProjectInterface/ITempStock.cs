using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
   public  interface ITempStock
    {
        int AddNewTempStock(TempStockDetails tsd);
        int UpdateExistingTempStock(TempStockDetails tsd);
        bool CheckExistingProductStockById(int id);
    }
}
