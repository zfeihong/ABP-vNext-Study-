using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Domain.Data
{
    public interface IGmDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
