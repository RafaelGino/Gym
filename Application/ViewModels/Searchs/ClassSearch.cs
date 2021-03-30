using Domain.Entities;
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
    public class ClassSearch : ISearch<Class>, IOrderBy<Class>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Expression<Func<Class, bool>> GetFilter()
        {
            var expression = PredicateBuilder.True<Class>();

            if (!string.IsNullOrEmpty(this.Name))
                expression = expression.And(x => x.Name.Contains(this.Name));

            if (!string.IsNullOrEmpty(this.Description))
                expression = expression.And(x => x.Description.Contains(this.Description));

            return expression;

        }

        public Func<IQueryable<Class>, IOrderedQueryable<Class>> GetOrderBy()
        {
            return query => query.OrderBy(x => x.CreatedDate);
        }
    }
}
