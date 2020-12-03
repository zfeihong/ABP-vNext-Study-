using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Gm.Tenant.Application.Contracts
{
    public interface ITenantService : IApplicationService
    {
        Task<TenantDto> CreateAsync(TenantDto tenant);
        Task<TenantDto> GetAsync(string id);
    }
}
