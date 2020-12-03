using Gm.Domain;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
//using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;

namespace Gm.EfCore
{
    [DependsOn(typeof(AbpEntityFrameworkCoreMySQLModule))]
    //[DependsOn(typeof(AbpEntityFrameworkCoreSqlServerModule))]
    [DependsOn(typeof(GmDomainModule))]
    public  class GmEfCoreModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //注入DbContext
            context.Services.AddAbpDbContext<GmDbContext>(options => {
                options.AddDefaultRepositories();
            });

            //使用MySQL数据库
            Configure<AbpDbContextOptions>(options => {

                //
                //options.UseSqlServer();
                //
                options.UseMySQL();
            });
        }
    }
}
