using Infra.Data.Abstractions.Data;
using System.Collections.Generic;

namespace Infra.Data.Data
{
    public class QueryResult<TEntity> : IQueryResult<TEntity>
    {
        public int Page { get; set; }
        public int? PageSize { get; set; }
        public long Total { get; set; }
        public long TotalItens { get; set; }
        public IEnumerable<TEntity> Itens { get; set; }

        public QueryResult(int page, int? pageSize)
        {
            this.Page = page;
            this.PageSize = pageSize;
        }
    }
}
