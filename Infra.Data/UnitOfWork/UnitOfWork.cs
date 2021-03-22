using Infra.Data.Abstractions.Data;
using Infra.Data.Context;
using System.Threading.Tasks;

namespace Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GymContext context;

        public UnitOfWork(GymContext context)
        {
            this.context = context;
        }

        public bool Commit()
        {
            return context.SaveChangesAsync().GetAwaiter().GetResult() > 0;
        }

        public Task<bool> CommitAsync()
        {
            return Task.Factory.StartNew(() =>
            {
                return Commit();
            });
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
