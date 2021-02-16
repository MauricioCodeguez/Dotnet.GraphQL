using AutoMapper;
using Dotnet.GraphQL.CrossCutting.Notifications;
using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Repositories.Abstractions;
using Dotnet.GraphQL.Repositories.Abstractions.UnitsOfWork;
using Dotnet.GraphQL.Services.Abstractions;
using Dotnet.GraphQL.Services.Models;

namespace Dotnet.GraphQL.Services
{
    public class CampoValorClienteService : Service<Campo_Valor_Cliente, CampoValorClienteModel, int>, ICampoValorClienteService
    {
        public CampoValorClienteService(IUnitOfWork unitOfWork, IRepository<Campo_Valor_Cliente, int> repository, IMapper mapper, INotificationContext notificationContext) 
            : base(unitOfWork, repository, mapper, notificationContext)
        {
        }
    }
}