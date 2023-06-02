using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace FrontaTCG;

public class FrontaTCGWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<FrontaTCGWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
