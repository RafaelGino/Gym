using Infra.Data.Abstractions.Data;
using System;


namespace Domain.Abstractions.Entity
{
    public abstract class Entity : IEntity<long>
    {
        public virtual long Id { get; protected set; }
        public virtual DateTime CreatedDate { get; protected set; }

        public Entity()
        {
            this.CreatedDate = DateTime.Now;
        }

        public Entity(DateTime createdDate)
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
