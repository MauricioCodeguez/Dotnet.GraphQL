using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Services.Abstractions;
using Dotnet.GraphQL.Services.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Services
{
    public interface IClienteService : IService<Cliente, ClienteModel, int>
    {
        Task<ILookup<int, Campo>> GetLookupFieldsByTabelaIdAsync(IEnumerable<int> tableIds, CancellationToken cancellationToken);
        Task<ILookup<int, Campo_Valor_Cliente>> GetLookupFieldsByClienteIdAsync(IEnumerable<int> clienteIds, CancellationToken cancellationToken);
        Task<IEnumerable<Campo_Valor_Cliente>> GetFields(int clienteId, CancellationToken cancellationToken);
    }
}