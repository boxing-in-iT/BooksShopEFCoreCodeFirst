using BooksShop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksShop.BLL.ServiceWrapper
{
    public interface IServiceWrapper
    {
        IProductService ProductService { get; }
        ICategoryService CategoryService { get; }
        IBindingService BindingService { get; }
    }
}
