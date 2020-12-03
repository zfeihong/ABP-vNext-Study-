using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Gm.Account.Application.Contracts
{
    public interface IAccountService : IApplicationService
    {
        Task<AccountDto> CreateAsync(AccountDto account);

        Task<IEnumerable<AccountDto>> GetListAsync(AccountQueryDto query);
    }
}
