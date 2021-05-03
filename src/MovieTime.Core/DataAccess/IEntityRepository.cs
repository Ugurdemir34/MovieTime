using MovieTime.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Core.DataAccess
{
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        //T Get(Expression<Func<T, bool>> filter, params Expression<Func<T,object>>[] includeProperties);
        Task<T> GetAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
       // IList<T> GetList(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties);
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>> filter);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
       // Task<T> AddRangeAsync(List<T> Entities);
    }
}
