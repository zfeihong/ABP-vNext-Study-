using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Gm.Domain.Entity
{
    public class SysRole : AggregateRoot<Guid>, IMultiTenant
    //public class SysRole:IEntity
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected internal set; }

        public Guid? TenantId { get; protected set; }
    }
}
