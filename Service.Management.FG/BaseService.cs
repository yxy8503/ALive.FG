using System.Linq.Expressions;
using IRepository.Management.FG;
using IService.Management.FG;
using SqlSugar;

namespace Service.Management.FG;

public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
{
    protected IBaseRepository<TEntity> _iBaseRepository;

    public async Task<bool> CreateAsync(TEntity entity)
    {
        return await _iBaseRepository.CreateAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _iBaseRepository.DeleteAsync(id);
    }

    public async Task<bool> EditAsync(TEntity entity)
    {
        return await _iBaseRepository.EditAsync(entity);
    }

    public async Task<TEntity> FindAsync(int id)
    {
        return await _iBaseRepository.FindAsync(id);
    }

    public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> func)
    {
        return await _iBaseRepository.FindAsync(func);
    }

    public async Task<List<TEntity>> QueryAsync()
    {
        return await _iBaseRepository.QueryAsync();
    }

    public async Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func)
    {
        return await _iBaseRepository.QueryAsync(func);
    }

    public async Task<List<TEntity>> QueryAsync(int pageIndex, int size, RefAsync<int> total)
    {
        return await _iBaseRepository.QueryAsync(pageIndex, size, total);
    }

    public async Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func, int pageIndex, int size,
        RefAsync<int> total)
    {
        return await _iBaseRepository.QueryAsync(func, pageIndex, size, total);
    }
}