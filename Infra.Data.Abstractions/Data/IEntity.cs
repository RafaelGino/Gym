using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Abstractions.Data
{
    //Implement TPrimaryKey on interface
    public interface IEntity
    {
        long Id { get; }
        DateTime CreatedDate { get; }
    }
}
