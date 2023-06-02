using System;
using System.Collections.Generic;
using System.Text;
using FrontaTCG.Localization;
using Volo.Abp.Application.Services;

namespace FrontaTCG;

/* Inherit your application services from this class.
 */
public abstract class FrontaTCGAppService : ApplicationService
{
    protected FrontaTCGAppService()
    {
        LocalizationResource = typeof(FrontaTCGResource);
    }
}
