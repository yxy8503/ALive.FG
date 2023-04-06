using System.Linq.Expressions;
using IRepository.Management.FG;
using Model.Management.FG.AccountInfo;
using SqlSugar;

namespace Repository.Management.FG;

public class AccountDetailRepository : BaseRepository<AccountDetail>, IAccountDetailRepository
{
    public Task<bool> CreateAsync(AccountDetail entity)
    {
        return base.CreateAsync(entity);
    }

    public Task<bool> DeleteAsync(int id)
    {
        return base.DeleteAsync(id);
    }

    public Task<bool> EditAsync(AccountDetail entity)
    {
        return base.EditAsync(entity);
    }

    public Task<AccountDetail> FindAsync(int id)
    {
        return base.FindAsync(id);
    }

    public Task<AccountDetail> FindAsync(Expression<Func<AccountDetail, bool>> func)
    {
        return base.FindAsync(func);
    }

    public Task<List<AccountDetail>> QueryAsync()
    {
        return base.QueryAsync();
    }

    public Task<List<AccountDetail>> QueryAsync(Expression<Func<AccountDetail, bool>> func)
    {
        return base.QueryAsync(func);
    }

    public Task<List<AccountDetail>> QueryAsync(int pageIndex, int size, RefAsync<int> total)
    {
        return base.QueryAsync(pageIndex, size, total);
    }

    public Task<List<AccountDetail>> QueryAsync(Expression<Func<AccountDetail, bool>> func, int pageIndex, int size,
        RefAsync<int> total)
    {
        return base.QueryAsync(func, pageIndex, size, total);
    }
}