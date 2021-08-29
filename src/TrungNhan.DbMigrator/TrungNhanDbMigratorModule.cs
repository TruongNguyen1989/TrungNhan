using TrungNhan.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TrungNhan.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TrungNhanEntityFrameworkCoreModule),
        typeof(TrungNhanApplicationContractsModule)
    )]
    public class TrungNhanDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options =>
            {
                options.IsJobExecutionEnabled = false;
            });
        }
    }
}
