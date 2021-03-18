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
   
    public class BLLMembershipType : IMembershipType
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();

        public int AddNewMembershipType(MembershipTypeDetails mtd)
        {
            tblMembershipType tmt = new tblMembershipType();
            tmt.MembershipType = mtd.MembershipType;
            tmt.ChargesPerMonth = mtd.ChargesPerMonth;
            tmt.ServiceTAX = mtd.ServiceTAX;
            tmt.VAT = mtd.VAT;
            _db.tblMembershipTypes.Add(tmt);
            return _db.SaveChanges();
        }

        public bool CheckMembershipType(string memtypename)
        {
            var membershiptype = _db.tblMembershipTypes.Where(m => m.MembershipType == memtypename).FirstOrDefault();
            if (membershiptype!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteMembershipType(int mtid)
        {
            tblMembershipType tmt = _db.tblMembershipTypes.Where(m => m.MT_ID == mtid).FirstOrDefault();
            _db.tblMembershipTypes.Remove(tmt);
            return _db.SaveChanges();
        }

        public List<MembershipTypeDetails> GetAllMembershipType()
        {
            List<MembershipTypeDetails> lstmt = new List<MembershipTypeDetails>();
            var membershiptype = _db.tblMembershipTypes.ToList();
            foreach (var item in membershiptype)
            {
                lstmt.Add(new MembershipTypeDetails() { MT_ID = item.MT_ID, MembershipType = item.MembershipType, ChargesPerMonth=item.ChargesPerMonth,ServiceTAX=item.ServiceTAX,VAT=item.VAT });
            }
            return lstmt;
        }

        public int UpdateMembershipType(MembershipTypeDetails mtd)
        {
            tblMembershipType tmt = _db.tblMembershipTypes.Where(m => m.MT_ID == mtd.MT_ID).FirstOrDefault();
            tmt.MembershipType = mtd.MembershipType;
            tmt.ChargesPerMonth = mtd.ChargesPerMonth;
            tmt.ServiceTAX = mtd.ServiceTAX;
            tmt.VAT = mtd.VAT;
            return _db.SaveChanges();
        }
    }
}
