using FrontaTCG.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FrontaTCG;

[DependsOn(
    typeof(FrontaTCGEntityFrameworkCoreTestModule)
    )]
public class FrontaTCGDomainTestModule : AbpModule
{

}
