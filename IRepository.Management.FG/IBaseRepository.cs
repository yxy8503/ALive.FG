using System.Linq.Expressions;
using SqlSugar;

namespace IRepository.Management.FG;

public interface IBaseRepository<TEntity> where TEntity : class,new()
{
    Task<bool> CreateAsync(TEntity entity);
    
    Task<bool> DeleteAsync(int id);

    Task<bool> EditAsync(TEntity entity);

    Task<TEntity> FindAsync(int id);
    
    Task<TEntity> FindAsync(Expression<Func<TEntity,bool>> func);
    
    Task<List<TEntity>> QueryAsync();
    
    Task<List<TEntity>> QueryAsync(Expression<Func<TEntity,bool>> func);
    
    Task<List<TEntity>> QueryAsync(int pageIndex,int size, RefAsync<int> total);
    
    Task<List<TEntity>> QueryAsync(Expression<Func<TEntity,bool>> func,int pageIndex,int size, RefAsync<int> total);
}