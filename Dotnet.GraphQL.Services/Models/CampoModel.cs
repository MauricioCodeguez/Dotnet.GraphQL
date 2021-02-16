using Dotnet.GraphQL.Services.Abstractions.Models;

namespace Dotnet.GraphQL.Services.Models
{
    public abstract record CampoModel : Model<int>
    {
        public int ID_ClientePloomes { get; init; }
        public int ID_Tabela { get; init; }
        public string Descricao { get; init; }
        public string Chave { get; init; }
    }
}