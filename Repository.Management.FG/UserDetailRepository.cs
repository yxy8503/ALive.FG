using System.Linq.Expressions;
using IRepository.Management.FG;
using Model.Management.FG.UserInfo;
using SqlSugar;

namespace Repository.Management.FG;

public class UserDetailRepository : BaseRepository<UserDetail>, IUserDetailRepository
{
    public Task<bool> CreateAsync(UserDetail entity)
    {
        return base.CreateAsync(entity);
    }

    public Task<bool> DeleteAsync(int id)
    {
        return base.DeleteAsync(id);
    }

    public Task<bool> EditAsync(UserDetail entity)
    {
        return base.EditAsync(entity);
    }

    public Task<UserDetail> FindAsync(int id)
    {
        return base.FindAsync(id);
    }

    public Task<UserDetail> FindAsync(Expression<Func<UserDetail, bool>> func)
    {
        return base.FindAsync(func);
    }

    public Task<List<UserDetail>> QueryAsync()
    {
        return base.QueryAsync();
    }

    public Task<List<UserDetail>> QueryAsync(Expression<Func<UserDetail, bool>> func)
    {
        return base.QueryAsync(func);
    }

    public Task<List<UserDetail>> QueryAsync(int pageIndex, int size, RefAsync<int> total)
    {
        return base.QueryAsync(pageIndex, size, total);
    }

    public Task<List<UserDetail>> QueryAsync(Expression<Func<UserDetail, bool>> func, int pageIndex, int size,
        RefAsync<int> total)
    {
        return base.QueryAsync(func, pageIndex, size, total);
    }
}