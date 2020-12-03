using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Gm.EfCore.MigrationsForMySql.DbContext
{
    [DependsOn(typeof(GmEfCoreModule))]
    public class GmEfCoreDbMigrationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<GmDbMigrationsContext>();
            base.ConfigureServices(context);
        }
    }
}
