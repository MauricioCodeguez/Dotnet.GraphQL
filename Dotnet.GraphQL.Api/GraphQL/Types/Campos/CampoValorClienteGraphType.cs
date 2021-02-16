using Dotnet.GraphQL.Domain.Entities.Campos.Valor;
using GraphQL.Types;

namespace Dotnet.GraphQL.Api.GraphQL.Types.Campos
{
    public class CampoValorClienteGraphType : ObjectGraphType<Campo_Valor_Cliente>
    {
        public CampoValorClienteGraphType()
        {
            Name = "otherproperties";

            Field(x => x.ID, type: typeof(IntGraphType));
            Field(x => x.ValorTexto);
        }
    }
}