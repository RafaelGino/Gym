using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCuting.Interfaces
{
    public interface IRequestSearch<T>
    {
        public T Search { get; set; }
        public int Page { get; set; }
        public int? PageSize { get; set; }
    }
}
