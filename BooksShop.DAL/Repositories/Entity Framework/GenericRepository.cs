using BooksShop.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Entity_Framework
{
    public class GenericRepository<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext context)
        {
            _appDbContext = context;
        }

        public void Add(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Remove(entity);
            _appDbContext.SaveChanges();
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            return _appDbContext.Set<TEntity>().Where(expression);
        }

        public IQueryable<TEntity> GetAll()
        {
            //return _appDbContext.Set<TEntity>().ToList();
            return _appDbContext.Set<TEntity>().AsNoTracking();
        }

        public void Update(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Update(entity);
            _appDbContext.SaveChanges();
        }
    }
}
