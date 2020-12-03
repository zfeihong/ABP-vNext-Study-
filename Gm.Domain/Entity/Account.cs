using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Gm.Domain.Entity
{
    public class Account :AuditedAggregateRoot<Guid>
    {
        private Account()
        {

        }

        public virtual Guid? TenantId { get; private set; }

        public virtual string UserName { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string Surname { get; private set; }

        public virtual string Email { get; private set; }

        public virtual bool EmailConfirmed { get; private set; }

        public virtual string PhoneNumber2 { get; private set; }

        public virtual bool PhoneNumberConfirmed { get; private set; }
    }
}
