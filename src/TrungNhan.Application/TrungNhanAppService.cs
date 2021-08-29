using TrungNhan.Localization;
using Volo.Abp.Application.Services;

namespace TrungNhan
{
    /* Inherit your application services from this class.
     */
    public abstract class TrungNhanAppService : ApplicationService
    {
        protected TrungNhanAppService()
        {
            LocalizationResource = typeof(TrungNhanResource);
        }
    }
}
