using Domain.Entities;
using Infra.Data.Abstractions.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IClassRepository : IRepository<Class, long>
    {

    }
}
