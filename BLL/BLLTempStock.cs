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
    public class BLLTempStock : ITempStock
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();
        public int AddNewTempStock(TempStockDetails tsd)
        {
            tblTemp_Stock tts = new tblTemp_Stock();
            //tblProduct tp = new tblProduct();
            tblStock ts = new tblStock();
            tts.ProductID = tsd.ProductID;
            tts.Quantity = tsd.Quantity;
            _db.tblTemp_Stock.Add(tts);
            return _db.SaveChanges();
        }

        public bool CheckExistingProductStockById(int id)
        {
            var tempstock = _db.tblTemp_Stock.Where(s => s.ProductID == id).FirstOrDefault();
            if (tempstock != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int UpdateExistingTempStock(TempStockDetails tsd)
        {
            tblTemp_Stock tts = _db.tblTemp_Stock.Where(s => s.ProductID == tsd.ProductID).FirstOrDefault();
            tts.ProductID = tsd.ProductID;
            //tblTemp_Stock ttq = _db.tblTemp_Stock.Where(s => s.Quantity == tsd.Quantity).FirstOrDefault();
            //ttq.Quantity = tsd.Quantity;
            tts.Quantity = (tsd.Quantity + tts.Quantity);
            return _db.SaveChanges();
        }


       

    }
}
