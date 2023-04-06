using System.Linq.Expressions;
using IRepository.Management.FG;
using Model.Management.FG.AccountInfo;
using SqlSugar;

namespace Repository.Management.FG;

public class AccountRepository : BaseRepository<Account>, IAccountRepository
{
    public Task<bool> CreateAsync(Account entity)
    {
        return base.CreateAsync(entity);
    }

    public Task<bool> DeleteAsync(int id)
    {
        return base.DeleteAsync(id);
    }

    public Task<bool> EditAsync(Account entity)
    {
        return base.EditAsync(entity);
    }

    public Task<Account> FindAsync(int id)
    {
        return base.FindAsync(id);
    }

    public Task<Account> FindAsync(Expression<Func<Account, bool>> func)
    {
        return base.FindAsync(func);
    }

    public Task<List<Account>> QueryAsync()
    {
        return base.QueryAsync();
    }

    public Task<List<Account>> QueryAsync(Expression<Func<Account, bool>> func)
    {
        return base.QueryAsync(func);
    }

    public Task<List<Account>> QueryAsync(int pageIndex, int size, RefAsync<int> total)
    {
        return base.QueryAsync(pageIndex, size, total);
    }

    public Task<List<Account>> QueryAsync(Expression<Func<Account, bool>> func, int pageIndex, int size,
        RefAsync<int> total)
    {
        return base.QueryAsync(func, pageIndex, size, total);
    }
}