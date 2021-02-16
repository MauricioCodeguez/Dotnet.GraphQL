using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Dotnet.GraphQL.Repositories
{
    public class CampoRepository : Repository<Campo, int>, ICampoRepository
    {
        public CampoRepository(DbContext dbDbContext)
            : base(dbDbContext) { }
    }
}