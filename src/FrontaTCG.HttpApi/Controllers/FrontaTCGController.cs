using FrontaTCG.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FrontaTCG.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FrontaTCGController : AbpControllerBase
{
    protected FrontaTCGController()
    {
        LocalizationResource = typeof(FrontaTCGResource);
    }
}
