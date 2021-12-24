using BooksShop.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories
{
    public interface IUnitOfWork
    {
        IProductRepository productRepository { get; }
        ICategoryRepository categoryRepository { get; }
        IBindingRepository bindingRepository { get; }
        Task SaveAsync();
    }
}
