using Dotnet.GraphQL.Services.Abstractions.Models;

namespace Dotnet.GraphQL.Services.Models
{
    public abstract record CampoValorClienteModel : Model<int>
    {
        public int ID_Cliente { get; init; }
        public int ID_Campo { get; init; }
        public string ValorTexto { get; init; }
        public string ValorTextoMultilinha { get; init; }
    }
}