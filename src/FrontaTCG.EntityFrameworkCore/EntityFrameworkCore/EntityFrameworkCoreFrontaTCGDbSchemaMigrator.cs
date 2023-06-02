using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FrontaTCG.Data;
using Volo.Abp.DependencyInjection;

namespace FrontaTCG.EntityFrameworkCore;

public class EntityFrameworkCoreFrontaTCGDbSchemaMigrator
    : IFrontaTCGDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFrontaTCGDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FrontaTCGDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FrontaTCGDbContext>()
            .Database
            .MigrateAsync();
    }
}
