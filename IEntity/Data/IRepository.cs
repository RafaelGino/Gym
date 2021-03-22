using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Abstractions.Data
{
    public interface IRepository<TEntity, TPrimaryKey> : IReadRepository<TEntity, TPrimaryKey>, IWriteRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        DbContext Context { get; }
        DbSet<TEntity> Set { get; }
    }
}
