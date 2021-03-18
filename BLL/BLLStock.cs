using BO;
using DAL;
using ProjectInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLStock : IStock
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();
        public int AddNewStock(StockDetails sd)
        {
            tblStock ts = new tblStock();
            ts.StockNo = sd.StockNo;
            ts.ProductID = sd.ProductID;
            ts.SupplierID = sd.SupplierID;
            ts.Quantity = sd.Quantity;
            ts.Date = DateTime.Now;
            _db.tblStocks.Add(ts);
            return _db.SaveChanges();
        }

        public int DeleteStock(int stockid)
        {
            tblStock ts = _db.tblStocks.Where(s =>s.StockID == stockid).FirstOrDefault();
            _db.tblStocks.Remove(ts);
            return _db.SaveChanges();
        }

        public List<StockDetails> GetAllStock()
        {
            List<StockDetails> lstst = new List<StockDetails>();
            var stock = _db.tblStocks.ToList();
            foreach (var item in stock)
            {
                lstst.Add(new StockDetails() { StockID = item.StockID, StockNo = item.StockNo, ProductID = item.tblProduct. PID,ProductName=item.tblProduct.ProductName, SupplierID = item.tblSupplier.S_ID,SupplierName=item.tblSupplier.S_Name, Quantity = item.Quantity, Date = item.Date });
            }
            return lstst;
        }

        public int UpdateStock(StockDetails sd)
        {
            tblStock ts = _db.tblStocks.Where(s => s.StockID == sd.StockID).FirstOrDefault();
            ts.StockID = sd.StockID;
            ts.StockNo = sd.StockNo;
            ts.ProductID = sd.ProductID;
            ts.SupplierID = sd.SupplierID;
            ts.Quantity = sd.Quantity;
            ts.Date = DateTime.Now;
            return _db.SaveChanges();
        }
    }
}
