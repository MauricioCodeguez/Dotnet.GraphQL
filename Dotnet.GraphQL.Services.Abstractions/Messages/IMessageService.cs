using Dotnet.GraphQL.Services.Abstractions.Models;
using System;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Services.Abstractions.Messages
{
    public interface IMessageService<TMessage, in TModel, TId>
        where TMessage : class
        where TModel : Model<TId>
        where TId : struct
    {
        TMessage Add(TModel model);
        Task<IObservable<TMessage>> MessagesAsync();
    }
}