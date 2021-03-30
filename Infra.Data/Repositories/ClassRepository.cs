using Domain.Entities;
using Domain.Repositories;
using Gym.Domain.Entities;
using Infra.Data.Abstractions.Data;
using Infra.Data.Context;
using Infra.Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class ClassRepository : Repository<Class, long>, IClassRepository
    {
        public ClassRepository(GymContext context) : base(context)
        {
        }

        public Task<Class> GetCustomerById(int id, IInclude<Class> include = null)
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
