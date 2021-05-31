using AutoMapper;
using SistemaDeProductos.Data.Entities;
using SistemaDeProductos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeProductos.Data
{
    public class AutoMapperProfile:Profile {
        public AutoMapperProfile() {
            this.CreateMap <ProductEntity, Product> ()
            .ReverseMap();
            this.CreateMap<Product, ProductEntity>()
            .ReverseMap();
        }
    }

    public class Profile
    {
    }
}
