using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
  public interface IMembershipType
    {
        List<MembershipTypeDetails> GetAllMembershipType();
        int AddNewMembershipType(MembershipTypeDetails mtd);
        int UpdateMembershipType(MembershipTypeDetails mtd);
        int DeleteMembershipType(int mtid);
        bool CheckMembershipType(string memtypename);
    }
}
