using Dotnet.GraphQL.Services.Abstractions.Models;

namespace Dotnet.GraphQL.Services.Models
{
    public abstract record ClienteModel : Model<int>
    {
        public string Nome { get; init; }
        public string RazaoSocial { get; init; }
        public string CNPJ { get; init; }
    }
}