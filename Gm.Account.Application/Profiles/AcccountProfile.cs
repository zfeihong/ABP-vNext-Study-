using AutoMapper;
using Gm.Account.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gm.Account.Application.Profiles
{
    public class AcccountProfile:Profile
    {
        public AcccountProfile()
        {
            CreateMap<Gm.Domain.Entity.Account, AccountDto>().ReverseMap();
        }
    }
}
