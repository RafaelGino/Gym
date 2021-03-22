using System;
using System.Linq;

namespace Infra.Data.Abstractions.Data
{
    public interface IOrderBy<T>
    {
        Func<IQueryable<T>, IOrderedQueryable<T>> GetOrderBy();
    }
}
