using IRepository.Management.FG;
using IService.Management.FG;
using Model.Management.FG.AccountInfo;

namespace Service.Management.FG;

public class AccountService : BaseService<Account>, IAccountService
{
    private readonly IAccountRepository _iAccountRepository;

    public AccountService(IAccountRepository iAccountRepository)
    {
        _iAccountRepository = iAccountRepository;
        base._iBaseRepository = iAccountRepository;
    }
}