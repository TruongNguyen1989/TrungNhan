using TrungNhan.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TrungNhan.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TrungNhanController : AbpController
    {
        protected TrungNhanController()
        {
            LocalizationResource = typeof(TrungNhanResource);
        }
    }
}