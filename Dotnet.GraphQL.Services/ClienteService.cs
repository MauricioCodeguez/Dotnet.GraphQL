using AutoMapper;
using Dotnet.GraphQL.CrossCutting.Notifications;
using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Repositories.Abstractions;
using Dotnet.GraphQL.Repositories.Abstractions.Pages;
using Dotnet.GraphQL.Repositories.Abstractions.UnitsOfWork;
using Dotnet.GraphQL.Services.Abstractions;
using Dotnet.GraphQL.Services.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Services
{
    public class ClienteService : Service<Cliente, ClienteModel, int>, IClienteService
    {
        public ClienteService(IUnitOfWork unitOfWork, IRepository<Cliente, int> repository, IMapper mapper, INotificationContext notificationContext) 
            : base(unitOfWork, repository, mapper, notificationContext)
        {
        }

        public async Task<IEnumerable<Campo_Valor_Cliente>> GetFields(int clienteId, CancellationToken cancellationToken)
        {
            var pagedResult = await Repository.GetAllAsync(
                pageParams: new PageParams { Size = 10 },
                selector: cliente => cliente.OtherProperties,
                predicate: null,
                include: cliente => cliente.Include(x => x.OtherProperties),
                cancellationToken: cancellationToken);

            return pagedResult.Items.SelectMany(field => field).Where(a => a.ID_Cliente == clienteId);
        }

        public async Task<ILookup<int, Campo_Valor_Cliente>> GetLookupFieldsByClienteIdAsync(IEnumerable<int> clienteIds, CancellationToken cancellationToken)
        {
            var ids = clienteIds?.ToList();
            if (ids is { Count: > 0 } is false) return default;

            var pagedResult = await Repository.GetAllAsync(
                pageParams: new PageParams { Size = 10 },
                selector: cliente => cliente.OtherProperties,
                predicate: null,
                include: cliente => cliente.Include(x => x.OtherProperties),
                cancellationToken: cancellationToken);

            return pagedResult.Items.SelectMany(review => review).ToLookup(review => review.ID);
        }

        public async Task<ILookup<int, Campo>> GetLookupFieldsByTabelaIdAsync(IEnumerable<int> tableIds, CancellationToken cancellationToken)
        {
            var ids = tableIds?.ToList();
            if (ids is { Count: > 0 } is false) return default;

            var pagedResult = await Repository.GetAllAsync<ICollection<Campo>>(
                pageParams: new PageParams { Size = ids.Count },
                selector: null,
                predicate: campo => ids.Contains(campo.ID),
                include: null,
                cancellationToken: cancellationToken);

            return pagedResult.Items.SelectMany(review => review).ToLookup(review => review.ID);
        }
    }
}