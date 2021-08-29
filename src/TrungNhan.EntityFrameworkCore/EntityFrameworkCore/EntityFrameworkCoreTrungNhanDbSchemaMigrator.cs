using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrungNhan.Data;
using Volo.Abp.DependencyInjection;

namespace TrungNhan.EntityFrameworkCore
{
    public class EntityFrameworkCoreTrungNhanDbSchemaMigrator
        : ITrungNhanDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTrungNhanDbSchemaMigrator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TrungNhanDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TrungNhanDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
