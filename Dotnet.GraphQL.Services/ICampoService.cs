using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Services.Abstractions;
using Dotnet.GraphQL.Services.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Services
{
    public interface ICampoService : IService<Campo, CampoModel, int>
    {
    }
}