using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Repositories.Abstractions;

namespace Dotnet.GraphQL.Repositories
{
    public interface IClienteRepository : IRepository<Cliente, int> { }
}