using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Gm.Domain.Data
{
    public class GmDbMigrationService : ITransientDependency
    {
        public ILogger<GmDbMigrationService> Logger { get; set; }
        private readonly IGmDbSchemaMigrator _dbSchemaMigrators;
        //private readonly IDataSeeder _dataSeeder;

        public GmDbMigrationService(
            //IDataSeeder dataSeeder, 
            IGmDbSchemaMigrator dbSchemaMigrators)
        {
            //_dataSeeder = dataSeeder;
            _dbSchemaMigrators = dbSchemaMigrators;

            Logger = NullLogger<GmDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");
            
            //迁移
            await _dbSchemaMigrators.MigrateAsync();


            Logger.LogInformation($"Successfully completed host database migrations.");

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}
