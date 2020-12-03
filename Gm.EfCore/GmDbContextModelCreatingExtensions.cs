using Gm.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Gm.EfCore
{
    public static class GmDbContextModelCreatingExtensions
    {
        public static void ConfigureGmStore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Account>(o => {
                o.ToTable("Account");
                o.ConfigureByConvention();
            });
             
        }
    }
}
