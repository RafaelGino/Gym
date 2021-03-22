using System;
using System.Linq;

namespace Infra.Data.Data
{
    public class OrderBy<TEntity>
    {
        public OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> expression)
        {
            OrderByFunc = expression;
        }

        public Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> OrderByFunc { get; }
    }
}