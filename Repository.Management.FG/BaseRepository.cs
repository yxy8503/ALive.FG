using System.Linq.Expressions;
using IRepository.Management.FG;
using Model.Management.FG.AccountInfo;
using Model.Management.FG.UserInfo;
using SqlSugar;
using SqlSugar.IOC;

namespace Repository.Management.FG;

public class BaseRepository<TEntity> : SimpleClient<TEntity>, IBaseRepository<TEntity> where TEntity : class, new()
{
    public BaseRepository(ISqlSugarClient context = null) : base(context)
    {
        base.Context = DbScoped.SugarScope;
        base.Context.DbMaintenance.CreateDatabase();
        base.Context.CodeFirst.InitTables(
            typeof(Account),
            typeof(AccountDetail),
            typeof(User),
            typeof(UserDetail)
        );
    }

    public async Task<bool> CreateAsync(TEntity entity)
    {
        return await base.InsertAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await base.DeleteByIdAsync(id);
    }

    public async Task<bool> EditAsync(TEntity entity)
    {
        return await base.UpdateAsync(entity);
    }

    public async Task<TEntity> FindAsync(int id)
    {
        return await base.GetByIdAsync(id);
    }

    public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> func)
    {
        return await base.GetSingleAsync(func);
    }

    public async Task<List<TEntity>> QueryAsync()
    {
        return await base.GetListAsync();
    }

    public async Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func)
    {
        return await base.GetListAsync(func);
    }

    public async Task<List<TEntity>> QueryAsync(int pageIndex, int size, RefAsync<int> total)
    {
        return await base.Context.Queryable<TEntity>().ToPageListAsync(pageIndex, size, total);
    }

    public async Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func, int pageIndex, int size,
        RefAsync<int> total)
    {
        return await base.Context.Queryable<TEntity>().Where(func).ToPageListAsync(pageIndex, size, total);
    }
}