using Dotnet.GraphQL.CrossCutting.Extensions;
using Dotnet.GraphQL.Repositories.Abstractions.UnitsOfWork;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace Dotnet.GraphQL.Repositories.Abstractions.Entensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services.Scan(selector
                => selector
                    .FromApplicationDependencies(assembly
                        => assembly.FullName?.StartsWith(assembly.GetEntryAssemblySuffix()) ?? default)
                    .AddClasses(filter
                        => filter.AssignableToAny(typeof(IRepository<,>)))
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsImplementedInterfaces()
                    .WithScopedLifetime());

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
            => services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}