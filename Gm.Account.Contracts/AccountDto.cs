using System;
using System.Collections.Generic;
using System.Text;

namespace Gm.Account.Application.Contracts
{
    public class AccountDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }

    }
}
