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
    public class BLLProduct : IProduct
    {
        GymManagementDBEntities _db = new GymManagementDBEntities();
        public int AddNewProduct(ProductDetails pd)
        {
            tblProduct tp = new tblProduct();
            tp.ProductNo = pd.ProductNo;
            tp.ProductName = pd.ProductName;
            tp.SubCategoryID = pd.SubCategoryID;
            tp.Category = pd.Category;
            tp.Features = pd.Features;
            tp.VAT = pd.VAT;
            tp.ServiceTAX = pd.ServiceTAX;
            tp.Discount = pd.Discount;
            tp.Price = pd.Price;
            tp.Photo = pd.Photo;
            _db.tblProducts.Add(tp);
            return _db.SaveChanges();

        }

        public bool CheckProduct(string productname)
        {
            var products = _db.tblProducts.Where(p => p.ProductName == productname).FirstOrDefault();

            if (products != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DeleteProduct(int productid)
        {
            tblProduct tp = _db.tblProducts.Where(p => p.PID == productid).FirstOrDefault();
            _db.tblProducts.Remove(tp);
            return _db.SaveChanges();
        }

        public List<ProductDetails> GetAllProducts()
        {
            List<ProductDetails> pdlst = new List<ProductDetails>();
            var products = _db.tblProducts.ToList();
            foreach (tblProduct item in products)
            {
                pdlst.Add(new ProductDetails() { PID = item.PID, ProductNo = item.ProductNo, ProductName = item.ProductName, SubCategoryID = item.tblSubCategory.SubCatId, SubCategoryName = item.tblSubCategory.SubCategoryName,Category=item.Category, Features = item.Features, VAT = item.VAT, ServiceTAX = item.ServiceTAX, Discount = item.Discount, Price = item.Price, Photo = item.Photo });
            }
            return pdlst;
        }

        public int GetProductById(int productid)
        {
            tblProduct tp = _db.tblProducts.Where(p => p.PID == productid).FirstOrDefault();
            return productid;
        }

        public int UpdateProduct(ProductDetails pd)
        {
            tblProduct tp = _db.tblProducts.Where(p => p.PID == pd.PID).FirstOrDefault();
          
            tp.ProductNo = pd.ProductNo;
            tp.ProductName = pd.ProductName;
            tp.SubCategoryID = pd.SubCategoryID;
            tp.Category = pd.Category;
            tp.Features = pd.Features;
            tp.VAT = pd.VAT;
            tp.ServiceTAX = pd.ServiceTAX;
            tp.Discount = pd.Discount;
            tp.Price = pd.Price;
            tp.Photo = pd.Photo;
            return _db.SaveChanges();
        }
    }
}
