using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FrontaTCG.Web;

[Dependency(ReplaceServices = true)]
public class FrontaTCGBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "FrontaTCG";
}
