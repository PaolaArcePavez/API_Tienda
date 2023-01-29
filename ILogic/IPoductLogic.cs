using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogic
{
    public interface IProductLogic
    {
        List<Product> GetAllProducts();
        List<Product> GetProductsByCriteria();
        void InsertProduct(Product product);
    }
}
