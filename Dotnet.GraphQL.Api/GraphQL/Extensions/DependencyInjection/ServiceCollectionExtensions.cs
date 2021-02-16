using Dotnet.GraphQL.Api.GraphQL.Executers;
using GraphQL.Server;
using GraphQL.Server.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Dotnet.GraphQL.Api.GraphQL.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        private static readonly Options Options = new();

        public static IGraphQLBuilder AddApplicationGraphQL(this IServiceCollection services, Action<Options> actionOptions)
        {
            actionOptions.Invoke(Options);

            return services
                .AddScoped(typeof(IGraphQLExecuter<>), typeof(ApplicationExecuter<>))
                .AddSingleton<ApplicationSchema>()
                .AddGraphQL((options, provider) =>
                {
                    options.EnableMetrics = Options.IsDevelopment;
                    var logger = provider.GetRequiredService<ILogger<Startup>>();
                    options.UnhandledExceptionDelegate = ctx => logger.LogError("{Error} occured", ctx.OriginalException.Message);
                })
                .AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
                .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { })
                .AddWebSockets()
                .AddDataLoader()
                .AddGraphTypes(typeof(ApplicationSchema));
        }
    }

    public class Options
    {
        public bool IsDevelopment { get; set; }
    }
}
