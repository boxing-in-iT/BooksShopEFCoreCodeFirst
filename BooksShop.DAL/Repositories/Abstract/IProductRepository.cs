using BooksShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Abstract
{
    public interface IProductRepository:IDataRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetAllWithDetailsAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> GetByIdWithDetailsAsync(int id);
    }
}
