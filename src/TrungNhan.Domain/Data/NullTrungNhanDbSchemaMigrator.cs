using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TrungNhan.Data
{
    /* This is used if database provider does't define
     * ITrungNhanDbSchemaMigrator implementation.
     */
    public class NullTrungNhanDbSchemaMigrator : ITrungNhanDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}