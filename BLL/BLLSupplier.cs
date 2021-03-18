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
    public class BLLSupplier : ISupplier
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();
        public int AddNewSupplier(SupplierDetails sd)
        {
            tblSupplier ts = new tblSupplier();
            ts.SupplierNo = sd.SupplierNo;
            ts.S_Name = sd.S_Name;
            ts.Address = sd.Address;
            ts.City = sd.City;
            ts.Email = sd.Email;
            ts.ContactNo = sd.ContactNo;
            ts.Photo = sd.Photo;
            _db.tblSuppliers.Add(ts);
            return _db.SaveChanges();
        }

        public bool CheckSuppliername(string suppliername)
        {
            var suppliers = _db.tblSuppliers.Where(s=> s.S_Name == suppliername).FirstOrDefault();
            if (suppliers != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteSupplier(int supplierid)
        {
            tblSupplier ts = _db.tblSuppliers.Where(s => s.S_ID == supplierid).FirstOrDefault();
            _db.tblSuppliers.Remove(ts);
            return _db.SaveChanges();
        }

        public List<SupplierDetails> GetAllSupplier()
        {
            List<SupplierDetails> lstsd = new List<SupplierDetails>();
            var suppliers = _db.tblSuppliers.ToList();
            foreach (tblSupplier item in suppliers)
            {
                lstsd.Add(new SupplierDetails() { S_ID = item.S_ID, SupplierNo = item.SupplierNo, S_Name = item.S_Name, Address = item.Address, City = item.City, Email = item.Email, ContactNo = item.ContactNo, Photo = item.Photo });
            }
            return lstsd;
        }

        public int UpdateSupplier(SupplierDetails sd)
        {
            tblSupplier ts = _db.tblSuppliers.Where(s => s.S_ID == sd.S_ID).FirstOrDefault();
            ts.S_ID = sd.S_ID;
            ts.SupplierNo = sd.SupplierNo;
            ts.S_Name = sd.S_Name;
            ts.Address = sd.Address;
            ts.City = sd.City;
            ts.Email = sd.Email;
            ts.ContactNo = sd.ContactNo;
            ts.Photo = sd.Photo;
            return _db.SaveChanges();
        }
    }
}
