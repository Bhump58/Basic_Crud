using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
