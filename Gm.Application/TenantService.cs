using Gm.Application.Contracts;
using Gm.Application.Contracts.Models.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Guids;

namespace Gm.Application
{
    public class TenantService : ApplicationService, ITenantService
    {
        private readonly IGuidGenerator _guidGenerator;
        private IAccountService _accountService { get; set; }

        public TenantService(IAccountService accountService, IGuidGenerator guidGenerator)
        {
            _guidGenerator = guidGenerator;
            _accountService = accountService;
        }

        public Task<TenantDto> CreateAsync(TenantDto tenant)
        {
            throw new NotImplementedException();
        }

        public async Task<TenantDto> GetAsync(string id)
        {
            var accounts = await _accountService.GetListAsync(new AccountQueryDto());
            var task = await Task.Run(() =>
            {
                Thread.Sleep(100);
                return new TenantDto()
                {
                    Id = _guidGenerator.Create(),
                    Name = "租户1",
                    Accounts = accounts
                };
            });
            return task;
        }

    }
}
