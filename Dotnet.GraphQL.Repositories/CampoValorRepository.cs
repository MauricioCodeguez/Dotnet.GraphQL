using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.GraphQL.Repositories
{
    public class CampoValorRepository : Repository<Campo_Valor, int>, ICampoValorRepository
    {
        public CampoValorRepository(DbContext dbDbContext) 
            : base(dbDbContext)
        {
        }
    }
}