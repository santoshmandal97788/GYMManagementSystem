using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
    public interface ISubCategory
    {
        List<SubCategoryDetails> GetAllSubCategory();
        int AddNewSubCategory(SubCategoryDetails scd);
        int UpdateSubCategory(SubCategoryDetails scd);
        int DeleteSubCategory(int subcatid);
        bool CheckSubCategory(string subcatname);
    }
}
