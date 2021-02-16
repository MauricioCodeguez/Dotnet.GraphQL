using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using Dotnet.GraphQL.Services.Abstractions;
using Dotnet.GraphQL.Services.Models;

namespace Dotnet.GraphQL.Services
{
    public interface ICampoValorClienteService : IService<Campo_Valor_Cliente, CampoValorClienteModel, int>
    {
    }
}