using Gm.Account.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Gm.Account.Application
{
    public class AccountService : ApplicationService, IAccountService
    {
        private readonly IRepository<Gm.Domain.Entity.Account> _accountRepository;
        public AccountService(IRepository<Gm.Domain.Entity.Account> account)
        {
            _accountRepository = account;
        }
        public Task<AccountDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountDto> CreateAsync(AccountDto account)
        {
            var acc = ObjectMapper.Map<AccountDto, Gm.Domain.Entity.Account>(account);
            var re = await _accountRepository.InsertAsync(acc);
            return ObjectMapper.Map<Gm.Domain.Entity.Account,AccountDto>(re);
        }

        public async Task<IEnumerable<AccountDto>> GetListAsync(AccountQueryDto query)
        {
            var users = await _accountRepository.GetListAsync();

            //var re = new List<AccountDto>() {
            //    new AccountDto(){  Id=Guid.Parse("F1DB8D3D-F27E-FFB5-BAAC-9C5EDA2134FE"), Name="jackyfei",Pwd="123456" },
            //    new AccountDto(){  Id=Guid.Parse("F2DB8D3D-F27E-FFB5-BAAC-9C5EDA2134FE"), Name="jackyfei2",Pwd="654321" }
            //};

            var userList = ObjectMapper.Map<List<Gm.Domain.Entity.Account>,List<AccountDto>>(users);

            return await Task.FromResult(userList);
        }

    }
}
