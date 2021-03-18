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
    public class BLLCustomer : ICustomer
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();
        public int AddNewCustomer(CustomerDetails cd)
        {
            tblCustomer tc = new tblCustomer();
            tc.CustomerNo = cd.CustomerNo;
            tc.C_Name = cd.C_Name;
            tc.Address = cd.Address;
            tc.Gender = cd.Gender;
            tc.City = cd.City;
            tc.Email = cd.Email;
            tc.ContactNo = cd.ContactNo;
            tc.Photo = cd.Photo;
            _db.tblCustomers.Add(tc);
            return _db.SaveChanges();

        }

        public int DeleteCustomer(int customerid)
        {
            tblCustomer tc = _db.tblCustomers.Where(c => c.C_ID == customerid).FirstOrDefault();
            _db.tblCustomers.Remove(tc);
            return _db.SaveChanges();
        }

        public List<CustomerDetails> GetAllCustomer()
        {
            List<CustomerDetails> lstcd = new List<CustomerDetails>();
            var customers = _db.tblCustomers.ToList();
            foreach (tblCustomer item in customers)
            {
                lstcd.Add(new CustomerDetails() { C_ID = item.C_ID, CustomerNo = item.CustomerNo, C_Name = item.C_Name, Address = item.Address, Gender = item.Gender, City = item.City, Email = item.Email, ContactNo = item.ContactNo, Photo = item.Photo });
            }
            return lstcd;
        }

        public int GetCustomerById(int customerid)
        {
            tblCustomer tc = _db.tblCustomers.Where(c => c.C_ID == customerid).FirstOrDefault();
            return customerid;

        }

        public int UpdateCustomer(CustomerDetails cd)
        {
            tblCustomer tc = _db.tblCustomers.Where(c => c.C_ID == cd.C_ID).FirstOrDefault();
            tc.C_ID = cd.C_ID;
            tc.CustomerNo = cd.CustomerNo;
            tc.C_Name = cd.C_Name;
            tc.Address = cd.Address;
            tc.Gender = cd.Gender;
            tc.City = cd.City;
            tc.Email = cd.Email;
            tc.ContactNo = cd.ContactNo;
            tc.Photo = cd.Photo;
            return _db.SaveChanges();
        }
    }
}
