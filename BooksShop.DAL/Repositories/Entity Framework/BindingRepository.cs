using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Entity_Framework
{
    public class BindingRepository : GenericRepository<Binding>, IBindingRepository
    {
        public BindingRepository(AppDbContext context) : base(context)
        {
            // _appDbContext = context;
        }

        public async Task<Binding> GetByIdAsync(int id)
        {
            return await Get(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Binding>> GetAllAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}
