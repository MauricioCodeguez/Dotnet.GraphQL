using Dotnet.GraphQL.Api.GraphQL.Types.Campos;
using Dotnet.GraphQL.Api.GraphQL.Types.Clientes;
using Dotnet.GraphQL.Api.GraphQL.Types.Pages;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Repositories.Abstractions.Pages;
using Dotnet.GraphQL.Services;
using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;
using System.Collections.Generic;

namespace Dotnet.GraphQL.Api.GraphQL
{
    public sealed class ApplicationQuery : ObjectGraphType
    {
        public ApplicationQuery()
        {
            FieldAsync<PagedResultGraphType<ClienteGraphType, Cliente>>(
                name: "clientes",
                arguments: new QueryArguments(new QueryArgument<PageParamsGraphType> { Name = "pageParams" }),
                resolve: async context =>
                {
                    var clientes = await context.RequestServices
                        .GetRequiredService<IClienteService>()
                        .GetAllAsync(
                            pageParams: context.GetArgument<PageParams>("pageParams"),
                            selector: product => product,
                            cancellationToken: context.CancellationToken);

                    return clientes;
                });

            FieldAsync<ClienteGraphType>(
                name: "cliente",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    if (Equals(id, default(int))) context.Errors.Add(new ExecutionError($"Invalid Id: {id}"));

                    var cliente = await context.RequestServices
                        .GetRequiredService<IClienteService>()
                        .GetByIdAsync(
                            id: id,
                            cancellationToken: context.CancellationToken);

                    return cliente;
                });

            FieldAsync<CampoGraphType>(
                name: "campo",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: async context =>
                {
                    var id = context.GetArgument<int>("id");
                    if (Equals(id, default(int))) context.Errors.Add(new ExecutionError($"Invalid Id: {id}"));

                    var cliente = await context.RequestServices
                        .GetRequiredService<ICampoService>()
                        .GetByIdAsync(
                            id: id,
                            cancellationToken: context.CancellationToken);

                    return cliente;
                });
        }
    }
}
