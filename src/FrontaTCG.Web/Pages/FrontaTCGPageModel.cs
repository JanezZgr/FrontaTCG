using FrontaTCG.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FrontaTCG.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class FrontaTCGPageModel : AbpPageModel
{
    protected FrontaTCGPageModel()
    {
        LocalizationResourceType = typeof(FrontaTCGResource);
    }
}
