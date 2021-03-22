using Infra.Data.Abstractions.Data;
using System;
using System.Linq;

namespace Infra.Data.Data
{
    public class Include<TEntity> : IInclude<TEntity>
    {
        public Include(Func<IQueryable<TEntity>, IQueryable<TEntity>> expression)
        {
            Includes = expression;
        }

        public Func<IQueryable<TEntity>, IQueryable<TEntity>> Includes { get; }

        public Func<IQueryable<TEntity>, IQueryable<TEntity>> GetIncludes()
        {
            return this.Includes;
        }
    }
}
