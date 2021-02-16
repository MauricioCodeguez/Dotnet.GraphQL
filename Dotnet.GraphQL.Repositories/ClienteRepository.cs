using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.GraphQL.Repositories
{
    public class ClienteRepository : Repository<Cliente, int>, IClienteRepository
    {
        public ClienteRepository(DbContext dbDbContext) 
            : base(dbDbContext)
        {
        }
    }
}