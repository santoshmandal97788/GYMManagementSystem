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
    public class BLLSubCategory : ISubCategory
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();
        public int AddNewSubCategory(SubCategoryDetails scd)
        {
            tblSubCategory tsc = new tblSubCategory();
            tsc.CategoryId = scd.CategoryId;
            tsc.SubCategoryName = scd.SubCategoryName;
            _db.tblSubCategories.Add(tsc);
            return _db.SaveChanges();
        }
        public bool CheckSubCategory(string subcatname)
        {
            var subcategory = _db.tblSubCategories.Where(sc => sc.SubCategoryName == subcatname).FirstOrDefault();

            if (subcategory != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteSubCategory(int subcatid)
        {
            tblSubCategory tsc = _db.tblSubCategories.Where(sc => sc.SubCatId == subcatid).FirstOrDefault();
            _db.tblSubCategories.Remove(tsc);
            return _db.SaveChanges();
        }

        public List<SubCategoryDetails> GetAllSubCategory()
        {
            List<SubCategoryDetails> subcatlst = new List<SubCategoryDetails>();
            var subcategory = _db.tblSubCategories.ToList();
            foreach (tblSubCategory item in subcategory)
            {
                subcatlst.Add(new SubCategoryDetails() { SubCatId = item.SubCatId, CategoryId = item.tblCategory.CategoryId, CategoryName=item.tblCategory.CategoryName, SubCategoryName = item.SubCategoryName });
            }
            return subcatlst;
        }

        public int UpdateSubCategory(SubCategoryDetails scd)
        {
            tblSubCategory tsc = _db.tblSubCategories.Where(sc => sc.SubCatId == scd.SubCatId).FirstOrDefault();
            tsc.CategoryId = scd.CategoryId;
            tsc.SubCategoryName = scd.SubCategoryName;
            return _db.SaveChanges();
        }
    }
}
