using IKYS.Domain.Abstract;
using System.Linq.Expressions;

namespace IKYS.Domain.Repositories
{
    public interface IRepositories<T> where T : PersonelBase
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<T> Delete(object Id);

    }
}
