using Volo.Abp.Modularity;

namespace FrontaTCG;

[DependsOn(
    typeof(FrontaTCGApplicationModule),
    typeof(FrontaTCGDomainTestModule)
    )]
public class FrontaTCGApplicationTestModule : AbpModule
{

}
