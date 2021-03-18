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
    public class BLLRegistration : IRegistration
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();

        public RegistrationDetails CheckUserLogin(string username, string password)
        {
            RegistrationDetails rd = new RegistrationDetails();
            var user = _db.tblRegistrations.Where(r => r.UserName == username && r.Password == password).FirstOrDefault();
            if (user != null)
            {

                rd.UserName = user.UserName;
                rd.Password = user.Password;
                rd.UserType = user.UserType;

            }
            return rd;
        }

        public int DeleteRegisteredUser(int userid)
        {
            tblRegistration tr = _db.tblRegistrations.Where(u => u.UserId == userid).FirstOrDefault();
            _db.tblRegistrations.Remove(tr);
            return _db.SaveChanges();
        }

        public List<RegistrationDetails> GetAllUser()
        {
            List<RegistrationDetails> lstuser = new List<RegistrationDetails>();
            var users = _db.tblRegistrations.ToList();
            foreach (var item in users)
            {
                lstuser.Add(new RegistrationDetails() { UserId = item.UserId, UserName = item.UserName, UserType = item.UserType, Password = item.Password, FullName = item.FullName, ContactNo=item.ContactNo,Email=item.Email,JoiningDate=item.JoiningDate });
            }
            return lstuser;
        }

        public int RegisterNewUser(RegistrationDetails rd)
        {
            tblRegistration tr = new tblRegistration();
            tr.UserName = rd.UserName;
            tr.UserType = rd.UserType;
            tr.Password = rd.Password;
            tr.FullName = rd.FullName;
            tr.ContactNo = rd.ContactNo;
            tr.Email = rd.Email;
            tr.JoiningDate = DateTime.Now;
            _db.tblRegistrations.Add(tr);
            return _db.SaveChanges();
        }

        public int UpdateRegisteredUser(RegistrationDetails rd)
        {
            tblRegistration tr = _db.tblRegistrations.Where(u => u.UserId == rd.UserId).FirstOrDefault();
            tr.UserName = rd.UserName;
            tr.UserType = rd.UserType;
            tr.Password = rd.Password;
            tr.FullName = rd.FullName;
            tr.ContactNo = rd.ContactNo;
            tr.Email = rd.Email;
            tr.JoiningDate = DateTime.Now;
            return _db.SaveChanges();
        }
    }
}
