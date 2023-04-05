using IRepository.Management.FG;
using IService.Management.FG;
using Model.Management.FG.UserInfo;

namespace Service.Management.FG;

public class UserService : BaseService<User>, IUserService
{
    private readonly IUserRepository _iUserRepository;

    public UserService(IUserRepository iUserRepository)
    {
        _iUserRepository = iUserRepository;
        base._iBaseRepository = iUserRepository;
    }
}