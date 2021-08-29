using Volo.Abp.Modularity;

namespace TrungNhan
{
    [DependsOn(
        typeof(TrungNhanApplicationModule),
        typeof(TrungNhanDomainTestModule)
        )]
    public class TrungNhanApplicationTestModule : AbpModule
    {

    }
}