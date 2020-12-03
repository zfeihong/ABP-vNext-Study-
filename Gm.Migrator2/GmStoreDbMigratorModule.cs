using Gm.Domain;
using Gm.EfCore.MigrationsForMySql.DbContext;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;


namespace Gm.Migrator2
{ 
      [DependsOn(typeof(AbpAutofacModule),
        typeof(GmDomainModule),
        typeof(GmEfCoreDbMigrationModule))]
    public class GmStoreDbMigratorModule : AbpModule
    {
    }
}
