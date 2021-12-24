using AutoMapper;
using BooksShop.BLL.DTO.Binding;
using BooksShop.BLL.DTO.Category;
using BooksShop.BLL.DTO.mainPhoto;
using BooksShop.BLL.DTO.Product;
using BooksShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.BLL.Configurations
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductShortDetailDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Product, ProductDetailDTO>();
            CreateMap<ProductDTOForCreating, Product>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<Binding, BindingDTO>();
            CreateMap<MainPhoto, MainPhotoDTO>();
        }
    }
}
