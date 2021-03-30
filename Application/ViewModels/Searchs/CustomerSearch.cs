using Gym.Domain.Entities;
using Infra.Data.Abstractions.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Application.ViewModels.Searchs
{
    public class CustomerSearch : ISearch<Customer>, IOrderBy<Customer>
    {
        public string FirstName { get;  set; }
        //public string MiddleName { get;  set; }
        //public string LastName { get;  set; }
        //public int? Age { get;  set; }
        //public string Address { get;  set; }
        //public decimal? Weight { get;  set; }
        //public decimal? Height { get;  set; }
        //public string PrimaryPhone { get;  set; }
        //public string SecondaryPhone { get;  set; }
        //public string Email { get;  set; }
        //public string ZipCode { get;  set; }
        //public bool Active { get;  set; }
        public Expression<Func<Customer, bool>> GetFilter()
        {
            var expression = PredicateBuilder.True<Customer>();

            if (!string.IsNullOrEmpty(this.FirstName))
                expression = expression.And(x => x.FirstName.Contains(this.FirstName));
            //if (this.DataEntrega.HasValue)
            //    expression = expression.And(x => x.DataEntrega.Date == this.DataEntrega.Value.Date);
            //if (this.DataEmissao.HasValue)
            //    expression = expression.And(x => x.DataEmissao.Date == this.DataEmissao.Value.Date);
            //if (this.FornecedorCodigo.HasValue)
            //    expression = expression.And(x => x.FornecedorCodigo == this.FornecedorCodigo.Value);
            return expression;

        }

        public Func<IQueryable<Customer>, IOrderedQueryable<Customer>> GetOrderBy()
        {
            return query => query.OrderBy(x => x.CreatedDate);
        }

        public Func<IQueryable<Customer>, IQueryable<Customer>> GetIncludes()
        {
            return q => q.Include(x => x.Classes);
        }
    }
}
