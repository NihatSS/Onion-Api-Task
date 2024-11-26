using Domain.Common;
using System.Linq.Expressions;

namespace Repository.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task EditAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllWithExpression(Expression<Func<T,bool>> predicate);
        Task<T> GetWithExpression(Expression<Func<T,bool>> predicate);
        Task DeleteAsync(int id);
    }
}
