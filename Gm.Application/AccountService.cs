using Gm.Application.Contracts;
using Gm.Application.Contracts.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Gm.Application
{
    public class AccountService : ApplicationService, IAccountService
    {
        public AccountService()
        {
        }

        public Task<AccountDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountDto> CreateAsync(AccountDto account)
        {
            throw new NotImplementedException();

        }

        public async Task<IEnumerable<AccountDto>> GetListAsync(AccountQueryDto query)
        {
            var re = new List<AccountDto>() { new AccountDto {
                         Id=Guid.NewGuid(), Name="name",Pwd="pwd"
                    } };

            return await Task.FromResult(re);

        }
    }
}
