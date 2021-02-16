using Dotnet.GraphQL.CrossCutting.Notifications;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet.GraphQL.CrossCutting.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNotificationContext(this IServiceCollection services)
            => services.AddScoped<INotificationContext, NotificationContext>();
    }
}