using Gm.Account.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gm.Tenant.Application.Contracts
{
    public class TenantDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<AccountDto> Accounts { get; set; }

    }
}
