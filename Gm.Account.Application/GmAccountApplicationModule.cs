using Gm.Account.Application.Contracts;
using Gm.Domain;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Gm.Account.Application
{
    [DependsOn(typeof(GmAccountApplicationContractsModule))]
    [DependsOn(typeof(GmDomainModule))]
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class GmAccountApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<GmAccountApplicationModule>();

            Configure<AbpAutoMapperOptions>(options => {
                options.AddMaps<GmAccountApplicationModule>();
            });
        }
    }
}
