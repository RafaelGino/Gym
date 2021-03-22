using System;
using System.Linq.Expressions;

namespace Infra.Data.Data
{
    public class SearchFilter<TEntity>
    {
        public SearchFilter(Func<Expression<Func<TEntity, bool>>> expression)
        {
            Expression = expression.Invoke();
        }

        public Expression<Func<TEntity, bool>> Expression { get; }
    }
}
