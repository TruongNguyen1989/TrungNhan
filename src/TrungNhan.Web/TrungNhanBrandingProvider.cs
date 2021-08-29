using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TrungNhan.Web
{
    [Dependency(ReplaceServices = true)]
    public class TrungNhanBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TrungNhan";
    }
}
