using AutoMapper;
using BooksShop.BLL.Interfaces;
using BooksShop.BLL.Services;
using BooksShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.BLL.ServiceWrapper
{
    public class ServiceWrapper:IServiceWrapper
    {
        private readonly Lazy<IProductService> productService;
        private readonly Lazy<ICategoryService> categoryService;
        private readonly Lazy<IBindingService> bindingService;

        public ServiceWrapper(IUnitOfWork dataRepositoryWrapper, IMapper mapper)
        {
            productService = new Lazy<IProductService>(() => new ProductService(dataRepositoryWrapper, mapper));
            categoryService = new Lazy<ICategoryService>(() => new CategoryService(dataRepositoryWrapper, mapper));
            bindingService = new Lazy<IBindingService>(() => new BindingService(dataRepositoryWrapper, mapper));
        }

        public ICategoryService CategoryService => categoryService.Value;

        public IProductService ProductService => productService.Value;

        public IBindingService BindingService => bindingService.Value;
    }
}
