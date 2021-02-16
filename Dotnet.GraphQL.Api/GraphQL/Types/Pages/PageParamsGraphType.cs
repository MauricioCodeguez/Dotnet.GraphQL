using Dotnet.GraphQL.Repositories.Abstractions.Pages;
using GraphQL.Types;

namespace Dotnet.GraphQL.Api.GraphQL.Types.Pages
{
    public sealed class PageParamsGraphType : InputObjectGraphType<PageParams>
    {
        public PageParamsGraphType()
        {
            Name = nameof(PageParamsGraphType);
            Field(x => x.Index, true, typeof(IntGraphType));
            Field(x => x.Size, true, typeof(IntGraphType));
        }
    }
}