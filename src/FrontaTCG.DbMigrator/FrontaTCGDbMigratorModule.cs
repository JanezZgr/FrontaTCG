using FrontaTCG.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FrontaTCG.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FrontaTCGEntityFrameworkCoreModule),
    typeof(FrontaTCGApplicationContractsModule)
    )]
public class FrontaTCGDbMigratorModule : AbpModule
{

}
