using Domain.Abstractions.Entity;
using Gym.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Class : Entity
    {
        public Class()
        {
        }

        public Class(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }        
        public virtual IList<Customer> Customers { get; private set; }
    }
}
