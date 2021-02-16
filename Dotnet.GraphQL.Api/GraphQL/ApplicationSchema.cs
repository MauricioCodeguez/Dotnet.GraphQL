using Dotnet.GraphQL.Api.GraphQL.Types.Campos;
using Dotnet.GraphQL.Api.GraphQL.Types.Clientes;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace Dotnet.GraphQL.Api.GraphQL
{
    public class ApplicationSchema : Schema
    {
        public ApplicationSchema(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ApplicationQuery>();
            Mutation = serviceProvider.GetRequiredService<ApplicationMutation>();
            Subscription = serviceProvider.GetRequiredService<ApplicationSubscription>();
        }
    }
}