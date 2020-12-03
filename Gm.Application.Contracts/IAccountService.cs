using Gm.Application.Contracts.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Gm.Application.Contracts
{
    public interface IAccountService : IApplicationService
    {
        Task<AccountDto> CreateAsync(AccountDto account);

        Task<IEnumerable<AccountDto>> GetListAsync(AccountQueryDto query);
    }
}
