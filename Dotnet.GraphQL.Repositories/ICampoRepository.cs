using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Repositories.Abstractions;

namespace Dotnet.GraphQL.Repositories
{
    public interface ICampoRepository : IRepository<Campo, int> { }
}