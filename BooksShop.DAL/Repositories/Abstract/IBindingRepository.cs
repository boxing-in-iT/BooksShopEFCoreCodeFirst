using BooksShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Abstract
{
    public interface IBindingRepository
    {
        Task<IEnumerable<Binding>> GetAllAsync();
        Task<Binding> GetByIdAsync(int id);
    }
}
