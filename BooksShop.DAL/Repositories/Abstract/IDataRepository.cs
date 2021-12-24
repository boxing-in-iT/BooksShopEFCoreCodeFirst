using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BooksShop.DAL.Repositories.Abstract
{
    public interface IDataRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity product);
    }
}
