using Data;
using Entities;
using ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
     public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public List<Product> GetAllProducts()
        {
            return _serviceContext.Set<Product>().ToList();
        }
        public List<Product> GetProductsByCriteria()
        {
            //ejemplo para IsActive solamente
            return _serviceContext.Set<Product>()
                .Where(p => p.IsActive)
                .ToList();
        }
        public void InsertProduct(Product product)
        {
            _serviceContext.Product.Add(product);
            _serviceContext.SaveChanges();
        }

    }
}
