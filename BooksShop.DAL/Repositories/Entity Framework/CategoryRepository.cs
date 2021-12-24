using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Entity_Framework
{
    public class CategoryRepository: GenericRepository<Category> ,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await Get(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Category> GetByIdWithDetailsAsync(int id)
        {
            return await Get(e => e.Id == id).Include(e => e.products).FirstOrDefaultAsync();
        }
    }
}
