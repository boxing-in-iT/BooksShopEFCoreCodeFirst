using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Entity_Framework
{
    public class ProductRepository : GenericRepository<Product> ,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
            // _appDbContext = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllWithDetailsAsync()
        {
            return await GetAll().Include(e => e.mainPhoto).Include(e => e.category).Include(e => e.binding).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await Get(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Product> GetByIdWithDetailsAsync(int id)
        {
            return await Get(e => e.Id == id).Include(e => e.category).Include(c => c.mainPhoto).FirstOrDefaultAsync();
        }
    }
}
