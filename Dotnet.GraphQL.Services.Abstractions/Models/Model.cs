namespace Dotnet.GraphQL.Services.Abstractions.Models
{
    public abstract record Model<TId>
        where TId : struct
    {
        private TId? Id { get; init; }
    }
}