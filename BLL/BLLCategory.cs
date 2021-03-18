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
    public class BLLCategory : ICategory
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();

        public int AddNewCategory(CategoryDetails cd)
        {
            tblCategory tc = new tblCategory();
            tc.CategoryName = cd.CategoryName;
            _db.tblCategories.Add(tc);
            return _db.SaveChanges();
        }

        
        public bool CheckCategory(string categoryname)
        {
            var categories = _db.tblCategories.Where(c => c.CategoryName == categoryname).FirstOrDefault();

            if (categories != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteCategory(int categoryid)
        {
            tblCategory tc = _db.tblCategories.Where(c => c.CategoryId == categoryid).FirstOrDefault();
            _db.tblCategories.Remove(tc);
            return _db.SaveChanges();
        }

        public List<CategoryDetails> GetAllCategory()
        {
            List<CategoryDetails> lstcat = new List<CategoryDetails>();
            var categories = _db.tblCategories.ToList();
            foreach (var item in categories)
            {
                lstcat.Add(new CategoryDetails() { CategoryId = item.CategoryId, CategoryName = item.CategoryName });
            }
            return lstcat;
        }

        public int UpdateCategory(CategoryDetails cd)
        {
            tblCategory tc = _db.tblCategories.Where(c => c.CategoryId == cd.CategoryId).FirstOrDefault();
            tc.CategoryName = cd.CategoryName;
            return _db.SaveChanges();
        }
    }
}
