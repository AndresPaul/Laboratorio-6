using SistemaDeProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProductos.Services
{
    public interface IProductService {
        public IEnumerable<Product> GetAllStudents();
        public Product GetProductInfo(int ProductId);
        public Product CreateNewProduct(Product Product);
        public Product UpdateProduct(int ProductId, Product Product);
        public bool DeleteProduct(int ProductId);
    }
}
