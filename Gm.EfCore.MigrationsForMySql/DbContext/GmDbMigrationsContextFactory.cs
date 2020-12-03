﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Gm.EfCore.MigrationsForMySql
{
    public class GmDbMigrationsContextFactory : IDesignTimeDbContextFactory<GmDbMigrationsContext>
    {
        public GmDbMigrationsContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<GmDbMigrationsContext>()
                .UseMySql(configuration.GetConnectionString("GmDbMySqlConnectstring"));

            return new GmDbMigrationsContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }

    }
}
