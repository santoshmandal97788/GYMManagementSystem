using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
   public interface IRegistration
   {
        List<RegistrationDetails> GetAllUser();
        int RegisterNewUser(RegistrationDetails rd);
        int UpdateRegisteredUser(RegistrationDetails rd);
        int DeleteRegisteredUser(int userid);
        RegistrationDetails CheckUserLogin(string username, string password);

   }
}
