using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Abstractions.Data
{
    public interface IQueryResult<T>
    {
        int Page { get; set; }
        int? PageSize { get; set; }
        long Total { get; set; }
        long TotalItens { get; set; }
        IEnumerable<T> Itens { get; set; }
    }
}
