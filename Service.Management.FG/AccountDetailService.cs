using IRepository.Management.FG;
using IService.Management.FG;
using Model.Management.FG.AccountInfo;

namespace Service.Management.FG;

public class AccountDetailService : BaseService<AccountDetail>, IAccountDetailService
{
    private readonly IAccountDetailRepository _iAccountDetailRepository;

    public AccountDetailService(IAccountDetailRepository iAccountDetailRepository)
    {
        _iAccountDetailRepository = iAccountDetailRepository;
        base._iBaseRepository = iAccountDetailRepository;
    }
}