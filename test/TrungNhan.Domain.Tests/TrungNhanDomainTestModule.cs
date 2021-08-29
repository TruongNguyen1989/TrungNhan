using TrungNhan.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TrungNhan
{
    [DependsOn(
        typeof(TrungNhanEntityFrameworkCoreTestModule)
        )]
    public class TrungNhanDomainTestModule : AbpModule
    {

    }
}