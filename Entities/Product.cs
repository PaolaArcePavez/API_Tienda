using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Product
    {
        public Product()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }

    }
}
