using System.Linq.Expressions;
using KodlamaNTierProject.Entities.Abstract;

namespace KodlamaNTierProject.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T:class,IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}