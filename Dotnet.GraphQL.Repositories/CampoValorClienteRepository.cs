using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.GraphQL.Repositories
{
    public class CampoValorClienteRepository : Repository<Campo_Valor_Cliente, int>, ICampoValorClienteRepository
    {
        public CampoValorClienteRepository(DbContext dbDbContext) 
            : base(dbDbContext)
        {
        }
    }
}