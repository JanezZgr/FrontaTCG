using System.Threading.Tasks;

namespace FrontaTCG.Data;

public interface IFrontaTCGDbSchemaMigrator
{
    Task MigrateAsync();
}
