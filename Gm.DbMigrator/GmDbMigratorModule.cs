using Gm.Domain;
using Gm.EfCore.MigrationsForMySql.DbContext;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Gm.DbMigrator
{ 
    [DependsOn(typeof(AbpAutofacModule),
        typeof(GmDomainModule),
        typeof(GmEfCoreDbMigrationModule))]
    public class GmDbMigratorModule:AbpModule
    {
    }
}
