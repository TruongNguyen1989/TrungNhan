using TrungNhan.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TrungNhan.Web.Pages
{
    public abstract class TrungNhanPageModel : AbpPageModel
    {
        protected TrungNhanPageModel()
        {
            LocalizationResourceType = typeof(TrungNhanResource);
        }
    }
}