using Gm.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Gm.EfCore
{
    [ConnectionStringName("GmDbMySqlConnectstring")]
    public class GmDbContext: AbpDbContext<GmDbContext>
    {
        public GmDbContext(DbContextOptions<GmDbContext> options)
        : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; } 
        public DbSet<SysRole> SysRoles { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
            builder.ConfigureGmStore();
        }
    }
}
