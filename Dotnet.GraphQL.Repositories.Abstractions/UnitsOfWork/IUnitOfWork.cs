using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Repositories.Abstractions.UnitsOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDbContextTransaction BeginTransaction();
        Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);
        void Commit();
        Task CommitAsync(CancellationToken cancellationToken);
        void Rollback();
        Task RollbackAsync(CancellationToken cancellationToken);
        void SaveChanges();
        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}