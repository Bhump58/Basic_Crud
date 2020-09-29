using Dapper;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
                new { id = id });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
