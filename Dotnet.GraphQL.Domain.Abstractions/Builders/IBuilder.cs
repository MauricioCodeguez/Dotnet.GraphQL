using Dotnet.GraphQL.Domain.Abstractions.Entities;

namespace Dotnet.GraphQL.Domain.Abstractions.Builders
{
    public interface IBuilder<out TEntity, TId>
        where TEntity : Entity<TId>
        where TId : struct
    {
        TEntity Build();
    }
}