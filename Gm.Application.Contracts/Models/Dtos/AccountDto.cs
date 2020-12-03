using System;
using System.Collections.Generic;
using System.Text;

namespace Gm.Application.Contracts.Models.Dtos
{
    public class AccountDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }

    }
}
