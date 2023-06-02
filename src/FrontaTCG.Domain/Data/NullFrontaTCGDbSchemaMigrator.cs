using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FrontaTCG.Data;

/* This is used if database provider does't define
 * IFrontaTCGDbSchemaMigrator implementation.
 */
public class NullFrontaTCGDbSchemaMigrator : IFrontaTCGDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
