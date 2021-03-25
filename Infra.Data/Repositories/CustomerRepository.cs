using Domain.Repositories;
using Gym.Domain.Entities;
using Infra.Data.Abstractions.Data;
using Infra.Data.Context;
using Infra.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class CustomerRepository : Repository<Customer, long>, ICustomerRepository
    {
        public CustomerRepository(GymContext context) : base(context)
        {
        }

        public Task<Customer> GetCustomerById(int id, IInclude<Customer> include = null)
        {
            var query = base.Set.Where(x => x.Id == id);
            if (include != null)
            {
                query = include.GetIncludes()(query);
            }
            return query.FirstOrDefaultAsync();
        }
    }
}
