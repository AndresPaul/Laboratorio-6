using SistemaDeProductos.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProductos.Data.Repository
{
    public class LocalRepository : ILocalRepository {
        private List<ProductEntity> Product = new List<ProductEntity>() {
            new ProductEntity(){Id=1,Name="PAN"},
            new ProductEntity(){Id=2,Name="FANTA"},
        };
        public IEnumerable<ProductEntity> GetAllProducts() {
            return Product;
        }
        public ProductEntity GetStudentInfo(int ProductId) {
            return Product.First(a => a.Id == ProductId);
        }
        public ProductEntity CreateNewProduct(ProductEntity ProductEntity) {
            int ProductId;
            if (Product.Count() == 0) ProductId = 1;
            else ProductId = Product.OrderByDescending(c => c.Id).First().Id + 1;
            ProductEntity.Id = ProductId;
            Product.Add(ProductEntity);
            return ProductEntity;
        }
        public ProductEntity UpdateProduct(ProductEntity ProductEntity) {
            var update = GetProductInfo(ProductEntity.Id);
            update.Name = ProductEntity.Name ?? update.Name;
            return update;
        }
        public bool DeleteProduct(int ProductId) {
            var delete = GetProductInfo(ProductId);
            Product.Remove(delete);
            return true;
        }

        private object GetProductInfo(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
