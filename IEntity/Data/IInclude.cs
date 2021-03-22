using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Data.Abstractions.Data
{
    public interface IInclude<T>
    {
        Func<IQueryable<T>, IQueryable<T>> GetIncludes();
    }
}
