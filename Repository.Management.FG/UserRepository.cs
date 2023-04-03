using System.Linq.Expressions;
using IRepository.Management.FG;
using Model.Management.FG.UserInfo;
using SqlSugar;

namespace Repository.Management.FG;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public Task<bool> CreateAsync(User entity)
    {
        return base.CreateAsync(entity);
    }

    public Task<bool> DeleteAsync(int id)
    {
        return base.DeleteAsync(id);
    }

    public Task<bool> EditAsync(User entity)
    {
        return base.EditAsync(entity);
    }

    public Task<User> FindAsync(int id)
    {
        return base.FindAsync(id);
    }

    public Task<User> FindAsync(Expression<Func<User, bool>> func)
    {
        return base.FindAsync(func);
    }

    public Task<List<User>> QueryAsync()
    {
        return base.QueryAsync();
    }

    public Task<List<User>> QueryAsync(Expression<Func<User, bool>> func)
    {
        return base.QueryAsync(func);
    }

    public Task<List<User>> QueryAsync(int pageIndex, int size, RefAsync<int> total)
    {
        return base.QueryAsync(pageIndex, size, total);
    }

    public Task<List<User>> QueryAsync(Expression<Func<User, bool>> func, int pageIndex, int size,
        RefAsync<int> total)
    {
        return base.QueryAsync(func, pageIndex, size, total);
    }
}