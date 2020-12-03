using System;
using System.Collections.Generic;
using System.Text;

namespace Gm.Application.Contracts.Models.Dtos
{
    public class TenantDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<AccountDto> Accounts { get; set; }

    }
}
