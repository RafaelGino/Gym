using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Infra.Data.Abstractions.Data
{
    public interface ISearch<T> where T : class
    {
        Expression<Func<T, bool>> GetFilter();
    }
}
