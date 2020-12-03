﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Gm.EfCore.DbMirgrationMysql
{
    [ConnectionStringName("GmDbMySqlConnectstring")]
    public class GmDbMigrationsContext : AbpDbContext<GmDbMigrationsContext>
    {
        public GmDbMigrationsContext(DbContextOptions<GmDbMigrationsContext> options)
          : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureGmStore();
        }

    }
}
