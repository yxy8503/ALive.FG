using IRepository.Management.FG;
using IService.Management.FG;
using Model.Management.FG.AccountInfo;
using Model.Management.FG.UserInfo;

namespace Service.Management.FG;

public class UserDetailService : BaseService<UserDetail>, IUserDetailService
{
    private readonly IUserDetailRepository _iUserDetailRepository;

    public UserDetailService(IUserDetailRepository iUserDetailRepository)
    {
        _iUserDetailRepository = iUserDetailRepository;
        base._iBaseRepository = iUserDetailRepository;
    }
}