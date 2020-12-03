using Gm.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Gm.EfCore.MigrationsForMySql
{
    public class EfCoreGmStoreDbSchemaMigrator : IGmDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EfCoreGmStoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public async Task MigrateAsync()
        {
            await _serviceProvider
              .GetRequiredService<GmDbMigrationsContext>()
              .Database
              .MigrateAsync();
        }
    }
}
