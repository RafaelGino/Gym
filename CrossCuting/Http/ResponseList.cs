using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCuting.Http
{
    public class ResponseList<T>
    {
        public IEnumerable<T> Items { get; set; }
        public long Total { get; set; }
        public long TotalItems { get; set; }

        public ResponseList() { }

        public ResponseList(IEnumerable<T> itens, long total, long totalItems)
        {
            this.Items = itens;
            this.Total = total;
            this.TotalItems = totalItems;
        }
    }
}
