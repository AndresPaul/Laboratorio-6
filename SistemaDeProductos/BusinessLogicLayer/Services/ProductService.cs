using AutoMapper;
using SistemaDeProductos.Data.Entities;
using SistemaDeProductos.Data.Repository;
using SistemaDeProductos.Exceptions;
using SistemaDeProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProductos.Services
{
    public class ProductService : IProductService {
        private ILocalRepository _localRepository;
        private IMapper _mapper;

        public ProductService(ILocalRepository localRepository, IMapper _mapper) {
            this._localRepository = localRepository;
            this._mapper = _mapper;
        }
        public IEnumerable<Product> GetAllProducts() {
            var entityList= _localRepository.GetAllProducts();
            var modelList = _mapper.Map<IEnumerable<Product>>(entityList);
            return modelList;
        }
        public Product GetProductInfo(int ProductId) {
            var getS = _localRepository.GetProductInfo(ProductId);
            if (getS == null) throw new NotFoundException($" {ProductId} not found");
            return _mapper.Map<Product>(getS);
        }
        public Product CreateNewProduct(Product Product) {
            var entityreturned=_localRepository.CreateNewProduct(_mapper.Map<ProductEntity>(Product));
            return _mapper.Map<Product>(entityreturned);
        }
        public Product UpdateProduct(int ProductId, Product Product) {
            var update=_localRepository.UpdateProduct(_mapper.Map<ProductEntity>(Product));
            return _mapper.Map<Product>(update);
        }
        public bool DeleteProduct(int ProductId) {
            var delete = GetProductInfo(ProductId);
            return _localRepository.DeleteProduct(ProductId);
        }
    }
}
