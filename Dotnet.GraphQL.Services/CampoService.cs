using AutoMapper;
using Dotnet.GraphQL.CrossCutting.Notifications;
using Dotnet.GraphQL.Domain.Entities.Campos;
using Dotnet.GraphQL.Domain.Entities.Clientes;
using Dotnet.GraphQL.Repositories.Abstractions;
using Dotnet.GraphQL.Repositories.Abstractions.Pages;
using Dotnet.GraphQL.Repositories.Abstractions.UnitsOfWork;
using Dotnet.GraphQL.Services.Abstractions;
using Dotnet.GraphQL.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Services
{
    public class CampoService : Service<Campo, CampoModel, int>, ICampoService
    {
        public CampoService(IUnitOfWork unitOfWork, IRepository<Campo, int> repository, IMapper mapper, INotificationContext notificationContext) 
            : base(unitOfWork, repository, mapper, notificationContext)
        {
        }
    }
}
