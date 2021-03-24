using Gym.Domain.Entities;
using Infra.Data.Abstractions.Data;
using System;

namespace Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, long>
    {

    }
}
