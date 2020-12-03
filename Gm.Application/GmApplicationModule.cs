using Gm.Application.Contracts;
using Volo.Abp.Modularity;

namespace Gm.Application
{
    [DependsOn(typeof(GmApplicationContractsModule))]
    public class GmApplicationModule : AbpModule
    {

    }
}
