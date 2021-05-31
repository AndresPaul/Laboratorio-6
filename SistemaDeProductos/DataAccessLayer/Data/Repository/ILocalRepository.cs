using SistemaDeProductos.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProductos.Data.Repository
{
    public interface ILocalRepository {
        public IEnumerable<ProductEntity> GetAllProducts();
        public ProductEntity GetProductInfo(int ProductId);
        public ProductEntity CreateNewProduct(ProductEntity ProductEntity);
        public ProductEntity UpdateProduct(ProductEntity ProductEntity);
        public bool DeleteProduct(int ProductId);
    }
}