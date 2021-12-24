using BooksShop.DAL.Repositories.Abstract;
using BooksShop.DAL.Repositories.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly AppDbContext appDbContext;
        public IProductRepository product;
        public ICategoryRepository category;
        public IBindingRepository binding;

        public UnitOfWork(AppDbContext dbContext)
        {
            appDbContext = dbContext;
        }

        public IProductRepository productRepository
        {
            get
            {
                if (product == null)
                {
                    product = new ProductRepository(appDbContext);
                }
                return product;
            }
        }

        public ICategoryRepository categoryRepository
        {
            get
            {
                if (category == null)
                {
                    category = new CategoryRepository(appDbContext);
                }
                return category;
            }
        }

        public IBindingRepository bindingRepository
        {
            get
            {
                if(binding == null)
                {
                    binding = new BindingRepository(appDbContext);
                }
                return binding;
            }
        }

        public async Task SaveAsync()
        {
            await appDbContext.SaveChangesAsync();
        }
    }
}
