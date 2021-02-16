using Dotnet.GraphQL.Domain.Entities.Campos;
using GraphQL.Types;

namespace Dotnet.GraphQL.Api.GraphQL.Types.Campos
{
    public sealed class CampoGraphType : ObjectGraphType<Campo>
    {
        public CampoGraphType()
        {
            Name = "campo";

            Field(x => x.ID, type: typeof(IntGraphType));
            Field(x => x.Descricao);
        }
    }
}