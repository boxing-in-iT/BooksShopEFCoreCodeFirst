using BooksShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> GetByIdWithDetailsAsync(int id);
    }
}
