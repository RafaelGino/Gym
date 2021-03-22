using System;

namespace Infra.Data.Abstractions.Data
{
    //Implement TPrimaryKey on interface
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; }
        DateTime CreatedDate { get; }
    }
}
