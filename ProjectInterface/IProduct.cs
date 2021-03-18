using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterface
{
    public interface IProduct
    {
        List<ProductDetails> GetAllProducts();
        int AddNewProduct(ProductDetails pd);
        int UpdateProduct(ProductDetails pd);
        int DeleteProduct(int productid);
        bool CheckProduct(string productname);
        int GetProductById(int productid);
    }
}
